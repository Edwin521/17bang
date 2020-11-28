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
        static ArticleRepository()
        {
            articles = new List<Article>() {

            new Article
            {
                Id = 1,
                Title = @"异步方法和TPL： async / await / Parallel",
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
                Title = @"面向对象：类和对象/封装/继承/多态/抽象接口/枚举/反射/String",
                Body = @"类和对象 类文件后缀：.java包（namespace）：项目上右键创建package _17bang.CD.Yz;引入（using）import _17bang.YZ.Student;没有partial类访问修饰符：没有关键字internal（不能显式声明，默认即可，package中可见）static：可以由对象调用（只warning不报错)引用类型和值类",
                Author = new User
                {
                    Id = 20,
                    Name = @"李大钊"
                },
                PublishTime = new DateTime(2019, 10, 3, 12, 35, 26)
            }
        };
        }

        internal IList<Article> Get(int ID)
        {
            return articles;
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
