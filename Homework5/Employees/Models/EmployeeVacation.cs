using System;

namespace Vacations.Models
{
    public class EmployeeVacation
    {
        public string Name { get; set; }
        public DateTime StartVacation { get; set; }
        public DateTime EndVacation { get; set; }
        public TimeSpan VacationPeriod
        {
            get
            {
                return EndVacation - StartVacation;
            }
        }


        public EmployeeVacation(string name, DateTime startVacation, DateTime endVacation)
        {
            if (startVacation < endVacation) 
            {
                Name = name;
                StartVacation = startVacation;
                EndVacation = endVacation;
            }
            else
            {
                throw new ArgumentException("Date isn't correct.");
            }
        }

        public double GetDaysOfVacation()
        {
            return (EndVacation - StartVacation).TotalDays;
        }

        public override string ToString()
        {
            return $"{Name} was on vacation from {StartVacation.ToShortDateString()} to {EndVacation.ToShortDateString()}";
        }
    }
}
