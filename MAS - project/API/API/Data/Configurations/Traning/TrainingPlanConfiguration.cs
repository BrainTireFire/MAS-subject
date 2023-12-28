using API.Entities.Plans.Traning;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.Configurations.Traning
{
    public class TrainingPlanConfiguration : IEntityTypeConfiguration<TrainingPlan>
    {
        public void Configure(EntityTypeBuilder<TrainingPlan> builder)
        {
            builder.ToTable("TrainingPlan");
            builder.HasKey(e => e.IdTrainingPlan);

            builder.HasOne(e => e.Users)
                .WithMany(e => e.TrainingPlans)
                .HasForeignKey(e => e.IdUser);

            builder.HasOne(e => e.AdminAndModerator)
                .WithMany(e => e.TrainingPlansAdmins)
                .HasForeignKey(e => e.IdAdminAndModerator);


            //builder.Entity<TrainingPlan>()
            //    .HasOne(e => e.AdminAndModerator)
            //    .WithMany(e => e.TrainingPlansAdmins)
            //    .IsRequired();

            //builder.Entity<TrainingPlan>()
            //    .HasOne(e => e.Users)
            //    .WithMany(e => e.TrainingPlans)
            //    .IsRequired();

            //builder.HasData(new List<TrainingPlan>
            //{
            //    new TrainingPlan
            //    {
            //        IdTrainingPlan = 1,
            //        Name = "Beginner Full-Body Workout",
            //        Description = "A beginner-level full-body workout routine",
            //        DegreeOfDifficulty = 1,
            //        TrainingLength = 45,
            //        NumberOfRepetitions = 10,
            //        NumberOfSeries = 3,
            //        NumberOfTrainingDaysPerWeek = 3,
            //        Active = true
            //    },
            //    new TrainingPlan
            //    {
            //        IdTrainingPlan = 2,
            //        Name = "Advanced Push-Pull Split",
            //        Description = "An advanced push-pull split workout routine",
            //        DegreeOfDifficulty = 3,
            //        TrainingLength = 60,
            //        NumberOfRepetitions = 8,
            //        NumberOfSeries = 4,
            //        NumberOfTrainingDaysPerWeek = 4,
            //        Active = true
            //    },
            //    new TrainingPlan
            //    {
            //        IdTrainingPlan = 3,
            //        Name = "Intermediate Cardio Circuit",
            //        Description = "An intermediate-level cardio circuit training routine",
            //        DegreeOfDifficulty = 2,
            //        TrainingLength = 30,
            //        NumberOfRepetitions = 15,
            //        NumberOfSeries = 5,
            //        NumberOfTrainingDaysPerWeek = 5,
            //        Active = true
            //    },
            //    new TrainingPlan
            //    {
            //        IdTrainingPlan = 4,
            //        Name = "Strength and Conditioning Program",
            //        Description = "A comprehensive strength and conditioning program",
            //        DegreeOfDifficulty = 3,
            //        TrainingLength = 75,
            //        NumberOfRepetitions = 6,
            //        NumberOfSeries = 5,
            //        NumberOfTrainingDaysPerWeek = 4,
            //        Active = true
            //    },
            //    new TrainingPlan
            //    {
            //        IdTrainingPlan = 5,
            //        Name = "Bodyweight HIIT Workout",
            //        Description = "A high-intensity bodyweight workout routine",
            //        DegreeOfDifficulty = 2,
            //        TrainingLength = 40,
            //        NumberOfRepetitions = 12,
            //        NumberOfSeries = 4,
            //        NumberOfTrainingDaysPerWeek = 3,
            //        Active = true
            //    }
            //});
        }
    }
}
