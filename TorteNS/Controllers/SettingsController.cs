using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TorteNS.Controllers
{
    public class SettingsController : Controller
    {
        public ActionResult Index()
        {
			ViewBag.Title = "Settings";
            return View();
        }
	}
}