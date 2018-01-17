using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hospital.DTO;
using Hospital.Services.Services;
using Hospital.Services.Iservices;
using System.Web.Security;

namespace Hospital.Web.Controllers.Authentication
{
    public class AuthenticationController : Controller
    {
        private readonly IloginUserServices _loginUserServices;
        public AuthenticationController()
        {
            _loginUserServices = new loginUserServices();
        }
        // GET: Authentication
        public ActionResult Login()
        {
            return View();
        }
        
        [HttpPost,ActionName("Login")]
        public ActionResult Dologin(UserDTO chklogin)

        {
            if (ModelState.IsValid)
            {
                if (_loginUserServices.Dologin(chklogin))
                {
                    TempData["username"] = chklogin.User_Name;
                    return RedirectToAction("Index", "Employee");
                }
                else
                {

                    ModelState.AddModelError("", "Wrong Username or Password");
                    //return RedirectToAction("Login");
                    //return View("Login");
                }
            }
            return View ("Login");
        }
        public ActionResult logout()
        {
            FormsAuthentication.SignOut();
            //return View("Login");
            return RedirectToAction("Login");
        }
    }
}