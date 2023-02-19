using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission06_jrsarge.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_jrsarge.Controllers
{
    public class HomeController : Controller
    {
        private MovieSubmissionContext _blahContext { get; set; }

        //Constructor
        public HomeController(MovieSubmissionContext someName)
        {
            _blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movies()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Movies(MovieSubmission ar)
        {
            _blahContext.Add(ar);
            _blahContext.SaveChanges();

            return View("Confirmation");
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }
    }
}
