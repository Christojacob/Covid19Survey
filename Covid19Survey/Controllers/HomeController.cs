﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Covid19Survey.Models;

namespace Covid19Survey.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() => View("WelcomeView");

        [HttpGet]
        public ViewResult Questionnaire() => View();

        [HttpPost]
        public ViewResult Questionnaire(UserResponse userResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(userResponse);
                return View("Thankyou", userResponse);
            }
            else
            {
                return View();
            }
        }
        public ViewResult Statistics() => View(Repository.ResponseCollection);
    }
}
