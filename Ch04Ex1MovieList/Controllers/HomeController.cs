﻿using Ch04Ex1MovieList.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ch04Ex1MovieList.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
