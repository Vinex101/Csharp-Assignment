using System;
using System.Collections.Generic;
using System.Text;

namespace A2Q4___Bubble
{
    class Algorithm
    {
        private int temp;
        private int iterations = 0;
        private int pass = 1;
        private bool check, swap;
        private int swapscheck = 0;


        public void displayArray(int[] temparray)
        {
            for (int i = 0; i < temparray.Length; i++)
            {
                Console.Write(temparray[i] + " ");
            }
        }

        public void bubbleSort(int[] temparray)
        {
            for (int i = 0; i < temparray.Length; i++)
            {
                for (int y = 0; y <temparray.Length - 1; y++)
                {
                    if (temparray[y] > temparray[y + 1])
                    {
                        temp = temparray[y];
                        temparray[y] = temparray[y + 1];
                        temparray[y + 1] = temp;
                    }
                }
                iterations = i;
            }
            Console.WriteLine("There have been {0} iterations of the BubbleSort loop.",iterations);
        }

        public void improvedBubbleSort(int[] temparray)
        {
            do
            {
                for (int i = 0; i < temparray.Length; i++)
                {
                    swap = false;
                    for (int y = 0; y < temparray.Length - pass; y++)
                    {
                        if (temparray[y] > temparray[y + 1])
                        {
                            temp = temparray[y];
                            temparray[y] = temparray[y + 1];
                            temparray[y + 1] = temp;
                            swap = true;
                            //swapscheck++;
                        }
                    }

                    //Used to test how many iterations have happened

                    //Console.WriteLine("\nIteration " + iterations);
                    //displayArray(temparray);
                    //Console.WriteLine("\n");

                  
                    iterations++;
                    pass++;

                    if (swap == false)
                    {
                        check = false;
                        break; //My friend Jack taught me about break, thanks Jack!
                    }
                }

            } while (check == true);

            Console.WriteLine("There have been {0} iterations of the BubbleSort loop.", iterations);

            //Console.WriteLine("\nA total of {0} swaps have been made." ,swapscheck);

        }

    }
}
