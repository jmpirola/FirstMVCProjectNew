using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCProject.Controllers
{
    public class FirstMVCController : Controller
    {
        // GET: FirstMVC
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SayHello()
        {
            return View("HelloView");
        }
    }
}    