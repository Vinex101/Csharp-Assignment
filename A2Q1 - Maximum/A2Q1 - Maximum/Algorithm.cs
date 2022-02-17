using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace A2Q1___Maximum
{
    class Algorithm
    {
        //Insance variables
        private int BigNum, TempNum;
        private bool Container;


        public void displayArray(int[] temparray)
        {
            for (int i = 0; i < temparray.Length; i++)
            {
                Console.Write(temparray[i] + " ");
            }
        }

        public void findMaximum(int[] temparray, int n)
        {
            //ArrayList bigNumStorage = new ArrayList();

            ////Using nested for loops to find biggest number in array
            //for (int o = 0; o <= n; o++)
            //{
            //    for (int i = 0; i < temparray.Length; i++)
            //    {

            //        if (temparray[i] > BigNum)
            //        {
            //            BigNum = temparray[i];
            //        }

            //    }

            //    //I'm using a boolean variable to check if the biggest number is already in the bigNumStorage array, if it isnt, it is added to the bigNumStorage array
            //    Container = bigNumStorage.Contains(BigNum);
            //    if (Container == false)
            //    {
            //        bigNumStorage.Add(BigNum);
            //        Console.WriteLine("Added");
            //    }

            //}

            ////Displaying the bigNumStorage array
            //for (int i = 0; i < bigNumStorage.Count; i++)
            //{
            //    Console.WriteLine(bigNumStorage[i]);
            //}

            //Console.WriteLine("\n");
            ////Console.WriteLine(BigNum);
            ///


            //------------------------------------------------------------------------------------------------------

            int tempnum = n;
            int tempstorage;

            for (int i = 0; i < temparray.Length; i++)
            {
                for (int y = 0; y < temparray.Length - 1; y++)
                {
                    if (temparray[y] > temparray[y + 1])
                    {
                        tempstorage = temparray[y];
                        temparray[y] = temparray[y + 1];
                        temparray[y + 1] = tempstorage;
                    }
                }
            }



            for (int i = 0; i < temparray.Length; i++)
            {
                Console.Write(temparray[i] + " ");
            }

            Console.WriteLine("\n");



            ArrayList bigNumStorage = new ArrayList();

            for (int i = temparray.Length - 1; i > tempnum; i--)
            {
                if (tempnum > 0)
                {
                    bigNumStorage.Add(temparray[i]);
                    tempnum--;
                }
            }

            Console.Write("{0} Maximum Values are: ", n);
            for (int i = 0; i < bigNumStorage.Count; i++)
            {
                Console.Write(bigNumStorage[i] + " ");
            }





        }
    }
}
