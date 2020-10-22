using System;
using System.Collections.Generic;
using System.Text;

namespace LZBC
{

    // 观察“一起帮”的：
    //注册/登录功能，定义一个User类，包含字段：Name（用户名）、Password（密码）和 邀请人（InvitedBy），和方法：Register()、Login()
    //求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、发布时间（PublishDateTime）和作者（Author），和方法Publish()
    //帮帮币版块，定义一个类HelpMoney，包含你认为应该包含的字段和方法
    class user
    {

        private string Name;
        private string Password;
        private string InvitedBy;

        public static bool Register(string InvitedBy, string InviteCode, string userName, string password, string verifyPassword, string authCode, out string output)
        {
            string dateInviteby = "1234", dateInviteCode = "4567", dateUserName = "老李", datePassword = "4936", dateAuthCode = "5200";


            if (dateInviteby == InvitedBy && dateInviteCode == InviteCode && dateUserName == userName && datePassword == password && dateAuthCode == authCode)
            {
                output = "恭喜你，注册成功";
                return true;
            }


            if (dateInviteby == InvitedBy)
            {

                if (InviteCode.Length == 0)
                {
                    output = "邀请码不能为空";
                    return false;

                }

                else if (InviteCode.Length != 4)
                {
                    output = "邀请码必须是4位数字";
                    return false;
                }

                else if (InviteCode != dateInviteCode)
                {
                    output = "邀请码错误";
                    return false;
                }

                else
                {

                    if (userName.Length == 0)
                    {
                        output = "用户名不能为空";
                        return false;
                    }
                    else if (userName.Length > 20)
                    {
                        output = "用户名的长度不能大于20";
                        return false;
                    }
                    else
                    {

                        if (password.Length == 0)
                        {
                            output = "密码不能为空";
                            return false;
                        }
                        else if (password.Length > 20 || password.Length < 4)
                        {
                            output = "密码的长度不能小于4，大于20";
                            return false;
                        }
                        else
                        {

                            if (Console.ReadLine().Length == 0)
                            {
                                output = "确认密码不能为空";
                                return false;
                            }
                            else if (Console.ReadLine() != password)
                            {
                                output = "确认密码和密码不一致";
                                return false;
                            }
                            else
                            {

                                if (Console.ReadLine().Length == 0)
                                {
                                    output = "验证码不能为空";
                                    return false;
                                }
                                else if (Console.ReadLine().Length != 4)
                                {
                                    output = "* 验证码的长度只能等于4";
                                    return false;
                                }
                                else if (Console.ReadLine() != authCode)
                                {
                                    output = "* 验证码错误，请重新输入";
                                    return false;
                                }
                                else
                                {
                                    output = "恭喜你，登录成功";
                                    return true;
                                }

                            }
                        }

                    }
                }

            }
            else
            {
                output = $"没有找到以{InvitedBy}开头的用户名";
                return false;
            }

        }



    }
}
