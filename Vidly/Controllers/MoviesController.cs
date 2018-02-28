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
        public ViewResult Index()
        {
            var Movies = getMovies();
            return View(Movies);
        }
                
        private IEnumerable<Movie> getMovies()
        {
            var movies = new List<Movie>
            {
                new Movie {Id = 1, Name = "Rush Hour" },
                new Movie {Id = 2, Name = "Fight Club" }
            };
            return movies;            
        }
    }
}