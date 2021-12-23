﻿using Microsoft.AspNetCore.Mvc;

using PartyInvites.Models;

using System.Diagnostics;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //TODO: Опознать имя через уч. Windows
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FormAccept() => View();

        [HttpPost]
        public IActionResult FormAccept(GuestResponse guestResponse)
        {
            return View("Thanks", guestResponse);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}