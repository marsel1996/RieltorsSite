﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Realtors.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult ContactView()
        {
            return View();
        }
    }
}