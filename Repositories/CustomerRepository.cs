using TP4.Models;

namespace TP4.Repositories
{
	public class CustomerRepository
	{
		private readonly ApplicationDbContext _context;
		public CustomerRepository(ApplicationDbContext context)
		{
			_context = context;
		}
	}
}
