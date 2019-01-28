using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class MovieController : Controller
    {

        [Route("Movie")]
        // GET: Movie
        public ActionResult Movie()
        {
            var movieList = new List<Movie>
            {
                new Movie{ Name = "Shrek"},
                new Movie{ Name = "Wall-e"}
            };
            var viewModel = new MovieViewModel
            {
                MovieList = movieList
            };
            return View(viewModel);
        }
    }
}