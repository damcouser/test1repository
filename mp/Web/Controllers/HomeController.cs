using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
	public class HomeController : Controller
	{
		[Route]
		public ActionResult Index()
		{
			return View();
		}
        public void set() {
            // for u mr suhail saab ji . please update after getting this.
        }
	}
}