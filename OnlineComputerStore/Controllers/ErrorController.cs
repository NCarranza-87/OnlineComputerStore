﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineComputerStore.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult ServerProblems()
        {
            return View();
        }

        public ActionResult NotFound()
        {
            return View();
        }
    }
}