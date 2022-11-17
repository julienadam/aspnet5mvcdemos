using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomImageResultDemo.Plumbing;

namespace CustomImageResultDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DisplayTime()
        {
            Bitmap bmp = new Bitmap(200, 50);
            Graphics g = Graphics.FromImage(bmp);

            g.FillRectangle(Brushes.White, 0, 0, 200, 50);
            g.DrawString(DateTime.Now.ToShortTimeString(), new Font("Arial", 32), Brushes.Red, new PointF(0, 0));

            return new ImageResult { Image = bmp, ImageFormat = ImageFormat.Jpeg };
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}