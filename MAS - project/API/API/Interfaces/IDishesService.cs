using API.Entities.Plans.Diet;

namespace API.Interfaces
{
    public interface IDishesService
    {
        Task<ICollection<Dish>> GetDishies();
        Task AddNewDish(Dish dish);
        Task<bool> DoesDishExistByName(string name);
    }
}
