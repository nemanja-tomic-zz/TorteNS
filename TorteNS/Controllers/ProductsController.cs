using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TorteNS.Controllers
{
    public class ProductsController : Controller
    {
        
        public ActionResult Index()
        {
			ViewBag.Title = "Products";
            return View();
        }
	}
}