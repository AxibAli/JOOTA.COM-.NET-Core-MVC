using Joota.com.Data;
using Joota.com.Data.Base;
using Joota.com.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace Joota.com.Models
{
    public class NewShoeVM
    {
        [Display(Description ="Shoes Title")]
        [Required(ErrorMessage ="Title is Required")]

        public string Name { get; set; }

        [Display(Description = "Shoes Description")]
        [Required(ErrorMessage = "Description is Required")]

        
        public  string Description { get; set; }

        [Display(Description = "Price ")]
        [Required(ErrorMessage = "Price is Required")]

       
        public double Price { get; set; }


        [Display(Description = "Image URL")]
        [Required(ErrorMessage = "ImageURL is Required")]
        public string ImageURL { get; set; }

        [Display(Description = "Quantity ")]
        [Required(ErrorMessage = " Quantity is Required")]


        public int Quantity { get; set; }

        [Display(Description = "size")]
        [Required(ErrorMessage = "size is Required")]

        public int Size { get; set; }

        [Display(Description = "Select a catagory")]
        [Required(ErrorMessage = "Movie category is Required")]

        public ShoesCategory ShoesCategory { get; set; }

        [Display(Description = "Select a gender")]
        [Required(ErrorMessage = "Gender is Required")]

        public Gender Gender { get; set; }
    }
}
