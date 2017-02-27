using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace WebHelpers.Controllers
{
    public class WebImageTestController : Controller
    {
        private string ImagePath
        {
            get
            {
                return Server.MapPath("~/Content/img1.jpg");
            }
        }

        // GET: WebImageTest
        public ActionResult Index()
        {

            return View();
        }

        public void DisplayImage()
        {
            WebImage img = new WebImage(ImagePath);
            //Rotate image
            //img.RotateLeft();
            //img.RotateRight();

            //Flip image
            //img.FlipHorizontal();
            //img.FlipVertical();

            //Resize image
            //img.Resize(100, 100, preserveAspectRatio: true);

            //Add Text Watermark
            //img.AddTextWatermark("Test", fontColor: "White", fontSize: 20, horizontalAlign: "Center", verticalAlign: "Top", opacity: 50);

            img.AddImageWatermark(Server.MapPath("~/Content/img2.jpg"), opacity: 50, width: 400, height: 350);
            img.Write();
        }
    }
}