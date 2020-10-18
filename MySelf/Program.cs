using System;

namespace MySelf
{
    class Program
    {

        static int[] findPrimeNum(int start, int end)
        {
            int[] Array = new int[20];
            for (int i = start; i < end; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }//else nothing
                    if (i - 1 == j)
                    {
                        Array[i] = i;
                    }
                }
            }
          

        }




        static void Main(string[] args)
        {

            //findPrimeNum(10, 30);

            //double result = Math.Round(0.3333, 2);
            //Console.WriteLine(result);













        }
    }
}







