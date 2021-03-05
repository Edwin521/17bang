using _18bangMVC.Models;
using BLL.Entities;
using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18bangServices.ProdServices
{
    public class RegisterService : BaseService
    {
        private UserRepository userRepository;
        public RegisterService()
        {
            userRepository = new UserRepository(dbContext);
        }
        public RegisterModel GetByName(string name)
        {
            User userInfo = userRepository.GetByName(name);
            return Mapper.Map<RegisterModel>(userInfo);
        }

        public int Add(RegisterModel user)
        {
            User newUser = Mapper
                 .Map<User>(user);
            BMoney award = new BMoney();
            award = award.RegisterAwardBMoney();

            newUser.Inviter = UserRepository.GetByName(user.InviterName);
            newUser = newUser.Register(newUser, award);
            int userId = UserRepository.AddRegisterToDb(newUser);
            return userId;
            ///给邀请人奖励
            




        }
    }
}
