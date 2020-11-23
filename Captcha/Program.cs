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
            ///每次都是随机的底色，随机的线条，线条的颜色也是随机的
            Random random1 = new Random();//rgb  透明度，r,g,b 三个参数
            Random random2 = new Random();
            Random random3 = new Random();
            Random random4 = new Random();
            Graphics g = Graphics.FromImage(image);    //在画板的基础上生成一个绘图对象
            g.Clear(Color.FromArgb(random1.Next(50),random2.Next(200),random3.Next(200),random4.Next(200)));           //添加底色
            for (int i = 0; i < 20; i++)
            {
                g.DrawLine(new Pen(Color.FromArgb(random1.Next(50-i), random2.Next(200-i), random3.Next(200-i), random4.Next(200-i))),
              new Point(0, 0), new Point(random1.Next(200), random2.Next(700))); //画直线
            }
          
           
          
            string usable =  "1234567890abcdefghrjklmnopqrstuvwxyzABCDEFGHRJKLMNOPQRSTUVWXYZ" ;
            Random random = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                int index = random.Next(usable.Length);
                sb.Append(usable[index]);
            }
            string captch = sb.ToString();
            g.DrawString( captch,       //绘制字符串
                new Font("Tahoma", 55),                //指定字体
                new SolidBrush(Color.BurlyWood),      //绘制时使用的刷子
                new PointF(1, 0)                    //左上角定位
            );

            Random num_x = new Random();
            Random num_y = new Random();
           //绘制像素点
            for (int i = 0; i < 80; i++)
            {
              
                image.SetPixel(num_x.Next(200-i), num_y.Next(80-i), Color.Black);  
            }

            image.SetResolution(72,92 );
         

            image.Save(@"D:hello.jpg", ImageFormat.Jpeg);   //保存到文件

        }
    }
}
