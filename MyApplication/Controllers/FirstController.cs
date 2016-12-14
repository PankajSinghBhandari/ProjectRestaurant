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
        //Branch1 change
        public ActionResult Index()
        {
            return View();

        }
    }
}