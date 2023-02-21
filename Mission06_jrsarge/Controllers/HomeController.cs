using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private MovieSubmissionContext SeeMoviesContext { get; set; }

        //Constructor
        public HomeController(MovieSubmissionContext someName)
        {
            SeeMoviesContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movies()
        {
            ViewBag.Categories = SeeMoviesContext.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Movies(MovieSubmission ar)
        {
            SeeMoviesContext.Add(ar);
            SeeMoviesContext.SaveChanges();

            return View("Confirmation");
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ViewMovies()
        {
            var movies = SeeMoviesContext.Responses
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();

            return View(movies);
        }

        public IActionResult Edit()
        {
            ViewBag.Categories = SeeMoviesContext.Categories.ToList();

            //var submission = SeeMoviesContext.Responses.Single();

            return View("Movies");
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}
