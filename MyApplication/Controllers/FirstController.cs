using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyApplication.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        // Starting my first controller work
        public ActionResult Index()
        {
            return View();

        }
    }
}