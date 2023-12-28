using API.Entities.Plans.Diet;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.Configurations.Diet
{
    public class CompositionOfNutritionalValueConfiguration : IEntityTypeConfiguration<CompositionOfNutritionalValue>
    {
        public void Configure(EntityTypeBuilder<CompositionOfNutritionalValue> builder)
        {
            builder.ToTable("CompositionOfNutritionalValue");

            builder.HasKey(e => e.IdCompositionOfNutritionalValue);

            builder.Property(e => e.Name).HasMaxLength(100);
            builder.Property(e => e.Description).HasMaxLength(300);

            builder.HasData(new List<CompositionOfNutritionalValue>
            {
                new CompositionOfNutritionalValue
                {
                    IdCompositionOfNutritionalValue = 1,
                    IdDish = 1,
                    Name = "Protein",
                    Description = "High protein content in grilled chicken salad."
                },
                new CompositionOfNutritionalValue
                {
                    IdCompositionOfNutritionalValue = 2,
                    IdDish = 2,
                    Name = "Fiber",
                    Description = "Rich in dietary fiber due to various vegetables in stir-fry."
                },
                new CompositionOfNutritionalValue
                {
                    IdCompositionOfNutritionalValue = 3,
                    IdDish = 3,
                    Name = "Omega-3",
                    Description = "Salmon provides a good source of omega-3 fatty acids."
                },
                new CompositionOfNutritionalValue
                {
                    IdCompositionOfNutritionalValue = 4,
                    IdDish = 4,
                    Name = "Vitamins",
                    Description = "Quinoa salad is packed with essential vitamins and minerals."
                },
                new CompositionOfNutritionalValue
                {
                    IdCompositionOfNutritionalValue = 5,
                    IdDish = 5,
                    Name = "Mediterranean Flavors",
                    Description = "Mediterranean pasta offers a delightful blend of flavors and textures."
                }
            });
        }
    }
}
