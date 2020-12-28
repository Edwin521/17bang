using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _18bangMVC.Models
{
    public class PlanModel
    {
        public string Title { get; set; }
        public string Explain { get; set; }//详细说明
        public string Tag { get; set; }
        public DateTime Start { get; set; }//开始执行时间
        public DateTime End { get; set; }//目标结束时间
        public IList<DayOfWeek> SubmitWorkTime { get; set; }
        public int HavaRest { get; set; }//可请假几天
        public string Prove { get; set; }
        public string AccessibleUrl { get; set; }
        public int NicePeople { get; set; }
        public int Penalty { get; set; }//罚金
        public bool Continue { get; set; }//继续
    }
    public class SubmitWorkTime
    {
        public bool Selected { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
    }
}