using Demo_07.Salead;
using Demo_07.Static;

namespace Demo_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Static 
            //Utilities utilities = new Utilities(1, 2);

            //Console.WriteLine(utilities.MeterToCM(10));
            //utilities.X = 10;
            //utilities.Y = 20;
            //Console.WriteLine(utilities.MeterToCM(10));// No Update طول لما  attribute مبتأثرش على function روح اعملها Static وبكده هتوفر في heap 

            //Solve Problem 
            //Console.WriteLine(Utilities.MeterToCM(10));

            //Console.WriteLine(Utilities.CalcArea(10));
            //**********************************************************************************************************
            //static constructor بيتنادى بس في اول استخدام للكلاس 
            //  * يعني بيتم استدعاؤه مره واحده فقط 

            //Utilities utilities = new Utilities(1, 2); // One Case ->  Create obj from class 

            //Test test = new Test();// Two Case -> Create obj from class -> Inhirt from another class

            //Console.WriteLine(Utilities.MeterToCM(10));
            #endregion


            GrandChild child = new GrandChild();
            child.Salary = 10;
            Console.WriteLine(child.Salary);


        }
    }
}
