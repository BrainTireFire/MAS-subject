using API.Data;
using API.Entities.Plans.Diet;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public class DishesService : IDishesService
    {
        private readonly DataContext _context;
        public DishesService(DataContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Dish>> GetDishies()
        {
            return await _context.Dishs.ToListAsync();
        }

        public async Task AddNewDish(Dish dish)
        {
            await _context.AddAsync(dish);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DoesDishExistByName(string name)
        {
            return await _context.Dishs.AnyAsync(e => e.Name == name);
        }
    }
}
