using System;
using System.Collections.Generic;
using System.Text;

namespace LZBC
{
    //帮帮币版块，定义一个类HelpMoney，表示一行帮帮币交易数据，包含你认为应该包含的字段和方法
    //将之前User/Problem/HelpMoney类的字段封装成属性，其中：
    //user.Password在类的外部只能改不能读
    
    //problem.Reward不能为负数
    //调用这些类的有参/无参构造函数，生成这些类的对象，调用他们的方法 
    //一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写。设计一种方式，保证：
    //每一个Problem对象一定有Body赋值
    //每一个User对象一定有Name和Password赋值
    public class helpMoneny
    {
        private DateTime time { get; set; }
        private int useable { get; set; }
        private int freeza { get; set; }
        private string kind { get; set; }
        private int change { get; set; }
        private string notes { get; set; }




        public void gain(int num)
        {

        }
        public void freeze(int num)
        {

        }
    }
}
