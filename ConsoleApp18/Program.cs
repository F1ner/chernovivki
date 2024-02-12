using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            ///масив обьектов
            List<Employee> employees = new List<Employee>()
            {
             new Manager { FirstName = "", LastName = "", BirthDate = new DateTime(1980, 1, 1), MinSalary = 0, SalesVolume = 1 },
             new Manager { FirstName = "Иван", LastName = "Петров", BirthDate = new DateTime(1980, 1, 1), MinSalary = 50, SalesVolume = 12 },
             new Engineer { FirstName = "Мария", LastName = "Сидорова", BirthDate = new DateTime(1985, 5, 8), MinSalary = 40, ProjectsCount = 10 },
             new Engineer { FirstName = "Максим", LastName = "Игнатенко", BirthDate = new DateTime(2007,4 ,20 ), MinSalary = 150, ProjectsCount = 10 },
             new Engineer { FirstName = "Илья", LastName = "Абабий", BirthDate = new DateTime(2006,5 ,31 ), MinSalary =100 , ProjectsCount = 10 },
             new Engineer { FirstName = "Максим", LastName = "Гулин", BirthDate = new DateTime(2007, 3,27 ), MinSalary =700 , ProjectsCount = 10 },
            };
            ///цикл для выдачи результатов
            foreach (var employee in employees)
            {
                employee.PrintInfo();
                Console.WriteLine($"Доход: {employee.GetIncome(1.2)}");
                Console.WriteLine();
            }
            // Суммарный доход
            double totalSalary = 0;
            // Максимальный доход менеджера
            double maxManagerSalary = 0;
            foreach (Employee employee in employees)
            {
                // Вывод информации о сотруднике
                employee.PrintInfo();
                // Расчет дохода
                double income = employee.GetIncome(1.2);
                // Добавление дохода к суммарному
                totalSalary += income;
                // Проверка, является ли сотрудник менеджером
                if (employee is Manager)
                {
                    // Сравнение дохода с максимальным
                    if (income > maxManagerSalary)
                    {
                        maxManagerSalary = income;
                    }
                }
                // Вывод дохода
                Console.WriteLine($"Доход: {income:F2}");
                Console.WriteLine();
            }
            // Вывод суммарного дохода
            Console.WriteLine($"Суммарный доход: {totalSalary:F2}");
            // Вывод максимального дохода менеджера
            Console.WriteLine($"Максимальный доход менеджера: {maxManagerSalary:F2}");
            Console.ReadKey();
        }
    }
}
