﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2WooxTravel.Areas.Admin.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Admin/Default
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript() { 
        
        return PartialView();
        }

        public PartialViewResult PartialNavbar() {
            return PartialView();
        
        }

        public PartialViewResult PartialBanner()
        {
            return PartialView();

        }

        public PartialViewResult PartialCountry()
        {
            return PartialView();

        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();

        }
    }
}