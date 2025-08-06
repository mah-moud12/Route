using Solve_Task.Question_05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Part02
{
    class Duration
    {
        #region Properties
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; } 
        #endregion



        #region Constructor
        public Duration(int Hours, int Minutes, int Seconds)
        {

            this.Hours = Hours + (Minutes / 60);
            this.Minutes = (Minutes + (Seconds / 60)) % 60;
            this.Seconds = Seconds % 60;

        }
        public Duration()
        {
            
        }
        public Duration(int totalSecond)
        {
            Hours = (totalSecond / 60) / 60;
            Minutes = (totalSecond / 60) % 60;
            Seconds = (totalSecond % 60);
        }

        #endregion


        #region Method
        public override string ToString()
        {
            if (Hours > 0)
                return $"Hours: {Hours}, Minutes :{Minutes}, Seconds :{Seconds}";
            return $"Minutes :{Minutes}, Seconds :{Seconds}";
        }
        #endregion

        //D3=D1+D2
        public static Duration operator +(Duration D1, Duration D2)
        {
            return new Duration
            {
                Hours = D1.Hours + D2.Hours,
                Minutes = D1.Minutes + D2.Minutes,
                Seconds = D1.Seconds + D2.Seconds
            };
        }

        //D3=D1 + 7800
        public static Duration operator +(Duration D1, int second)
        {
            Duration D2 = new Duration(second);
            return new Duration
            {
                Hours = D1.Hours + D2.Hours,
                Minutes = D1.Minutes + D2.Minutes,
                Seconds = D1.Seconds + D2.Seconds
            };
        }
        //D4=666+D1
        public static Duration operator +(int second, Duration D1)
        {
            Duration D2 = new Duration(second);
            return new Duration
            {
                Hours = D1.Hours + D2.Hours,
                Minutes = D1.Minutes + D2.Minutes,
                Seconds = D1.Seconds + D2.Seconds
            };
        }

        //D3= ++D1(Increase One Minute)
        public static Duration operator ++(Duration D1)
        {
            return new Duration()
            {
                Hours = D1.Hours,
                Minutes = D1.Minutes + 1,
                Seconds=D1.Seconds
            };
        }
        //D3 = --D2(Decrease One Minute)
        public static Duration operator --(Duration D1)
        {
            return new Duration()
            {
                Hours = D1.Hours,
                Minutes = D1.Minutes - 1,
                Seconds = D1.Seconds
            };
        }
        //D1= D1 -D2
        public static Duration operator -(Duration D1, Duration D2)
        {
            return new Duration
            {
                Hours = D1.Hours - D2.Hours,
                Minutes = D1.Minutes - D2.Minutes,
                Seconds = D1.Seconds - D2.Seconds
            };
        }

        //If(D1>D2)
        public static bool operator >(Duration D1, Duration D2)
        {
            return (D1.Hours > D2.Hours);
        }
        public static bool operator <(Duration D1, Duration D2)
        {
            return (D1.Hours < D2.Hours);
        }
        //-----------------------------------------------------------

        //If(D1<=D2)
        public static bool operator <=(Duration D1, Duration D2)
        {
            return (D1.Hours <= D2.Hours);
        }
        public static bool operator >=(Duration D1, Duration D2)
        {
            return (D1.Hours >= D2.Hours);
        }
        //-------------------------------------------------------------

        //If (D1)
        public static bool operator true(Duration D1)
        {
            return (D1.Hours>0);
        }
        public static bool operator false(Duration D1)
        {
            return (D1.Hours < 0);
        }

        //DateTime Obj = (DateTime)D1
        public static explicit operator DateTime(Duration D1)
        {
            return new DateTime(2025, 8, 6, D1.Hours, D1.Minutes, D1.Seconds);
        }
    }
}
