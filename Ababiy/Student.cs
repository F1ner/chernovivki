using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy
{
    class Student:Person
    {
        DateTime birthdate;
        int course;

        public Student(int age, string name, string surname, string company, string job, DateTime birthdate, int course):base(age, name, surname,company, job)
        { 
            this.birthdate = birthdate;this.course = course; 
        }

        //public Student(DateTime birthdate) { this.birthdate = birthdate; }

        //public Student(DateTime birthdate, int course):this(birthdate)
        //{
        //    this.course = course;
        //}

        public DateTime Birthdate { get; set; }

        public int Course { get; set; }

        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Birthdate: {birthdate} Course: {Course}");
        }


    }
}
