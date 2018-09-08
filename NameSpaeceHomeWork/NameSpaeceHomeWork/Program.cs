using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypePerson;

namespace NameSpaeceHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.FirstName = "Олжас";

            person.MiddleName = "Баракпаев";

            person.LastName = "Булатович";

            person.Age = 15;

            Console.WriteLine(Show.ShowAllStats(person));

            Console.ReadLine();
        }
    }
}
