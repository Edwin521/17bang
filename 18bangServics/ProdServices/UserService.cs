using _18bangMVC.Models;
using _18bangServices.ViewModel;
using BLL.Entities;
using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Global;
using _18bangServices.ViewModel.Log;

namespace ProdServices
{

    public class UserService : BaseService
    {
      
       
        #region 由于使用了严格的per view per model,有两个方法为了适应不同的model返回值
        public RegisterModel RGetByName(string name)
        {
            User userInfo = userRepository.GetByName(name);
            RegisterModel model = mapper.Map<RegisterModel>(userInfo);
            return model;
        }
        public OnModel OGetByName(string UserName)
        {
            User userInfo = userRepository.GetByName(UserName);
            OnModel model = mapper.Map<OnModel>(userInfo);
            return model;
        }
        #endregion


        public UserModel GetByName(string name) {
            User userInfo = userRepository.GetByName(name);
            UserModel model= mapper.Map<UserModel>(userInfo);
            return model;
        }


        public int Register(RegisterModel model)
        {
            User user = mapper.Map<User>(model);
            BMoney bMoney = new BMoney();
            user.Register(bMoney);

            user.Inviter = userRepository.GetByName(model.InviterName);
            user = user.Register(bMoney);
            int UserId = userRepository.Save(user);


            ///给邀请人奖励
            BMoneyRepository bMoneyRepository = new BMoneyRepository(Context);
            BMoney money = new BMoney();
            money = money.GiveInviterPrize(bMoneyRepository.GetBMoneyByAuthor(user.InviterId));
            bMoneyRepository.Save(money);

            return user.Id;
        }



    }
}
