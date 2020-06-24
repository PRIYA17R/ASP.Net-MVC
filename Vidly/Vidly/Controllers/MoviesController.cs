using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        //GET: Customers
        public ActionResult Index()
        {
            var Movies  = GetMovies();
            return View(Movies);
        }

        // create movies List

        public List<Movie> GetMovies()
        {
            List<Movie> Movies = new List<Movie>{
            new Movie{Id=1, Name="shrekkk"},
            new Movie{Id=2, Name="fall on the sky"}
            };
            return Movies;
        }



        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Id = 1, Name = "Sherkkk" };

            List<Customer> customerList = new List<Customer>{
                new Customer { Name = "Priya"},
                new Customer { Name = "Shashank" }
            };

            var viewModel = new RandomMovieViewModel {
                Movie = movie,
                Customers = customerList
            };


            //ViewData["Movie"] = movie;
            return View(viewModel);
        }
        

        //public ActionResult Edit(int id)
        //{
        //    return Content("id is " + id);
        //}

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";
        //    return Content(String.Format("Pageindex = {0} andsortedby = {1}", pageIndex, sortBy));
        //}

        //[Route("movies/released/{year}/{month:regex(\\d{4}):range(1, 12)}")]
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year +"  / " +month);
        //}
    }
}