using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Problem : BaseEntity
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public bool NeedRemoteHelp { get; set; }
        public int RewardMoney { get; set; }
        public ProblemStatus Status { get; set; }
        public User HelpFrom { get; set; }
        public DateTime PublishTime { get; set; }
        public User Author { get; set; }
        public IList<Keyword> OwnkeyWords { get; set; }
        public void Publish(int rewardMoney )
        {
            this.PublishTime = DateTime.Now;
            this.RewardMoney = rewardMoney;
            this.Status = ProblemStatus.assist;
        }
    }

    public enum ProblemStatus
    {
        [Display(Name = "已撤销")]
        cancelled,
        [Display(Name = "已酬谢")]
        Rewarded,
        [Display(Name = "协助中")]
        inprocess,
        [Display(Name = "待协助")]
        assist
    }
}
