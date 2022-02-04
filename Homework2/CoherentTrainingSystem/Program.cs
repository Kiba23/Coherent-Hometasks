using System;
using System.Collections.Generic;

namespace CoherentTrainingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var training = new Training();

            List<TrainingBase> setOfTrainings = new List<TrainingBase>()
            {
                new Lecture(),
                new PracticalLesson(),
                new PracticalLesson()
            };

            training.Add(setOfTrainings);

            // IsPractical method testing
            Console.WriteLine(training.IsPractical());

            // Clone method testing, especially does list has changed
            Training training2 = training.Clone();

            Console.WriteLine($"Size before changing - {training.LecturesAndPractice.Count}");
            Console.WriteLine($"Size before changing - {training2.LecturesAndPractice.Count}");

            training.LecturesAndPractice.Add(new Lecture());

            Console.WriteLine($"Size after changing - {training.LecturesAndPractice.Count}");
            Console.WriteLine($"Size after changing - {training2.LecturesAndPractice.Count}");
        }
    }
}
