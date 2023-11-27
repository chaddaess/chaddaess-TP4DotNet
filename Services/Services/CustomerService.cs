using TP4.Models;
using TP4.Repositories;
using TP4.Services.ServiceContracts;

namespace TP4.Services.Services
{
	public class CustomerService: ICustomerService
	{
		private readonly CustomerRepository _customerRepository;
		public CustomerService(CustomerRepository customerRepository) { 
			_customerRepository = customerRepository;
		}
		public void AddCustomer(String Name,int MembershipTypeId)
		{
			Customer c = new Customer()
			{
				Name = Name,
				MembershipTypeId = MembershipTypeId,
			};
			_customerRepository.AddCustomer(c);

		}
		public List<Customer> AllCustomers()
		{
			var	allCustomers= _customerRepository.GetAllCustomers();
			return allCustomers;
		}

	}
}
