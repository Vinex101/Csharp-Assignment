using System;
using System.Collections.Generic;
using System.Text;

namespace A2Q2___Algorithm
{
    class Algorithm
    { 
        public void displayArray(int[] temparray)
        {
            for (int i = 0; i < temparray.Length; i++)
            {
                Console.Write(temparray[i] + " ");
            }
        }

        public int NumOccuranceSearch(int[] temparray, int tempvalue, int tempoccurance)
        {
            //The compiler does not like it when a return method has code paths that dont lead to a return, so I have these hard coded variables for the code to return if the value is not found.
            int tempint = 0;
            int tempindex = -1;

            for (int i = 0; i < temparray.Length; i++)
            {
                //Comparing the current element in array to the user value, then incrementing an int to count how many occurances of that value occur in the array.
                if (temparray[i] == tempvalue)
                {
                    tempint++;
                }

                //Comparing the user occurance to the incremented occurance, if they are the same the amount of occurances is returned
                if (tempoccurance == tempint)
                {
                    tempindex = i;
                    return tempindex;
                }
            }
            //This is here to make sure that code paths return, if the number is found then it will return that, if it is not it will return -1 which was hard coded in the beginning of the method.
            return tempindex;


        }
    }
}
