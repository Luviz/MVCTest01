using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTest01.Controllers {
	public class HomeController : Controller {
		public ActionResult Index() {
			return View();
		}

		public ActionResult About() {
			ViewBag.Message = "Your application description page.";
			return View();
		}

		public ActionResult Contact() {
			ViewBag.Message = "Your contact page.";
			return View();
		}

		public ActionResult hw() {
			ViewBag.Massage = "Hello World";
			return View();
		}

		public ActionResult ViwePage1() {
			ViewBag.Massage = "VP1";
			return View();
		}

		public ActionResult DivTest() {
			ViewBag.Massage = "Divs";
			return View();
		}
	}
}