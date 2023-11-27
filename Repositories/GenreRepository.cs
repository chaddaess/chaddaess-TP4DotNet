using TP4.Models;

namespace TP4.Repositories
{
	public class GenreRepository
	{
		private readonly ApplicationDbContext _context;
		public  GenreRepository(ApplicationDbContext context)
		{
			_context = context;
		}
		public Genre GetByName(string name)
		{
			var genre=_context.Genres.Where(g=>g.GenreName == name).FirstOrDefault();
			return genre;
		}

		public Genre GetById(int id)
		{
			var genre = _context.Genres.Where(g => g.Id ==id).FirstOrDefault();
			return genre;
		}

		public List<Genre> GetAll()
		{
			return(_context.Genres.ToList());
		}

	}
}
