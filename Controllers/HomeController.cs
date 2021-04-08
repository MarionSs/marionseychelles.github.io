using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using test.Models;

namespace test.Controllers
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

        [Route("espace-privé")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("nos-expetises")]
        public IActionResult Our_expertises()
        {
            return View();
        }

        [Route("agenda")]
        public IActionResult Agenda()
        {
            return View();
        }

        [Route("contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [Route("carriere")]
        public IActionResult Career()
        {
            return View();
        }

        [Route("mentions-légales")]
        public IActionResult Legals()
        {
            return View();
        }

        [Route("webinaire")]
        public IActionResult Webinar()
        {
            return View();
        }


        [Route("lire-la-suite")]
        public IActionResult Articles()
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
