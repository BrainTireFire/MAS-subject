namespace API.Entities.Plans.Diet
{
    public class CompositionOfNutritionalValue
    {
        public int IdCompositionOfNutritionalValue { get; set; }
        public int IdDish { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public virtual Dish Dish { get; set; } = null!;

    }
}
