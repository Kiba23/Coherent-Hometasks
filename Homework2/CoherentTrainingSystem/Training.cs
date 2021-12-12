using System.Collections.Generic;
using System.Linq;

namespace CoherentTrainingSystem
{
    public class Training : TrainingBase
    {
        public List<TrainingBase> LecturesAndPractice = new List<TrainingBase>();

        public void Add(TrainingBase training)
        {
            LecturesAndPractice.Add(training);
        }

        public void Add(List<TrainingBase> trainings)
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
            Training deepcopyTraining = new Training();

            // Copying not the reference but the values itself
            deepcopyTraining.LecturesAndPractice.AddRange(this.LecturesAndPractice);

            return deepcopyTraining;
        }
    }
}
