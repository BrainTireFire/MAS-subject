using API.Entities.Plans.Diet;

namespace API.DTOs
{
    public class NewPlanDTO
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int PlanCalories { get; set; }
        public bool Active { get; set; }
        public ICollection<NewDishDietPlanDTO> DishDietPlans { get; set; } = new List<NewDishDietPlanDTO>();
    }
}
