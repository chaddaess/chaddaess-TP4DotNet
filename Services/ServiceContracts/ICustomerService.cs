using TP4.Models;
using TP4.Repositories;

namespace TP4.Services.ServiceContracts
{
	public interface ICustomerService
	{
		public void AddCustomer(String Name, int MembershipTypeId);
		public List<Customer> AllCustomers();

	}
}
