using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class Motivator
    {
        public int IdMotivator { get; set; }
        public string Name { get; set; }
        public string Pseudonym { get; set; }
        [NotMapped]
        public List<string> MotivatingWords { get; set; }
        public ICollection<AppUser> Users { get; set; } = new List<AppUser>();
    }
}
