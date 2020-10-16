using System;

namespace MySelf
{
    class Program
    {
        static void Main(string[] args)
        {

            Random ran = new Random();
            int[] arr = new int[10];
            arr[0] = ran.Next(50);//随机第一个数字
            Console.WriteLine(arr[0]);
            for (int i = 1; i < 12; i++)
            {
                arr[i] = arr[i - 1] + ran.Next(50);
                Console.WriteLine(arr[i] + ",");
            }

            //计算得到源栈同学的平均成绩（精确到两位小数），方法名GetAverage()
        }
    }
}



