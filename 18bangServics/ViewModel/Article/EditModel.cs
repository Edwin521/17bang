using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18bangServices.ViewModel.Article
{
    public class EditModel
    {
        [Required(ErrorMessage = "标题不能为空")]
        public string Title { get; set; }

        [Required(ErrorMessage = "正文不能为空")]
        [StringLength(21474782, MinimumLength = 2, ErrorMessage = " 正文的长度不能小于2，大于21474782")]
        public string Body { get; set; }
    }
}
