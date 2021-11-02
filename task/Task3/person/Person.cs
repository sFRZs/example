using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace example3
{
    public class Person: IDisplayable
    {
        public Guid id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public decimal JobSalary { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    
        public virtual void Display()
        {
            Console.WriteLine($"Hello, I'm {FullName}.");
        }
    }
}
