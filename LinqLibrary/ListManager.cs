using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqLibrary
{
    class ListManager
    {
        public static List<Person> LoadSampleData()
        {
            List<Person> output = new List<Person>();

            output.Add(new Person { LastName = "Corey", FirstName = "Tim", Birthday = Convert.ToDateTime("25.2.1970"), YearsOfExperience = 20 });
            output.Add(new Person { LastName = "Smith", FirstName = "Joe", Birthday = Convert.ToDateTime("31.3.1970"), YearsOfExperience = 24 });
            output.Add(new Person { LastName = "Storm", FirstName = "Sue", Birthday = Convert.ToDateTime("3.6.1974"), YearsOfExperience = 21 });
            output.Add(new Person { LastName = "Jones", FirstName = "Sara", Birthday = Convert.ToDateTime("4.8.1964"), YearsOfExperience = 30 });
            output.Add(new Person { LastName = "Doe", FirstName = "Jamie", Birthday = Convert.ToDateTime("23.1.1968"), YearsOfExperience = 28 });
            output.Add(new Person { LastName = "Smith", FirstName = "Mary", Birthday = Convert.ToDateTime("13.4.1965"), YearsOfExperience = 32 });

            return output;
        }
    }
}
