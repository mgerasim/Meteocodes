﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Meteo.Controllers
{
    public class StationController : Controller
    {
        //
        // GET: /Station/

        public ActionResult Index()
        {
            return View();
        }

    }
}