using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZaynabHteit_Homework2.Models;
using ZaynabHteit_Homework2.ViewModels;

namespace ZaynabHteit_Homework2.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movies /Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer {Id=1 ,Name = "Sami "},
                new Customer {Id=2 ,Name = "Wessam "},
                new Customer {Id=3 ,Name = "Zaynab"},
                new Customer {Id=4 ,Name = "Sally"}

             };
            /* var Movie = new List<Movies>
             {
                 new  Movies {Name = "Movie 1"},
                 new Movies  {Name = "Movie 2"}
             };*/
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            /* var viewResult = new ViewResult();
             viewResult.ViewData.Model*/
            /* ViewData["RandomMovie"] = movie;
             ViewBag.RandomMovie = movie;*/

            return View(viewModel);
            //return View(movie);
            // return new ViewResult();
            // return Content("Hello world! ");
            // return HttpNotFound();
            // return new EmptyResult();
            // return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        /* [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
         public ActionResult ByReleaseDate(int year , int month)
         {
             return Content(year + "/" +month);

         }*/



        // a new action 
        /*public ActionResult Edit(int movieId)
        {
            return Content("id =" + movieId);
        }*/

        public ActionResult Movie()
        {
            var MoviesList = new List<Movies>()
            {
                new Movies{Id=1 ,Name="Le Casa De Papel"},
                new Movies{Id=2 ,Name="Mission Impossible"},
                new Movies{Id=3 ,Name="fast & ferious"}

            };

            var viewModel = new RandomMovieViewModel
            {
                Movieslist = MoviesList
            };
            return View(viewModel);
        }



        public ActionResult Edit(int id)
        {
            return Content("id =" + id);
        }
        //Movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);

        }
        public ActionResult GetCustomer(int id)
        {

            if (id == 1)
            {
                return Content("Sami");
            }
            else if (id == 2)
            {
                return Content("Wessam");
            }
            else if (id == 3)
            {
                return Content("Zaynab");
            }
            else
            {
                return Content("Sally");
            }

        }
        public ActionResult GetMovie(int id)
        {

            if (id == 1)
            {
                return Content("Le Casa De Papel");
            }
            else if (id == 2)
            {
                return Content("Mission Impossible");
            }
            else
            {
                return Content("fast & ferious");
            }

        }
    }
}




