namespace API.Entities.Plans.Diet
{
    public class Dish
    {
        public virtual int IdDish { get; set; }
        public virtual int? IdCompositionOfNutritionalValue { get; set; }
        public virtual string Name { get; set; } = null!;
        public virtual string Description { get; set; } = null!;
        public virtual int AmountOfCaloriesInTheDish { get; set; }
        public virtual ICollection<DishDietPlan> DishDietPlans { get; set; } = new List<DishDietPlan>();
        public virtual CompositionOfNutritionalValue CompositionOfNutritionalValue { get; set; } = null!;
    }
}
