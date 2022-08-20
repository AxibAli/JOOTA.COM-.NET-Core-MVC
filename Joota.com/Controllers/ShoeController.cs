using Joota.com.Data;
using Joota.com.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Joota.com.Controllers
{
    public class ShoeController : Controller
    {


        private readonly IShoeService _service;
        public ShoeController(IShoeService service)
        {
            _service = service;

        }

        public async Task<ActionResult> Index()
        {
            var allshoes = await _service.GetAllAsync(n => n.Name);
            return View(allshoes);
        }

        //Get: Shoe/Details/1
        public async Task<ActionResult> Details(int id)
        {
            var shoeDetail = await _service.GetShoesByIdAsync(id);
            return View(shoeDetail);
        }

        //Get: ,Movies/Create
        public IActionResult Create()
        {
            ViewData["welcome"] = "welcome to our store";
            ViewBag.Description = "This is the store desription";
            return View();
        }
    }
}
