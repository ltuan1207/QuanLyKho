using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyKho.Controllers
{
    public class DasboardController : Controller
    {
        // GET: Dasboard
        public ActionResult Index()
        {
            return View();
        }
    }
}