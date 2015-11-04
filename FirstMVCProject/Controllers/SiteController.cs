using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCProject.Controllers
{
    
        // GET: Site
        public class SiteController : Controller
        {
            //
            // GET: /Site/

            public ActionResult GotoHome()
            {
                return View("Home");
            }

            public ActionResult AboutUs()
            {
                return View("About");
            }

            public ActionResult SeeProduct()
            {
                return View("Product");
            }
        }
    
}