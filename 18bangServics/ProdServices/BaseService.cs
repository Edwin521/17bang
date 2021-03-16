using BLL.Repositories;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Global;
using BLL.Entities;
using System.Data.Entity;
using AutoMapper;
using VM = _18bangServices.ViewModel;


namespace ProdServices
{
    public class BaseService
    {
        protected UserRepository userRepository;
        #region map映射

        protected readonly static MapperConfiguration config;
        static BaseService()
        {
            config = new MapperConfiguration(
                cfg =>
                {
                    cfg.CreateMap<Article, VM.Article.SingleModel>().ReverseMap();
                    cfg.CreateMap<Article, VM.Article.NewModel>().ReverseMap();
                    cfg.CreateMap<Article, VM.Article.ArticleIndexModel>().ReverseMap();
                    cfg.CreateMap<Article, VM.ArticleItemModel>().ReverseMap();
                    cfg.CreateMap<Article, VM.Article.EditModel>().ReverseMap();

                    cfg.CreateMap<User, VM.Log.OnModel>().ReverseMap();

                    cfg.CreateMap<Keyword, VM.Keyword.KeywordModel>().ReverseMap();

                    cfg.CreateMap<BMoney, VM.SaleModel>().ReverseMap();

                    cfg.CreateMap<User, VM.RegisterModel>().ReverseMap();

                    cfg.CreateMap<User, VM.Password.ForgetModel>().ReverseMap();
                    cfg.CreateMap<User, VM.Password.ChangeModel>().ReverseMap();

                });
        }
        protected IMapper mapper
        {
            get { return config.CreateMapper(); }
        }

        #endregion
        public BaseService()
        {
            userRepository = new UserRepository(Context);
        }





        ///1,顺利拿到cookie
        ///2，拿不到cookie
        ///2.1 没有这个cookie
        ///2.2 有这个cookie，但是验证通不过
        public int? CurrentUserId
        {
            get
            {
                HttpCookie cookie = HttpContext.Current.Request.Cookies[Keys.Name];
                if (cookie == null)
                {
                    return null;
                }
                string id = cookie.Values[Keys.Id];
                string pwd = cookie.Values[Keys.Password];

                User current = userRepository.Find(Convert.ToInt32(id));

                if (current.Password != pwd)
                {
                    throw new ArgumentException("信息有问题,我们已经记录在案");
                }
                return Convert.ToInt32(id);
            }
        }
        public User CurrenUser
        {
            get => userRepository.Find(CurrentUserId.Value);
        }


        protected SqlDbContext Context
        {
            get
            {

                //if (HttpContext.Current.Items[Keys.DbContext] == null)
                //{
                //    SqlDbContext cx = new SqlDbContext();
                //    cx.Database.BeginTransaction();
                //    HttpContext.Current.Items[Keys.DbContext] = cx;

                //}//else nothing;
                //return (SqlDbContext)HttpContext.Current.Items[Keys.DbContext];
                SqlDbContext context = HttpContext.Current.Items[Keys.DbContext] as SqlDbContext;
                if (context==null)
                {
                    context = new SqlDbContext();
                    context.Database.BeginTransaction();
                    HttpContext.Current.Items[Keys.DbContext] = context;
                }//else nothing
                return context;



            }
        }
        private static SqlDbContext getContextFromHttp()
        {
            object objContext = HttpContext.Current.Items[Keys.DbContext];
            HttpContext.Current.Items.Remove(Keys.DbContext);
            return objContext as SqlDbContext;
        }
        public static void Commit()
        {
            SqlDbContext context = getContextFromHttp();
            if (context != null)
            {
                using (context)
                {
                    using (DbContextTransaction transaction = context.Database.CurrentTransaction)
                    {
                        transaction.Commit();//transaction进行数据库的提交如果失败，它会自动回滚。
                    }
                }
            }
        }
        public static void RollBack()
        {
            SqlDbContext context = getContextFromHttp();
            if (context != null)
            {
                using (context)
                {
                    using (DbContextTransaction transaction = context.Database.CurrentTransaction)
                    {
                        transaction.Rollback();
                    }
                }
            }
        }
        public void ClearContext()
        {
            HttpContext.Current.Items["dbContext"] = null;
        }
    }
}
