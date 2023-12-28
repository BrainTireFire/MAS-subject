namespace API.Entities.Plans.Traning
{
    public class ExerciseWithTheDevice : Exercise
    {
        public int IdInstrument { get; set; }
        public Instrument Instrument { get; set; } = null!;
    }
}
