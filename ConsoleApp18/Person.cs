using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy18_4
{
    public abstract class Person // Объявил абстрактный класс Person.
    {
       /// <summary>
       /// C
       /// </summary>
        public string FirstName { get ; set; } 
        public string LastName { get; set; } // Свойство для фамилии.
        public DateTime BirthDate { get; set; } // Свойство для даты рождения.
                                                // Добавил свойство Факультет
        public string Faculty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="birthDate"></param>
        /// <param name="faculty"></param>
        public Person(string firstName, string lastName, DateTime birthDate, string faculty) // Конструктор с тремя параметрами.
        {
            FirstName = firstName; // Инициализировал свойство FirstName.
            LastName = lastName; // Инициализировал свойство LastName.
            BirthDate = birthDate; // Инициализировал свойство BirthDate.
            Faculty = faculty;// Инициализировал свойство BirthDate.
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual void Display()
        {
            Console.WriteLine($"Имя: {FirstName} {LastName} Возраст: {Age}  Факультет: {Faculty} Курс: {Course}");
        }
       
        public int Age // Свойство для возраста.
        {
            get
            {
                var today = DateTime.Today; // Получил текущую дату.
                var age = today.Year - BirthDate.Year; // Вычислил количество лет, прожитых с момента рождения.

                if (today.Month < BirthDate.Month || (today.Month == BirthDate.Month && today.Day < BirthDate.Day)) // Если сегодняшняя дата еще не достигла дня рождения.
                {
                    age--; // Уменьшил количество лет на 1.
                }

                return age; // Вернул количество лет.
            }
        }
    }
}
