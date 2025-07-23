using Microsoft.VisualBasic;
using System.Diagnostics.Metrics;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Demo_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region (Fractions Or Float Point) And Discard

            float floatNumber = 10.1234567f;
            Console.WriteLine(floatNumber); // 10.123457

            double doubleNumber = 1.123456789123456789; // 1.1234567891234568
            Console.WriteLine(doubleNumber);

            decimal decimalNumber = 10.123456789123456789123456789m;
            Console.WriteLine(decimalNumber);

            //decimal mydecimalNumber = 100_000_000_000; // Underscores are for readability
            //Console.WriteLine(mydecimalNumber);

            //Console.WriteLine($"{mydecimalNumber:c}");

            //CultureInfo myculture = new CultureInfo("ar-Sa"); // Saudi Riyals
            //Console.WriteLine(mydecimalNumber.ToString("c", myculture));//100?000?000?000?00 ر.س.? 
            //                                             // => علشان لازم انزل اللغه العربية علشان الفورمات تشتغل
            #endregion

            #region Casting
            #region Implicit And Explicit Casting

            #region Example One 

            //int X = 1000; // 4 Byte In Stack
            //long Y =X; // 8 Byte In Stack - Implicit Casting[automation & Safe Casting]
            //Console.WriteLine(Y);

            //long num01 = 1000;
            //If you're trying to convert a value from type long to int, this is called "narrowing conversion", and it doesn't happen automatically.
            //int num02 = num01;// Erorr 
            //---------------------------------------------------------------------------------
            //---------------------------------------------------------------------------------
            //Solve Problem (Use Explicit Casting)
            //long num01 = 10000;
            //int num02 = (int)num01;
            //Console.WriteLine(num02);
            //---------------------------------------------------------------------------------
            //---------------------------------------------------------------------------------
            //Note:
            //If (num01) has a value larger than the maximum value of int(which is 2, 147, 483, 647), this conversion may cause the value to change completely(overflow occurs).
            //long num01 = 10000000000000000;
            //int num02 = (int)num01;
            //Console.WriteLine(num02);// Random Value [because (over flow)] 

            //Solve Problem (Use Checked)
            //checked
            //{
            //    long num01 = 10000000000000000;
            //    int num02 = (int)num01;
            //    unchecked
            //    {
            //        Console.WriteLine(num02);
            //    }
            //}//output: exception. System.OverflowException
            /*
                I did this because it was giving me an incorrect value, which could cause me a lot of problems. 
                So I did this so that it would give me an (Exception) instead of giving me an incorrect value that would cause me problems.
            */

            //طب علشان ميطلعليش  Exception يبقى لازم استخدم Protective Code 
            //---------------------------------------------------------------------------------
            //---------------------------------------------------------------------------------
            //Protective Code

            //long number01 = 12423654646545;

            //int number02 = number01;// Error بسبب انه مش هيقدر يحول تلقائي لازم استخدم Explicit

            //int number02 = (int)number01;// incorrect value 

            //solve Problem 

            //if(number01> int.MaxValue || number01< int.MinValue)
            //    Console.WriteLine("Exception Try Again.");
            //else
            //{
            //    int number02 = (int)number01;
            //    Console.WriteLine(number01);
            //}

            #endregion

            #region Example Two

            //int A = 15;
            //decimal B = A;
            //Console.WriteLine(B);
            //---------------------------------------------------------------------------------
            //---------------------------------------------------------------------------------
            //decimal C = 10.10m;
            ////int D = C;// Error بسبب انه مش هيقدر يحول تلقائي لازم استخدم Explicit
            //           // C=> 8 Byte , D=> 4 Byte

            //int D = (int)C;// Explicit Casting [May Cause Loss Of Data]
            //Console.WriteLine(D);

            #endregion



            #endregion

            #region Convert 
            //Class provides methods to convert between types 
            //It handles null values by converting to 0 
            //throws exceptions when the conversion is invalid or not supported => "abc" to int

            //---------------------------------------------------------------------------------
            //---------------------------------------------------------------------------------
            //Console.WriteLine("Please Enter Your Data");
            //Console.Write("Name : ");
            //string? name = Console.ReadLine(); // [Accept Null]

            //Console.Write("Age : ");
            //int Age = Convert.ToInt32(Console.ReadLine()); // [Explicit Casting]

            //Console.Write("Salary : ");
            //decimal salary = Convert.ToDecimal(Console.ReadLine());


            //Console.Clear();
            //Console.WriteLine("Employee Data :");
            //Console.WriteLine("Name is " + name);
            //Console.WriteLine("Age is " + Age);
            //Console.WriteLine("Salary is " + salary);
            #endregion

            #region Parse
            //Method is used to convert a string representation of a number into a numeric type 
            //throws exceptions when the string is  (invalid format) or is (null).

            //---------------------------------------------------------------------------------
            //---------------------------------------------------------------------------------
            //Console.WriteLine("Please Enter Your Data");
            //Console.Write("Name : ");
            //string? name = Console.ReadLine(); // [Accept Null]

            //Console.Write("Age : ");
            //int Age = int.Parse(Console.ReadLine()); // [Explicit Casting]


            //Console.Write("Salary : ");
            //decimal salary = decimal.Parse(Console.ReadLine());


            //Console.Clear();
            //Console.WriteLine("Employee Data :");
            //Console.WriteLine("Name is " + name);
            //Console.WriteLine("Age is " + Age);
            //Console.WriteLine("Salary is " + salary);

            #endregion

            #region Try Parse 

            //Method is a [safe] alternative to Parse.
            //Convert a string to a specified type and returns a [boolean] indicating success or failure. 
            //It does not throw exceptions.

            //---------------------------------------------------------------------------------
            //---------------------------------------------------------------------------------
            //Console.WriteLine("Please Enter Your Data");
            //Console.Write("Name : ");
            //string? name = Console.ReadLine(); // [Accept Null]

            //Console.Write("Age : ");
            //int Age ;
            //bool flagAge = int.TryParse(Console.ReadLine(), out Age);


            //Console.Write("Salary : ");
            //bool flagSalary = decimal.TryParse(Console.ReadLine(),out decimal salary);

            //Console.Clear();
            //Console.WriteLine("Employee Data :");
            //Console.WriteLine("Name is " + name);
            //Console.WriteLine("Age is " + Age);
            //Console.WriteLine("Salary is " + salary);
            #endregion

            #endregion


            #region Operators 

            #region Unary Operators [ ++ , -- ]
            //int X = 10;

            ////1. ++
            //// 1.1 PreFix [Increment and Then Print]
            //Console.WriteLine(++X); // 11
            //Console.WriteLine(X); // 11

            //// 1.2 PostFix [Print and Then Increment]
            //Console.WriteLine(X++); // 10 
            //Console.WriteLine(X); // 11


            ////2. --
            //// 2.1 PreFix [Decrement and Then Print]
            //Console.WriteLine(--X); // 9
            //Console.WriteLine(X); // 9

            //// 2.2 PostFix [Print and Then Decrement]
            //Console.WriteLine(X--); // 10 
            //Console.WriteLine(X); // 9
            #endregion

            #region Binary | Arithmetic Operators [+ , - , * , / , %]

            //int sumResult, subResult, mulResult, divResult, modResult;
            //int number01 = 6, number02 = 2;
            //sumResult = number01 + number02; // 8 
            //subResult = number01 - number02; // 4
            //mulResult = number01 * number02; // 12
            //divResult = number01 / number02; // 3
            //modResult = number01 % number02; // 0

            #endregion

            #region Assignment Operators [= , += , -= , *= , /= , %=]

            //int X;
            //X = 4;
            //X += 2; // X = X + 2
            //X -= 2; // X = X - 2
            //X *= 2; // X = X * 2
            //X /= 2; // X = X / 2
            //X %= 2; // X = X % 2

            #endregion

            #region Relational | Comparsion Operators [== , != , < , > , <=, >=]
            //int X = 10, Y = 10;

            //Console.WriteLine(X == Y); // True
            //Console.WriteLine(X != Y); // False 
            //Console.WriteLine(X > Y); // False 
            //Console.WriteLine(X < Y); // False
            //Console.WriteLine(X >= Y); // True 
            //Console.WriteLine(X <= Y); // True

            #endregion

            #region Logical Operators [! , && , ||]
            //// [Short Circuit]
            //Console.WriteLine(!true); // False
            //Console.WriteLine(false && true); // False
            //Console.WriteLine(false || true); // True 


            //Console.WriteLine(4 < 5 && 7 < 9); // True
            //Console.WriteLine(4 < 5 && 7 > 9); // False
            //Console.WriteLine(4 > 5 && 7 < 9); // False

            #endregion

            #region BitWise Operator [& , | , ^ , ~ , << , >> ]
            //// [Long Circuit]
            //Console.WriteLine(false & true); // False
            //Console.WriteLine(true | false); // True 
            //Console.WriteLine(false ^ true); // True 

            //int X = 5 , Y = 3; // X = 0101 , Y = 0011

            //Console.WriteLine(X & Y);  // 1 (0101 & 0011 = 0001)
            //Console.WriteLine(X | Y);  // 7 (0101 | 0011 = 0111)
            //Console.WriteLine(X ^ Y);  // 6 (0101 ^ 0011 = 0110) => [(XOR)]
            //Console.WriteLine(~X);     // -6 (complement of 0101 is 1010)
            //Console.WriteLine(X << 1); // 10 (1010)   // يحرك البتات جهة الشمال = ×2
            //Console.WriteLine(X >> 1); // 2  (0010)   //يحرك البتات جهة اليمين = ÷ 2
            #endregion

            #region Terany Operator [Conditional Operator] [?:]
            //int X = 10, Y = 50;

            //if (X > Y)
            //    Console.WriteLine("X > Y");
            //else
            //    Console.WriteLine("X < Y");

            //string message = X > Y ? "X > Y" : "X < Y";
            //Console.WriteLine(message);
            #endregion

            #region Operators Priority and Associativity

            //int a = 20;
            //int b = 15;
            //int c = 10;
            //int d = 5;
            //int Result;

            //Result = (a + b) * c / d; // ( 20 + 15 ) * 10 / 5 = 70
            //Result = ((a + b) * c) / d; // (( 20 + 15 ) * 10 ) / 5 = 70
            //Result = (a + b) * (c / d); // ( 20 + 15 ) * ( 10 / 5 ) = 70
            //Result = a + (b * c) / d; // 20 + ( 15 * 10 ) / 5 = 50

            #endregion
            #endregion

            #region String Formatting
            // Equation : 10 + 5 = 15
            //int X =20, Y=10;
            //int Z = X + Y;
            //string message;


            // 1. String Interpolation

            //message = $"Equation : {X} + {Y} = {Z}";
            //Console.WriteLine(message);
            //---------------------------------------------------------------------------------
            //---------------------------------------------------------------------------------
            // 2. String.Format Method

            //message = string.Format("Equation : {0} + {1} = {2}", X, Y, Z);
            //Console.WriteLine(message);
            //---------------------------------------------------------------------------------
            //---------------------------------------------------------------------------------
            // 3. Composite Formatting

            //Console.WriteLine("Equation : {0} + {1} = {2}", X, Y, Z);

            //---------------------------------------------------------------------------------
            //---------------------------------------------------------------------------------
            // 4. String Concatenation

            //message = "Equation : " + X + " + " + Y + " = " + Z;
            //Console.WriteLine(message);

            #endregion

        }
    }
}
