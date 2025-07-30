using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task
{
    class Develop
    {

        #region Properties  
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        #endregion

        #region Constructor
        public Develop(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        #endregion
        #region Method 

        public string NameDayMonthYear()
        {
            try
            {

                CultureInfo c = new CultureInfo("en-US");
                DateTime date = new DateTime(year, month, day);
                return $"Day : {date.DayOfWeek}\nMonth : {date.ToString("MMMM", c)}\nYear : {date.Year}";
            }
            catch(Exception ex)
            {
                return $"Invalid date : {ex.Message}";
            }
        }
        




        #endregion
    }
}
