using LZBC;
using System;
using System.Reflection;

namespace test2
{
    public class Program



    {





        ///判断一个数是不是质数
        ///
        public static bool IsPrimeNum(int num)
        {


            if (num < 2)
                return false;
            if (num == 2 || num == 3)
            {
                return true;
            }
            for (int i = 2; i < num - 1; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
                //else nothing 
            }
            Console.WriteLine(num.ToString() + "是素数");
            return true;

        }








        ///完成“猜数字”游戏，方法名GuessMe()：
        /////随机生成一个大于0小于1000的整数
        ////用户输入一个猜测值，系统进行判断，告知用户猜测的数是“大了”，还是“小了”
        ////没猜中可以继续猜，但最多不能超过10次
        ////如果5次之内猜中，输出：你真牛逼！
        ////如果8次之内猜中，输出：不错嘛！
        ////10次还没猜中，输出：(～￣(OO)￣)ブ

        ////猜数字，限制次数10


        public static void GuessMe()
        {
            int num = new Random().Next(1000);
            Console.WriteLine("随机数是：" + num);

            for (int i = 1; i < 11; i++)
            {
                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    if (input != num)
                    {
                        if (i == 10)
                        {
                            Console.WriteLine("～￣(OO)￣");
                            break;
                        }
                        if (input > num)
                        {
                            Console.WriteLine($"太大了吆!还剩{10 - i}次");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine($"太小了呢!还剩{10 - i}次");
                            continue;
                        }
                    }
                    else
                    {
                        if (i <= 5)
                        {
                            Console.WriteLine("你真牛逼");

                        }
                        else if (i <= 8)
                        {
                            Console.WriteLine("不错嘛");

                        }
                        else
                        {
                            Console.WriteLine("你有点笨噢！");

                        }
                        break;

                    }
                }
                else
                {
                    Console.WriteLine("输入错误，请输入1-1000的自然数");
                    continue;
                }
            }

        }



        public static void GuessMe(int num)
        {



        }


        //封装一个方法，可以修改Content的CreateTime和PublishTime
        public void AlterCreateTime( Content content ,DateTime dateTime)
        {
            typeof(Content)
               .GetProperty("CreateTime", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(content, dateTime);
            Console.WriteLine();
        }
        public void AlterPublishTime(Content content, DateTime dateTime)
        {
            typeof(Content)
               .GetProperty("PublishTime", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(content, dateTime);
            Console.WriteLine();
        }




        static void Main(string[] args)
        {
            //封装一个方法，可以修改Content的CreateTime和PublishTime
            DateTime lw = new DateTime(2023, 3, 4);

            Content article = new Content("文章");
            article.GetType()
                .GetProperty("CreateTime", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(article, lw);
            Console.WriteLine();





            //Console.WriteLine(Program.findPrimeNum(1, 10));

            TokenManager tokenManager = new TokenManager();
            User user = new User("lls", "1234");
            Console.WriteLine(user.ToString());

            Console.WriteLine(user);

            //Article js = new Article
            //{
            //    title = "title1",
            //    Author = new User("lzb", "333")
            //};

            //User lls = new User("lls", "123");
            //js.AgreedBy(lls);

            //new Article().AgreedBy(new User("lls", "1234"));


            //ISendMessage lzb = new User("lzb","123");///调用显示接口
            //User lls = new User("lls", "333");

            //lzb.Send(lls);

            //Console.WriteLine(time.GetDate(new DateTime(2020,2,27), 3)); 
            //Console.WriteLine(time.GetDate(new DateTime(2020,2,27), 1)); 
            //Console.WriteLine(time.GetDate(new DateTime(2020,12,30), 1)); 
            //Console.WriteLine(time.GetDate(new DateTime(2020,1,1), 1));

            //Console.WriteLine(time.GetDateofmondy(2021));
            //Console.WriteLine(time.GetDateofmondy(2022)); 
            //Console.WriteLine(time.GetDateofmondy(2023)); 
            //Console.WriteLine(time.GetDateofmondy(2024)); 


            //time.GetWeeks(new DateTime(2020, 1, 6));


            //TokenManager lzb = new TokenManager();
            //lzb._token = lzb._token | Token.Admin;///存入权限身份
            //lzb._token = lzb._token ^ Token.Blogger;//剥夺权限身份


            //Console.WriteLine((lzb._token & Token.Newbie) == Token.Newbie);//查看是否存在这个权限





            //用代码证明struct定义的类型是值类型
            //bed dream = new bed();
            //dream = null;///值类型不能赋值为null
            //User lzb = new User("lzb","123");
            //lzb = null;///同样的由class定义的引用类型就可以赋值为null

            //Suggest lzb = new Suggest();
            //Console.WriteLine(lzb._kind);
            //Article lz = new Article();
            //Console.WriteLine(lz._kind);


            // FactoryContext lzb = new FactoryContext();
            //FactoryContext a = FactoryContext.foo();
            //FactoryContext b = FactoryContext.foo();
            //MimicStack.MimicStack.Push(123);
            //MimicStack.MimicStack.Push(124);
            //MimicStack.MimicStack.Push(123);

            /* FactoryContext a = new FactoryContext();*////构造函数设为私有后，新new的时候就会报错


            //problem lzb = new problem();
            //lzb[1] = "123";
            //lzb[2] = "456";
            //lzb[3] = "789";
            //lzb[0] = "22";
            //Console.WriteLine(lzb[2]);

            //problem lzb = new problem("lzb");

            //problem lw = new problem("");

            //User zdh = new User("空", "ki");
            //Console.WriteLine(zdh.Name);

            //Console.WriteLine(zdh.Password);

            ///调用函数
            ///
            //string output;
            //LZBC.user.Register("1234", "2345", "3456",  "4567", "6789",out output);
            //if (LZBC.user.Register("1234", "2345", "3456", "4567", "6789", out output))
            //{
            //    Console.WriteLine(output);
            //}
            //else
            //{
            //    Console.WriteLine(output);
            //}




            //            string num;
            //            if (logOn("12", "13", "14", out num)
            //)
            //            {
            //                Console.WriteLine(num);
            //            }
            //            else
            //            {
            //                Console.WriteLine(num);

            //            }


            //Console.WriteLine(BinarySeek(new int[] { 1, 3, 5, 6, 8, 12, 24 }, 0, 7, 12));
            //Console.WriteLine(BinarySeek2(new int[] { 1, 3, 5, 6, 8, 12, 24, 34,75 },75 ));
            //GetArray(12, 12, 12);
            //GuessMe();
            //Console.WriteLine(GetAverage(new double[] { 23.45, 12.3, 34.5 }));
            //findPrimeNum(10,30);//找质数
            /// Console.WriteLine(getMax(new double[] { 23.1, 44, 32, 13 })); 
            //getMax(new double[] { 23.1, 44, 32, 13 });
            //twoDimensional();//数组下标
            //GetAverage(1200, 43);//平均成绩
            //Console.WriteLine(GetAverage(1200, 43));

            // Console.WriteLine(logOn("123", "234", "345"));//登录
            //GuessMe(12);//猜数字

            ///  //getSum(1, 2);
            //Console.WriteLine(getSum(1, 2));
            //getProduct(2, 3);
            //Console.WriteLine(getProduct(2, 3));
            //differencing(23, 21);
            //Console.WriteLine(differencing(23, 21));
            //QUOTIENT(4, 3);
            //Console.WriteLine(QUOTIENT(6,2.4));











        }


    }
}
