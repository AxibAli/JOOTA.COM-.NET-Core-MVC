using Joota.com.Data;
using Joota.com.Data.Services;
using Joota.com.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            var allshoes = await _service.GetAllAsync();
            return View(allshoes);
        }

        //Get: Shoe/Details/1
        public async Task<ActionResult> Details(int id)
        {
            var shoeDetail = await _service.GetShoesByIdAsync(id);
            return View(shoeDetail);
        }

        //Get: ,Movies/Create
        public async Task<IActionResult> Create()
        {
            var ShoeDropDownData = await _service.GetNewShoeDropDownValues();
            ViewBag.Id = new SelectList(ShoeDropDownData.Shoes, "Id", "Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(NewShoeVM Shoe)
        {
            if(!ModelState.IsValid)
            {
                var ShoeDropDownData = await _service.GetNewShoeDropDownValues();
                ViewBag.Id = new SelectList(ShoeDropDownData.Shoes, "Id", "Name");
                return View();
            }

            await _service.AddNewShoeAsync(Shoe);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]

        //Get: ,Movies/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var ShoeDetails  = await _service.GetShoesByIdAsync(id);
            if (ShoeDetails == null) return View("Not Found");
            var response = new NewShoeVM()
            {
                Id = ShoeDetails.Id,
                Name = ShoeDetails.Name,
                Description = ShoeDetails.Description,
                Price = ShoeDetails.Price,
                ImageURL = ShoeDetails.ImageURL,
                Quantity = ShoeDetails.Quantity,
                ShoesCategory = ShoeDetails.ShoesCategory

            };

            var ShoeDropDownData = await _service.GetNewShoeDropDownValues();
            ViewBag.Id = new SelectList(ShoeDropDownData.Shoes, "Id", "Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewShoeVM shoe)
        {
            if (id != shoe.Id) return View("Not Found");
            if (!ModelState.IsValid)
            {
                var ShoeDropDownData = await _service.GetNewShoeDropDownValues();
                ViewBag.Id = new SelectList(ShoeDropDownData.Shoes, "Id", "Name");
                return View();
            }

            await _service.UpdateShoeAsync(shoe);
            return RedirectToAction(nameof(Index));
        }
    }
}
