using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentApps.Models;

namespace RentApps.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Details(int id)
        {
            var movies = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movies == null)
               return HttpNotFound();

            return View(movies);
           
        }


        // GET: Movies
        public ViewResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList(); 
            return View(movies);

        }

        
    }
}