﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace JobApplication_App.Controllers
{
    public class JobAdvertController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
