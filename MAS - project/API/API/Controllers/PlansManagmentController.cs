using API.DTOs;
using API.DTOs.GETS;
using API.Entities.Plans.Diet;
using API.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Transactions;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlansManagmentController : ControllerBase
    {
        private readonly IDbService _dbService;
        public PlansManagmentController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [Authorize(Policy = "RequiredModerator")]
        [HttpGet]
        public async Task<IActionResult> GetDietPlansData()
        {
            var dietPlans = await _dbService.GetDietPlansData();

            var dietPlanDTOs = dietPlans.Select(e => new GetDietPlansDTO
            {
                Name = e.Name,
                Description = e.Description,
                PlanCalories = e.PlanCalories,
                Active = e.Active,
                //Users = e.User.DietPlans.Select(p => new GetUserDTO
                //{
                //    Username = p.User.UserName,
                //    Gender = p.User.Gender,
                //    DateOfBirth = p.User.DateOfBirth,
                //    //Country = p.User.Country
                //}).ToList(),
                Dishes = e.DishDietPlans.Select(p => new GetDishDTO
                {
                    IdDish = p.Dish.IdDish,
                    Name = p.Dish.Name,
                    Description = p.Dish.Description,
                    AmountOfCaloriesInTheDish = p.Dish.AmountOfCaloriesInTheDish
                }).ToList()
            });

            return Ok(dietPlanDTOs);
        }

        [Authorize(Policy = "RequiredModerator")]
        [HttpPost]
        public async Task<IActionResult> AddNewDietPlanData(NewPlanDTO newPlanDTO)
        {
            if (await _dbService.GetDietPlanExistsByName(newPlanDTO.Name))
            {
                return Conflict($"Diet plan already exists by {newPlanDTO.Name} name");
            }

            int maxDietPlanId = (await _dbService.GetMaxIdFromDietPlansTable()) ?? 1;

            var planData = new DietPlan
            {
                IdDietPlan = maxDietPlanId + 1,
                Name = newPlanDTO.Name,
                Description = newPlanDTO.Description,
                PlanCalories = newPlanDTO.PlanCalories,
                Active = newPlanDTO.Active,
            };

            if (newPlanDTO.DishDietPlans.Count < 1)
            {
                return BadRequest("You didnt added the dishes to the diet plan");
            }

            //int maxDishDietPlanId = (int)await _dbService.GetMaxIdFromDishDietPlansTable();
            var dishDietPlan = new List<DishDietPlan>();
            foreach (var newDish in newPlanDTO.DishDietPlans)
            {
                var dish = await _dbService.GetDishById(newDish.IdDish);
                if (dish == null)
                {
                    return NotFound($"Dish with given ID - {newDish.IdDish} doesn't exist");
                }

                dishDietPlan.Add(new DishDietPlan
                {
                    //IdDishDietPlan = maxDishDietPlanId + 1,
                    IdDish = dish.IdDish,
                    IdDietPlan = planData.IdDietPlan,
                    DietPlan = planData,
                });
            }

            await _dbService.AddNewPlan(planData);
            await _dbService.AddDishDietPlan(dishDietPlan);


            return Created("api/PlansManagment", "");
        }
    }
}
