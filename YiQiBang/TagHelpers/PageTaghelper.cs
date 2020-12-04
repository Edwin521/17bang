using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YiQiBang.TagHelpers
{
    [HtmlTargetElement("datetime", Attributes = "index,path,asp-showicon,+asp-only")]

    public class PageTagHelper:TagHelper
    {
        public const string INDEX = "index";
        public const string PATH = "path";
        public const string ASP_SHOWICON = "asp-showicon";
        public const string ASP_ONLY = "asp-only";

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "small";//指定最后输出的

            object pageIndex = context.AllAttributes[INDEX].Value;//取index的值
            output.Attributes.Remove(context.AllAttributes[INDEX]);

            object path = context.AllAttributes[PATH].Value;  //取path的值
            output.Attributes.Remove(context.AllAttributes[PATH]);


            Object asp_Showicon = context.AllAttributes[ASP_SHOWICON].Value;//取出asp-showicon的值
            if (Convert.ToBoolean(asp_Showicon))
            {
                output.Content.AppendHtml("<span class='glyphicon glyphicon - calendar'></span>");
            }//else nothing

            object asp_Only = context.AllAttributes[ASP_ONLY].Value;//取出asp-only的值
            if (asp_Only.ToString() == "date")
            {
                output.Content.AppendHtml(DateTime.Now.ToString("yyyy年MM月dd日"));
            }//else nothing
            output.Attributes.Add("href", $"{path}/page-{ pageIndex}");
            base.Process(context, output);



        }





    }
}
