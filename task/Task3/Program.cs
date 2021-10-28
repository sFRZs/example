using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int maxValueOfPerson = rnd.Next(25);
            var personfactory = new PersonFactory();
            var employees = new List<Employee>();
            var candidates = new List<Candidate>();
          
            for (int i = 0; i < maxValueOfPerson; i++)
            {
                personfactory.GeneratePerson(Convert.ToString((Persons)rnd.Next(2)), candidates, employees);
            }
            foreach(var person in employees)
            {
                person.Display();
                Console.WriteLine();
            }
            foreach(var person in candidates)
            {
                person.Display();
                Console.WriteLine();

            }
        }
    }
}
enum Persons
{
    Candidate,
    Employee
}
