using System.Text;

namespace Demo_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region  Looping | Iteration Statements

            #region For - Foreach

            //int[] numbers = { 10, 20, 30, 40, 50 };
            ////dublicated 
            //Console.WriteLine("Number 0 of: {0}", numbers[0]);
            //Console.WriteLine("Number 1 of: {0}", numbers[1]);
            //Console.WriteLine("Number 2 of: {0}", numbers[2]);
            //Console.WriteLine("Number 3 of: {0}", numbers[3]);
            //Console.WriteLine("Number 4 of: {0}", numbers[4]);
            //-----------------------------------------------------------------
            //-----------------------------------------------------------------
            //Reduce repetition to improve maintenance
            //بص على notes

            //for (int i = 0; i < 5; i++)
            //{
            //    numbers[i] += 10;
            //    Console.WriteLine("Number {0} of: {1}", i, numbers[i]);
            //}

            //------------------------------------------------------------------
            //------------------------------------------------------------------
            //foreach (int item in numbers)
            //{
            //    item += 10; // error علشان هيا واخده نسخة مش هتنفع تتعدل شوف notes 
            //    Console.WriteLine("Number of: {1}", item);
            //}

            #endregion

            #region While - do While

            #region do While
            //int number;
            //bool isParse;

            //do
            //{
            //    Console.WriteLine("Enter the even number.");
            //    isParse = int.TryParse(Console.ReadLine(), out number);

            //} while (number % 2 == 1 || !isParse);
            //Console.Clear();
            //Console.WriteLine("The even number is: {0}", number);

            #endregion

            #region While 
            //Console.Write("Please Enter Number: ");
            //bool isParse = int.TryParse(Console.ReadLine(), out int number);

            //if (isParse)
            //{
            //    while (number <= 10)
            //    {
            //        Console.WriteLine("Number of: {0}", number);
            //        number++;
            //    }
            //}





            #endregion

            #endregion
            #endregion

            #region String 

            #region Example 01 

            //string Name = new string("Route"); // 10 bytes
            //                                   //"Route" → literal
            //                                   //🔹 It is stored in the String Intern Pool automatically.
            //                                   //new string("Route") → 🔹 Creates a new, independent instance of "Route" in Heap.
            //                                   //Name → 🔹 موجود في Stack -> بيشاور على النسخة اللي في Heap(مش اللي في pool)
            //Console.WriteLine($"Name = {Name}");
            //Console.WriteLine($"HashCode = {Name.GetHashCode()}");
            ////------------------------------------------------------------
            //string Name02 = "Route"; // 10 bytes
            //                         //"Route" already exists in String Intern Pool.
            //                         //Name02 →🔹 موجود في Stack،-> 🔹 بيشاور مباشرة على النسخة في pool(اللي اتخزنت من السطر الأول).

            //Console.WriteLine($"Name02 = {Name02}");
            //Console.WriteLine($"HashCode2 = {Name02.GetHashCode()}");

            //Console.WriteLine(object.ReferenceEquals(Name, Name02));

            ////notes
            ////Name و Name02 يشاوروا على أماكن مختلفة.
            ////القيم متساوية (== ✅)، لكن المراجع مختلفة (ReferenceEquals ❌).
            ////بص على الصورة اللي في demo

            #endregion

            #region Example 02
            //string name01 = new string("Mahmoud");
            //string name02 = "Mahmoud";

            //Console.WriteLine("Your Name is : {0}",name01);
            //Console.WriteLine("Hash Code to name01 : {0}",name01.GetHashCode());

            //Console.WriteLine("Your Name is : {0}",name02);
            //Console.WriteLine("Hash Code to name02 : {0}", name02.GetHashCode());

            //name02 = name01;

            //Console.WriteLine("After assigned.");

            //Console.WriteLine("Your Name is : {0}", name01);
            //Console.WriteLine("Hash Code to name01 : {0}", name01.GetHashCode());

            //Console.WriteLine("Your Name is : {0}", name02);
            //Console.WriteLine("Hash Code to name02 : {0}", name02.GetHashCode());

            //Console.WriteLine(ReferenceEquals(name01,name02));//true
            //// لو ال hashCode بتاع name01 بيساوي hashCode بتاع name02 ده مش معناه انهم بيشاوروا على نفس المكان في heap
            ////لكن لازم ReferenceEquals(Name, Name02) ترجع true علشان اعرف انهم بيشاوروا على نفس المكان 

            //Console.WriteLine("After Changing.");
            //name01 = "Ahmed";

            //Console.WriteLine("Your Name is : {0}", name01);
            //Console.WriteLine("Hash Code to name01 : {0}", name01.GetHashCode());

            //Console.WriteLine("Your Name is : {0}", name02);
            //Console.WriteLine("Hash Code to name02 : {0}", name02.GetHashCode());
            //-----------------------------------------------------------------------------------------
            //notes 
            // ليه ال string immutable علشان هيا array of character و array is fixed size

            #endregion

            #region Example 03
            //string message = "Hello, ";
            //// message بيشاور على hello في heap 
            //Console.WriteLine("Your Message Is : {0}",message);
            //Console.WriteLine("Your Message to Hash Code Is : {0}",message.GetHashCode());

            //Console.WriteLine("Message after assign.");

            //message += "Mahmoud";
            ////message بيشاور على hello, Mahmoud وده ال object الجديد
            //Console.WriteLine("Your Message Is : {0}", message);
            //Console.WriteLine("Your Message to Hash Code Is : {0}", message.GetHashCode());


            #endregion

            #endregion

            #region String method
            //string? name = "   Mahmoud   ";
            //Console.WriteLine(name.Length);
            //Console.WriteLine(name.Trim());
            //Console.WriteLine(name.TrimEnd());
            //Console.WriteLine(name.TrimStart());
            //Console.WriteLine(name.Replace('o','S'));
            //Console.WriteLine(name.Replace("Mah","Moh"));
            //Console.WriteLine(name.Substring(1,3));
            //Console.WriteLine(name.Contains("Mahmoud"));
            //Console.WriteLine(name.Contains('o'));
            //Console.WriteLine(name.ToUpper());
            //Console.WriteLine(name.ToLower());
            #endregion

            #region String Builder
            ////StringBuilder name ="mahmoud";  //Error لانه مش هيعرف يعمل casting
            //StringBuilder name = new StringBuilder("Mahmoud");

            //Console.WriteLine("Your Name Is: {0}",name);
            //Console.WriteLine("Your Name To Hash Code IS: {0}",name.GetHashCode());

            //Console.WriteLine("After Assign.");

            //name.Append(" Mohamed");
            //Console.WriteLine("Your Name Is: {0}", name);
            //Console.WriteLine("Your Name To Hash Code IS: {0}", name.GetHashCode());

            //شوف السبب في الصورة اللي في demo
            #endregion

            #region String method
            //StringBuilder Message = new("Hello, ");

            //Console.WriteLine(Message);
            //Console.WriteLine("============================");

            //Message.Append("Ya ");
            //Console.WriteLine(Message);

            //Console.WriteLine("============================");
            //Message.AppendLine("Hoda ");      
            //Console.WriteLine(Message);
            //Console.WriteLine("============================");
            //Message.Append("Your Age is 21"); 
            //Console.WriteLine(Message);
            //Console.WriteLine("============================");
            //Message.Replace('H', 'h');
            //Console.WriteLine(Message);

            //Message.Replace("hoda", "Ahmed");
            //Console.WriteLine(Message);
            //Console.WriteLine("============================");

            //Message.Remove(2,5);
            //Console.WriteLine(Message);
            //Console.WriteLine("============================");
            //Message.AppendJoin("_", "\nMahmoud", "Ahmed");
            //Console.WriteLine(Message);




            #endregion

        }
    }
}
