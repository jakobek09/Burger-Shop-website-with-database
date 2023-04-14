using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ASP.Models;
using ASP.Data;
using System;

namespace ASP.Pages.checkout
{
    [BindProperties(SupportsGet = true)]
    public class checkoutModel : PageModel
    {
        public string BurgerName { get; set; }
        public float BurgerPrice { get; set; }
        public string ImageTitle { get; set; }
        [BindProperty]
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Ingredients { get; set; }
        public BurgersModel burger1 { get; set; }
		public int Tomatox { get; set; }
		public int Cheesex { get; set; }
		public int Hamx { get; set; }
		public int Onionx { get; set; }
		public int Saladx { get; set; }
		public int Meatx { get; set; }
		public int VegeMeatx { get; set; }
		public int Mushroomx { get; set; }
		public int Picklesx { get; set; }

		private readonly AppDbContext _context;
		public checkoutModel(AppDbContext context)
		{
			_context = context;
		}

		public IActionResult OnPost()
        {
			if (string.IsNullOrWhiteSpace(BurgerName))
			{
				BurgerName = "Custom";
			}
			if (string.IsNullOrWhiteSpace(ImageTitle))
			{
				ImageTitle = "logo";
			}
			if (string.IsNullOrWhiteSpace(Ingredients))
			{
				Ingredients = "Standard";
			}
			Order burgerOrder = new Order();
			burgerOrder.Price = BurgerPrice;
			burgerOrder.Name = BurgerName;
			burgerOrder.Address = Address;
			burgerOrder.Phone = Phone;
			burgerOrder.Ingredients = Ingredients;
			_context.Orders.Add(burgerOrder);
			_context.SaveChanges();
			return RedirectToPage("/checkout/thankYou");
		}
    }
}
