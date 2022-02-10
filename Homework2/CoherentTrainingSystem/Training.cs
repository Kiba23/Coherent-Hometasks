using System.Collections.Generic;
using System.Linq;

namespace CoherentTrainingSystem
{
    public class Training
    {
        public string Description { get; set; }
        public List<TrainingBase> LecturesAndPractice { get; private set; } = new List<TrainingBase>();

        public Training() { }
        public Training(string description)
        {
            Description = description;
        }

        public void Add(TrainingBase training)
        {
            LecturesAndPractice.Add(training);
        }
        public void Add(IEnumerable<TrainingBase> trainings)
        {
            LecturesAndPractice.AddRange(trainings);
        }
        public bool IsPractical()
        {
            return LecturesAndPractice.All(l => l is PracticalLesson);
        }
        public Training Clone()
        {
            // Creating a new object for a deep cloning
            Training clone = new Training(this.Description);

            // Copying not the reference but the values itself
            foreach (var item in this.LecturesAndPractice)
            {
                clone.Add(item.Clone());
            }
            return clone;
        }
    }
}
