﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication14.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Statistics()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Culture()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult Safety()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}