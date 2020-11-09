﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LZBC
{

    // 观察“一起帮”的：
    //注册/登录功能，定义一个User类，包含字段：Name（用户名）、Password（密码）和 邀请人（InvitedBy），和方法：Register()、Login()
    //求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、发布时间（PublishDateTime）和作者（Author），和方法Publish()
    //帮帮币版块，定义一个类HelpMoney，包含你认为应该包含的字段和方法


    //每一个User对象一定有Name和Password赋值


    //让User类无法被继承
    sealed public class User : Entity, ISendMessage, IChat
    {
        //User类中添加一个Tokens属性，类型为TokenManager
        public TokenManager Tokens { get; set; }
        //设计一个适用的机制，能确保用户（User）的昵称（Name）不能含有admin、17bang、管理员等敏感词
        //??是不是得专门有个类来装这些敏感词汇，当敏感词较多的时候就得用，较少的时候可以不用吧。
        private string _name;
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Contains("admin")||value.Contains("17bang")||value.Contains("管理员"))
                {
                    Console.WriteLine("请您不要输入带有特殊意义的敏感字符");
                }
                else
                {
                   _name=value;
                }

            }
        }

        private string _password;



        public string Password
        {
            set { _password = value; } //user.Password在类的外部只能改不能读
            //get { return _password; }
        }


        public User _InvitedBy { get; set; }
        public string _InviteCode { get; set; }

        public int HelpMoney { get; set; }
        public int HelpDot { get; set; }
        public int HelpBean { get; set; }

        private User()
        {

        }
        public User(string name, string password)//每一个User对象一定有Name和Password赋值
        {
            _name = name;
            _password = password;
        }
        public string Name
        {
            set       //如果user.Name为“admin”，输入时修改为“系统管理员”
            {
                if (value == "admin")
                {
                    _name = "系统管理员";

                }
                else
                {
                    _name = value;
                }
            }
            get
            {
                return _name;
            }
        }

        //public void Register(User user)
        //{
        //    if (user._Name == "lzb")
        //    {
        //        return true;
        //    }
        //    if (user._InvitedBy._Name == "lls")
        //    {

        //    }
        //}

        //public  void login()
        //{

        //}


        void ISendMessage.Send(User receiver) { }
        void IChat.Send(User receiver) { }




    }
}
