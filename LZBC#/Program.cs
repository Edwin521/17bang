using System;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {

            ///C#作业
            //const string greet = "123";
            // Console.WriteLine(greet);

            //bool gender;
            //int birthday;
            //string constellation;
            //string keyword;
            //string selfIntroduction;

            //输出两个整数 / 小数的和 / 差 / 积 / 商

            //Console.WriteLine(12+12);
            //Console.WriteLine(12*12);
            //Console.WriteLine(12-12);
            //Console.WriteLine(12/12);

            //Console.WriteLine(12.1+12.1);
            //Console.WriteLine(12.1-12.1);
            //Console.WriteLine(12.1*12.1);
            //Console.WriteLine(12.1/12.1);

            //电脑计算并输出：[(23 + 7)x12-8]÷6的小数值（挑战：精确到小数点以后2位）

            //Console.WriteLine(((23+7)*12-8)/6) ;

            //想一想以下语句输出的结果：

            //int i = 15;
            //Console.WriteLine(i++);//15
            //i -= 5;
            //Console.WriteLine(i);//11
            //Console.WriteLine(i >= 10);//true

            //Console.WriteLine("i值的最终结果为：" + i); //i值的最终结果为：11

            //int j = 20;
            //Console.WriteLine($"{i}+{j}={i + j}");//11+20=31


            //int a = 10;
            //Console.WriteLine(a+12);
            //a -= 1;
            //Console.WriteLine(a);

            ///用户依次由控制台输入：验证码、用户名和密码： 如果验证码输入错误，直接输出：“*验证码错误”；
            // 如果用户名不存在，直接输出：“*用户名不存在”；
            // 如果用户名或密码错误，输出：“*用户名或密码错误”
            // 以上全部正确无误，输出：“恭喜！登录成功！”



            //Console.WriteLine("请输入验证码（1234）");
            //var outcode1= Console.ReadLine();

            //if (outcode1 == "1234")
            //{
            //    Console.WriteLine("请输入用户名(edwin)");
            //    var outcode2=  Console.ReadLine();
            //    if (outcode2 == "edwin")
            //    {
            //        Console.WriteLine("请输入密码（4567）");
            //        var outcode3=Console.ReadLine();
            //        if (outcode3 == "4567")
            //        {
            //            Console.WriteLine("恭喜！登录成功");
            //        }
            //        else
            //        {
            //            Console.WriteLine("用户名或密码错误");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("用户名不存在");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("验证码错误");
            //}



            // 将源栈同学姓名 / 昵称分别：
            //    按进栈时间装入一维数组，
            //    按座位装入二维数组，

            //并输出共有多少名同学。


            string[] students = new string[5];
            students[4] = "刘伟-刘光头";
            students[1] = "龚廷义-小可爱";
            students[2] = "周丁浩-小帅哥";
            students[0] = "李智博-理智";
            students[3] = "廖光银-廖兄";

            string [,] stacklist = new string [3, 3];
            stacklist[0, 0] = "刘伟-刘光头";
            stacklist[1, 0] = "龚廷义-小可爱";
            stacklist[1, 1] = "周丁浩-小帅哥";
            stacklist[1, 2] = "李智博-理智";
            stacklist[2, 0] = "廖光银-廖兄";
            Console.WriteLine(stacklist.Length);
            Console.WriteLine(stacklist.Rank);
            Console.WriteLine(stacklist[1,2]);


        }
    }
}
