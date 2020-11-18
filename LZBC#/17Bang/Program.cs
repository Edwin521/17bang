using LZBC;
using System;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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
            DLinkNode dLinkNode1 = new DLinkNode();
            DLinkNode dLinkNode2 = new DLinkNode();
            DLinkNode dLinkNode3 = new DLinkNode();
            DLinkNode dLinkNode4 = new DLinkNode();
            dLinkNode1.AddAfter(dLinkNode2);
            dLinkNode2.AddAfter(dLinkNode3);
            dLinkNode3.AddAfter(dLinkNode4);
            
            foreach (DLinkNode item in dLinkNode1)
            {
                Console.WriteLine(item);
            }


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
            ///构建文章，评论，评价，关键字的关系。
            User lzb = new User("李智博", "5210");
            User xy = new User("小鱼", "8888");
            User fg = new User("飞哥", "4399");
            IEnumerable<User> users = new List<User> { lzb, xy, fg };



            Comment comment1 = new Comment { main = "你写的真不错" };
            Comment comment2 = new Comment { main = "你的文笔真不错" };
            Comment comment3 = new Comment { main = "写的不是很好，不符合我的价值观" };
            Comment comment4 = new Comment { main = "写的不错，给你100分" };
            Comment comment5 = new Comment { main = "你是我见过写的最差的" };
            Comment comment6 = new Comment { main = "写的不是很符合我的逻辑，感觉很凌乱，继续加油哦" };
            IEnumerable<Comment> Comments = new List<Comment> { comment1, comment2, comment3 };

            Keyword<Article> java = new Keyword<Article> { Word = "java的应用" };
            Keyword<Article> c = new Keyword<Article> { Word = "c应用" };
            Keyword<Article> css = new Keyword<Article> { Word = "css的应用" };
            Keyword<Article> jquery = new Keyword<Article> { Word = "jquery的应用" };
            Keyword<Article> it = new Keyword<Article> { Word = "编程语言" };
            Keyword<Article> csharp = new Keyword<Article> { Word = "编程语言之csharp" };
            Keyword<Article> net = new Keyword<Article> { Word = "编程世界之-.net" };
            IEnumerable<Keyword<Article>> keywords = new List<Keyword<Article>> { java, c, css, jquery, it };

            Article Article1 = new Article()
            {
                Title = "it学习入门",
                Main = "it入门需要做些什么准备呢，咱们。。。",
                Author = fg,
                PublishTime = new DateTime(2020, 10, 1),
                keywords = new List<Keyword<Article>> { it, csharp },
                Comment = new List<Comment> { comment3 }

            };



            Article Article2 = new Article
            {
                Title = "高效的学习效率",
                Main = "怎样提高我们的学习效率呢。。。",
                Author = fg,
                PublishTime = new DateTime(2019, 10, 1),
                keywords = new List<Keyword<Article>>() { it, java, c },
                Comment = new List<Comment> { comment4 }
            };
            Article Article3 = new Article
            {
                Title = "怎样选择编程语言",
                Main = "编程语言需要结合。。。。",
                Author = fg,
                PublishTime = new DateTime(2019, 6, 1),
                keywords = new List<Keyword<Article>>() { it },
                Comment = new List<Comment>() { comment5 }
            };
            Article article4 = new Article
            {
                Title = "编程语言的魅力",
                Author = xy,
                keywords = new List<Keyword<Article>>() { it, css, jquery },
                Comment = new List<Comment>() { comment1, comment2 },
                PublishTime = new DateTime(2020, 11, 1)

            };
            IEnumerable<Article> Articles = new List<Article> { Article1, Article2, Article3, article4 };

            Problem problem1 = new Problem
            {
                Author = lzb,
                Reward = 13,
                PublishTime = new DateTime(2020, 1, 20),
                Main = "求助大佬关于c#委托方面的知识",
                Title = "c#方面的求助",
                comments = new List<Comment> { comment1, comment2 },
          
                
            };

            IEnumerable<Problem> problems = new List<Problem> { problem1 };


            //文章文章添加评价
            Appraise appraise1 = new Appraise { Voter = lzb };
            appraise1.Agree();
            Article1.appraises.Add(appraise1);

            Appraise appraise2 = new Appraise { Voter = xy };
            appraise2.Disagree();
            Article1.appraises.Add(appraise2);


            //一个文章有多个关键字
            Article1.keywords = new List<Keyword<Article>> { java, c, css };
            Article2.keywords = new List<Keyword<Article>> { jquery, css };

            //一个关键字也可以对应多个文章
            it.Articles = new List<Article> { Article1, Article2, Article3 };
            //文章可以有多个评论
            Article1.Comment = new List<Comment> { comment1, comment2 };
            //每个评论必须有一个对应的文章
            comment3.Article = Article3;


            ////每篇文章都对应着它的作者

            Article1.Author = fg;
            Article2.Author = fg;
            Article3.Author = fg;
            article4.Author = xy;


            ContentService kk = new ContentService();
            kk.Publish(Article1);
            Console.WriteLine(Article1.PublishTime);

            //在之前“文章 / 评价 / 评论 / 用户 / 关键字”对象模型的基础上，添加相应的数据，然后完成以下操作：

            //用linq方法改写以前的表达式

            //找出“飞哥”发布的文章
            var Find_dfg = Articles.Where(a => a.Author == fg);
            //找出2019年1月1日以后“小鱼”发布的文章
            var Find_xy = Articles.Where(a => a.Author == xy && a.PublishTime > new DateTime(2019, 1, 1));
            //按发布时间升序 / 降序排列显示文章
            var Ascd = Articles.OrderBy(a => a.PublishTime);
            var Desc = Articles.OrderByDescending(a => a.PublishTime);


            //统计每个用户各发布了多少篇文章
            var Fg_article = Articles.Where(a => a.Author == fg).GroupBy(a => a.Author);
            var Xy_article = Articles.Where(a => a.Author == xy).GroupBy(a => a.Author);
            //找出包含关键字“C#”或“NET”的文章
            var Csharp_kw = Articles.Where(a => a.keywords.Any(k => k.Word == "c#"));
            var Net_kw = Articles.Where(a => a.keywords.Any(k => k.Word == ".NET"));

            //找出评论数量最多的文章
            var Article_Comment_Max = Articles.OrderByDescending(a => a.Comment.Count()).First();

            //找出每个作者评论数最多的文章
            var Fg_Comment_Max = Articles.Where(a => a.Author == fg).OrderByDescending(a => a.Comment.Count()).First();
            var Xy_Comment_Max = Articles.Where(a => a.Author == xy).OrderByDescending(a => a.Comment.Count()).First();

            //找出每个作者最近发布的文章
            var Fg_Article_Rec = Articles.Where(a => a.Author == fg).OrderByDescending(a => a.PublishTime).First();
            var Xy_Article_Rce = Articles.Where(a => a.Author == xy).OrderByDescending(a => a.PublishTime).First();


            //找出每一篇求助的悬赏都大于5个帮帮币的求助作者
            var resualt = problems.Where(p => p.Reward > 5).GroupBy(p => p.Author);


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
