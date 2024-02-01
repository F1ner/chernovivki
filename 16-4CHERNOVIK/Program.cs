using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_4CHERNOVIK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 2: Создать массив из N объектов структуры Employee.
            Console.Write("Введите количество сотрудников (N): ");
            int n = int.Parse(Console.ReadLine());

            Employee[] employees = new Employee[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nВведите информацию о сотруднике {i + 1}:");

                Console.Write("Табельный номер: ");
                int employeeId = int.Parse(Console.ReadLine());

                Console.Write("ФИО: ");
                string fullName = Console.ReadLine();

                Console.Write("Дата рождения (гггг-мм-дд): ");
                DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());

                Console.Write("Должность: ");
                string position = Console.ReadLine();

                Console.Write("Оклад: ");
                decimal salary = decimal.Parse(Console.ReadLine());

                employees[i] = new Employee(employeeId, fullName, dateOfBirth, position, salary);
            }

            // Задание 3: Вывести информацию о возрасте каждого сотрудника на данный момент времени.
            Console.WriteLine("\nИнформация о сотрудниках и их возрасте:");

            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("| Табельный номер |          ФИО          | Дата рождения |    Должность    |      Оклад      | Возраст |");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");

            foreach (var employee in employees)
            {
                Console.WriteLine($"| {employee.EmployeeId,-15} | {employee.FullName,-21} | {employee.DateOfBirth.ToString("yyyy-MM-dd"),-14} | {employee.Position,-16} | {employee.Salary,-15} | {employee.CalculateAge(),-7} |");
            }

            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}
