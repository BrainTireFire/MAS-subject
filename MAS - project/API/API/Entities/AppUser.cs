using API.Entities.Plans.Diet;
using API.Entities.Plans.Traning;
using Microsoft.AspNetCore.Identity;

namespace API.Entities
{
    public class AppUser : IdentityUser<int>
    {
        // public int IdMotivator { get; set; }
       // public string Gender { get; set; }
        //public DateTime DateOfBirth { get; set; }
       // public string Country { get; set; }
        public ICollection<AppUserRole> UserRoles { get; set; }
        public virtual ICollection<DietPlan> DietPlans { get; set; } = new List<DietPlan>();
        public virtual ICollection<DietPlan> DietPlansAdmins { get; set; } = new List<DietPlan>();
        public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
        public virtual ICollection<TrainingPlan> TrainingPlans { get; set; } = new List<TrainingPlan>();
        public virtual ICollection<TrainingPlan> TrainingPlansAdmins { get; set; } = new List<TrainingPlan>();
        //public virtual Motivator Motivator { get; set; } = null!;
    }
}
