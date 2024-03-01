using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy18_4
{
    public class Employee : Person
    {
       

        // Конструктор с четырьмя параметрами для инициализации сотрудника
        public Employee(string firstName, string lastName, DateTime birthDate, string faculty) : base(firstName, lastName, birthDate, faculty)
        {
            // Установил значение свойства Факультет
            Faculty = faculty;
        }

        // Переопределенный метод Display для вывода информации о сотруднике
        public override void Display()
        {
            base.Display();
        }
    }

}
