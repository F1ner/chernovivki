using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Использование конструкторов класса Person
            Person person1 = new Person(); // вызов конструктора без параметров
            Person person2 = new Person(15,"John"); // вызов конструктора с двумя параметрами
            Person person3 = new Person(17,"Alice","Watson"); // вызов конструктора с тремя параметрами

            // Вывод информации о каждом объекте
            person1.DisplayInfo();
            person2.DisplayInfo();
            person3.DisplayInfo();


            Employee emp = new Employee();



            // Создание объекта производного класса и вызов метода вывода информации о сотруднике
            Employee employee = new Employee
            {
               Company="BBC",
                Job="Richwoman"
            };
            employee.DisplayInfo();

            // Создание ссылки типа базового класса на объект производного класса и вызов метода вывода состояния базового класса
            Person student = new Student
            {
                Birthdate = new DateTime(2000, 3, 10),
                Course = 2
            };
            student.DisplayInfo();

            Console.ReadLine();
        }
    }
}
