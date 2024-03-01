using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy18_4
{
    public class Student : Person
    {
        //Добавил свойство Курс
        public int Course { get; set; }

        // Конструктор с пятью параметрами для инициализации студента
        public Student(string firstName, string lastName, DateTime birthDate, string faculty, int course) : base(firstName, lastName, birthDate, faculty)
        {
            // Установил значение свойства Факультет
            Faculty = faculty;

            // Установил значение свойства Курс
            Course = course;
        }

        // Переопределенный метод Display для вывода информации о студенте
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"");
        }
    }


}
