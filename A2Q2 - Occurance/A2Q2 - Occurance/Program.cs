using System;

namespace A2Q2___Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Generator = new Random();
            int[] NumArray = new int[100];
            Algorithm NewAlgo = new Algorithm();
            int value, occurance, index;

            for (int i = 0; i < NumArray.Length; i++)
            {
                NumArray[i] = Generator.Next(1,101);
            }

            NewAlgo.displayArray(NumArray);

            Console.Write("\nWhat value do you want to find: >");
            value = Convert.ToInt32(Console.ReadLine());

            Console.Write("Which occurance do you want to find: >");
            occurance = Convert.ToInt32(Console.ReadLine());

            index = NewAlgo.NumOccuranceSearch(NumArray, value, occurance);

            if (index == -1)
            {
                Console.WriteLine("Your value was not found in the array.");
            }

            else
            {
                Console.WriteLine("The item {0} has occurance {1} at index {2}", value, occurance, index);
            }
        


            Console.ReadKey();
        }
    }
}
