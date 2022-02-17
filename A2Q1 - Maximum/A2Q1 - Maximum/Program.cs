using System;

namespace A2Q1___Maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Generator = new Random();
            int[] NumArray = new int[10];
            Algorithm NewAlgo = new Algorithm();

            for (int i = 0; i < NumArray.Length; i++)
            {
                NumArray[i] = Generator.Next(1,101);
            }

            NewAlgo.displayArray(NumArray);

            Console.WriteLine("\n\n");
            NewAlgo.findMaximum(NumArray, 3);

            Console.ReadKey();
        }
    }
}
