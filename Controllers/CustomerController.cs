using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TP4.Repositories;
using TP4.Services.ServiceContracts;

namespace TP4.Controllers
{
	public class CustomerController : Controller
	{
		private readonly ICustomerService _customerService;
		private readonly IMembershipService _membershipService;
		public CustomerController(ICustomerService customerService,IMembershipService membershipService)
		{
			_customerService = customerService;
			_membershipService = membershipService;
		}
		public IActionResult Index()
		{
			var customers = _customerService.AllCustomers();
			return View(customers);
		}

		public IActionResult Add()
		{
			var memberships = _membershipService.getMemberships();
			ViewBag.memberships = memberships.Select(membership => new SelectListItem()
			{
				Text=membership.DiscountRate.ToString(),
				Value=membership.Id.ToString(),
			});
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Add(String Name ,int MembershipTypeId)
		{
			if(ModelState.IsValid)
			{
				_customerService.AddCustomer(Name, MembershipTypeId);
				return (RedirectToAction(nameof(Index)));
			}
			ViewBag.Errors=ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();
			return(RedirectToAction(nameof(Add)));
			
		}
	}
}
