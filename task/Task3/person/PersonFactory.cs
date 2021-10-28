using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;

namespace example3
{
    public class PersonFactory
    {
        public PersonFactory()
        { }
        public  void GeneratePerson(string person, List<Candidate> candidates, List<Employee> employees)
        {
            if (person == "Candidate")

            {
                CreatePerson<Candidate>(candidates);
            }
            else
            {
                CreatePerson<Employee> (employees);
            }

        }

        private void CreatePerson<PersonFactory>(List<PersonFactory> person) where PersonFactory : Person
        {
            var faker = new Faker<PersonFactory>()
            .RuleFor(c => c.id, f => Guid.NewGuid())
            .RuleFor(c => c.FirstName, f => f.Name.FirstName())
            .RuleFor(c => c.LastName, f => f.Name.LastName())
            .RuleFor(c => c.JobTitle, f => f.Name.JobTitle())
            .RuleFor(c => c.JobDescription, f => f.Name.JobDescriptor())
            .RuleFor(c => c.JobSalary, f => f.Finance.Amount(50m, 10000m));
            person.Add(faker.Generate());
        }
    }
}   
