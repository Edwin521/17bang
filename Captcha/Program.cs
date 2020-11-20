using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Captcha
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Bitmap image = new Bitmap(200, 80);  //生成一个像素图“画板”
           
            
            Graphics g = Graphics.FromImage(image);    //在画板的基础上生成一个绘图对象
            g.Clear(Color.AliceBlue);           //添加底色

            g.DrawLine(new Pen(Color.BurlyWood), new Point(0, 0), new Point(200, 700)); //画直线
            g.DrawLine(new Pen(Color.Blue), new Point(0, 0), new Point(200, 40)); //画直线
            g.DrawString("A84h",       //绘制字符串
                new Font("英雄黑体", 55),                //指定字体
                new SolidBrush(Color.BurlyWood),      //绘制时使用的刷子
                new PointF(1, 0)                    //左上角定位
            );

            Random num1 = new Random();
            Random num2 = new Random();
           
            for (int i = 0; i < 80; i++)
            {
              
                image.SetPixel(num1.Next(200-i), num2.Next(80-i), Color.Black);  //绘制一个像素的点
            }

            image.SetResolution(72,92 );
         

            image.Save(@"D:hello.jpg", ImageFormat.Jpeg);   //保存到文件

        }
    }
}
