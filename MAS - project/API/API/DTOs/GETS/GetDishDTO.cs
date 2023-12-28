namespace API.DTOs.GETS
{
    internal class GetDishDTO
    {
        public int IdDish { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int AmountOfCaloriesInTheDish { get; set; }
    }
}