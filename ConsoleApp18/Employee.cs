using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class Employee
    {
       
        // Имя
        public string firstName;
        // Фамилия
        public string lastName;
        // Дата рождения
        public DateTime birthDate;
        // Минимальная зарплата
        public double minSalary;
       

        
        // Конструктор без параметров
        public Employee() { }

        // Конструктор с параметрами
        public Employee(string firstName, string lastName, DateTime birthDate, double minSalary)
        {
            // Инициализация полей
            firstName = FirstName;
            lastName = LastName;
            birthDate = BirthDate;
            minSalary = MinSalary;
        }
        

        
        // Имя (свойство get/set)
        public string FirstName
        {
            get { return (firstName != "") ? firstName : "Неизвестно"; }
            set { firstName = value; }
        }

        // Фамилия (свойство get/set)
        public string LastName
        {
            get { return (lastName != "") ? lastName : "Неизвестно"; }
            set { lastName = value; }
        }

        // Дата рождения (свойство get/set)
        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        // Минимальная зарплата (свойство get/set)
        public double MinSalary
        {
            get { return minSalary; }
            set {
                if (value < 1)

                    Console.WriteLine("Такой зарплаты не бывает");

                else

                    minSalary = value;
            }
        }
        

       
        // Виртуальный метод вывода информации о сотруднике
        public virtual void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName}\n Дата рождения: {BirthDate.ToShortDateString()}\n Минимальная зарплата: {minSalary}");
        }

        // Виртуальный метод вычисления дохода
        public virtual double GetIncome(double coefficient)
        {
            // Расчет дохода по формуле k * p
            return coefficient * minSalary;
        }
        
    }
}
