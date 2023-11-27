using TP4.Models;

namespace TP4.Services.ServiceContracts
{
	public interface IMovieService
	{
		public Movie getMovieById(int id);
		public Movie getMovieByName(string Name);
		public List<Movie> getMoviesByGenre(string genre);
		public List<Movie> getAllMovies();
		public void AddMovie(string MovieName, string GenreName );


	}
}