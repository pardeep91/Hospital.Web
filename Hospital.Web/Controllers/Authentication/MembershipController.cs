using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hospital.DTO;
using Hospital.Services.Services;
using Hospital.Services.Iservices;

namespace Hospital.Web.Controllers.Authentication
{
    public class MembershipController : Controller
    {
        private readonly ISignupServices _signupServices;
        public MembershipController()
        {
            _signupServices = new SignupServices();
        }
        // GET: Membership
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(UserDTO signup)
        {
            _signupServices.Signup(signup);
            TempData["Member"] = signup.User_Name;
            return View("SignupSucess");
        }
    }
}