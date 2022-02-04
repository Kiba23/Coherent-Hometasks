
namespace CoherentTrainingSystem
{
    public class PracticalLesson : TrainingBase
    {
        public string TaskConditionLink { get; set; }
        public string SolutionLink { get; set; }

        public PracticalLesson() { }
        public PracticalLesson(string description, string taskConditionLink, string solutionLink) : base(description)
        {
            TaskConditionLink = taskConditionLink;
            SolutionLink = solutionLink;
        }

        public override TrainingBase Clone()
        {
            PracticalLesson practicalLesson = new PracticalLesson(this.Description, this.TaskConditionLink, this.SolutionLink);

            return practicalLesson;
        }
    }
}
