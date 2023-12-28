namespace API.Entities.Plans.Diet
{
    public class Recipe
    {
        public int IdRecipe { get; set; }
        public string Name { get; set; } = null!;
        public string IngredientsNeeded { get; set; } = null!;
        public string StepsToCreate { get; set; } = null!;
        // public ICollection<string> Photos { get; set; } = new List<string>();
        public bool Active { get; set; }
        public AppUser? User { get; set; } = null!;
    }
}
