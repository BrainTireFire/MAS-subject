using API.DTOs;
using API.DTOs.GETS;
using API.Entities.Plans.Diet;
using API.Interfaces;
using API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DishesController : ControllerBase
    {
        private readonly IDishesService _dishesService;
        public DishesController(IDishesService dishesService)
        {
            _dishesService = dishesService;
        }

        [Authorize(Policy = "RequiredModerator")]
        [HttpGet]
        public async Task<IActionResult> GetDishies()
        {
            var dishies = await _dishesService.GetDishies();

            var dishiesDTO = dishies.Select(e => new GetDishDTO
            {
                IdDish = e.IdDish,
                Name = e.Name,
                Description = e.Description,
                AmountOfCaloriesInTheDish = e.AmountOfCaloriesInTheDish
            });

            return Ok(dishiesDTO);
        }

        [Authorize(Policy = "RequiredModerator")]
        [HttpPost]
        public async Task<IActionResult> AddDish(NewDishDTO newDishDTO)
        {
            if (await _dishesService.DoesDishExistByName(newDishDTO.Name))
            {
                return Conflict($"Dish already exists by {newDishDTO.Name} name");
            }

            var dish = new Dish
            {
                Name = newDishDTO.Name,
                Description = newDishDTO.Description,
                AmountOfCaloriesInTheDish = newDishDTO.AmountOfCaloriesInTheDish
            };

            await _dishesService.AddNewDish(dish);

            return Created("api/orders", "");
        }
    }
}
