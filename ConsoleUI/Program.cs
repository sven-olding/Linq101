using System;
using System.Collections.Generic;
using System.Linq;
using LinqLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = ListManager.LoadSampleData();

            foreach(var person in people)
            {
                Console.WriteLine($"{person.FullName} ({person.Birthday.ToShortDateString()}): Experience {person.YearsOfExperience} years");
            }

            Console.ReadLine();
        }
    }
}
