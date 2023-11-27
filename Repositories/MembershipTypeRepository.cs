using TP4.Models;

namespace TP4.Repositories
{
	public class MembershipTypeRepository
	{
		private readonly ApplicationDbContext _context;
		public MembershipTypeRepository(ApplicationDbContext context) {
			_context = context;
		}
		public List<MembershipType> getAllMemberships()
		{
			var memberships=_context.MembershipTypes.ToList();
			return memberships;
		}

	}
}
