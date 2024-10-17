using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2WooxTravel.Controllers
{
    public class ErrorPagesController : Controller
    {
        // GET: ErrorPages
        public ActionResult Pages404()
        {
            return View();
        }
    }
}