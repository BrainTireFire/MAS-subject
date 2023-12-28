using API.Data;
using API.Entities.Plans.Diet;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace API.Services
{
    public class DbService : IDbService
    {
        private readonly DataContext _context;
        public DbService(DataContext context)
        {
            _context = context;
        }

        public async Task<ICollection<DietPlan>> GetDietPlansData()
        {
            return await _context.DietPlans
                .Include(e => e.User)
                //.ThenInclude(e => e.DietPlans)
                //.Include(e => e.AdminsAndModerator)
                .Include(e => e.DishDietPlans)
                .ThenInclude(e => e.Dish)
                .ToListAsync();
        }

        public async Task AddDishDietPlan(IEnumerable<DishDietPlan> dishDietPlan)
        {
            await _context.AddRangeAsync(dishDietPlan);
            await _context.SaveChangesAsync();
        }

        public async Task AddNewPlan(DietPlan dietPlan)
        {
            await _context.AddAsync(dietPlan);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> GetDietPlanExistsByName(string name)
        {
            return await _context.DietPlans.AnyAsync(e => e.Name == name);
        }

        //public async Task<int> GetMaxIdFromTable<TEntity>(Expression<Func<TEntity, int>> idSelector) where TEntity : class
        //{
        //    int maxId = await _context.Set<TEntity>().MaxAsync(idSelector);
        //    return maxId;
        //}

        public async Task<int?> GetMaxIdFromDietPlansTable()
        {
            int? maxId = await _context.DietPlans.MaxAsync(e => (int?)e.IdDietPlan);
            if (maxId == null)
            {
                return 1;
            }

            return maxId.Value;
        }

        public async Task<int?> GetMaxIdFromDishDietPlansTable()
        {
            int? maxId = await _context.DishDietPlans.MaxAsync(e => (int?)e.IdDishDietPlan);
            return maxId;
        }


        public async Task<Dish?> GetDishById(int IdDish)
        {
            return await _context.Dishs.FirstOrDefaultAsync(e => e.IdDish == IdDish);
        }

        //public async Task AddDishDietPlanDish(IEnumerable<DishDietPlanDish> dishDietPlanDish)
        //{
        //    await _context.AddRangeAsync(dishDietPlanDish);
        //    await _context.SaveChangesAsync();
        //}
    }
}
