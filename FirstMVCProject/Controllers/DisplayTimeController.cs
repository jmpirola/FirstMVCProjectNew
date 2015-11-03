﻿    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCProject.Controllers
{
    public class DisplayTimeController : Controller
    {
        // GET: DisplayTime
        public ActionResult Index()
        {
            ViewData["CurrentTime"] = DateTime.Now.ToString();
            return View("DisplayTimeView");
        }
    }
}