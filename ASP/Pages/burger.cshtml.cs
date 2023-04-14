using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ASP.Models;

namespace ASP.Pages
{
    public class burgerModel : PageModel
    {
        public List<BurgersModel> fakeburgerDB = new List<BurgersModel>()
        {
            new BurgersModel() { ImageTitle = "bison", BurgerName = "Bison Burger", FinalPrice = 25 },
            new BurgersModel() { ImageTitle = "czisburger", BurgerName = "CheeseBurger", FinalPrice = 20 },
            new BurgersModel() { ImageTitle = "czyli", BurgerName = "Chili Burger", FinalPrice = 26 },
            new BurgersModel() { ImageTitle = "dip", BurgerName = "Dip Burger", FinalPrice = 24 },
            new BurgersModel() { ImageTitle = "dzusi", BurgerName = "Juicy Burger", FinalPrice = 23 },
            new BurgersModel() { ImageTitle = "elk", BurgerName = "ELk Burger", FinalPrice = 30 },
            new BurgersModel() { ImageTitle = "frita", BurgerName = "Fries Burger", FinalPrice = 28 },
            new BurgersModel() { ImageTitle = "onion", BurgerName = "Onion Burger", FinalPrice = 24 },
        };
        public void OnGet()
        {
        }
    }
}
