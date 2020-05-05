using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AntiForgeryTokenWithMultipartForm.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Test()
        {
            Request.Files[0].SaveAs("C:/repos/file.file");
            
            return Json(new Test() { Age = "age", Name = 123 });
        }
    }

    public class Test
    {
        public Int32 Name { set; get; }

        public String Age { set; get; }
    }

    public class TestRequest
    {
        
    }
}