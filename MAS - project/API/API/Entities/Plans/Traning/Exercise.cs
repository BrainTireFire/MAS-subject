namespace API.Entities.Plans.Traning
{
    public abstract class Exercise
    {
        public int IdExercise { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Photo { get; set; }
        public string Video { get; set; }
        public string MuscleGroups { get; set; } = null!;
        public ICollection<ExerciseTraningPlan> ExerciseTraningPlans { get; set; } = new List<ExerciseTraningPlan>();
    }
}
