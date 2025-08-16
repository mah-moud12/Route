namespace Demo_05
{
    // class
    // interface
    // struct
    // enum
    internal class Program
    {
        // Two type of method
        //1.1 Class Member Method [Static Method] -> person.method
        //1.2 Object Member Method [Non-Static Method] -> person p1; p1.method
        #region Method

        #region Example 01
        //public static void printShape()
        //{
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.WriteLine("_*_^_*_^_");
        //    }
        //}
        #endregion

        #region Example 02
        //public static void printShape02(string pattern = "(@:=>_*_<=:@)", int count = 3)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.WriteLine(pattern);
        //    }
        //}
        #endregion

        #region [Value Type]

        #region Passing by value 
        //public static void SwapValue(int X, int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}
        #endregion

        #region Passing by reference
        //public static void SwapRefer(ref int X, ref int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}
        #endregion

        #endregion

        #region [Reference type]

        #region Passing by value 

        //public static int SumArray(int[] arr)
        //{
        //    int sum = 0;
        //    arr[0] = 100;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}

        #endregion

        #region Passing by value anthor Example
        //public static int SumArray(int[] arr)
        //{
        //    int sum = 0;
        //    arr = new int[] { 100, 200, 300 };
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}
        #endregion

        #region Passing by reference 

        //public static int SumArray(ref int[] arr)
        //{
        //    int sum = 0;
        //    arr[0] = 100;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}
        #endregion

        #region Passing by Reference anthor Example
        //public static int SumArray(ref int[] arr)
        //{
        //    int sum = 0;
        //    arr= new int []{ 100,200,300};
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}
        #endregion

        #region Output parameter

        //public static int[] SumSub(int x, int y)
        //{
        //    int sum = x + y;
        //    int sub = x - y;
        //    int div = x / y;

        //    //return new int[] { sum, sub };
        //    return [sum, sub,div];
        //}

        ////improve solution

        //public static void SumSub(int x, int y, out int sum, out int sub)
        //{
        //    sum = x + y;
        //    sub = x - y;
        //}



        #endregion
        #endregion

        #region Function parameter params

        public static void Params(int x, params int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(x + " " + arr[i] + " ");
            }
        }

        #endregion



        #endregion
        static void Main(string[] args)
        {
            #region Array
            //Follow Presentation
            #region 1D Array

            #region Example 01
            //int[] arr;//4 byte in stack 

            // Console.WriteLine(arr[0]);// Error -> Use of unassigned local variable 'arr'

            //arr = new int[3];//create new object in heap contain 12 byte ;

            //Console.WriteLine(arr[0]);
            //Console.WriteLine(arr[1]);
            //Console.WriteLine(arr[2]);

            //arr[0] = 10;
            //arr[1] = 20;
            //arr[2] = 30;

            //Console.WriteLine(arr[0]);
            //Console.WriteLine(arr[1]);
            //Console.WriteLine(arr[2]);

            //Console.WriteLine(arr.Length); //3
            //Console.WriteLine(arr.Rank);  //1D

            //----------------------------------------------------------------------------------
            //solve problem redundency

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //Console.WriteLine("=======================");
            //foreach(var item in arr)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Array creation ways
            //int[] arr00 = new int[3];
            //int[] arr01 = new int[] { 1, 2, 3, 4, 5 };
            //int[] arr02 = new int[5] { 1, 2, 3, 4, 5 };
            //int[] arr03 = { 1, 2, 3, 4, 5 };

            #endregion

            #endregion

            #endregion


            #region Function

            #region function Prototype
            //printShape();

            ////pass parameter by order
            //printShape02("/#||#\\", 4);

            ////pass parameter by Name
            //printShape02(count: 4, pattern: "/#||#\\");

            ////pass parameter by default
            //printShape02();
            #endregion

            #region Escape sequences

            //Console.WriteLine("mahmoud \ mohamed ");// Error 

            ////one solution
            //Console.WriteLine(@"Mahmoud \ mohamed");

            ////second solution
            //Console.WriteLine("Mahmoud \\ mohamed");

            //Console.WriteLine("mahmoud \t mohamed");
            //Console.WriteLine("mahmoud \n mohamed");

            ////follow presentation


            #endregion

            #region Function Paramter [value Type]

            #region Pssing by Value

            //int A = 5;
            //int B = 3;
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //SwapValue(A, B);
            //Console.WriteLine("After swap");
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //مش هيحصل تبديل لإن انت باعت قيمة المتغير 
            //شوف presentation
            #endregion

            #region Passing by Reference

            //int A = 5;
            //int B = 3;
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //SwapRefer(ref A, ref B);
            //Console.WriteLine("After swap");
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //هيحصل تغير لان انت بعتت المتغير نفسه 
            //شوف ال presentation
            //اعمل debug علشان تتاكد
            #endregion

            #endregion

            #region Function Paramter [Reference Type]

            #region Passing by Value 
            //int[] numbers = { 1, 2, 3 };
            //int res = SumArray(numbers);
            ////هنا اكني عملت كده numbers = arr
            ////هنا انا مررتلها عنوان ال object 
            ////ال numbers وال arr بيشاوروا على نفس object
            ////لو اي واحد منهم غير اي حاجه في القيم التاني هيتغير معاه علشان بيشاوروا على نفس ال object
            ////هنا انا عندي اتنين reference
            ////follow presentation
            //Console.WriteLine(res);
            //Console.WriteLine(numbers[0]);
            #endregion

            #region Passing by value anthor Example

            //int[] numbers = { 1, 2, 3 };
            //int res = SumArray(numbers);
            ////follow presentation slide(32)
            //Console.WriteLine(res);
            //Console.WriteLine(numbers[0]);

            #endregion

            #region Passing by Reference


            //int[] numbers = { 1, 2, 3 };
            //int res = SumArray(ref numbers);
            ////هنا بدلت ال number وحطيت مكانها arr
            ////بعد لما SumArray تتمسح من Stack ال numbers هترجع مكان arr تاني 
            ////لو اي واحد منهم غير اي حاجه في القيم التاني هيتغير معاه علشان بيشاوروا على نفس ال object
            ////هنا انا عندي واحد reference
            ////هنا انا بعتلو ال object ب reference
            ////follow presentation
            //Console.WriteLine(res);
            //Console.WriteLine(numbers[0]);

            #endregion

            #region Passing by Reference anthor Example

            //int[] numbers = { 1, 2, 3 };

            //Console.WriteLine(numbers.GetHashCode());

            //int res = SumArray(ref numbers);
            ////هنا هيتغير عن المثال التاني لإن انت بعتلو ال object ب reference 
            ////follow presentation slide(33)



            //Console.WriteLine(res);
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers.GetHashCode());

            #endregion


            #endregion

            #region Function parameter Output 
            //int A, B;
            //SumSub(20, 10, out A, out B);

            //Console.WriteLine(A);
            //Console.WriteLine(B);


            #endregion

            #region Function parameter params
            int[] arr = { 1, 2, 3, 4, 5, 1, 2 };

            Params(1, 22, 3, 4, 5, 64, 6, 45, 4,33);

            #endregion

            #endregion


        }
    }
}
