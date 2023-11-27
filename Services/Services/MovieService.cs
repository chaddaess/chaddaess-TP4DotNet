using TP4.Models;
using TP4.Repositories;
using TP4.Services.ServiceContracts;

namespace TP4.Services.Services
{
	public class MovieService :IMovieService
	{
		private readonly MovieRepository _MovieRepository;
		private readonly GenreRepository _GenreRepository;

		public MovieService(MovieRepository repository,GenreRepository genreRepository)
		{
			this._MovieRepository = repository;
			this._GenreRepository = genreRepository;
			
		}

		public Movie getMovieById(int id) {
			return _MovieRepository.getById(id);
		}

		public Movie getMovieByName(string Name)
		{
			return _MovieRepository.getByName(Name);
		}

		public List<Movie> getMoviesByGenre(string genre)
		{
			return _MovieRepository.getByGenre(genre);
		}

		public List<Movie> getAllMovies()
		{
			return _MovieRepository.findAll();
		}

		public  void AddMovie(string MovieName,string GenreName)
		{
			Genre genre = _GenreRepository.GetByName(GenreName);
			Movie movie = new()
			{
				Name = MovieName,
				Genre = genre,
				GenreId = genre.Id,
			};
			 _MovieRepository.AddMovie(movie);
			

		}

	
	}
}
