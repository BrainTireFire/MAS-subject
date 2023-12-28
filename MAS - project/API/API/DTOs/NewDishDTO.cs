namespace API.DTOs
{
    public class NewDishDTO
    {
        public virtual string Name { get; set; } = null!;
        public virtual string Description { get; set; } = null!;
        public virtual int AmountOfCaloriesInTheDish { get; set; }
    }
}
