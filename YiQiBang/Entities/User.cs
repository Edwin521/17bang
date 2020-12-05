using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YiQiBang.Entities
{
    public class User : Entity
    {
        
        [Required(ErrorMessage ="*用户名不能为空")]
        public string Name { get; set; }
    

        public string Introduction { get; set; }
        [Required(ErrorMessage = "*密码不能为空")]
        [StringLength(20,MinimumLength =4,ErrorMessage ="*密码的长度不能小鱼4，大于20")]
        public string Password { get; set; }
        public bool? IsMale { get; set; }
        [Required(ErrorMessage = "*邀请人不能为空")]

        public User InvitedBy { get; set; }
        [Required(ErrorMessage = "*邀请码不能为空")]
        [StringLength(4,MinimumLength =4,ErrorMessage ="*邀请码只能是4位数字")]
        public string InviteCode { get; set; }
    
        public int HelpMoney { get; set; }
        public int HelpDot { get; set; }
        public int HelpBean { get; set; }
        public void Register()
        {
            InvitedBy.HelpBean += 10;
        }

    }
}
