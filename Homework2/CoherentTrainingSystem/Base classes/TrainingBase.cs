
namespace CoherentTrainingSystem
{
    public abstract class TrainingBase
    {
        public string Description { get; set; }

        public TrainingBase() { }
        public TrainingBase(string description) 
        {
            Description = description;
        }

        public abstract TrainingBase Clone();
    }
}
