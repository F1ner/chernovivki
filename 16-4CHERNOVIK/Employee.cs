using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_4CHERNOVIK
{
    internal class Employee
    { // Поля класса Employee
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

        // Конструктор класса Employee
        public Employee(int employeeId, string fullName, DateTime dateOfBirth, string position, decimal salary)
        {
            EmployeeId = employeeId;
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            Position = position;
            Salary = salary;
        }

        // Метод для вычисления возраста сотрудника
        public int CalculateAge()
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - DateOfBirth.Year;

            if (currentDate < DateOfBirth.AddYears(age))
            {
                age--;
            }

            return age;
        }
        }
}
