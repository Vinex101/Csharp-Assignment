using System;

namespace A2Q3___LastOccurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Generator = new Random();
            int[] NumArray = new int[20];
            Algorithm NewAlgo = new Algorithm();
            int uservalue;
            int occurance;

            for (int i = 0; i < NumArray.Length; i++)
            {
                NumArray[i] = Generator.Next(1,101);
            }

            Console.WriteLine("Original Array");
            NewAlgo.displayArray(NumArray);

            Console.Write("\n\nWhat Value would you like to find?: >");
            uservalue = Convert.ToInt32(Console.ReadLine());

            occurance = NewAlgo.LastOccuranceSearch(NumArray, uservalue);

            if (occurance == -1)
            {
                Console.WriteLine("\nYour value of {0} was not found in the array." ,uservalue);
            }

            else
            {
                Console.WriteLine("\nThe item {0} has its last occurance at index {1}.", uservalue, occurance);
            }

            Console.Write("\nPress any key to quit...");

            Console.ReadKey();
        }
    }
}
