using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JFine.Web.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Error(string number, string title, string message)
        {
            ViewBag.number = number;
            ViewBag.title = title;
            ViewBag.message = message;
            return View();
        }

    }
}