using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ASP.Models;
using ASP.Data;
using MySqlX.XDevAPI;

namespace ASP.Pages
{
    public class OrdersModel : PageModel
    {
        public List<Order> BurgerOrders = new List<Order>();

        private readonly AppDbContext _context;
        public OrdersModel(AppDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            BurgerOrders = _context.Orders.ToList();
        }
    }
}
