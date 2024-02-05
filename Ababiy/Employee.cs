using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy
{
    class Employee:Person
    {
        string company, job;

        //public Employee() { }

        //public Employee(string company) { this.company = company; }

        //public Employee(string company, string job) :this(company)
        //{
        //    this.job = job;
        //}

        public Employee(int age, string name, string surname, string company, string job):base(age, name, surname) { this.company = company; this.job = job; }
        public string Company { get; set; }
        public string Job { get; set; }

        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Company- {company}  Job-{job}");
        }


    }
}
