﻿using Director.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Director.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

      /*  public IActionResult Suggest()
        {
            // TODO: use the term here to query your data source
            // and return the suggested results as JSON:
            var results = new[]
            {
                new { id = "1", label = "label 1", value = "value 1" },
                new { id = "2", label = "label 2", value = "value 2" },
                new { id = "3", label = "label 3", value = "value 3" },
            };
            return Json(results, JsonRequestBehavior.AllowGet);
            //return View();
        }*/

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
