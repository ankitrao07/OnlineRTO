using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eRTO.Controllers
{
    public class DealerController : Controller
    {
        //
        // GET: /Dealer/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowRegistration()
        {
            return PartialView("_ShowRegistrationData");
        }

        public ActionResult NewRegistrationForm()
        {
            return PartialView("RegistrationForm");
        }
        public ActionResult EditRegistration()
        {
            return PartialView("_EditRegistration");
        }
	}
}