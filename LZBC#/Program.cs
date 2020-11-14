using LZBC;
using System;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
namespace test2
{
    public class Program
    {

        //封装一个方法，可以修改Content的CreateTime和PublishTime
        public void AlterCreateTime(Content content, DateTime dateTime)
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

        //实现GetCount(string container, string target)方法，可以统计出container中有多少个target

        public static int GetCount(string container, string target)
        {

            return Regex.Matches(container, target).Count;

        }
        //不使用string自带的Join()方法，定义一个mimicJoin()方法，能将若干字符串用指定的分隔符连接起来，
        //比如：mimicJoin("-","a","b","c","d")，其运行结果为：a-b-c-d
        public static string mimicJoin(string connector, string[] strings)
        {
            string result = "";
            for (int i = 0; i < strings.Length; i++)
            {
                result += strings[i].Insert(0, connector);
            }
            return result.Remove(0, 1);

        }

        // 声明一个方法GetWater()，该方法接受ProvideWater作为参数，
        //并能将ProvideWater的返回值输出
        public static int GetWater(ProvideWater Provider)
        {
            Person person = new Person();
            return Provider(person);
        }

        public static int AssignToDlg(Person person)
        {
            return person.weight--;
        }




        static void Main(string[] args)
        {
            //方法给委托赋值
            ProvideWater provideWater = new ProvideWater(AssignToDlg);
         
            //匿名方法给委托赋值
            ProvideWater provideWater2 = delegate (Person person)
            {
                return person.weight--;
            };
            // lambda表达式给委托赋值
            ProvideWater provideWater3 = p => p.weight--;

            Console.WriteLine(GetWater(provideWater3));

///////////////////////////////////////////////////////////////////////
            Appraise nice = new Appraise { Content = "你写的非常好" };

            Comment good = new Comment { Content = "很好" };
            Article idea = new Article { Title = "好的idea如何产生" };

            idea.Comment = new List<Comment> { good };
            good.Article = idea;

            //一个文章有多个关键字，一个关键字也可以对应多个文章

            Keyword java = new Keyword { Content = "java的应用" };
            Keyword c = new Keyword { Content = "c的应用" };
            Keyword css = new Keyword { Content = "css的应用" };
            Keyword jquery = new Keyword { Content = "jquery的应用" };

            Article it = new Article { Title = "it学习" };
            it.keywords = new List<Keyword> { java, c, css };
            idea.keywords = new List<Keyword> { jquery, css };
            //一个关键字也可以对应多个文章
            css.Articles = new List<Article> { it, idea };
            //Console.WriteLine(HomeWork<int>.BinarySeek(new System.Collections.Generic.List<int> { 1, 5, 76, 8, 9, 0, 43, 6, 3, 5 }, 0));

            ///字符串
            //Console.WriteLine(mimicJoin("-", new string[] {"众所周知", "飞哥", "的", "颜值","是","一百分" }));
            //Console.WriteLine(GetCount("13212*212-212", "212"));
            //Console.WriteLine(GetCount("111234512", "12"));
            //封装一个方法，可以修改Content的CreateTime和PublishTime
            //DateTime lw = new DateTime(2023, 3, 4);

            //Content article = new Content("文章");
            //article.GetType()
            //    .GetProperty("CreateTime", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(article, lw);
            //Console.WriteLine();





            //Console.WriteLine(Program.findPrimeNum(1, 10));

            //TokenManager tokenManager = new TokenManager();
            //User user = new User("lls", "1234");
            //Console.WriteLine(user.ToString());

            //Console.WriteLine(user);

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
