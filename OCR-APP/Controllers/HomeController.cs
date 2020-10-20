using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using tessnet2;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;



namespace OCRAPP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // now add the following C# line in the code page  
            var image = new Bitmap("\\work\\Tesseract\\OCR-APP\\uber\\scan_1.tif");
            varocr = new Tesseract();
            ocr.Init("\\work\\Tesseract\\OCR-APP\\uber\\", "eng", false);
            var result = ocr.DoOCR(image,Rectangle.Empty);

            List<string> datamine = null;

            datamine = new List<string> { "asd", "zxc" };
            //foreach (tessnet2.Word word in result)
            //{

            //    datamine.Add(word.text);
               
            //}


            return View(datamine);
        }
    }
}
