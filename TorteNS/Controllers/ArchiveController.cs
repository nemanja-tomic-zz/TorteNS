using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TorteNS.Controllers
{
    public class ArchiveController : Controller
    {
        //
        // GET: /Archive/
        public ActionResult Index()
        {
			ViewBag.Title = "Archive";
            return View();
        }
	}
}