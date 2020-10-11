using System;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {

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
