using TP4.Models;
using TP4.Repositories;
using TP4.Services.ServiceContracts;
namespace TP4.Services.Services
{
	public class GenreService: IGenreService
	{
		private readonly GenreRepository _Genrerepository;
		public GenreService(GenreRepository repository) { 
			_Genrerepository = repository;
		}
		public List<string> getAllGenreNames()
		{
			var genreNames = new List<string>();
			var genres = _Genrerepository.GetAll();
			foreach (var genre in genres) {
				genreNames.Add(genre.GenreName);
			}
			return genreNames;
		}

	}
}

