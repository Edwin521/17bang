using System;

namespace MySelf
{
    class Program
    {

        static string GetAverage(double[] scores)
        {
            double sum = 0;
            double avg;
            for (int i = 0; i < scores.Length; i++)
            {

                sum += scores[i];

            }
            avg = Math.Round((sum / scores.Length),2);

            return $"班级的平均成绩为{avg}";
        }




        static void Main(string[] args) {

            //double result = Math.Round(0.3333, 2);
            //Console.WriteLine(result);

            Console.WriteLine(GetAverage(new double[] { 23.45, 12.3, 34.5 })); 




        }








    }
}







