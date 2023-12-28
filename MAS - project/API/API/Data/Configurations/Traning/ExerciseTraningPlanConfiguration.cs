using API.Entities.Plans.Traning;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.Configurations.Traning
{
    public class ExerciseTraningPlanConfiguration : IEntityTypeConfiguration<ExerciseTraningPlan>
    {
        public void Configure(EntityTypeBuilder<ExerciseTraningPlan> builder)
        {
            builder.ToTable("ExerciseTraningPlan");
            builder.HasKey(e => e.IdExerciseTraningPlan);

            builder.HasOne(e => e.TrainingPlan)
                .WithMany(e => e.ExerciseTraningPlans)
                .HasForeignKey(e => e.IdTraningPlan);

            builder.HasMany(e => e.Exercises)
                   .WithMany(e => e.ExerciseTraningPlans);

            //builder.HasData(new List<ExerciseTraningPlan>
            //{
            //    new ExerciseTraningPlan
            //    {
            //        IdExerciseTraningPlan = 1,
            //        IdExercise = 1,
            //        IdTraningPlan = 1
            //    },
            //    new ExerciseTraningPlan
            //    {
            //        IdExerciseTraningPlan = 2,
            //        IdExercise = 2,
            //        IdTraningPlan = 2
            //    },
            //    new ExerciseTraningPlan
            //    {
            //        IdExerciseTraningPlan = 3,
            //        IdExercise = 3,
            //        IdTraningPlan = 3
            //    },
            //    new ExerciseTraningPlan
            //    {
            //        IdExerciseTraningPlan = 4,
            //        IdExercise = 4,
            //        IdTraningPlan = 4
            //    },
            //    new ExerciseTraningPlan
            //    {
            //        IdExerciseTraningPlan = 5,
            //        IdExercise = 5,
            //        IdTraningPlan = 5
            //    },
            //    new ExerciseTraningPlan
            //    {
            //        IdExerciseTraningPlan = 6,
            //        IdExercise = 1,
            //        IdTraningPlan = 2
            //    },
            //    new ExerciseTraningPlan
            //    {
            //        IdExerciseTraningPlan = 7,
            //        IdExercise = 2,
            //        IdTraningPlan = 3
            //    },
            //    new ExerciseTraningPlan
            //    {
            //        IdExerciseTraningPlan = 8,
            //        IdExercise = 3,
            //        IdTraningPlan = 4
            //    },
            //    new ExerciseTraningPlan
            //    {
            //        IdExerciseTraningPlan = 9,
            //        IdExercise = 4,
            //        IdTraningPlan = 5
            //    },
            //    new ExerciseTraningPlan
            //    {
            //        IdExerciseTraningPlan = 10,
            //        IdExercise = 5,
            //        IdTraningPlan = 1
            //    },
            //});
        }
    }
}
