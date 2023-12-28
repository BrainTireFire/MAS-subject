using API.Entities.Plans.Diet;
using System.Linq.Expressions;

namespace API.Interfaces
{
    public interface IDbService
    {
        Task AddNewPlan(DietPlan dietPlan);
        Task AddDishDietPlan(IEnumerable<DishDietPlan> dishDietPlan);
       // Task AddDishDietPlanDish(IEnumerable<DishDietPlanDish> dishDietPlanDish);
        Task<bool> GetDietPlanExistsByName(string name);
        Task<Dish?> GetDishById(int IdDish);
        //Task<int> GetMaxIdFromTable<TEntity>(Expression<Func<TEntity, int>> idSelector) where TEntity : class;
        Task<int?> GetMaxIdFromDietPlansTable();
        Task<int?> GetMaxIdFromDishDietPlansTable();
        Task<ICollection<DietPlan>> GetDietPlansData();
    }
}
