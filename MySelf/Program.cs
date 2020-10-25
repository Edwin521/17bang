using System;

namespace MySelf
{
    class Program
    {



        static void grow(ref student student)

        {
            student = new student();
            student.age++;
        }


        static void Main(string[] args)
        {

            student lzb = new student();
            lzb.age = 20;
            grow(ref  lzb);
            Console.WriteLine(lzb.age);

            //findPrimeNum(10, 30);

            //double result = Math.Round(0.3333, 2);
            //Console.WriteLine(result);

            //Program.publish();
            //student lzb = new student();
            //lzb.age = 18;
            //student clone = lzb;
            //clone.age = 20;
            //Console.WriteLine(lzb.age);















        }
    }
}







