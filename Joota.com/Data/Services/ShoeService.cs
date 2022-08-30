using Joota.com.Data.ViewModels;
using Joota.com.Models;
using Microsoft.EntityFrameworkCore;

namespace Joota.com.Data.Services
{
    public class ShoeService : EntityBaseRepository<Shoes>, IShoeService
    {
        private readonly AppDbContext _context;
        public ShoeService(AppDbContext context): base(context)
        {
            _context = context;
        }

        public async Task AddNewShoeAsync(NewShoeVM data)
        {
            var newShoe = new Shoes()
            {
                Name = data.Name,
                Description = data.Description,
                Price = data.Price,
                Quantity = data.Quantity,
                Size = data.Size,
                ImageURL = data.ImageURL,
                ShoesCategory = data.ShoesCategory
            };
           await _context.Shoes.AddAsync(newShoe);
            await _context.SaveChangesAsync();

        }

        public async Task<NewShoeDropDownVM> GetNewShoeDropDownValues()
        {
            var response = new NewShoeDropDownVM();
            {
                response.Shoes = await _context.Shoes.OrderBy(n => n.Name).ToListAsync();
            };
            return response;

        }

        public async Task<Shoes> GetShoesByIdAsync(int id, Shoes? shoeDetails)
        {
            var ShoeDetails = await _context.Shoes
                .Include(s => s.Id)
                .FirstOrDefaultAsync(n => n.Id == id);
                return shoeDetails;
            
        }

        public async Task UpdateShoeAsync(NewShoeVM data)
        {
            var dbShoe = await _context.Shoes.FirstOrDefaultAsync(n => n.Id == data.Id);
            if(dbShoe != null)
            {

                dbShoe.Name = data.Name;
                dbShoe.Description = data.Description;
                dbShoe.Price = data.Price;
                dbShoe.Quantity = data.Quantity;
                dbShoe.Size = data.Size;
                dbShoe.ImageURL = data.ImageURL;
                dbShoe.ShoesCategory = data.ShoesCategory;
                await _context.SaveChangesAsync();
               
            }
                
          
            
        }
    }
}
