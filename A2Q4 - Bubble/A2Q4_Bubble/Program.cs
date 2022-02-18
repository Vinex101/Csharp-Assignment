using System;

namespace A2Q4___Bubble
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Generator = new Random();
            int[] NumArray = new int[100];
            Algorithm NewAlgo = new Algorithm();

            for (int i = 0; i < NumArray.Length; i++)
            {
                NumArray[i] = Generator.Next(1,101);
            }

            Console.WriteLine("Original Array:\n");

            NewAlgo.displayArray(NumArray);

            

            //NewAlgo.bubbleSort(NumArray);

            //NewAlgo.displayArray(NumArray);

            Console.WriteLine("\n\n");
            Console.WriteLine("After bubble sort:\n");
            NewAlgo.improvedBubbleSort(NumArray);

            NewAlgo.displayArray(NumArray);


            Console.ReadKey();
        }
    }
}
