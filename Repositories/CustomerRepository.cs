using TP4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TP4.Repositories
{
	public class CustomerRepository
	{
		private readonly ApplicationDbContext _context;
		public CustomerRepository(ApplicationDbContext context)
		{
			_context = context;
		}

		public void  AddCustomer(Customer customer)
		{
			_context.Customers.Add(customer);
			_context.SaveChanges();

		}

		public List<Customer> GetAllCustomers()
		{
			var customers = _context.Customers
							.Include(c => c.MembershipType)
							.ToList();
			return(customers);
		}
	}
}
