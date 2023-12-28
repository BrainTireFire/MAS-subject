using API.Entities.Plans.Traning;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.Configurations.Traning
{
    public class ExerciseWithTheDeviceConfiguration : IEntityTypeConfiguration<ExerciseWithTheDevice>
    {
        public void Configure(EntityTypeBuilder<ExerciseWithTheDevice> builder)
        {
            builder.ToTable("ExerciseWithTheDevice");

            //builder.HasKey(e => e.IdExerciseDevice);

            builder.Property(e => e.Name).HasMaxLength(100);
            builder.Property(e => e.Description).HasMaxLength(300);

            builder.HasOne(e => e.Instrument)
                   .WithMany(e => e.ExerciseWithTheDevices)
                   .HasForeignKey(e => e.IdInstrument);

            builder.HasData(new List<ExerciseWithTheDevice>
            {
                new ExerciseWithTheDevice
                {
                    IdExercise = 6,
                    IdInstrument = 1,
                    Name = "Bench Press",
                    Description = "A compound exercise for the upper body that primarily targets the chest, shoulders, and triceps.",
                    Photo = "benchpress.jpg",
                    Video = "benchpress.mp4",
                    MuscleGroups = "Chest, Shoulders, Triceps"
                },
                new ExerciseWithTheDevice
                {
                    IdExercise = 7,
                    IdInstrument = 2,
                    Name = "Dumbbell Bicep Curls",
                    Description = "An isolation exercise targeting the biceps using dumbbells.",
                    Photo = "bicepcurls.jpg",
                    Video = "bicepcurls.mp4",
                    MuscleGroups = "Biceps"
                },
                new ExerciseWithTheDevice
                {
                    IdExercise = 8,
                    IdInstrument = 3,
                    Name = "Kettlebell Swings",
                    Description = "A dynamic full-body exercise targeting the hips, glutes, and hamstrings.",
                    Photo = "kettlebellswings.jpg",
                    Video = "kettlebellswings.mp4",
                    MuscleGroups = "Glutes, Hamstrings"
                },
                new ExerciseWithTheDevice
                {
                    IdExercise = 9,
                    IdInstrument = 4,
                    Name = "Lat Pulldown",
                    Description = "An upper body exercise targeting the back and biceps using a lat pulldown machine.",
                    Photo = "latpulldown.jpg",
                    Video = "latpulldown.mp4",
                    MuscleGroups = "Back, Biceps"
                },
                new ExerciseWithTheDevice
                {
                    IdExercise = 10,
                    IdInstrument = 4,
                    Name = "Incline Bench Press",
                    Description = "A compound exercise for the upper body that targets the upper chest, shoulders, and triceps.",
                    Photo = "inclinebenchpress.jpg",
                    Video = "inclinebenchpress.mp4",
                    MuscleGroups = "Upper Chest, Shoulders, Triceps"
                }
            });
        }
    }
}
