using API.Entities.Plans.Diet;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.Configurations.Diet
{
    public class DishConfiguration : IEntityTypeConfiguration<Dish>
    {
        public void Configure(EntityTypeBuilder<Dish> builder)
        {
            builder.ToTable("Dish");

            builder.HasKey(e => e.IdDish);

            builder.Property(e => e.Name).HasMaxLength(100);
            builder.Property(e => e.Description).HasMaxLength(300);

            builder.HasOne(e => e.CompositionOfNutritionalValue)
                   .WithOne(e => e.Dish)
                   .HasForeignKey<CompositionOfNutritionalValue>(e => e.IdCompositionOfNutritionalValue)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(new List<Dish>
            {
                new Dish
                {
                    IdDish = 1,
                    IdCompositionOfNutritionalValue = 1,
                    Name = "Grilled Chicken Salad",
                    Description = "A healthy salad with grilled chicken breast.",
                    AmountOfCaloriesInTheDish = 350
                },
                new Dish
                {
                    IdDish = 2,
                    IdCompositionOfNutritionalValue = 2,
                    Name = "Vegetable Stir-Fry",
                    Description = "A stir-fried medley of fresh vegetables.",
                    AmountOfCaloriesInTheDish = 250
                },
                new Dish
                {
                    IdDish = 3,
                    IdCompositionOfNutritionalValue = 3,
                    Name = "Salmon with Roasted Vegetables",
                    Description = "Oven-roasted salmon served with a side of roasted vegetables.",
                    AmountOfCaloriesInTheDish = 400
                },
                new Dish
                {
                    IdDish = 4,
                    IdCompositionOfNutritionalValue = 4,
                    Name = "Quinoa Salad",
                    Description = "A nutritious salad with quinoa, vegetables, and vinaigrette dressing.",
                    AmountOfCaloriesInTheDish = 300
                },
                new Dish
                {
                    IdDish = 5,
                    IdCompositionOfNutritionalValue = 5,
                    Name = "Mediterranean Pasta",
                    Description = "Pasta dish with tomatoes, olives, feta cheese, and herbs.",
                    AmountOfCaloriesInTheDish = 450
                }
            });
        }
    }
}
