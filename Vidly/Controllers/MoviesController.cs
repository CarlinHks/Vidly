using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
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

		// GET: Movies
		public ViewResult Index()
		{
			var movies = _context.Movies.Include(m => m.GenreType).ToList();

			return View(movies);
		}

		public ViewResult Details(int id)
		{
			var movie = _context.Movies.Include(m => m.GenreType).SingleOrDefault(m => m.Id == id);

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