using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestFramework.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "欢迎访问，大家好!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
