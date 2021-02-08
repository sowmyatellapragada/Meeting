using FirstProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        //public ViewResult Index()
        //{
        //    int hour = DateTime.Now.Hour;
        //    string viewModel = hour < 12 ? "GoodMorning" : "Good Afternoon";
        //    return View("Index", viewModel);
        //}
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Form()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Form(Response guestResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }

        }
        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r =>
            r.WillAttend == true));
        }



        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
