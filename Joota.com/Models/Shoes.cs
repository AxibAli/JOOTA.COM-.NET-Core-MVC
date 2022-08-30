using Joota.com.Data;
//using Joota.com.Data.Base;
using Joota.com.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Joota.com.Models
{
    public class Shoes : IEntityBase
    {
        [Key]

        public int id { get; set; }
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Discription")]
        public string Description { get; set; }

        [Display(Name = "Price")]
        public double Price { get; set; }

        [Display(Name = "Image URL")]
        public string ImageURL { get; set; }


        public int Quantity { get; set; }

        public int Size { get; set; }

        public ShoesCategory ShoesCategory { get; set; }

        public Gender Gender { get; set; }

        
    }
}

