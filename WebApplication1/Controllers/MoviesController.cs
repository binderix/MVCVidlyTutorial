using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebApplication1.Models;
using WebApplication1.ViewModels;



namespace WebApplication1.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };

            //ViewData["Movie"] = movie;
            //ViewBag.Movie = movie;


            ///////////////////////
            ///var movie = new Movie() { Name = "Shrek" };
            var customers = new List<Customer>
            {
                new Customer {Name="Harry Heinzel"},
                new Customer {Name="Nadja Nickel"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        // GET: Movies/Vidly
        public ActionResult Vidly()
        {
            List<Movie> movies = new List<Movie> {
                new Movie() { Name = "Schneewittchen" },
                new Movie() { Name = "Wall-e"}
            };

            var movieList = new ViewModels.MovieList
            {
                movies = movies
            };


            return View(movieList);
            //return Content("Hello World");
        }

        // GET: Movies/Customer
        public ActionResult Customer()
        {
            var movie = new Movie() { Name = "Shrek" };
            var customers = new List<Customer>
            {
                new Customer {Name="Harry Heinzel"},
                new Customer {Name="Nadja Nickel"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };


            return View(viewModel);
        }
    }
}