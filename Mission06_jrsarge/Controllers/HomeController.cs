using Final_jrsarge.Models;
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
        private IFinalRepository repo;

        public HomeController(IFinalRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Categories = repo.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Add(MovieSubmission ar)
        {
            //If Valid
            if (ModelState.IsValid)
            {
                SeeMoviesContext.Add(ar);
                SeeMoviesContext.SaveChanges();

                return View("Confirmation");
            }

            //If Invalid
            else
            {
                ViewBag.Categories = SeeMoviesContext.Categories.ToList();
                return View(ar);
            }
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ViewEntertainers()
        {
            var movies = SeeMoviesContext.Responses
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = SeeMoviesContext.Categories.ToList();

            var submission = SeeMoviesContext.Responses.Single(x => x.MovieID == movieid);

            return View ("Movies", submission);
        }

        [HttpPost]
        public IActionResult Edit(MovieSubmission soup)
        {
            SeeMoviesContext.Update(soup);
            SeeMoviesContext.SaveChanges();

            return RedirectToAction("ViewMovies");
        }

        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var submission = SeeMoviesContext.Responses.Single(x => x.MovieID == movieid);

            return View(submission);
        }

        [HttpPost]
        public IActionResult Delete(MovieSubmission ms)
        {
            SeeMoviesContext.Responses.Remove(ms);
            SeeMoviesContext.SaveChanges();


            return RedirectToAction("ViewMovies");
        }
    }
}
