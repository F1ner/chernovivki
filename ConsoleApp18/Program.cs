using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ababiy18_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создал список объектов класса Person
            List<Person> people = new List<Person>
        {
          

            // Добавил 1 студента
            new Student("Петр", "Петров", new DateTime(1998, 2, 10), "Факультет", 2),

            // Добавил 1 преподавателя
            new Teacher("Алексей", "Алексеев", new DateTime(1965, 12, 25), "Факультет", "Преподаватель", 35),

              // Добавил 1 сотрудника
            new Employee("Сергей", "Сидоров", new DateTime(1970, 3, 20), "Факультет"),

             // Добавил 2 студента
            new Student("Евгений", "Иосиф", new DateTime(1999, 4, 11), "Факультет", 4),

            // Добавил 2 преподавателя
            new Teacher("Григорий", "Донцой", new DateTime(1978, 7, 26), "Факультет", "Преподаватель", 35),

              // Добавил 2 сотрудника
            new Employee("Илья", "Сидоров", new DateTime(1990, 1, 16), "Факультет"),
        };

            // Вывел информацию о всех людях в списке
            foreach (var person in people)
            {
                person.Display();
            }

            Console.WriteLine();

            // Нашел людей, чей возраст попадает в заданный диапазон
            var ageRange = Enumerable.Range(18, 31); // Диапазон возрастов от 18 до 30 лет включительно
            var filteredPeople = people.Where(p => ageRange.Contains(p.Age));

            Console.WriteLine("Возраст от 18 до 30 лет:");
            foreach (var person in filteredPeople)
            {
                person.Display();
            }

            Console.ReadKey();
        }
    }
}
