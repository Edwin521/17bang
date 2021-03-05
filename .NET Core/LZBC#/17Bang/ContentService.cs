using System;
using System.Collections.Generic;
using System.Text;

namespace LZBC
{
    //在ContentService中捕获异常
    //如果是“参数为空”异常，Console.WriteLine() 输出：内容的作者不能为空，将当前异常封装进新异常的InnerException，再将新异常抛出
    //如果是“”参数越界”异常，Console.WriteLine() 输出：求助的Reward为负数（-XX），不再抛出异常

    public class ContentService
    {

        public void Publish(Content content)
        {
            try
            {
                content.Publish();
                Console.WriteLine("存入数据库");
            }
            catch (ArgumentNullException )
            {

                Console.WriteLine("内容的作者不能为空");
                //throw new Exception("内容的作者不能为空",a)   //当前异常封装进新异常的InnerException，再将新异常抛出
            }
            catch (ArgumentOutOfRangeException )
            {
                Console.WriteLine("求助的Reward为负数");
            }
            catch (Exception e)
            {
                Console.WriteLine("发现一个异常："+e.Message.ToString());//捕获一切异常，并记录异常的消息和堆栈信息
                throw;
            }
            finally
            {
                Console.WriteLine(DateTime.Now.ToString("yyyy年MM月dd日hh时mm分ss秒"));
                Console.WriteLine("关闭文件流");
            }


        }

    }
}
