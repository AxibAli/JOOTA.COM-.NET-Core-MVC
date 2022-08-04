using Joota.com.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Joota.com.Controllers
{
    public class ShoeController : Controller
    {
        

        private readonly AppDbContext _context;
        public ShoeController (AppDbContext context)
        {
            _context = context;

        }

        public async Task<ActionResult> Index()
        {
            var allProducts = await _context.Shoes.ToListAsync();
            return View();
        }
    }
}
