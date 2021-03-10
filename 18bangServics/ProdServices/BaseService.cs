using BLL.Repositories;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ProdServices
{
   public  class BaseService
    {
        private UserRepository userRepository;
        public BaseService() {
            userRepository = new UserRepository(dbContext);
        }

        public SqlDbContext dbContext
        {                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
            get
            {
                SqlDbContext context = HttpContext.Current.Items["dbContext"] as SqlContext;
                if (context == null)
                {
                    context = new SqlDbContext();  
                    context.Database.BeginTransaction();
                    HttpContext.Current.Items["dbContext"] = context;
                }//else nothing;
                return context;
            }

        }
    }
}
