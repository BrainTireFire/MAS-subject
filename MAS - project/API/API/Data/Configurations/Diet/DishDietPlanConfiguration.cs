using API.Entities.Plans.Diet;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.Configurations.Diet
{
    public class DishDietPlanConfiguration : IEntityTypeConfiguration<DishDietPlan>
    {
        public void Configure(EntityTypeBuilder<DishDietPlan> builder)
        {
            builder.ToTable("DishDietPlan");
            builder.HasKey(e => e.IdDishDietPlan);

            builder.HasOne(e => e.DietPlan)
                .WithMany(e => e.DishDietPlans)
                .HasForeignKey(e => e.IdDietPlan)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.Dish)
               .WithMany(e => e.DishDietPlans)
               .HasForeignKey(e => e.IdDish)
               .OnDelete(DeleteBehavior.Cascade);

            //builder.HasMany<Dish>(nameof(DishDietPlan.Dishes))
            //    .WithMany(nameof(Dish.DishDietPlans))
            //    .UsingEntity<DishDietPlanDish>(
            //        j => j
            //            .HasOne(d => d.Dish)
            //            .WithMany()
            //            .HasForeignKey(d => d.IdDish),
            //        j => j
            //            .HasOne(d => d.DishDietPlan)
            //            .WithMany()
            //            .HasForeignKey(d => d.IdDishDietPlan),
            //        j =>
            //        {
            //            j.ToTable("DishDietPlanDish");
            //            j.HasKey(d => new { d.IdDish, d.IdDishDietPlan });
            //        }
            //    );

            //.UsingEntity(j => j.ToTable("DishDietPlans")); ;

            //builder.HasData(new List<DishDietPlan>
            //{
            //    new DishDietPlan
            //    {
            //        IdDishDietPlan = 1,
            //        IdDietPlan = 1,
            //        IdDish = 1
            //    },
            //    new DishDietPlan
            //    {
            //        IdDishDietPlan = 2,
            //        IdDietPlan = 1,
            //        IdDish = 2
            //    },
            //    new DishDietPlan
            //    {
            //        IdDishDietPlan = 3,
            //        IdDietPlan = 2,
            //        IdDish = 3
            //    },
            //    new DishDietPlan
            //    {
            //        IdDishDietPlan = 4,
            //        IdDietPlan = 3,
            //        IdDish = 4
            //    },
            //    new DishDietPlan
            //    {
            //        IdDishDietPlan = 5,
            //        IdDietPlan = 4,
            //        IdDish = 5
            //    },
            //    new DishDietPlan
            //    {
            //        IdDishDietPlan = 6,
            //        IdDietPlan = 4,
            //        IdDish = 1
            //    },
            //    new DishDietPlan
            //    {
            //        IdDishDietPlan = 7,
            //        IdDietPlan = 5,
            //        IdDish = 3
            //    },
            //    new DishDietPlan
            //    {
            //        IdDishDietPlan = 8,
            //        IdDietPlan = 5,
            //        IdDish = 4
            //    },
            //    new DishDietPlan
            //    {
            //        IdDishDietPlan = 9,
            //        IdDietPlan = 5,
            //        IdDish = 5
            //    }
            //});
        }
    }
}
