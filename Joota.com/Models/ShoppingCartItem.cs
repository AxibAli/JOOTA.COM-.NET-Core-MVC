using System.ComponentModel.DataAnnotations;

namespace Joota.com.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int Id { get; set; }
        
        public Shoes Shoes { get; set; }

        public int Amount { get; set; }

        public string ShoppingCartId { get; set; }

    }
}
