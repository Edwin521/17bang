using System;

namespace test2
{
    class HomeWork
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


            //string[] students = new string[5];
            //students[4] = "刘伟-刘光头";
            //students[1] = "龚廷义-小可爱";
            //students[2] = "周丁浩-小帅哥";
            //students[0] = "李智博-理智";
            //students[3] = "廖光银-廖兄";

            //string[,] stacklist = new string[3, 3];
            //stacklist[0, 0] = "刘伟-刘光头";
            //stacklist[1, 0] = "龚廷义-小可爱";
            //stacklist[1, 1] = "周丁浩-小帅哥";
            //stacklist[1, 2] = "李智博-理智";
            //stacklist[2, 0] = "廖光银-廖兄";
            //Console.WriteLine(stacklist.Length);
            //Console.WriteLine(stacklist.Rank);
            //Console.WriteLine(stacklist[1,2]);



            //分别用for循环和while循环输出：1,2,3,4,5 和 1,3,5,7,9
            //for循环
            //for (int i = 1; i < 6; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 1; i < 10;i+=2)
            //{
            //    Console.WriteLine(i);
            //}



            //while循环
            //int i = 1;
            //while (i<6)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int i = 1;
            //while (i<10)
            //{
            //    Console.WriteLine(i);
            //    i +=2;
            //}

            //用for循环输出存储在一维 / 二维数组里的源栈所有同学姓名 / 昵称
            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine(students[i]);
            //}

            //for (int i = 0; i < stacklist.Length; i++)
            //{


            //    for (int j = 0; j <3; j++)
            //    {
            //        Console.WriteLine(stacklist[j, i]);

            //    }
            //}

            //让电脑计算并输出：99 + 97 + 95 + 93 + ...+1的值
            //int j = 0;
            //for (int i = 1; i < 100; i += 2)
            //{
            //    Console.WriteLine(i);
            //    j += i;

            //}

            //Console.WriteLine(j);

            //将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分
            //最高分
            //double[] scores = { 98, 78, 85.5, 67, 89, 98.3 };
            //// double max = 0;
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    if (scores[i]>max)
            //    {
            //        max = scores[i];
            //    }//else nothing
            //}

            //Console.WriteLine(max);


            //最低分
            //double[] scores = { 98, 78, 85.5, 67, 89, 98.3 };
            //double min = 100;//这个值很关键
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    if (scores[i] < min)
            //    {
            //        min = scores[i];
            //    }//else nothing
            //}

            //Console.WriteLine(min);

            ///一次写完取最大值和最小值
            ///
            //double max = scores[0],
            //       min = scores[0];
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    if (scores[i]> max )
            //    {
            //        max = scores[i];
            //    }//else nothing
            //    if (scores[i]<min)
            //    {
            //        min = scores[i];
            //    }//else 
            //}

            //Console.WriteLine($"最大成绩是：{max},最小成绩是：{min}");




            //找到100以内的所有质数（只能被1和它自己整除的数） 

            //for (int i = 2; i < 10; i++)
            //{

            //    for (int j = 2; j < i; j++)
            //    {

            //        if (i % j == 0)
            //        {
            //            break;


            //        }//else nothing
            //        if (i - 1 == j)
            //        {
            //            Console.WriteLine(i);
            //        }

            //    }
            //}

            ///生成一个元素，从小到大排列的数组；
            ///
            //Random ran = new Random();
            //int[] arr = new int[10];
            //arr[0] = ran.Next(50);//随机第一个数字
            //Console.WriteLine(arr[0]);
            //for (int i = 1; i < 10; i++)
            //{
            //    arr[i] = arr[i - 1] + ran.Next(50);
            //    Console.WriteLine(arr[i] + ",");
            //}

            ////猜数字，限制次数10
            ///比如要猜的数字为55；
            //Console.WriteLine("hello.word!"); 
            //Console.WriteLine("请输入一个不超过1000的自然数");


            //for (int i = 1; i<11; i++)
            //{
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    if (num!=55)
            //    {
            //        if (num>55)
            //        {
            //            Console.WriteLine($"太大了吆!还剩{10-i}次");
            //            continue;
            //        }
            //        else
            //        {
            //            Console.WriteLine($"太小了呢!还剩{10-i}次");
            //            continue;
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine($"恭喜你,答对了!只用了{i}次呢,棒棒的！");
            //        break;
            //    }
            //}
            ////设立并显示一个多维数组的值，元素值等于下标之和。Console.Write()//没写完
            ///

            //int[][] nums = new int[2, 3];
            //int[,] nums={  { 0,1, 2, 3 },  { 1, 2, 3, 4 }, { 2, 3, 4, 5 } };


            //for (int i = 0; i < nums.Length; i++)
            //{

            //    for (int j = 0; j < nums.Length;j++)
            //    {

            //        Console.WriteLine(nums[i, j]);

            //    }
            //}
            ////输入一个字符串，输出其字母颠倒后的结果。如：yuanzhan -> nahznauy //没写好


            //int[] arr = { 1, 2, 3, 4, 5, 6 };
            //int[] newArr = { };
            //for (int i = arr.Length-1; i >0; i--)
            //{
            //    newArr[newArr.Length] = arr[i];

            //}

            //for (int i = 0; i < newArr.Length; i++)
            //{
            //    Console.WriteLine(newArr[i]);
            //}

            ///二分查找写出来
            ///

            //int[] arr = { 1, 2, 3, 4, 5, 6 ,7};
            //int left = 0, right = arr.Length - 1, result = 0;
            //int num = 7;
            //while (arr[result] != num)
            //{
            //    int middle = (left + right) / 2;
            //    if (arr[middle] > num)
            //    {
            //        right = middle - 1;
            //    }
            //    else if (arr[middle] < num)
            //    {
            //        left = middle + 1;
            //    }
            //    else
            //    {
            //        result = middle;
            //        break;
            //    }
            //}
            //Console.WriteLine("下标位置为："+result);



            //计算得到源栈同学的平均成绩（精确到两位小数），方法名GetAverage()

            //static double GetAverage(double sumScores, int amount)
            //{
            //    return sumScores / amount;
            //}

            //GetAverage(1200, 43);
            //Console.WriteLine(GetAverage(1200, 43));


            ///完成“猜数字”游戏，方法名GuessMe()：
            /////随机生成一个大于0小于1000的整数
            //用户输入一个猜测值，系统进行判断，告知用户猜测的数是“大了”，还是“小了”
            //没猜中可以继续猜，但最多不能超过10次
            //如果5次之内猜中，输出：你真牛逼！
            //如果8次之内猜中，输出：不错嘛！
            //10次还没猜中，输出：(～￣(OO)￣)ブ

            ////猜数字，限制次数10
            ///比如要猜的数字为55；
            GuessMe(12);


            static void GuessMe(int input)
            {

                int num = new Random().Next(1000);
                Console.WriteLine(num);

                for (int i = 1; i < 11; i++)
                {
                    input = Convert.ToInt32(Console.ReadLine());
                    if (input != num)
                    {
                        if (input > num)
                        {
                            Console.WriteLine($"太大了吆!还剩{10 - i}次");
                            continue;
                        }

                        else if (i == 10)
                        {
                            Console.WriteLine("～￣(OO)￣");
                            break;
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
                            break;
                        }
                        else if (i <= 8)
                        {
                            Console.WriteLine("不错嘛");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("太笨了你！");
                            break;
                        }

                    }
                }

            }

        }

    }
}
