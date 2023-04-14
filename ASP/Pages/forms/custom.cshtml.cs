using ASP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.Pages.forms
{
	[BindProperties(SupportsGet = true)]
	public class customModel : PageModel
    {
        [BindProperty]
        public BurgersModel Burger { get; set; }

        public double BurgerPrice { get; set; }
        public string ImageTitle { get; set; }
        public string Ingredients { get; set; } = "";
        public int Tomatox { get; set; }
        public int Cheesex { get; set; }
        public int Hamx { get; set; }
        public int Onionx { get; set; }
        public int Saladx { get; set; }
        public int Meatx { get; set; }
        public int VegeMeatx { get; set; }
        public int Mushroomx { get; set; }
        public int Picklesx { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost() 
        {
            BurgerPrice = Burger.BasePrice;
            ImageTitle = "own";

            if (string.IsNullOrEmpty(Burger.BurgerName))
                Burger.BurgerName = "Your Own Burger";

			if (Burger.Cola)
            {
				BurgerPrice += 10; 
                Ingredients += "+Cola+Fries ";
			}
			if (Burger.Tomato)
            {
				BurgerPrice += 2 * Tomatox; 
                Ingredients += "+" + Tomatox + "x Tomato ";
			}
			if (Burger.Cheese)
            {
				BurgerPrice += 3 * Cheesex; 
                Ingredients += "+" + Cheesex + "x Cheese ";
			}
			if (Burger.Pickles)
            {
				BurgerPrice += 1 * Picklesx;
                Ingredients += "+" + Picklesx + "x Pickles ";
			}
			if (Burger.Ham)
            {
				BurgerPrice += 4 * Hamx; 
                Ingredients += "+" + Hamx + "x Ham ";
			}
			if (Burger.onion)
            {
				BurgerPrice += 1 * Onionx;
                Ingredients += "+" + Onionx + "x Onion ";
			}
			if (Burger.VegeMeat)
            {
				BurgerPrice += 10 * VegeMeatx;
                Ingredients += "+" + VegeMeatx + "x VegeMeat ";
			}
			if (Burger.Meat)
            {
				BurgerPrice += 15 * Meatx;
                Ingredients += "+" + Meatx + "x Meat ";
			}
			if (Burger.Mushroom)
            {
				BurgerPrice += 5 * Mushroomx;
                Ingredients += "+" + Mushroomx + "x Mushroom ";
			}
			if (Burger.Salad)
            {
				BurgerPrice += 3 * Saladx;
                Ingredients += "+" + Saladx + "x Salad ";
			}


			return RedirectToPage("/checkout/checkout", new {Saladx, Tomatox, Meatx, VegeMeatx, Onionx, Hamx, Mushroomx, Picklesx, Cheesex, Ingredients, Burger.BurgerName, BurgerPrice, ImageTitle, Burger.Cola, Burger.Tomato, Burger.Cheese, Burger.Pickles, Burger.Ham, Burger.onion, Burger.VegeMeat, Burger.Meat, Burger.Mushroom, Burger.Salad});
		}
    }
}
