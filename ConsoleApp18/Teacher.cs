using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy18_4
{
    public class Teacher : Person
    {
     

        // Добавил свойство Должность
        public string Position { get; set; }

        // Добавил свойство Стаж
        public int Experience { get; set; }

        // Конструктор с шестью параметрами для инициализации преподавателя
        public Teacher(string firstName, string lastName, DateTime birthDate, string faculty, string position, int experience) : base(firstName, lastName, birthDate, faculty)
        {
            // Установил значение свойства Факультет
            Faculty = faculty;

            // Установил значение свойства Должность
            Position = position;

            // Установил значение свойства Стаж
            Experience = experience;
        }

        // Переопределенный метод Display для вывода информации о преподавателе
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"{Position} {Experience}");
        }
    }

}
