using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication14.Models;

namespace WebApplication14.Controllers
{
	public class HomeController : Controller
	{
        AEPDbContext db = new AEPDbContext();
		public ActionResult Index()
		{
            return View(db.SCORECARD_FACT.ToList());
        }

		public ActionResult Statistics()
		{
			ViewBag.Message = "Your application description page.";

            return View(db.SCORECARD_FACT.ToList());
        }

		public ActionResult Culture()
		{
			ViewBag.Message = "Your contact page.";
            
			return View(db.SCORECARD_FACT.ToList());
		}

		public ActionResult Safety()
		{
			ViewBag.Message = "Your contact page.";

            return View(db.SCORECARD_FACT.ToList());
        }
	}
}