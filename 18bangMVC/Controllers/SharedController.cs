using _18bangMVC.Helper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _18bangMVC.Controllers
{
    public class SharedController:Controller
    {

        public ActionResult GetCaptcha()
        {

            Bitmap image = new Bitmap(100, 30);
            Graphics drawing = Graphics.FromImage(image);
            drawing.Clear(Color.White);
            Random random = new Random();

            image = CaptchHelper.captchaBackGroundPixel(image, random);
            drawing = CaptchHelper.captchaBackgroundDrawing(drawing, random);
            CaptchHelper.captchaMaker(random, drawing, image);

            MemoryStream stream = new MemoryStream();
            image.Save(stream, ImageFormat.Jpeg);   
            return File(stream.ToArray(), "image/jpg");
        }

    }
}