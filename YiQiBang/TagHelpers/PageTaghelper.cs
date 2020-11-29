using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YiQiBang.TagHelpers
{
    [HtmlTargetElement("datetime",Attributes=INDEX+","+PATH)]
   
    public class PageTagHelper:TagHelper
    {
        public const string INDEX = "index";
        public const string PATH = "path";
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "small";//指定最后输出的

            object pageIndex = context.AllAttributes[INDEX].Value;//取index的值
            output.Attributes.Remove(context.AllAttributes[INDEX]);

            object path = context.AllAttributes[PATH].Value;  //取path的值
            output.Attributes.Remove(context.AllAttributes[PATH]);

            output.Attributes.Add("href", $"{path}/page-{ pageIndex}");
            base.Process(context,output);
        }





    }
}
