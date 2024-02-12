using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class Engineer : Employee
    {

        /// <summary>
        /// поле описывающее колличество разработанных проектов
        /// </summary>
        public int ProjectsCount { get; set; }


        // Конструктор без параметров
        public Engineer() { }

        // Конструктор с параметрами
        public Engineer(int projectsCount):base() { }

        /// <summary>
        /// метод расчета дополнения к зарплате инженера
        /// </summary>
        /// <param name="coefficient"></param>
        /// <returns></returns>
        public override double GetIncome(double coefficient)
        {
            return base.GetIncome(coefficient) + 4.8 * ProjectsCount;
        }


    }
}
