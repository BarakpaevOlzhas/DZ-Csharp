using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypePerson
{
    public class Person
    {
        public string FirstName { set; get; }

        public string MiddleName { set; get; }

        public string LastName { set; get; }

        public int Age { set; get; }
    }

    static public class Show
    {
        static public string ShowAllStats(Person person)
        {
            return string.Format(person.MiddleName + " " + person.FirstName + " " + person.LastName + " " + person.Age);
        }

    }
}
