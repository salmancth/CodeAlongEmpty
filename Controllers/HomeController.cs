﻿using Microsoft.AspNetCore.Mvc;

namespace CodeAlongEmpty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
