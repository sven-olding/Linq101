using LinqLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = ListManager.LoadSampleData();

            // people = people.OrderByDescending(x => x.LastName).ThenByDescending(x => x.YearsOfExperience).ToList();
            people = people.Where(x => x.YearsOfExperience >= 25).OrderByDescending(x => x.YearsOfExperience).ToList();

            foreach (var person in people)
            {
                Console.WriteLine($"{person.FullName} ({person.Birthday.ToShortDateString()}): Experience {person.YearsOfExperience} years");
            }

            Console.ReadLine();
        }
    }
}
