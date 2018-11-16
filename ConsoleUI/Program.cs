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

            int yearsOfExperience = people.Sum(x => x.YearsOfExperience);

            Console.WriteLine("Years of experience: " + yearsOfExperience);

            //people = people.OrderByDescending(x => x.LastName).ThenByDescending(x => x.YearsOfExperience).ToList();
            // people = people.Where(x => x.YearsOfExperience >= 25).OrderByDescending(x => x.YearsOfExperience).ToList();

            //foreach (var person in people)
            //{
            //    Console.WriteLine($"{person.FullName} ({person.Birthday.ToShortDateString()}): Experience {person.YearsOfExperience} years");
            //}

            var selectedPeople = from p in people
                     orderby p.LastName descending, p.YearsOfExperience descending
                     where p.YearsOfExperience >= 25
                     select p;
            foreach (var person in selectedPeople)
            {
                Console.WriteLine($"{person.FullName} ({person.Birthday.ToShortDateString()}): Experience {person.YearsOfExperience} years");
            }


            string stringNotEmpty = "hello extension method";

            Console.WriteLine(stringNotEmpty.HasValue());

            string stringEmpty = string.Empty;
            Console.WriteLine(stringEmpty.HasValue());

            var integers = new List<int> { 1, 2, 3, 4, 4, 5 };
            Console.WriteLine(integers.First(x => x > 2));

            Console.WriteLine(integers.Last());

            // Console.WriteLine(integers.SingleOrDefault(x=>x==4));

            var emptyList = new List<string>();

            Console.WriteLine(emptyList.DefaultIfEmpty("null string").First());

            Console.ReadKey();
        }
    }

    public static class StringExtensions
    {
        public static bool HasValue(this string value)
        {
            return !string.IsNullOrEmpty(value);
        }
    }
}
