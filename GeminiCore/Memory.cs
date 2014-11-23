/**
 * Jason Walsh
 * Nadia Kiamilev
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiCore
{
    public class Memory
    {
        public static int[] memory = new int[256];
        public string nextInstruction;
        public static int cacheSize = 16;
        public int writeMiss { get; set; }
        public int writeHit { get; set; }
        public int readMiss { get; set; }
        public int readHit { get; set; }
        public int totalHits { get; set; }
        public int totalMisses { get; set; }
        public string hitMiss { get; set; }

        public struct frame
        {
            public bool dirtyBit;
            public int isEmpty;
            public int value;
            public int value2;
            public int tag;
            public int tag2;
        }

        public int solveMemory(int value, int instr, frame[] cache, int accVal, int type, int wordSize)
        {
            int block;
            if (type == 1) //One Way Set Associative
                block = value % cacheSize;
            else //Two Way Set Associative
            {
                block = value % cacheSize;
                Random num = new Random();
                int set = num.Next(0, 2);
                if (block % 2 == 0)
                {
                    if (set != 0)
                        block = block + 1;
                }
                else if (block % 2 != 0)
                {
                    if (set == 0)
                        block = block - 1;
                }
            }
            if (instr == 127 || instr == 125 || instr == 124 || instr == 123
                    || instr == 122 || instr == 121 || instr == 120)
            {
                if (cache[block].isEmpty == 0) //Read hit
                {
                    if (cache[block].tag == value)
                    {
                        hitMiss = "HIT";
                        //Console.WriteLine(hitMiss);
                        readHit++;
                        if (wordSize == 1)
                            return cache[block].value;
                        else
                        {
                            if (value % 2 == 0)
                                return cache[block].value;
                            else
                                return cache[block].value2;
                        }
                            
                    }
                    else
                    {
                        hitMiss = "MISS";
                        readMiss++;
                        //Console.WriteLine(hitMiss);
                        memory[cache[block].tag] = cache[block].value; // Read Miss
                        cache[block].value = memory[value];
                        cache[block].tag = value;
                        return cache[block].value;
                    }


                }
                else
                {
                    if (wordSize == 1)
                    {
                        readMiss++;
                        hitMiss = "MISS";
                        //Console.WriteLine(hitMiss);
                        cache[block].value = memory[value]; //Read Miss
                        cache[block].tag = value;
                        cache[block].isEmpty = 0;
                        return cache[block].value;
                    }
                    else
                    {
                        readMiss++;
                        hitMiss = "MISS";
                        //Console.WriteLine(hitMiss);
                        cache[block].value = memory[value];
                        if (value % 2 == 0)
                            cache[block].value2 = memory[value + 1];
                        else
                            cache[block].value2 = memory[value - 1];
                        cache[block].tag = value;
                        cache[block].tag2 = value + 1;
                        cache[block].isEmpty = 0;


                        return cache[block].value;
                    }
                }
            }
            else
            {
                if (cache[block].isEmpty == 1) //Write Miss
                {
                    hitMiss = "MISS";
                    writeMiss++;
                    //Console.WriteLine(hitMiss);
                    return value;
                }

                else
                {
                    if (cache[block].dirtyBit == false)
                    {
                        hitMiss = "HIT";
                        writeHit++;
                        //Console.WriteLine(hitMiss);
                        cache[block].value = accVal; //Write Hit and Clean
                        cache[block].dirtyBit = true;
                        cache[block].tag = value;
                    }
                    else
                    {
                        hitMiss = "HIT";
                        writeHit++;
                        //Console.WriteLine(hitMiss);
                        memory[cache[block].tag] = cache[block].value; // Write Hit and Dirty
                        cache[block].value = accVal;
                        cache[block].tag = value;
                        cache[block].dirtyBit = false;
                    }
                }
            }
            totalHits = writeHit + readHit;
            totalMisses = writeMiss + readMiss;
            Console.WriteLine("Number of Misses =  " + totalMisses);
            Console.WriteLine("Number of hits = " + totalHits);
            return value;
        }
    }
}
