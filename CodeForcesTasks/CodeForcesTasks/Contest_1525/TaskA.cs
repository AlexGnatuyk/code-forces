using System;
using System.Collections.Generic;

namespace CodeForcesTasks.Contest_1525
{
    public class TaskA
    {
        static void Main(string[] args)
        {
            var inputList = Read();
            var outputList = new List<int>();
            foreach (var percent in inputList)
            {
                outputList.Add(BoilCount(percent)); 
            }
            
            foreach (var result in outputList)
            {
                Console.WriteLine(result);    
            }
        }

        static int BoilCount(int k)
        {
            return 100/GCD(k, 100);
        }

        static List<int> Read()
        {
            var iterationCount = Int32.Parse(Console.ReadLine());
            var inputList = new List<int>();
            for ( var i = 0; i <= iterationCount - 1; i++)
            {
                inputList.Add(Int32.Parse(Console.ReadLine()));
            }

            return inputList;
        }
        
        private static int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a | b;
        }
    }
}