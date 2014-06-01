using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TorteNS.Controllers
{
    public class CalendarController : Controller
    {
        //
        // GET: /Calendar/
        public ActionResult Index()
        {
			ViewBag.Title = "Celendar";
            return View();
        }
	}
}