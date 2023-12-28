namespace API.DTOs.GETS
{
    internal class GetDietPlansDTO
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int PlanCalories { get; set; }
        public bool Active { get; set; }
        public ICollection<GetDishDTO> Dishes { get; set; } = null!;
       // public ICollection<GetUserDTO> Users { get; set; } = null!;
    }
}