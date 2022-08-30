using Joota.com.Data;
//using Joota.com.Data.Base;
using Joota.com.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace Joota.com.Models
{
    public class NewShoeVM
    {
        //[Display(Name = "Shoes ID")]
        //[Required(ErrorMessage = "ID is Required")]

        public int Id { get; set; }

        [Display(Name ="Shoes Title")]
        [Required(ErrorMessage ="Title is Required")]

        public string Name { get; set; }

        [Display(Name = "Shoes Description")]
        [Required(ErrorMessage = "Description is Required")]

        
        public  string Description { get; set; }

        [Display(Name = "Price ")]
        [Required(ErrorMessage = "Price is Required")]

       
        public double Price { get; set; }


        [Display(Name = "Image URL")]
        [Required(ErrorMessage = "ImageURL is Required")]
        public string ImageURL { get; set; }

        [Display(Name = "Quantity ")]
        [Required(ErrorMessage = " Quantity is Required")]


        public int Quantity { get; set; }

        [Display(Name = "size")]
        [Required(ErrorMessage = "size is Required")]

        public int Size { get; set; }

        [Display(Name = "Select a catagory")]
        [Required(ErrorMessage = "Movie category is Required")]

        public ShoesCategory ShoesCategory { get; set; }

        [Display(Name = "Select a gender")]
        [Required(ErrorMessage = "Gender is Required")]

        public Gender Gender { get; set; }
    }
}
