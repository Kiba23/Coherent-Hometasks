using System;
using System.Collections.Generic;
using System.Linq;

namespace Vacations.Models
{
    public class Organization
    {
        private List<EmployeeVacation> Vacations;


        public Organization(params EmployeeVacation[] employeeVacations)
        {
            for (int i = 0; i < employeeVacations.Length; i++)     // correctness check, if two dates intersects within the same person
            {
                for (int j = i + 1; j < employeeVacations.Length - 1; j++)
                {
                    if (employeeVacations[i].Name == employeeVacations[j].Name && employeeVacations[i].StartVacation <= employeeVacations[j].EndVacation
                        && employeeVacations[i].EndVacation >= employeeVacations[j].StartVacation)
                    {
                        throw new ArgumentException("Dates intersects.");
                    }
                }
            }

            Vacations = new List<EmployeeVacation>();
            Vacations.AddRange(employeeVacations);
        }

        public TimeSpan GetAverageVacation()
        {
            TimeSpan result = default(TimeSpan);
            foreach (var vacation in Vacations)
            {
                result += vacation.VacationPeriod;
            }
            return result / Vacations.Count;
        }

        public IEnumerable<(string Name, TimeSpan AvgVacation)> GetAvgVacationPerEmployee()
        {
            var totalVacationOfPerson = Vacations.GroupBy(v => v.Name);

            TimeSpan summedVacationTime = default(TimeSpan);
            foreach (var person in totalVacationOfPerson)       // iterating through employees (persons)
            {
                foreach (var vacation in person)                // iterating through vacations
                {
                    summedVacationTime += vacation.VacationPeriod;
                }
                yield return (person.Key, summedVacationTime / person.Count());
                summedVacationTime = default(TimeSpan);         // setting sum to zero again, for a new person
            }
        }

        public IEnumerable<(string Month, int NumberOfEmployees)> GetStatisticByMonth()
        {
            var months = Enumerable.Range(1, 12);

            foreach (var month in months)
            {
                yield return (month.ToString(), Vacations.Count(v => v.StartVacation.Month <= month && v.EndVacation.Month >= month));
            }
        }

        public IEnumerable<DateTime> GetDatesWithoutVacation()
        {
            for (DateTime date = DateTime.Parse("01.01.2021"); date <= DateTime.Parse("31.12.2021"); date = date.AddDays(1))
            {
                if (Vacations.All(v => v.StartVacation > date || v.EndVacation < date))
                {
                    yield return date.Date;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
