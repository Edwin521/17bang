using System;
using System.ComponentModel;
using System.Reflection;

namespace YiQiBang.Pages.Message
{
    public class MessageMine
    {

        public int Id { set; get; }
        public DateTime PublishTime { set; get; }
        public MessageStatus Status { set; get; }
 
        public string Content { set; get; }
        public bool HasRead { set; get; }
        public bool HasCheck { set; get; }
    }


    public enum MessageStatus
    {
        [Description("留言")]
        LeaveWords,
        [Description("邀请")]
        Invite,
        [Description("自动关注")]
        AutoFollow,
        [Description("有新应答")]
        HaveNewResponse,
        [Description("邀请帮忙")]
        InviteHelp,
        [Description("协助开始")]
        HelpStart,
        [Description("自动撤销")]
        AutoRevocation,
        [Description("酬谢")]
        Thanks,
        [Description("有新评论")]
        HaveNewComment,
        [Description("被点赞")]
        ByDissagree,
        [Description("被查看")]
        ByWatch,
        [Description("作业")]
        Homework,
        [Description("目标")]
        Target,
        [Description("奖励")]
        Reward,
        [Description("有打赏")]
        HaveReward,
        [Description("有新回复")]
        HaveReply,
        [Description("设为精选")]
        SetSelection,
        [Description("掉落")]
        Fall,
        [Description("被人捡走")]
        SomeOnePickUp,
        [Description("交易")]
        Deal,
        [Description("捐赠")]
        Donate,
        [Description("刷新")]
        Refresh,
        [Description("通知")]
        Inform,

    }


    public static class EnumExtension
    {
        public static string GetDescription<T>(this T status)
        {
            Type enumType = typeof(T);
            FieldInfo enumFieldInfo = enumType.GetField(status.ToString());
            DescriptionAttribute attribute = (DescriptionAttribute)
                DescriptionAttribute.GetCustomAttribute(enumFieldInfo, typeof(DescriptionAttribute));

            return attribute.Description;
        }
    }

}