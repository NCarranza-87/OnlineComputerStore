using OnlineComputerStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineComputerStore.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel registerUser)
        {
            if (ModelState.IsValid)
            {
                if(MemberDB.IsUsernameTaked(registerUser))
                {
                    ModelState.AddModelError("UsernameTaken",
                        "Username has been already taken!");
                    return View(registerUser);
                }

                Member m = new Member()
                {
                    Username = registerUser.Username,
                    EmailAddress = registerUser.Email
                };

                MemberDB.AddMember(m);
                SessionHelper.LogUserIn(m.Username);

                // redirect to home page
                return RedirectToAction("Index", "Home");
            }
            return View(registerUser);
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel loginUser)
        {
            if (ModelState.IsValid)
            {
                if (MemberDB.UserExits(loginUser))
                {
                    SessionHelper.LogUserIn(loginUser.Username);

                    return RedirectToAction("Index", "Home");
                }

                // Add Customer error to say "No Matching"
                ModelState.AddModelError("InvalidCredentials",
                    "Your user credentials were not found!");
            }
            return View(loginUser);
        }

        public ActionResult LogOut()
        {
            SessionHelper.LogUserOut();

            return RedirectToAction("Index", "Home");
        }
    }
}