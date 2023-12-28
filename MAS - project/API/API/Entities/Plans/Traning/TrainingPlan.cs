using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;
using API.Entities.Plans.Diet;

namespace API.Entities.Plans.Traning
{
    public class TrainingPlan
    {
        public int IdTrainingPlan { get; set; }
        public int IdUser { get; set; }
        public int IdAdminAndModerator { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int DegreeOfDifficulty { get; set; }
        public int TrainingLength { get; set; }
        public int NumberOfRepetitions { get; set; }
        public int NumberOfSeries { get; set; }
        public int NumberOfTrainingDaysPerWeek { get; set; }
        public bool Active { get; set; }
        public ICollection<ExerciseTraningPlan> ExerciseTraningPlans { get; set; } = new List<ExerciseTraningPlan>();
        public AppUser AdminAndModerator { get; set; } = null!;
        public AppUser Users { get; set; } = null!;
        //public ICollection<AppUser> Users { get; set; } = new List<AppUser>();
    }
}
