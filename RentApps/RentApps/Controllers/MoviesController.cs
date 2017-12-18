using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentApps.Models;

namespace RentApps.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ViewResult Index()
        {
            var movies = GetMovie();
            return View(movies);

        }

        private IEnumerable<Movie> GetMovie()
        {
            return new List<Movie>
            {
                new Movie {Id = 1, Name = "Shrek"},
                new Movie {Id = 3, Name = "Wall-e"}
            };
        }
    }
}