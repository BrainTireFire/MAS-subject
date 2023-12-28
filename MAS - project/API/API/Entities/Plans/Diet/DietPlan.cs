namespace API.Entities.Plans.Diet
{
    public class DietPlan
    {
        public virtual int IdDietPlan { get; set; }
        public virtual int? IdUser { get; set; }
        public virtual string Name { get; set; } = null!;
        public virtual string Description { get; set; } = null!;
        public virtual int PlanCalories { get; set; }
        public virtual bool Active { get; set; }
        public virtual ICollection<DishDietPlan> DishDietPlans { get; set; } = new List<DishDietPlan>();
        public virtual AppUser? AdminsAndModerator { get; set; } = null!;
        public virtual AppUser? User { get; set; } = null;
    }
}
