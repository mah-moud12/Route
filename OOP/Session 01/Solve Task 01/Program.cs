namespace Solve_Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 01
            //for (int i = 0; i < 7; i++)
            //{
            //    WeekDay W = (WeekDay)i;

            //    Console.WriteLine(W);
            //}
            ////anthor way            
            //foreach (WeekDay W in Enum.GetValues(typeof(WeekDay)))
            //    Console.WriteLine(W); 
            #endregion

            #region 02
            //bool flagSeason;
            //Seasons Season;
            //Console.Write("Enter The Season : ");
            //do
            //{
            //    flagSeason = Enum.TryParse(Console.ReadLine(),ignoreCase: true, out Season);
            //} while (!flagSeason);

            //if (Season == Seasons.Spring)
            //{
            //    Console.Clear();
            //    for (int i = 3; i <= 5; i++)
            //    {
            //        Console.WriteLine($"Month {i} : {(Months)i}");
            //    }
            //}
            //else if (Season == Seasons.Summer)
            //{
            //    Console.Clear();
            //    for (int i = 6; i <= 8; i++)
            //    {
            //        Console.WriteLine($"Month {i} : {(Months)i}");
            //    }
            //}
            //else if (Season == Seasons.Autumn)
            //{
            //    Console.Clear();
            //    for (int i = 9; i <= 11; i++)
            //    {
            //        Console.WriteLine($"Month {i} : {(Months)i}");
            //    }
            //}
            //else if (Season == Seasons.Winter)
            //{
            //    Console.Clear();
            //    Console.WriteLine($"Month {12} : {(Months)12}");
            //    for (int i = 1; i <= 2; i++)
            //    {
            //        Console.WriteLine($"Month {i} : {(Months)i}");
            //    }
            //}
            #endregion

            #region 04
            Console.Write("Enter The Color : ");
            bool flagColor = Enum.TryParse(Console.ReadLine(), ignoreCase: true, out Colors color);
            if(flagColor)
                Console.WriteLine("Color is a primary color : {0}",color);
            else
                Console.WriteLine("Color is a not primary color.");


            #endregion
        }
    }
}
