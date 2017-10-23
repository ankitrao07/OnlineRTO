using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineRTO.Controllers
{
    public class RTOController : Controller
    {
        //
        // GET: /RTO/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowPendingRegistration()
        {

            return PartialView("RegistrationForApproval");
        }
	}
}