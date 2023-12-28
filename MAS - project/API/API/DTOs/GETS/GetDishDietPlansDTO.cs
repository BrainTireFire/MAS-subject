namespace API.DTOs.GETS
{
    internal class GetDishDietPlansDTO
    {
        public ICollection<GetDishDTO> Dishes { get; set; } = null!;
    }
}