using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
	public class MoviesController : Controller
	{
		// GET: Movies
		public ViewResult Index()
		{
			var movies = GetMovies();

			return View(movies);
		}

		public ViewResult Details(int id)
		{
			var movie = GetMovies().SingleOrDefault(m => m.Id == id);

			return View(movie);
		}

		private IEnumerable<Movie> GetMovies()
		{
			return new List<Movie>
			{
				new Movie
				{
					Id = 1, Name = "Deadpool",
					Detail = "Esse filme é muito bom"
				},
				new Movie
				{
					Id = 2, Name = "Avengers",
					Detail = "Esse filme é muito bom, mas Deadpool é melhor"
				}
			};
		}
		
	}
}