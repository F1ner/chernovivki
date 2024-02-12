using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class Manager : Employee
    {

        /// <summary>
        /// поле описывающее колличество продаж в тоннах
        /// </summary>
        public double SalesVolume { get; set; }

        /// <summary>
        /// метод расчета дополнения к зарплате менеджера
        /// </summary>
        /// <param name="coefficient"></param>
        /// <returns></returns>
        public override double GetIncome(double coefficient)
        {
            return base.GetIncome(coefficient) + (SalesVolume > 100 ? MinSalary * 0.01 : 0);
        }


    }

   
}
