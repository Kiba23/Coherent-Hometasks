using System;
using Vacations.Models;

namespace Vacations
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Init data and Testing Intersection of data
            var employees = new EmployeeVacation[] {
                new EmployeeVacation("Anton", DateTime.Parse("20.02.2021"), DateTime.Parse("20.04.2021")),
                new EmployeeVacation("Max", DateTime.Parse("10.12.2021"), DateTime.Parse("23.12.2021")),
                new EmployeeVacation("Alex", DateTime.Parse("02.11.2021"), DateTime.Parse("15.12.2021")),
                new EmployeeVacation("Anton", DateTime.Parse("10.07.2021"), DateTime.Parse("11.08.2021")),
                //new EmployeeVacation("Anton", DateTime.Parse("15.07.2021"), DateTime.Parse("22.08.2021")), // Exception case, becuase names and dates intersects
                new EmployeeVacation("Alex", DateTime.Parse("08.01.2021"), DateTime.Parse("14.01.2021")),
                new EmployeeVacation("Boris", DateTime.Parse("01.01.2021"), DateTime.Parse("31.01.2021")),
                new EmployeeVacation("Mark", DateTime.Parse("30.01.2021"), DateTime.Parse("05.02.2021"))
            };

            var organization = new Organization(employees);
            #endregion

            #region Testing Avg Vacation
            var averageVacation = organization.GetAverageVacation();
            Console.WriteLine($"Average vacation is - {averageVacation.ToString(@"dd\:hh")} - (days, hours).");
            Console.WriteLine();
            #endregion

            #region Testing Avg Vacation Per Employee
            foreach (var item in organization.GetAvgVacationPerEmployee())
            {
                Console.WriteLine(item.Name + " name - " + item.AvgVacation.ToString(@"dd\:hh") + " average vacation.");
            }
            Console.WriteLine();
            #endregion

            #region Testing Statistic By Month
            foreach (var item in organization.GetStatisticByMonth())
            {
                Console.WriteLine(item.Month + " month - " + item.NumberOfEmployees + " number of employees on vacation.");
            }
            Console.WriteLine();
            #endregion

            #region Testing Dates Without Vacation
            Console.WriteLine("Dates without vacation:");
            foreach (var date in organization.GetDatesWithoutVacation())
            {
                Console.WriteLine(date.ToShortDateString());
            }
            Console.WriteLine();
            #endregion
        }
    }
}
