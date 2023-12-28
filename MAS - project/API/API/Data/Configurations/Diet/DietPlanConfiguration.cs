using API.Entities.Plans.Diet;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.Configurations.Diet
{
    public class DietPlanConfiguration : IEntityTypeConfiguration<DietPlan>
    {
        public void Configure(EntityTypeBuilder<DietPlan> builder)
        {
            builder.ToTable("DietPlan");
            builder.HasKey(e => e.IdDietPlan);

            builder.HasOne(e => e.User)
                .WithMany(e => e.DietPlans)
                .HasForeignKey(e => e.IdUser)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.AdminsAndModerator)
                .WithMany(e => e.DietPlansAdmins)
                .HasForeignKey(e => e.IdDietPlan)
                .OnDelete(DeleteBehavior.Cascade);

            //builder.HasData(new List<DietPlan>
            //{
            //    new DietPlan
            //    {
            //        IdDietPlan = 1,
            //        IdUser = 1,
            //        Name = "Low Carb Diet",
            //        Description = "A diet plan that restricts carbohydrates intake.",
            //        PlanCalories = 1500,
            //        Active = true
            //    },
            //    new DietPlan
            //    {
            //        IdDietPlan = 2,
            //        IdUser = 2,
            //        Name = "Mediterranean Diet",
            //        Description = "A diet plan inspired by the Mediterranean region.",
            //        PlanCalories = 1800,
            //        Active = true
            //    },
            //    new DietPlan
            //    {
            //        IdDietPlan = 3,
            //        IdUser = 3,
            //        Name = "Vegetarian Diet",
            //        Description = "A diet plan that focuses on plant-based foods.",
            //        PlanCalories = 1600,
            //        Active = true
            //    },
            //    new DietPlan
            //    {
            //        IdDietPlan = 4,
            //        IdUser = 4,
            //        Name = "Keto Diet",
            //        Description = "A diet plan that emphasizes high-fat, low-carb foods.",
            //        PlanCalories = 2000,
            //        Active = true
            //    },
            //    new DietPlan
            //    {
            //        IdDietPlan = 5,
            //        IdUser = 5,
            //        Name = "Paleo Diet",
            //        Description = "A diet plan based on the types of foods presumed to have been eaten by early humans.",
            //        PlanCalories = 1700,
            //        Active = true
            //    }
            //});
        }
    }
}
