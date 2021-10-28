using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;


namespace example3
{

    public class Candidate:Person
    {
        private string _dismissalReason;
        public Candidate()
        {
          Random rnd = new Random();
            _dismissalReason = Convert.ToString((DismissalReason)rnd.Next(0, 7));//random dismissal
        }
        public override void Display()
        {
            Console.WriteLine($"Hello, I am {FullName}. I want to be a {JobTitle} ({JobDescription})" +
                $" with a salary from {JobSalary}. I quit my previous job for a reason of {_dismissalReason}.");
        }
    }
}
 
    enum DismissalReason
    {
        FamilyReasons,
        ProfessionalGrowthLack,
        LowSalary,
        BadTeamMicroclimate,
        LackManagementUnderstanding,
        Other,
        Null
    }

