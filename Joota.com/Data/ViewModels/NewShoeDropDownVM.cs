using Joota.com.Models;

namespace Joota.com.Data.ViewModels
{
    public class NewShoeDropDownVM
    {
       public NewShoeDropDownVM()
        {
            Shoes = new List<Shoes>();
        }


        public List<Shoes> Shoes { get; set; }
    }
}
