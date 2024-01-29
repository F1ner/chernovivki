using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy16_3
{
    class DateClass
    {
        DateTime date;
     
       
        public DateClass() { }

        public DateClass(int year, int month, int day)
        {
            //this.year = year;
            //this.month = month;
            //this.day = day;
            date = new DateTime(year, month, day);
        }

        public DateTime Date
        {
            get { return date; }
            set{ date = value; }
        }

     

        public DateTime Yesterday()
        {
            return Date.AddDays(-1);


            //Console.WriteLine("Дата:");
            //DateTime date1;
            //DateTime.TryParse(Console.ReadLine(), out date);


        }

        public DateTime Tomorrow()
        {
            return Date.AddDays(1);

            //Console.WriteLine("Дата:");
            //DateTime date2;
            //DateTime.TryParse(Console.ReadLine(), out date);


        }

      
        public int EndMonth() 
        {
            return DateTime.DaysInMonth(date.Year, date.Month)-date.Day;

        }


        
    }

    }

