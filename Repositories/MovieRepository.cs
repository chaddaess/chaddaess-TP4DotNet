using TP4.Models;

namespace TP4.Repositories
{
	public class MovieRepository
	{
		private readonly ApplicationDbContext _context;
		public MovieRepository(ApplicationDbContext context)
		{
			_context = context;
		}
		public Movie getById(int id )
		{
			return _context.Movies.Where(m => m.Id == id).FirstOrDefault();
		}
		public Movie getByName(String Name)
		{
			return _context.Movies.Where(m => m.Name== Name).FirstOrDefault();
		}


		public List<Movie> getByGenre(string genre)
		{
			var Genre=_context.Genres.Where(g=>g.GenreName== genre).FirstOrDefault();
			return _context.Movies.Where(m => m.GenreId ==Genre.Id).ToList();

		}
		public List<Movie> findAll()
		{
			return _context.Movies.ToList();
		}

		public  void AddMovie(Movie movie)
		{
			_context.Movies.Add(movie);
			 _context.SaveChanges();
		}
	}
}
