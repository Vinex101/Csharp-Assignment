using System;
using System.Collections.Generic;
using System.Text;

namespace A2Q3___LastOccurance
{
    class Algorithm
    {
        public Algorithm()
        { 
        
        }


        public void displayArray(int[] temparray)
        {
            for (int i = 0; i < temparray.Length; i++)
            {
                Console.Write(temparray[i] + " ");
            }
        }

        public int LastOccuranceSearch(int[] temparray, int tempvalue)
        {
            //The compiler does not like it when a return method has code paths that dont lead to a return, so I have these hard coded variables for the code to return if the value is not found.
            int index = -1;

            //I used a backwards linear search to find the last occurance of the specified value in the array. It kinda feels cheesy to do it this way but it works everytime ¯\_(ツ)_/¯
            for (int i = temparray.Length-1; i > -1; i--)
            {
                if (temparray[i] == tempvalue)
                {
                    index = i;
                    return index;
                }
            }
            //This is here to make sure that code paths return, if the number is found then it will return that, if it is not it will return -1 which was hard coded in the beginning of the method.
            return index;
          
        }

    }
}
