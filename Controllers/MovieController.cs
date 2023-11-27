using Microsoft.AspNetCore.Mvc;
using TP4.Models;
using TP4.Services.ServiceContracts;

namespace TP4.Controllers
{
	public class MovieController : Controller
	{
		private readonly IMovieService _movieService;
		private readonly IGenreService _genreService;


		public MovieController(IMovieService movieService,IGenreService genreService)
		{
			_movieService = movieService;
			_genreService = genreService;
		}
		public IActionResult Index()
		{
			List<Movie> movies =_movieService.getAllMovies();
			return View(movies);
		}

		public IActionResult Add( )
		{
			ViewBag.GenreNames=_genreService.getAllGenreNames();

			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Add(string Name,string GenreId)
		{
			if (ModelState.IsValid)
			{
				_movieService.AddMovie(Name,GenreId);
				return (RedirectToAction(nameof(Index)));


			}
			return (RedirectToAction(nameof(Add)));
			

		}
	}
}
