using API.Entities.Plans.Traning;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.Configurations.Traning
{
    public class ExerciseWithoutTheDeviceConfiguration : IEntityTypeConfiguration<ExerciseWithoutTheDevice>
    {
        public void Configure(EntityTypeBuilder<ExerciseWithoutTheDevice> builder)
        {
            builder.ToTable("ExerciseWithoutTheDevice");

            //builder.HasKey(e => e.IdExerciseDevice);

            builder.Property(e => e.Name).HasMaxLength(100);
            builder.Property(e => e.Description).HasMaxLength(300);

            builder.HasData(new List<ExerciseWithoutTheDevice>
            {
                new ExerciseWithoutTheDevice
                {
                    IdExercise = 1,
                    Name = "Push-ups",
                    Description = "A classic bodyweight exercise targeting the chest, shoulders, and triceps.",
                    Photo = "pushups.jpg",
                    Video = "pushups.mp4",
                    MuscleGroups = "Chest, Shoulders, Triceps"
                },
                new ExerciseWithoutTheDevice
                {
                    IdExercise = 2,
                    Name = "Squats",
                    Description = "A compound lower body exercise targeting the quadriceps, hamstrings, and glutes.",
                    Photo = "squats.jpg",
                    Video = "squats.mp4",
                    MuscleGroups = "Quadriceps, Hamstrings, Glutes"
                },
                new ExerciseWithoutTheDevice
                {
                    IdExercise = 3,
                    Name = "Plank",
                    Description = "An isometric core exercise that strengthens the abs, back, and shoulders.",
                    Photo = "plank.jpg",
                    Video = "plank.mp4",
                    MuscleGroups = "Abs, Back, Shoulders"
                },
                new ExerciseWithoutTheDevice
                {
                    IdExercise = 4,
                    Name = "Lunges",
                    Description = "A compound lower body exercise targeting the quadriceps, hamstrings, and glutes.",
                    Photo = "lunges.jpg",
                    Video = "lunges.mp4",
                    MuscleGroups = "Quadriceps, Hamstrings, Glutes"
                },
                new ExerciseWithoutTheDevice
                {
                    IdExercise = 5,
                    Name = "Burpees",
                    Description = "A full-body exercise that combines squats, push-ups, and jumps.",
                    Photo = "burpees.jpg",
                    Video = "burpees.mp4",
                    MuscleGroups = "Chest, Shoulders, Legs, Abs"
                },
            });
        }
    }
}
