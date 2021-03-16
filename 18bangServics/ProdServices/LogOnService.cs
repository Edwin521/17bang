using _18bangServices.ViewModel;
using BLL.Entities;
using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdServices
{
    public class LogOnService:BaseService
    {
        private UserRepository userRepository;
        public LogOnService()
        {
            userRepository = new UserRepository(Context);
        }
       
    }
}
