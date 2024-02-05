using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy
{
    class Person
    {
        int age;
        string name, surname;
        

        public Person() { }
        public Person(int age)
        {
            this.age = age;
        }
        public Person(int age,string name):this (age)
        {
            this.name = name;
        }
        public Person(int age, string name, string surname) :this(age, name)
        {
            this.surname = surname;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Age: {age}\t Name: {name}\t SurName: {surname}");
        }



      
    }
}
