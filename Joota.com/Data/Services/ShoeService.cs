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

        public async Task<Shoes> GetShoesByIdAsync(int id)
        {
            var ShoeDetails = await _context.Shoes
                .FirstOrDefaultAsync(n => n.Id == id);
                return  ShoeDetails;
            
        }
    }
}
