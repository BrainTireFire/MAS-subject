namespace API.Entities.Plans.Traning
{
    public class Instrument
    {
        public int IdInstrument { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<ExerciseWithTheDevice> ExerciseWithTheDevices { get; set; } = new List<ExerciseWithTheDevice>();
    }
}
