namespace API.Entities.Plans.Diet
{
    public class DishDietPlan
    {
        public virtual int IdDishDietPlan { get; set; }
        public virtual int IdDietPlan { get; set; }
        public virtual int IdDish { get; set; }
        public virtual Dish Dish { get; set; } = null!;
        public virtual DietPlan DietPlan { get; set; } = null!;
    }
}
