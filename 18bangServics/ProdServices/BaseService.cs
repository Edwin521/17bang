using AutoMapper;
using BLL.Repositories;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _18bangServices.ProdServices
{
   public  class BaseService
    {
        public UserRepository UserRepository;
        private static MapperConfiguration mapper;
        public BaseService()
        {
            UserRepository = new UserRepository(dbContext);
        }
        public SqlDbContext dbContext
        {
            get
            {
                SqlDbContext context = HttpContext.Current.Items["dbContext"] as SqlDbContext;
                if (context == null)
                {
                    context = new SqlDbContext();
                    context.Database.BeginTransaction();
                    HttpContext.Current.Items["dbContext"] = context;
                }//else nothing;
                return context;
            }
        }

        protected IMapper Mapper { get => mapper.CreateMapper(); }
       
    }
}
