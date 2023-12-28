namespace API.Entities.Plans.Traning
{
    public class ExerciseTraningPlan
    {
        public int IdExerciseTraningPlan { get; set; }
        public int IdExercise { get; set; }
        public int IdTraningPlan { get; set; }
        public ICollection<Exercise> Exercises { get; set; } = new List<Exercise>();
        public TrainingPlan TrainingPlan { get; set; } = null!;
    }
}
