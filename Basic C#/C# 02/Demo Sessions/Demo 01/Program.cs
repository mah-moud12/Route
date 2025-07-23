using System.ComponentModel;

namespace Demo_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Error Types
            //  1. ============ Compile-Time Errors (Syntax Errors) ============
            //----------------------------------------
            // *=> Missing semicolon (;).  => Console.WriteLine("Helllo, World")
            //----------------------------------------
            // *=> Using undeclared variables =>  int x;    Console.WriteLine(x);
            //----------------------------------------
            // *=> Mismatched parentheses () or braces {} => if(5>2){


            //  2. ============ Runtime Errors (Exceptions) ============
            //----------------------------------------
            // *=> DivideByZeroException *************
            //    int x = 10;
            //    int y = 0;
            //    int result = x / y;
            //    Console.WriteLine(result);
            //----------------------------------------
            // *=> IndexOutOfRangeException **********
            //    int[] arr = { 1, 2, 3, 4 };
            //    Console.WriteLine(arr[5]);
            //----------------------------------------
            // *=> NullReferenceException ************
            //    string name = null;
            //    Console.WriteLine(name.Length);


            //  3. ============ 3. Logical Errors ============
            //--------------------------------------------
            // *=> Incorrect formula or calculation ******
            //    int num1 = 10;
            //    int num2 = 20;
            //    int resSumTwoNumber = num1 * num2;
            //    Console.WriteLine(resSumTwoNumber);
            //-------------------------------------------------------
            // *=> Wrong comparison in a conditional statement ******
            // -- Age must be greater than18 ************************
            //    int age = 19;
            //    if (age <= 18)
            //        Console.WriteLine("Age under 18 years old");
            //-------------------------------------------------------
            // *=> Using the wrong data types for variables    ******
            //    int age = "twenty"; 
            #endregion

            #region Comment
            // ======================== Comment ========================
            //----------------------------------------------------------
            // ------------ Multiple Comment ------------
            /*      
            *      Hello Ya Negm   
            *      Hello Ya Bro   
            */
            // ------------ XML Comment ------------
            //Console.WriteLine(sum(10, 20));
            #endregion

            #region Declare Variable
            // int 8X = 20; ==> error
            // int class =10; ==> Error
            /*
                int X;
                Console.WriteLine(X);==> error beacause unsigned value
            */
            #endregion

            #region Data Type

            #region Value Type 
            //int X;
            //// CLR Will Allocate 4 Uninitialized Bytes in Stack

            //X = 5;
            ////4Byte = 5

            //Int32 Y = 9;
            ////use BCL 

            //Y = X;//5

            //Console.WriteLine(Y);//5
            //Console.WriteLine(X);//5

            //Console.WriteLine("======================================");

            //X++;
            //Console.WriteLine(X);
            //Console.WriteLine(Y);

            #endregion

            #region Reference Type 
            //Point P01;
            //// Declare For Reference of Type Point “P1” Referencing to Null ==> 
            //// 4 Bytes Allocated in Stack For Pointer|Reference 
            //// 0 Bytes Allocated in Heap 

            //P01 = new Point();
            //// 1. Allocate Required Bytes at Heap
            //// 2. Initialize Allocated Bytes Of Object With Default Value
            //// 3. Call User Defined Constructor (If Exist)
            //// 4. Assign Reference (P1) To Allocated Object

            //Point P02 = new Point();

            //P02 = P01;
            //P02.X = 10;

            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);

            #endregion

            #endregion

            #region Object
                //Point P01;
                //// Declare For Reference of Type Point “P1” Referencing to Null ==> 
                //// 4 Bytes Allocated in Stack For Pointer|Reference 
                //// 0 Bytes Allocated in Heap 

                //P01 = new Point();
                //// 1. Allocate Required Bytes at Heap
                //// 2. Initialize Allocated Bytes Of Object With Default Value
                //// 3. Call User Defined Constructor (If Exist)
                //// 4. Assign Reference (P1) To Allocated Object

                //Point P02 = new Point();

                //P02 = P01;
                //P02.X = 10;
                //P02.Y = 20;
                //Console.WriteLine(P02.ToString()+": Is NameSpace.ClassName");
                //Console.WriteLine(P02.X.ToString() + " ya bro adf3.");//convert number into string.
                //Console.WriteLine("=================================");

                //Console.WriteLine(P01.Equals(P02));// True because P01.X = P02.X
                //Console.WriteLine("=================================");

                //Console.WriteLine(P01.Y.GetHashCode());// هيطبع قيمتها 
                //Console.WriteLine(P01.GetHashCode());
                //Console.WriteLine("=================================");

                //Console.WriteLine(P01.X.GetType());//Returns Namespace.TypeName.
                //Console.WriteLine(P01.GetType());//Returns Namespace.TypeName.

                //object name = "Mahmoud";
                //object Age = 21;
                //object Year = 2004;
                //Console.WriteLine("=================================");
                //Console.WriteLine("Student Info: ");
                //Console.WriteLine("Name Is: "+name);
                //Console.WriteLine("Age Is: "+Age);
                //Console.WriteLine("Year Is: "+Year);

            #endregion


        }
        /// <summary>
        /// Sum Two Numbers
        /// </summary>
        /// <param name="x">Num One</param>
        /// <param name="y">Num Two</param>
        /// <returns>Return Sum <paramref name="x"/> and <paramref name="y"/></returns>
        static int sum(int x, int y)
        {
            return x + y;
        }
    }
}
