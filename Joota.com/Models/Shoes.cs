using Joota.com.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace Joota.com.Models
{
    public class Shoes
    {
        [Key]
        public int Id { get; set; } 
        
        public string Name { get; set; }    

        public  string Description { get; set; }

        public double Price { get; set; }

        public string ImageURL { get; set; }

        public int Quantity { get; set; }

        public int Size { get; set; }

        public ShoesCategory ShoesCategory { get; set; }

        public Gender Gender { get; set; }
    }
}
