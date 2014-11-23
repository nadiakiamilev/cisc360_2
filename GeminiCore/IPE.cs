/**
 * Jason Walsh
 * Nadia Kiamilev
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Drawing;

namespace GeminiCore
{
    public class IPE
    {
        public static bool buttonsEnabled = true;
        public static string[] text;
        public string FileToParse { get; set; }
        public static UInt16[] opCodes;
        public static Dictionary<string, int> labelPositions = new Dictionary<string, int>();
        public Dictionary<string, UInt16> dictionary = new Dictionary<string, UInt16>(); //holds english instruction as keys, and assigns a 7 bit value
        public string[] instructions;

        public IPE(string filename)
        {
            this.FileToParse = filename;

            dictionary.Add("lda", 127);
            dictionary.Add("sta", 126);
            dictionary.Add("add", 125);
            dictionary.Add("sub", 124);
            dictionary.Add("mul", 123);
            dictionary.Add("div", 122);
            dictionary.Add("and", 121);
            dictionary.Add("or", 120);
            dictionary.Add("shl", 119);
            dictionary.Add("nota", 118);
            dictionary.Add("ba", 117);
            dictionary.Add("be", 116);
            dictionary.Add("bl", 115);
            dictionary.Add("bg", 114);
            dictionary.Add("nop", 113);
            dictionary.Add("hlt", 112);
        }

        /*writes the input to a text file that includes the binary code*/
        public void writeBinary(int opcode)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@".\binaryCodes.txt", true))
            {
                file.WriteLine(opcode);
            }
        }

        public void ParseFile()
        {
            text = File.ReadAllLines(this.FileToParse).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToArray(); //Reads in text file and puts it in an array
            var lineNumber = 0; //initialize line number

            for (int x = 0; x < text.Length; x++) //Cleans up each line, removing comments and extra white space
            {
                if (text[x].Contains('!'))
                    text[x] = text[x].Substring(0, text[x].IndexOf('!'));
                text[x] = text[x].Trim();
            }
            foreach (var line in text) //Runs through code once to get label positions
            {
                if (line != "")
                {
                    Regex labelStmtFormat = new Regex(@"^(?<label>.*?)\s*:$"); //Regex for finding labels
                    var labelStmtMatch = labelStmtFormat.Match(line); //Checks for label matching

                    if (labelStmtMatch.Success)
                    {
                        var label = labelStmtMatch.Groups["label"].Value;
                        labelPositions.Add(label, lineNumber);
                    }
                    lineNumber++;
                }
            }
            opCodes = new UInt16[lineNumber]; //initialize array of UInt16's for opCodes
            var instructions = new string[lineNumber];

            lineNumber = 0;

            foreach (var line in text)
            {

                if (line != "")
                {
                    UInt16 binaryInstruction = 0;
                    UInt16 binaryImmediate = 0;
                    UInt16 binaryValue = 0;

                    Regex labelStmtFormat = new Regex(@"^(?<label>.*?)\s*:$"); //Regex for finding labels
                    Regex instructionStmtFormat = new Regex(@"(?<ins>^\S*)"); //Regex for finding Instructions
                    Regex valueStmtFormat = new Regex(@"(?<val>\d+)"); //Regex for finding Values
                    Regex illegalCharStmtFormat = new Regex(@"[!@%\^&\*\(\)-]"); //Regex for finding Illegal Characters

                    var labelStmtMatch = labelStmtFormat.Match(line); //Checks for label matching
                    var instructionStmtMatch = instructionStmtFormat.Match(line); //checks for instruction matching
                    var valueStmtMatch = valueStmtFormat.Match(line); //checks for value matching
                    var illegalCharStmtMatch = illegalCharStmtFormat.Match(line); //checks for illegal charracter matching
                    var ins = instructionStmtMatch.Groups["ins"].Value;


                    var result = 0;
                    if (labelStmtMatch.Success)
                    {
                        var label = labelStmtMatch.Groups["label"].Value;
                        binaryValue = Convert.ToUInt16(lineNumber); //Adds 64 to guarantee a 7bit number
                        result = binaryValue;
                        binaryInstruction = 100 << 9; //moves the binary instruction code to the correct location in the 16-bit op Code

                        binaryImmediate = 0 << 8;
                        result = result | binaryImmediate;
                        result = result | binaryInstruction;
                    }

                    else if (instructionStmtMatch.Success)
                    {
                        binaryInstruction = Convert.ToUInt16(dictionary[ins]);
                        if (ins == "ba" || ins == "be" || ins == "bl" || ins == "bg") //Sets values accordingly if instruction is a jump
                        {
                            binaryImmediate = 0;
                            var tempString = line.Substring(3); //Gets label needed to jump to
                            tempString = tempString.Trim();
                            binaryValue = Convert.ToUInt16(labelPositions[tempString]); //Gets the label position from the dictionary, sets it as value
                            result = binaryInstruction;
                            result = result << 9;
                            binaryImmediate = 0 << 8;
                            result = result | binaryImmediate;
                            result = result  |binaryValue;
                        }
                        else
                        {
                            result = binaryInstruction;
                            result = result << 9; //moves the binary instruction code to the correct location in the 16-bit op Code
                        }
                    }
                    if (line.Contains("#$"))
                    {
                        binaryImmediate = 1 << 8; //moves the binary immediate code to the correct location in the 16-bit op Code
                        result = result | binaryImmediate; //Combines the op Code so far with the new immediate value
                    }
                    else if (line.Contains("$"))
                    {
                        binaryImmediate = 0 << 8;
                        result = result | binaryImmediate;
                    }
                    if (valueStmtMatch.Success)
                    {
                        var val = valueStmtMatch.Groups["val"].Value;
                        binaryValue = Convert.ToUInt16(val);
                        if (binaryValue > 256 && !line.Contains("#$"))
                        {
                            Console.WriteLine("There is a segmentation fault occurring at line number: " + lineNumber + ". Buttons will be disabled");
                            buttonsEnabled = false;
                        }
                        result = result | binaryValue; //Combines the op Code so far with the new value

                    }
                    writeBinary(result);

                    //placing the opcode values in a file
                    opCodes[lineNumber] = Convert.ToUInt16(result); //Puts the op Code of the current line into an array of op Codes
                    var temp = Convert.ToUInt16(result);
                    /***Write OpCodes to file**/
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@".\binaryCodes2.txt", true))
                    {
                        file.WriteLine(Convert.ToString(temp, 2));
                    }

                    if (illegalCharStmtMatch.Success)
                    {
                        Console.WriteLine("Illegal Character found at line: " + lineNumber + ". Buttons will be disabled.");
                        buttonsEnabled = false;
                    }
                    lineNumber++;
                }
                else
                    Console.WriteLine("This line is blank: " + lineNumber);
            }
        }
    }
}
