using System.Security.Cryptography;

namespace Demo_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Control Statements 

            #region * Conditional Statements

            #region Example 01 [Year Quarter] - [If,Switch With Numeric type using Constant Pattern]

            //Console.Write("Please Enter A Month Number Existed in 1st Quarter : ");
            //int.TryParse(Console.ReadLine(), out int monthNumber);

            #region if else 
            //if(monthNumber==1)
            //    Console.WriteLine("January");
            //else if(monthNumber==2)
            //    Console.WriteLine("February");
            //else if (monthNumber==3)
            //    Console.WriteLine("March");
            //else
            //    Console.WriteLine("Try again Enter a month number.");

            #endregion

            #region switch  
            // Jump Table => روح شوف السبب في notes 
            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("January");
            //        break;
            //    case 2:
            //        Console.WriteLine("February");
            //        break;
            //    case 3:
            //        Console.WriteLine("March");
            //        break;
            //    default:
            //        Console.WriteLine("Try again Enter a month number.");
            //        break;
            //}
            //--------------------------------------------------------------------------------
            //--------------------------------------------------------------------------------
            // No Jump Table Will be Created 
            //لانه اقل من 3 cases
            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("January");
            //        break;
            //    case 2:
            //        Console.WriteLine("February");
            //        break;
            //    default:
            //        Console.WriteLine("Try again Enter a month number.");
            //        break;
            //}
            //--------------------------------------------------------------------------------
            //--------------------------------------------------------------------------------
            // Jump Table
            //لإن في قيم متتاليه ف هيعملهم jumb table والارقام اللي مش متتاليه هيعاملهم كانهم if else 
            // Here the jump table will be made from 1 -> 8
            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("January");
            //        break;
            //    case 1500:
            //        Console.WriteLine("no");
            //        break;
            //    case 2:
            //        Console.WriteLine("February");
            //        break;
            //    case 4:
            //        Console.WriteLine("aywaaa");
            //        break;
            //    case 3000:
            //        Console.WriteLine("othor");
            //        break;
            //    case 3:
            //        Console.WriteLine("March");
            //        break;
            //    case 8:
            //        Console.WriteLine("agust");
            //        break;

            //    default:
            //        Console.WriteLine("Try again Enter a month number.");
            //        break;
            //}

            #endregion

            #endregion

            #region Example 02 [Student Age] - [If,Switch With Numeric type using Relational Pattern C# 9.0]
            //Age is greater than 22 => Student Age Is greater than 22
            //Age is Less than 22 => Student Age Is Less than 22
            //Age is 22 => Student Age is 22
            //Console.Write("Enter Your age : ");
            //int.TryParse(Console.ReadLine(), out int age);

            #region if else 
            //if (age > 22)
            //    Console.WriteLine("Student Age Is greater than 22");
            //else if (age < 22)
            //    Console.WriteLine("Student Age Is Less than 22");
            //else
            //    Console.WriteLine("Student Age is 22");
            #endregion

            #region Switch
            //No Jump Table Will be Created
            // علشان دي  Relational Pattern
            //switch (age)
            //{
            //    case > 22:
            //        Console.WriteLine("Student Age Is greater than 22");
            //        break;
            //    case < 22:
            //        Console.WriteLine("Student Age Is Less than 22");
            //        break;
            //    default:
            //        Console.WriteLine("Student Age is 22");
            //        break;
            //}


            #endregion
            #endregion

            #region Example 03 [Student Name] - [If,Switch With String type]
            //name = Ahmed => Hello Ahmed
            //name = Amar => Hello Amar
            //name = Sasa => Hello Sasa

            //Console.Write("Enter Student Name : ");
            //string nameOfStudent = Console.ReadLine() ?? "No Name.";

            #region if else 
            //if(nameOfStudent== "Ahmed")
            //    Console.WriteLine("Hello Ahmed");
            //else if (nameOfStudent == "Amar")
            //    Console.WriteLine("Hello Amar");
            //else if (nameOfStudent == "Sasa")
            //    Console.WriteLine("Hello Sasa");
            #endregion

            #region Switch
            // No Jump Table Will Be Created
            // Compiler will generate a sequence of string comparisons
            //switch(nameOfStudent)
            //{
            //    case "Ahmed":
            //        Console.WriteLine("Hello Ahmed");
            //        break;
            //    case "Amar":
            //        Console.WriteLine("Hello Amar");
            //        break;
            //    case "Sasa":
            //        Console.WriteLine("Hello Sasa");
            //        break;
            //}

            #endregion

            #endregion

            #region Example 04 [Budget] - [Switch With Goto]
            // Budget is 1000 => Option 01
            // Budget is 2000 => Option 01 , Option 02
            // Budget is 3000 => Option 01 , Option 02 , Option 03
            //Console.Write("Please Enter Your Budget : ");
            //int.TryParse(Console.ReadLine(), out int Budget);

            //كده فيه تكرار والتكرار ده هيعملي مشكلة وانا بعمل maintenance
            // No Jump Table Will Be Created
            //switch (Budget)
            //{
            //    case 1000:
            //        Console.WriteLine("Option 01");
            //        break;
            //    case 2000:
            //        Console.WriteLine("Option 01");
            //        Console.WriteLine("Option 02");
            //        break;
            //    case 3000:
            //        Console.WriteLine("Option 01");
            //        Console.WriteLine("Option 02");
            //        Console.WriteLine("Option 03");
            //        break;
            //}
            //-------------------------------------------------------
            //-------------------------------------------------------
            //solve problem dublicate using GO TO
            // No Jump Table Will Be Created
            //switch (Budget)
            //{
            //    case 1000:
            //        Console.WriteLine("Option 01");
            //        break;
            //    case 2000:
            //        Console.WriteLine("Option 02");
            //        goto case 1000;
            //        break;
            //    case 3000:
            //        Console.WriteLine("Option 03");
            //        goto case 2000;
            //        break;
            //}
            #endregion

            #region GO TO
            //Retry:
            //Console.Write("Please Enter Your Name : ");
            //string name = Console.ReadLine();

            //if (name == "Mahmoud")
            //    goto Retry;
            //else
            //    Console.WriteLine($"Hello, {name}");
            #endregion
            #endregion

            #region * Evolution Of Switch in C#

            #region Evolution of switch in C# 7.0 [Pattern matching - Case guards (When)]
            // No Jump Table Will Be Created
            //object number = 2; // Boxing 

            #region Example 01 [Pattern matching on type]

            //switch(number)
            //{
            //    case int Value:
            //        Console.WriteLine($"Number is integer = {Value}");
            //        break;
            //    case double Value:
            //        Console.WriteLine($"Number is double = {Value}");
            //        break;
            //    case string str:
            //        Console.WriteLine($"Number is string = {str}");
            //        break;
            //    default:
            //        Console.WriteLine("Try Enter anthor data type.");
            //        break;
            //}





            #endregion

            #region Example 02 [Case guards (When)]
            //switch (number)
            //{
            //    case int Value when Value >2 && Value < 10:
            //        Console.WriteLine($"Number is integer = {Value}");
            //        break;
            //    case double Value:
            //        Console.WriteLine($"Number is double = {Value}");
            //        break;
            //    case string str:
            //        Console.WriteLine($"Number is string = {str}");
            //        break;
            //    default:
            //        Console.WriteLine("Try again Enter anthor data type.");
            //        break;
            //}





            #endregion

            #region Example 03 [User-Define Data Type]
            //object P1 = new Person() { Id = 1, name = "mahmoud ", age = 20 };
            //switch (P1)
            //{
            //    case int Value:
            //        Console.WriteLine($"Number is integer = {Value}");
            //        break;
            //    case double Value:
            //        Console.WriteLine($"Number is double = {Value}");
            //        break;
            //    case string str:
            //        Console.WriteLine($"Number is string = {str}");
            //        break;
            //    case Person P when P.Id>1:
            //        Console.WriteLine($"I am Person = {P}");
            //        break;
            //    default:
            //        Console.WriteLine("Try Enter anthor data type.");
            //        break;
            //}

            #endregion

            #endregion

            #region Evolution of switch in C# 8.0


            #region Example Switch Case Before Switch Expression [Pattern matching without alias name]
            //string input = Console.ReadLine();
            //string message;

            //switch (input)
            //{
            //    case "1":
            //        message = "Option01";
            //        break;
            //    case "2":
            //        message = "Option02";
            //        break;
            //    case "3":
            //        message = "Option03";
            //        break;
            //    default:
            //        message = "Invalid";
            //        break;
            //}
            //Console.WriteLine(message);
            #endregion

            #region Example 02: Switch Expressions [Constant Pattern - Discard Pattern]
            //string input = Console.ReadLine();
            //string message;

            //message = input switch
            //{
            //    "1" => "Option01",
            //    "2" => "Option02",
            //    "3" => "Option03",
            //    //  ( _ ) : Discard Pattern
            //    _ => "Invalid"

            //};
            //Console.WriteLine(message);

            #endregion

            #region  Example 03 [Property Pattern]
            //Person P1 = new Person() {Id=10,name="Mahmoud",age=21 };
            //string message;

            //message = P1 switch
            //{
            //    { name: "Mahmoud", age: 2 } => $"Hello, Mahmoud",
            //    { name: "Omar" } => "Hello Omar",
            //    _ => "Invalid"
            //};
            //Console.WriteLine(message);

            #endregion

            #region Example 04 [Nullable Type - Relational Patterns (Partially)]
            //int? number = null;
            //string message;
            //message = number switch
            //{
            //    int num when num > 10 => "number greater than 10",
            //    null => "Value is nullaable",
            //    _ => "Invalid"
            //};
            //Console.WriteLine(message);

            #endregion


            #endregion

            #region Evolution of switch in C# 9.0

            #region [Relational patterns - Logical patterns ]

            //Person P1 = new Person() {Id=10,name="Mahmoud",age=21 };
            //string message;

            //message = P1 switch
            //{
            //    { Id: > 1 and <= 10, name: "Mahmoud" } => "Your Name Is Mahmoud",
            //    { Id: 11 or 14, name: "Ahemd" } => "Your Name Is Ahmed",
            //    _ => "Invalid"
            //};
            //Console.WriteLine(message);


            #endregion


            #endregion

            #endregion

            #endregion

        }
    }
}
