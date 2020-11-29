using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YiQiBang.Entities;

namespace YiQiBang.Repositories
{
    public class ArticleRepository
    {
        private static IList<Article> articles;
        public int ArticleCount { get; set; } = articles.Count;
        static ArticleRepository()
        {
            articles = new List<Article>() {

            new Article
            {
                Id = 1,
                Title = @"0异步方法和TPL： async / await / Parallel",
                Body = @"封装我们要把上面这个Task封装成方法，怎么办？最重要的一点，这个方法要能返回生成的random，后面的代码要用！public static Task<int> getRandom(){return Task<int>.Run(() =>{Thread.Sleep(500); //模拟耗时return new Random().Next();});}@想一想@：应该如何调用这个方法？",
                Author = new User
                {
                    Id = 10,
                    Name = @"马保国"
                },
                PublishTime = new DateTime(2020, 10, 2, 4, 35, 56),



            },
            new Article
            {
                Id = 2,
                Title = @"1面向对象：类和对象/封装/继承/多态/抽象接口/枚举/反射/String",
                Body = @"类和对象 类文件后缀：.java包（namespace）：项目上右键创建package _17bang.CD.Yz;引入（using）import _17bang.YZ.Student;没有partial类访问修饰符：没有关键字internal（不能显式声明，默认即可，package中可见）static：可以由对象调用（只warning不报错)引用类型和值类",
                Author = new User
                {
                    Id = 20,
                    Name = @"李大钊"
                },
                PublishTime = new DateTime(2019, 10, 3, 12, 35, 26)
            },
            new Article
            {
                Id = 3,
                Title = @"2分层架构：利弊分析和选择",
                Body = @"为什么需要分层？代码太多，需要组织：分层架构属于“纵向”组织。（组织代码/人手）题外话：为什么飞哥不看好“微服务”？本来就是“新瓶装老酒”（横向组织） 过犹不及 职责分离（单一职责），方便项目组织维护，甚至是重用。典型的就是目前流行的“前后端分离”：前端不需要懂C#/.NET/SQ没有partial类访问修饰符：没有关键字internal（不能显式声明，默认即可，package中可见）static：可以由对象调用（只warning不报错)引用类型和值类",
                Author = new User
                {
                    Id = 25,
                    Name = @"李智博"
                },
                PublishTime = new DateTime(2019, 11, 3, 12, 23, 26)
            },
             new Article
            {
                Id = 4,
                Title = @"3Action和ViewResult：ViewName/Model传值",
                Body = @"Controller中返回ActionResult的方法。一个Controller中可以有多个Action方法：重载的方法可以标记[HttpPost]/[HttpGet]等进行区分。但仅仅是[HttpPost]/[HttpGet]不能形成“重载”的效果（即不能用[HttpPost]/[HttpGet]等特性来区分方法）ViewResult 通过 return View() 返回，是最最常见的内容酒”（横向组织） 过犹不及 职责分离（单一职责），方便项目组织维护，甚至是重用。典型的就是目前流行的“前后端分离”：前端不需要懂C#/.NET/SQ没有partial类访问修饰符：没有关键字internal（不能显式声明，默认即可，package中可见）static：可以由对象调用（只warning不报错)引用类型和值类",
                Author = new User
                {
                    Id = 26,
                    Name = @"周丁浩"
                },
                PublishTime = new DateTime(2020, 11, 3, 12, 23, 26)
            },
             new Article
            {
                Id = 5,
                Title = @"4复杂查询：自定义SQL/存储过程",
                Body = @"继承的映射 只有当父类子类都需要被映射时，才会启动继承class MyContext : DbContext{public DbSet<Blog> Blogs { get; set; }public DbSet<RssBlog> RssBlogs。但仅仅是[HttpPost]/[HttpGet]不能形成“重载”的效果（即不能用[HttpPost]/[HttpGet]等特性来区分方法）ViewResult 通过 return View() 返回，是最最常见的内容酒”（横向组织） 过犹不及 职责分离（单一职责），方便项目组织维护，甚至是重用。典型的就是目前流行的“前后端分离”：前端不需要懂C#/.NET/SQ没有partial类访问修饰符：没有关键字internal（不能显式声明，默认即可，package中可见）static：可以由对象调用（只warning不报错)引用类型和值类",
                Author = new User
                {
                    Id = 27,
                    Name = @"特朗普"
                },
                PublishTime = new DateTime(2020, 12, 13, 12, 23, 26)
            },
              new Article
            {
                Id = 6,
                Title = @"5EF配置：关联关系和继承",
                Body = @"我们之前已经分别学习过：ER关系模型在对象（引用）和数据库（外键）上的表现形式。EF在构建Entity对象间关系时，采用了一种“混搭”的方式，引入了：影子属性比如每个Student都应该一个Classroom，就可以这样表示：public class Student : BaseEntity{//EF映射之后，blic DbSet<RssBlog> RssBlogs。但仅仅是[HttpPost]/[HttpGet]不能形成“重载”的效果（即不能用[HttpPost]/[HttpGet]等特性来区分方法）ViewResult 通过 return View() 返回，是最最常见的内容酒”（横向组织） 过犹不及 职责分离（单一职责），方便项目组织维护，甚至是重用。典型的就是目前流行的“前后端分离”：前端不需要懂C#/.NET/SQ没有partial类访问修饰符：没有关键字internal（不能显式声明，默认即可，package中可见）static：可以由对象调用（只warning不报错)引用类型和值类",
                Author = new User
                {
                    Id = 28,
                    Name = @"赵日天"
                },
                PublishTime = new DateTime(2019, 2, 13, 12, 2, 26)
            },
              new Article
            {
                Id = 7,
                Title = @"6C#进阶：Entity和Repository",
                Body = @"对象引用面向对象的世界里，万物皆对象。对象和对象之间的关系除了“继承”，就是“组合”（复习）。 这些关系通过对象的属性体现。比如：clablic DbSet<RssBlog> RssBlogs。但仅仅是[HttpPost]/[HttpGet]不能形成“重载”的效果（即不能用[HttpPost]/[HttpGet]等特性来区分方法）ViewResult 通过 return View() 返回，是最最常见的内容酒”（横向组织） 过犹不及 职责分离（单一职责），方便项目组织维护，甚至是重用。典型的就是目前流行的“前后端分离”：前端不需要懂C#/.NET/SQ没有partial类访问修饰符：没有关键字internal（不能显式声明，默认即可，package中可见）static：可以由对象调用（只warning不报错)引用类型和值类",
                Author = new User
                {
                    Id = 29,
                    Name = @"赵铁路"
                },
                PublishTime = new DateTime(2017, 2, 13, 12, 2, 26)
            },
              
        };
        }
        
        
 

        internal IList<Article> Get(int pageIndex, int pageSize)
        {
            return articles.Skip((pageIndex - 1) * pageSize)
                            .Take(pageSize)
                            .ToList();
        }

        public ArticleRepository()
        {

        }

        public Article find(int id)
        {


            return articles.Where(a => a.Id == id).SingleOrDefault();

        }
        void Delete()
        {

        }
        //int Save(Article article)
        //{
        //    articles.Add(article);
        //}
    }
}
