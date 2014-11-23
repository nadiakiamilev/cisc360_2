/**
 * Jason Walsh
 * Nadia Kiamilev
 * CISC360
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GeminiCore
{
    public class CPU
    {
        public int A { get; set; }
        public int B { get; set; }
        public int ACC { get; set; }
        public int Zero { get; set; }
        public int One { get; set; }
        public int PC { get; set; }
        public int MAR { get; set; }
        public int MDR { get; set; }
        public int TEMP { get; set; }
        public int IR { get; set; }
        public int CC { get; set; }
        public int i = -1; //common value shared between opcode position and doing instructions
        public int operationCount = 0;
        public string nextInstructionLabel;
        public int x = 1;
        public int[] lines = { };
        public string[] binaryText;
        public UInt16[] finalCodes;
        public int y = 0;
        public int nopCount = 0;
        public int currentNopCount = 0;

        public int branchVarDecode;
        public int branchVarEx;

        public Dictionary<int, bool> branchHistory = new Dictionary<int,bool>();
        public Dictionary<int, int> branchCounter = new Dictionary<int, int>();

        public bool isBranchPrediction = false;

        //temporary fetch instructions 
        public int fetchIRprev = 0;
        public int tmpValuePrev = 0;
        public string fetchString;
        public bool isBypassing = false;

        public int decodeInstrPrev = 0;
        public int decodeImmedPrev = 0;
        public int decodeValuePrev = 0;
        public int decodeInstrCurr = 0;
        public int decodeImmedCurr = 0;
        public int decodeValueCurr = 0;
        public string decodeString;
        public int i2 = -2;

        public int executeInstrPrev = 0;
        public int executeImmedPrev = 0;
        public int executeValuePrev = 0;
        public int executeInstrCurr = 0;
        public int executeImmedCurr = 0;
        public int executeValueCurr = 0;
        public string executeString;
        public int i3 = -3;

        public int storeInstrPrev = 0;
        public int storeImmedPrev = 0;
        public int storeValuePrev = 0;
        public int storeInstrCurr = 0;
        public int storeImmedCurr = 0;
        public int storeValueCurr = 0;
        public string storeString;
        public int i4 = -4;

        public int tmpValue = 0;
        public bool isDelay = false;

        public int associativeValue = 1; //set the associative value. 1 for direct, 2 for 2-Way Associative

        public int wordSize = 1;

        public int hitsMemory = 0;
        public int missMemory = 0;
        public string cacheStatus;

        bool fetchDone, decodeDone, executeDone, storeDone;

        public Memory myMemory = new Memory();
        public Memory.frame[] myCache = new Memory.frame[Memory.cacheSize];

        Thread fetchThread;
        AutoResetEvent fetchEvent = new AutoResetEvent(false);
        Thread decodeThread;
        AutoResetEvent decodeEvent = new AutoResetEvent(false);
        Thread executeThread;
        AutoResetEvent executeEvent = new AutoResetEvent(false);
        Thread storeThread;
        AutoResetEvent storeEvent = new AutoResetEvent(false);

        bool fetchRuns = true;
        bool decodeRuns = true;
        bool executeRuns = true;
        bool storeRuns = true;

        AutoResetEvent allThreadsDone = new AutoResetEvent(false);
        object allThreadsDoneLock = new object();

        public delegate void FetchDone(object sender, OperationEventArgs args);
        public event FetchDone OnFetchDone;
        public delegate void DecodeDone(object sender, OperationEventArgs args);
        public event DecodeDone OnDecodeDone;
        public delegate void ExecuteDone(object sender, OperationEventArgs args);
        public event ExecuteDone OnExecuteDone;
        public delegate void StoreDone(object sender, OperationEventArgs args);
        public event StoreDone OnStoreDone;

        bool areWeDone = false;

        public CPU()
        {
            y = 0;
            for (y = 0; y < Memory.cacheSize; y++)
            {
                myCache[y].dirtyBit = false;
                myCache[y].isEmpty = 1;
                myCache[y].tag = 0;
                myCache[y].value = 0;
            }

            fetchThread = new Thread(new ThreadStart(fetch));
            fetchThread.Name = "Fetch Thread";
            fetchThread.Start();

            decodeThread = new Thread(new ThreadStart(decode));
            decodeThread.Name = "Decode Thread";
            decodeThread.Start();

            executeThread = new Thread(new ThreadStart(execute));
            executeThread.Name = "Execute Thread";
            executeThread.Start();

            storeThread = new Thread(new ThreadStart(store));
            storeThread.Name = "Store Thread";
            storeThread.Start();

            this.OnFetchDone += CPU_OnThreadDone;
            this.OnDecodeDone += CPU_OnThreadDone;
            this.OnExecuteDone += CPU_OnThreadDone;
            this.OnStoreDone += CPU_OnThreadDone;
        }

        void CPU_OnThreadDone(object sender, OperationEventArgs args)
        {
            switch (args.CurrentThreadType)
            {
                case ThreadType.Fetch:
                    fetchDone = true;
                    break;
                case ThreadType.Decode:
                    decodeDone = true;
                    break;
                case ThreadType.Execute:
                    executeDone = true;
                    break;
                case ThreadType.Store:
                    storeDone = true;
                    break;
            }

            lock (allThreadsDoneLock)
            {
                if (fetchDone && decodeDone && executeDone && storeDone)
                    allThreadsDone.Set();
            }
        }

        public void Dispose()
        {
            areWeDone = true;
            fetchEvent.Set();
            fetchThread.Join();

            decodeEvent.Set();
            decodeThread.Join();

            executeEvent.Set();
            executeThread.Join();

            storeEvent.Set();
            storeThread.Join();
        }

        public void resetCPU()
        {
            i = 0;
            A = 0;
            B = 0;
            ACC = 0;
            Zero = 0;
            One = 1;
            PC = 0;
            MAR = 0;
            MDR = 0;
            TEMP = 0;
            IR = 0;
            CC = 0;
            operationCount = 0;
            nextInstructionLabel = "Instruction";
            Array.Clear(lines, 0, lines.Length); //reset array of instructions
            System.IO.File.Create(@".\binaryCodes.txt").Close();
        }

        //Fetch
        public void fetch()
        {
            while (!areWeDone)
            {
                fetchEvent.WaitOne();

                if (fetchRuns)
                {
                    if (i < finalCodes.Length)
                    {
                        Console.WriteLine("In Fetch " + finalCodes[i]);
                        IR = finalCodes[i];
                    }
                    else
                        ACC += 0;
                }

                if (OnFetchDone != null)
                    OnFetchDone(this, new OperationEventArgs(ThreadType.Fetch, this.IR));
            }
        }

        //Decode
        public void decode()
        {
            while (!areWeDone)
            {
                decodeEvent.WaitOne();

                if (decodeRuns)
                {
                    if (i2 < finalCodes.Length)
                    {
                        //decode those instructions into the way that they need to be 
                        decodeInstrCurr = (fetchIRprev >> 9) & 127; //Parses op code to find instruction
                        decodeImmedCurr = (fetchIRprev >> 8) & 1; //Parses op code to find immediate value
                        decodeValueCurr = (fetchIRprev & 255); //Parse op code to find value

                        Console.WriteLine("In Decode " + decodeInstrCurr + " " + decodeImmedCurr + " " + decodeValueCurr);
                        Console.WriteLine(i + " this is where we currently are");

                        if (!isBranchPrediction == false) //only runs if branch prediction is on!
                        {
                            if (decodeInstrCurr == 116 || decodeInstrCurr == 115 || decodeInstrCurr == 114)
                            {
                                Console.WriteLine("hey we need to do a branch prediction. this is a branch. ");
                                bool temp;
                                branchHistory.TryGetValue(i, out temp);
                                if (branchHistory.ContainsKey(i) && temp == true)
                                {
                                    branchVarDecode = i;
                                    Console.WriteLine(branchVarDecode + " CHECK OUT BRANCHVAR IN DECODE");
                                    i = decodeValueCurr; //assigns target value to take the jump
                                }
                                else
                                {
                                    branchVarDecode = i;
                                    Console.WriteLine(branchVarDecode + " CHECK OUT BRANCHVAR IN DECODE");
                                    if (!branchHistory.ContainsKey(i))
                                    {
                                        branchHistory.Add(i, false);
                                        branchCounter.Add(i, 0);
                                    }
                                }
                            }
                        }                        
                    }
                }

                if (OnDecodeDone != null)
                    OnDecodeDone(this, new OperationEventArgs(ThreadType.Decode, this.IR));
            }
        }

        //Execute
        public void execute()
        {

            while (!areWeDone)
            {
                executeEvent.WaitOne();

                if (executeRuns)
                {
                    executeInstrCurr = decodeInstrPrev;
                    executeImmedCurr = decodeImmedPrev;
                    executeValueCurr = decodeValuePrev;

                    Console.WriteLine("In Execute" + " " + executeInstrCurr + " " + executeImmedCurr + " " + executeValueCurr);

                    //fetch the instruction 
                    //decode that instruction
                    //run it 
                    switch (executeInstrCurr)
                    {
                        case (127): //LDA instruction

                            if (executeImmedCurr == 1)
                                tmpValue = executeValueCurr;
                            else
                                tmpValue = myMemory.solveMemory(executeValueCurr, executeInstrCurr, myCache, ACC, associativeValue, wordSize);
                            if (!isBypassing)
                            {
                                nopCount++;
                                currentNopCount++;
                                isDelay = true;
                            }

                            break;
                        /*case (126):
                            if (executeImmedCurr == 0)
                                tmpValue = ACC*/
                        case (125): //ADD instruction
                            if (executeImmedCurr == 1)
                                tmpValue += executeValueCurr;
                            else
                                tmpValue += myMemory.solveMemory(executeValueCurr, executeInstrCurr, myCache, ACC, associativeValue, wordSize);
                            if (tmpValue < 0)
                                CC = -1;
                            else if (tmpValue == 0)
                                CC = 0;
                            else if (tmpValue > 0)
                                CC = 1;
                            break;
                        case (124): //SUB instruction
                            if (executeImmedCurr == 1)
                                tmpValue -= executeValueCurr;
                            else
                                tmpValue -= myMemory.solveMemory(executeValueCurr, executeInstrCurr, myCache, ACC, associativeValue, wordSize);
                            if (tmpValue < 0)
                                CC = -1;
                            else if (tmpValue == 0)
                                CC = 0;
                            else if (tmpValue > 0)
                                CC = 1;
                            break;
                        case (123): //MUL instruction
                            if (executeImmedCurr == 1)
                                tmpValue *= executeValueCurr;
                            else
                                tmpValue *= myMemory.solveMemory(executeValueCurr, executeInstrCurr, myCache, ACC, associativeValue, wordSize);
                            if (tmpValue < 0)
                                CC = -1;
                            else if (tmpValue == 0)
                                CC = 0;
                            else if (tmpValue > 0)
                                CC = 1;
                            nopCount += 4;
                            currentNopCount = 3;
                            break;
                        case (122): //DIV instruction
                            if (executeImmedCurr == 1)
                                tmpValue /= executeValueCurr;
                            else
                                tmpValue /= myMemory.solveMemory(executeValueCurr, executeInstrCurr, myCache, ACC, associativeValue, wordSize);
                            if (tmpValue < 0)
                                CC = -1;
                            else if (tmpValue == 0)
                                CC = 0;
                            else if (tmpValue > 0)
                                CC = 1;
                            nopCount += 4;
                            currentNopCount = 3;
                            break;
                        case (121): //AND instruction
                            if (tmpValue == executeValueCurr)
                                CC = 0;
                            else if (tmpValue != executeValueCurr)
                                CC = -1;
                            if (executeImmedCurr == 1)
                                tmpValue = tmpValue & executeValueCurr;
                            else
                                tmpValue = tmpValue & myMemory.solveMemory(executeValueCurr, executeInstrCurr, myCache, ACC, associativeValue, wordSize);
                            break;
                        case (120): //OR instruction
                            if (tmpValue == executeValueCurr)
                                CC = 0;
                            if (executeImmedCurr == 1)
                                tmpValue = tmpValue | executeValueCurr;
                            else
                                tmpValue = tmpValue | myMemory.solveMemory(executeValueCurr, executeInstrCurr, myCache, ACC, associativeValue, wordSize);
                            break;
                        case (119): // SHL instruction
                            if (executeImmedCurr == 1)
                                ACC = ACC << executeValueCurr;
                            {
                                Console.WriteLine("Oops, something went wrong with: sta $" + executeValueCurr);
                                Environment.Exit(-1);
                            }
                            break;
                        case (118): //NOTA instruction
                            ACC = ~ACC;
                            break;
                        case (117): //BA instruction
                            i = executeValueCurr;
                            nopCount++;
                            currentNopCount++;
                            break;
                        case (116): //BE instruction
                            Console.WriteLine(branchVarEx + " CHECK OUT BRANCHVAR IN BE");
                            if (isBranchPrediction == false) //if branch prediction is false
                            {
                                if (CC == 0)
                                {
                                    i = executeValueCurr;
                                }
                            }
                            
                            if (!isBranchPrediction == false) //if branch predicting is on
                            {
                                if (CC == 0)
                                {
                                    bool temp;
                                    branchHistory.TryGetValue(branchVarEx, out temp);
                                    if (temp == true) {
                                        //correct branch prediction
                                        branchCounter[branchVarEx] = 0;
                                        Console.WriteLine("HEY! Correct Branch Prediction");
                                    }
                                    else {
                                        i = executeValueCurr;
                                        Console.WriteLine("Mis Branch Prediction. here's the value for i " + i );
                                        //lets check if branch counter is 1. if 
                                        if (branchCounter[branchVarEx] == 1)
                                        {
                                            branchHistory[branchVarEx] = true;
                                            branchCounter[branchVarEx] = 0;
                                        }
                                        else
                                            branchCounter[branchVarEx] = 1;                                    
                                    }
                                }
                                else 
                                {
                                    bool temp;
                                    branchHistory.TryGetValue(branchVarEx, out temp);
                                    if (temp == false)
                                    {
                                        //we skipped when we needed to
                                        branchCounter[branchVarEx] = 0;
                                        Console.WriteLine("HEY! Correct skip prediction.");
                                    }
                                    else
                                    {
                                        i = branchVarEx; //we made a mistake, go back  
                                        Console.WriteLine("hey, we made a mistake. let's go back to.. " + i);
                                        if (branchCounter[branchVarEx] == 1) {
                                            branchHistory[branchVarEx] = false;
                                            branchCounter[branchVarEx] = 0;
                                        }
                                        else {
                                            branchCounter[branchVarEx] = 1;
                                        }
                                    }
                                }
                            }

                            nopCount++;
                            currentNopCount++;
                            break;
                        case (115): //BL instruction
                            if (isBranchPrediction == false) //if branch prediction is false
                            {
                                if (CC < 0)
                                {
                                    i = executeValueCurr;
                                }
                            }

                            if (!isBranchPrediction == false)
                            {
                                Console.WriteLine(branchVarEx + " CHECK OUT BRANCHVAR IN BL");
                                if (CC < 0) //if negative
                                {
                                    bool temp;
                                    branchHistory.TryGetValue(branchVarEx, out temp);
                                    if (temp == true) {
                                        //correct branch prediction
                                        branchCounter[branchVarEx] = 0;
                                        Console.WriteLine("hey! we made a correct branch prediction for BL");
                                    }
                                    else { //misprediction
                                        i = executeValueCurr;
                                        Console.WriteLine("here's the value for i " + i);
                                        if (branchCounter[branchVarEx] ==1) {
                                            branchHistory[branchVarEx] = true;
                                            branchCounter[branchVarEx] = 0;
                                        }
                                        else 
                                            branchCounter[branchVarEx] = 1;
                                    }
                                }
                                else
                                {
                                    bool temp;
                                    branchHistory.TryGetValue(branchVarEx, out temp);
                                    if (temp == false)
                                    {
                                        //do nothing, we skipped when we needed to
                                        branchCounter[branchVarEx] = 0;
                                        Console.WriteLine("hey! we made a correct branch prediction");
                                    }
                                    else
                                    {
                                        i = branchVarEx;
                                        Console.WriteLine("here's the value for i " + i);
                                        if (branchCounter[branchVarEx] == 1)
                                        {
                                            branchHistory[branchVarEx] = false;
                                            branchCounter[branchVarEx] = 0;
                                        }
                                        else
                                            branchCounter[branchVarEx] = 1;
                                    }
                                }
                            }

                            nopCount++;
                            currentNopCount++;
                            break;
                        case (114): //BG instruction
                            Console.WriteLine(branchVarEx + " CHECK OUT BRANCHVAR IN BG");
                            if (isBranchPrediction == false) //if branch prediction is false
                            {
                                if (CC > 0)
                                {
                                    i = executeValueCurr;
                                }
                            }

                            if (!isBranchPrediction == false)
                            {
                                if (CC > 0) //if positive
                                {
                                    bool temp;
                                    branchHistory.TryGetValue(branchVarEx, out temp);
                                    if (temp == true)
                                    {
                                        //correct branch prediction
                                        branchCounter[branchVarEx] = 0;
                                        Console.WriteLine("hey! we made a correct branch prediction");
                                    }
                                    else
                                    { //misprediction
                                        i = executeValueCurr;
                                        Console.WriteLine("here's the value for i " + i);
                                        if (branchCounter[branchVarEx] == 1)
                                        {
                                            branchHistory[branchVarEx] = true;
                                            branchCounter[branchVarEx] = 0;
                                        }
                                        else
                                            branchCounter[branchVarEx] = 1;
                                    }

                                }
                                else
                                {
                                    bool temp;
                                    branchHistory.TryGetValue(branchVarEx, out temp);
                                    if (temp == false)
                                    {
                                        //do nothing, we skipped when we needed to
                                        branchCounter[branchVarEx] = 0;
                                        Console.WriteLine("hey! we made a correct branch prediction that didn't do anything");
                                    }
                                    else //misprediction
                                    {
                                        i = branchVarEx;
                                        Console.WriteLine("here's the value for i " + i);
                                        if (branchCounter[branchVarEx] == 1)
                                        {
                                            branchHistory[branchVarEx] = false;
                                            branchCounter[branchVarEx] = 0;
                                        }
                                        else
                                            branchCounter[branchVarEx] = 1;
                                    }
                                }
                            }

                            nopCount++;
                            currentNopCount++;
                            break;
                        case (113): //NOP instruction
                            ACC += 0;
                            break;
                        case (112): //HLT instruction
                            Environment.Exit(-1);
                            break;
                    }
                }

                if (OnExecuteDone != null)
                    OnExecuteDone(this, new OperationEventArgs(ThreadType.Execute, this.IR));
            }
        }

        //Store
        public void store()
        {
            while (!areWeDone)
            {
                storeEvent.WaitOne();

                if (storeRuns)
                {
                    storeImmedCurr = executeImmedPrev;
                    storeInstrCurr = executeInstrPrev;
                    storeValueCurr = executeValuePrev;

                    Console.WriteLine("In Store " + storeInstrCurr + " " + storeImmedCurr + " " + storeValueCurr);

                    //store it 
                    switch (storeInstrCurr)
                    {
                        case (127): //LDA instruction
                            ACC = tmpValuePrev;
                            break;
                        case (126): //STA instruction
                            if (storeImmedCurr == 0)
                                Memory.memory[myMemory.solveMemory(storeValueCurr, storeInstrCurr, myCache, ACC, associativeValue, wordSize)] = ACC;
                            else
                            {
                                Console.WriteLine("Oops, something went wrong with: sta $" + storeValueCurr);
                                Environment.Exit(-1);
                            }
                            break;
                        case (125): //ADD instruction
                            ACC = tmpValuePrev;
                            if (ACC < 0)
                                CC = -1;
                            else if (ACC == 0)
                                CC = 0;
                            else if (ACC > 0)
                                CC = 1;
                            break;
                        case (124): //SUB instruction
                            ACC = tmpValuePrev;
                            if (ACC < 0)
                                CC = -1;
                            else if (ACC == 0)
                                CC = 0;
                            else if (ACC > 0)
                                CC = 1;
                            break;
                        case (123): //MUL instruction
                            ACC = tmpValuePrev;
                            if (ACC < 0)
                                CC = -1;
                            else if (ACC == 0)
                                CC = 0;
                            else if (ACC > 0)
                                CC = 1;
                            break;
                        case (122): //DIV instruction
                            ACC = tmpValuePrev;
                            if (ACC < 0)
                                CC = -1;
                            else if (ACC == 0)
                                CC = 0;
                            else if (ACC > 0)
                                CC = 1;
                            break;
                        case (121): //AND instruction
                            ACC = tmpValuePrev;
                            break;
                        case (120): //OR instruction
                            ACC = tmpValuePrev;
                            break;
                    }
                }

                if (OnStoreDone != null)
                    OnStoreDone(this, new OperationEventArgs(ThreadType.Store, this.IR));
            }
        }

        public void nextInstructionText()
        {
            if (x < IPE.opCodes.Length)
            {
                var instr = (finalCodes[x] >> 9) & 127; //Parses op code to find instruction
                var immed = (finalCodes[x] >> 8) & 1; //Parses op code to find immediate value
                var value = (finalCodes[x] & 255); //Parse op code to find value

                switch (instr)
                {
                    case (127): //LDA instruction
                        if (immed == 1)
                            nextInstructionLabel = ("lda #$" + value);
                        else if (immed == 0)
                            nextInstructionLabel = ("lda $" + value);
                        break;
                    case (126): //STA instruction
                        if (immed == 0)
                            nextInstructionLabel = ("sta $" + value);
                        else
                            Console.WriteLine("Oops, something went wrong with: sta $" + value);
                        break;
                    case (125): //ADD instruction
                        if (immed == 1)
                            nextInstructionLabel = ("add #$" + value);
                        else if (immed == 0)
                            nextInstructionLabel = ("add $" + value);
                        break;
                    case (124): //SUB instruction
                        if (immed == 1)
                            nextInstructionLabel = ("sub #$" + value);
                        else if (immed == 0)
                            nextInstructionLabel = ("sub $" + value);
                        break;
                    case (123): //MUL instruction
                        if (immed == 1)
                            nextInstructionLabel = ("mul #$" + value);
                        else if (immed == 0)
                            nextInstructionLabel = ("mul $" + value);
                        break;
                    case (122): //DIV instruction
                        if (immed == 1)
                            nextInstructionLabel = ("div #$" + value);
                        else if (immed == 0)
                            nextInstructionLabel = ("div $" + value);
                        break;
                    case (121): //AND instruction
                        if (immed == 1)
                            nextInstructionLabel = ("and #$" + value);
                        else if (immed == 0)
                            nextInstructionLabel = ("and $" + value);
                        break;
                    case (120): //OR instruction
                        if (immed == 1)
                            nextInstructionLabel = ("or #$" + value);
                        else if (immed == 0)
                            nextInstructionLabel = ("or $" + value);
                        break;
                    case (119): // SHL instruction
                        if (immed == 1)
                            nextInstructionLabel = ("shl #$" + value);
                        else
                            Console.WriteLine("Oops, it looks like something went wrong with: shl #$" + value);
                        break;
                    case (118): //NOTA instruction
                        nextInstructionLabel = ("nota");
                        break;
                    case (117): //BA instruction
                        nextInstructionLabel = ("ba " + (value));
                        x = value;
                        break;
                    case (116): //BE instruction
                        nextInstructionLabel = ("be " + (value));
                        if (CC == 0)
                            x = value;
                        break;
                    case (115): //BL instruction
                        nextInstructionLabel = ("bl " + (value));
                        if (CC < 0)
                            x = value;
                        break;
                    case (114): //BG instruction
                        nextInstructionLabel = ("bg " + (value));
                        if (CC > 0)
                            x = value;
                        break;
                    case (113): //NOP instruction
                        nextInstructionLabel = ("nop");
                        break;
                    case (112): //HLT instruction
                        nextInstructionLabel = ("hlt");
                        break;
                    case (100): //A Label
                        nextInstructionLabel = IPE.labelPositions.FirstOrDefault(y => y.Value == x).Key;
                        break;
                }
            }
            else
                ACC += 0;
        }

        public void doInstruction()
        {
            fetchDone = false;
            decodeDone = false;
            executeDone = false;
            storeDone = false;

            //string values to display
            if (i < finalCodes.Length + 4)
            {
                if (i < finalCodes.Length)
                    fetchString = IPE.text[i];
                if (i2 >= 0 && i2 < finalCodes.Length)
                    decodeString = IPE.text[i2];
                if (i3 >= 0 && i3 < finalCodes.Length)
                    executeString = IPE.text[i3];
                if (i4 >= 0 && i4 < finalCodes.Length)
                    storeString = IPE.text[i4];

                //ok switch to prev
                i4 = i3;
                i3 = i2;
                i2 = i;
            }
        }

        public void nextInstruction() //Steps through opcode, one step at a time
        {
            IPE.buttonsEnabled = false;

            fetchIRprev = IR;
            tmpValuePrev = tmpValue;
            decodeImmedPrev = decodeImmedCurr;
            decodeInstrPrev = decodeInstrCurr;
            decodeValuePrev = decodeValueCurr;
            executeImmedPrev = executeImmedCurr;
            executeInstrPrev = executeInstrCurr;
            executeValuePrev = executeValueCurr;
            storeImmedPrev = storeImmedCurr;
            storeInstrPrev = storeInstrCurr;
            storeValuePrev = storeValueCurr;
            branchVarEx = branchVarDecode;

            if (isDelay == false && currentNopCount == 0)
            {
                if (x < finalCodes.Length + 4)
                {
                    i++;
                    x++;
                    doInstruction();

                    missMemory = myMemory.totalMisses;
                    hitsMemory = myMemory.totalHits;
                    cacheStatus = myMemory.hitMiss;

                    operationCount++;
                    PC = i;
                    Console.WriteLine("i = " + i);
                }

                if (i == finalCodes.Length + 1)
                    IPE.buttonsEnabled = false;
            }
            else
            {
                isDelay = false;
                currentNopCount--;

                fetchString = "Delay";
                decodeString = "Delay";
                executeString = "Delay";
                storeString = "Delay";
            }

            fetchEvent.Set();
            decodeEvent.Set();
            executeEvent.Set();
            storeEvent.Set();

            IPE.buttonsEnabled = true;

        }

        //method to read the file containing binary instructions. Fetch Instructions and put into binary file
        public void readBinaryFile()
        {
            var binaryText = System.IO.File.ReadAllLines(@".\binaryCodes.txt").ToArray();
            finalCodes = new UInt16[binaryText.Length];
            var a = 0;
            foreach (var line in binaryText) //should not load in all at once
            {
                finalCodes[a] = Convert.ToUInt16(line);
                a++;
            }
        }


        public void runToEnd() //Runs through all steps of opcode at once
        {
            operationCount = 0; //reset our operation count to 0, then run to end!
            while (i4 < finalCodes.Length)
            {
                doInstruction();
                i++;
                operationCount++;
                PC = i;

                missMemory = myMemory.totalMisses;
                hitsMemory = myMemory.totalHits;
            }

            IPE.buttonsEnabled = false;
        }
    }
}
