
namespace CoherentTrainingSystem
{
    public class Lecture : TrainingBase
    {
        public string Topic { get; set; }

        public Lecture() { }
        public Lecture(string description, string topic) : base(description)
        {
            Topic = topic;
        }

        public override TrainingBase Clone()
        {
            Lecture lecture = new Lecture(this.Description, this.Topic);

            return lecture;
        }
    }
}
