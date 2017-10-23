using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineRTO.ViewModel;
using OnlineRTO.Models;

namespace OnlineRTO.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/
        public ActionResult Index()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(vmLogin _user)
        {
            if (ModelState.IsValid)
            {
                if (clsLogin.IsAuthenticate(_user))
                {
                    clsLogin.GetUserDetails(Convert.ToInt32(HttpContext.Session["UID"]),Convert.ToString(HttpContext.Session["Role"]));
                    string role = Convert.ToString(HttpContext.Session["Role"]);
                    switch (role)
                    {
                        case "Dealer":
                            return RedirectToAction("Index", "Dealer");

                        case "RTO":
                            return RedirectToAction("Index", "RTO");
                    }
                }
            }
            return new EmptyResult();
        }

        public ActionResult Logout()
        {
            HttpContext.Session["UserName"] = null;
            HttpContext.Session["UserRole"] = null;
            HttpContext.Session["UID"] = null;
            return RedirectToAction("Index");
        }
	}
}