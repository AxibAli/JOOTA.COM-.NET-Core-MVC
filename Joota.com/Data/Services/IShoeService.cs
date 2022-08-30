
using Joota.com.Data.ViewModels;
using Joota.com.Models;

namespace Joota.com.Data.Services
{
    public interface IShoeService : IEntityBaseRepository<Shoes>
    {
        Task<Shoes> GetShoesByIdAsync(int id);
        Task<NewShoeDropDownVM> GetNewShoeDropDownValues();

        Task AddNewShoeAsync(NewShoeVM data);

        Task UpdateShoeAsync(NewShoeVM data);

        //Task<IEnumerable<Shoes>> GetAllAsyn();
        //Task<Shoes> GetByIdAsync(int id);
        //Task AddAsync(Shoes shoes);
        //Task<Shoes> UpdateAsync(int id, Shoes newshoes);

        //Task DeleteAsync(int id);

    }
}
