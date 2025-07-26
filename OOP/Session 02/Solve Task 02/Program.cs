namespace Solve_Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 01

            //Person[] PersonArr = new Person[3];

            ////person 01
            //Person p01 = new Person();
            //p01.Age = 25;
            //p01.Name = "Amr";

            ////person 02
            //Person p02 = new Person();
            //p02.Age = 21;
            //p02.Name = "Ahmed";

            ////person 03
            //Person p03 = new Person();
            //p03.Age = 22;
            //p03.Name = "Mahmoud";

            //PersonArr[0] = p01;
            //PersonArr[1] = p02;
            //PersonArr[2] = p03;

            //for (int i = 0; i < PersonArr.Length; i++)
            //{
            //    Console.WriteLine($"PersonNo : {i + 1} | PersonName : {PersonArr[i].Name} | PersonAge : {PersonArr[i].Age}");
            //}
            #endregion


            #region 02
            //Point P01 = new Point();
            //Point P02 = new Point();

            //Console.Write("Enter X to Point 01 : ");
            //int.TryParse(Console.ReadLine(), out int X1);

            //Console.Write("Enter Y to Point 01 : ");
            //int.TryParse(Console.ReadLine(), out int Y1);

            //Console.Write("Enter X to Point 02 : ");
            //int.TryParse(Console.ReadLine(), out int X2);

            //Console.Write("Enter Y to Point 02 : ");
            //int.TryParse(Console.ReadLine(), out int Y2);

            //P01.X = X1;
            //P01.Y = Y1;

            //P02.X = X2;
            //P02.Y = Y2;

            //double Calc = Math.Pow((Y2 - Y1), 2) + Math.Pow((X2 - X1), 2);
            //double res = Math.Sqrt(Calc);

            //Console.WriteLine($"Calculates the distance between 2D Point: {res}");

            ////anathor way
            //Console.WriteLine($"Calculates the distance between 2D Point: {Point.GetDistance(P01, P02)}"); 
            #endregion

            #region 03
            Person p01 = new Person();
            Person p02 = new Person();
            Person p03 = new Person();
            Person.SetPerson(ref p01, ref p02, ref p03);
            Console.Clear();
            Console.WriteLine($"Name and age of the oldest person : {Person.GetOldestPerson(p01, p02, p03)}");
            #endregion

            #region 04
            //Rectangle R = new Rectangle();
            //R.Width = 10.2;
            //R.Height = 10.2;

            //Console.WriteLine($"Area : {R.Area}"); 
            #endregion


        }
    }
}
