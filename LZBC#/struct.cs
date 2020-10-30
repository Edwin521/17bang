using System;
using System.Collections.Generic;
using System.Text;

namespace LZBC
{

    //用代码证明struct定义的类型是值类型
    //源栈的学费是按周计费的，所以请实现这两个功能：
    //    函数GetDate()，能计算一个日期若干（日/周/月）后的日期
    //1,先确定起始的某个日期和若干的
    //2，



    public struct time
    {


        public static DateTime GetDate(DateTime startTime, int num)
        {

            //DateTime weeks = startTime.AddMonths(num);
            //return   startTime.AddDays(num);//日
            return startTime.AddDays(num * 7);//周
                                              //return startTime.AddMonths(num);//月

        }

        ////    给定任意一个年份，就能按周排列显示每周的起始日期，如下图所示：
        ///

        //先确定给定的年份一月一号是否是周一，如果不是，继续往下找，直到找到星期一跳出循环



        public static DateTime GetDateofmondy(int AnyYear)
        {
            DateTime dateTime = new DateTime(AnyYear, 1, 1);
            for (int i = 1; i <= 6; i++)
            {
                if (dateTime.DayOfWeek == DayOfWeek.Monday)
                {
                    return dateTime;

                }
                else
                {
                    dateTime = dateTime.AddDays(1);
                }
            }
            return dateTime;
        }

        public static void GetWeeks(DateTime dateTime)
        {

            for (int i = 1; i <= 52; i++)
            {

                Console.WriteLine($"第{i}周，{dateTime.ToString("yyyy年MM月dd日")}--{dateTime.AddDays(6).ToString("yyyy年MM月dd日")}");
                dateTime = dateTime.AddDays(7);

            }
        }




    }


}

