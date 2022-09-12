using Joota.com.Models;
using Microsoft.EntityFrameworkCore;

namespace Joota.com.Data.Cart
{
    public class ShoppingCart
    {
        public AppDbContext _context { get; set; }

        public string ShoppingCartId { get; set; }

        public List<ShoppingCartItem> ShoppingCartItem { get; set; }

        public ShoppingCart(AppDbContext context)
        {
            _context = context;
        }
        public static ShoppingCart GetShoppingCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDbContext>();

            string cardId = session.GetString("CardId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cardId);

            return new ShoppingCart(context) { ShoppingCartId = cardId };
        }


        //AddItemToCart
        public void AddItemToCart(Shoes shoes)
        {
            var ShoppingCartItem = _context.ShoppingCartItems.FirstOrDefault(n => n.Shoes.Id == shoes.Id && n.ShoppingCartId == ShoppingCartId);

            if(ShoppingCartItem == null)
            {
               ShoppingCartItem = new ShoppingCartItem()
               {
                   ShoppingCartId = ShoppingCartId,
                    Shoes = shoes,
                    Amount = 1
               };
                _context.ShoppingCartItems.Add(ShoppingCartItem);
            }else
            {
                ShoppingCartItem.Amount++;
            }
            _context.SaveChanges();
        }

        public void RemoveItemFromCart(Shoes shoes)
        {
            var ShoppingCartItem = _context.ShoppingCartItems.FirstOrDefault(n => n.Shoes.Id == shoes.Id && n.ShoppingCartId == ShoppingCartId);

            if (ShoppingCartItem != null)
            {
                if(ShoppingCartItem.Amount > 1)
                {
                    ShoppingCartItem.Amount--;
                }else
                {
                    _context.ShoppingCartItems.Remove(ShoppingCartItem);

                }
                
           
            }
            _context.SaveChanges();
        }



        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItem ?? (ShoppingCartItem = _context.ShoppingCartItems.Where(n => n.ShoppingCartId == ShoppingCartId).Include(n => n.Shoes).ToList());
        }

        public double GetShoppingCartTotal() => _context.ShoppingCartItems.Where(n => n.ShoppingCartId == ShoppingCartId).Select(n => n.Shoes.Price * n.Amount).Sum();

        public async Task ClearShoppingCartAsync()
        {
            var items = await _context.ShoppingCartItems.Where(n => n.ShoppingCartId == ShoppingCartId).ToListAsync();
            _context.ShoppingCartItems.RemoveRange(items);
            await _context.SaveChangesAsync();
        }
    }

    
}
