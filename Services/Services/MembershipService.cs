using TP4.Models;
using TP4.Repositories;
using TP4.Services.ServiceContracts;

namespace TP4.Services.Services
{
	public class MembershipService:IMembershipService
	{	private readonly MembershipTypeRepository _membershipTypeRepository;
		public MembershipService(MembershipTypeRepository membershipTypeRepository) {
			_membershipTypeRepository = membershipTypeRepository;
		}
		public List<MembershipType> getMemberships()
		{
			var memberships=_membershipTypeRepository.getAllMemberships();
			return memberships;
		}
	}
}
