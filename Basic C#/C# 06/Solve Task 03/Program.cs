using System.Text;

namespace Solve_Task_03
{
    internal class Program
    {
        #region method

        #region 01

        #region Value Type => passing by value:
        //public static void Increase(int x, int y)
        //{
        //    x += 10;
        //    y += 5;
        //}
        #endregion

        #region Value Type => passing by reference :
        //public static void Increase(ref int x, ref int y)
        //{
        //    x += 10;
        //    y += 5;
        //}
        #endregion

        #endregion

        #region 02

        #region Reference type => passing by value 

        //public static void StudentUpdate(Student S)
        //{
        //    S = new Student() { Name = "Sasa" };// It will not change in the main
        //}

        #endregion

        #region Reference type => passing by reference
        //public static void StudentUpdate(ref Student S)
        //{
        //    S = new Student() { Name = "Sasa" };// It will not change in the main
        //}


        #endregion

        #endregion

        #region 03
        //public static void SumAndSub(int A,int B,out int sum,out int sub)
        //{
        //    if (B > A)
        //    {
        //        int Temp = A;
        //        A = B;
        //        B = Temp;
        //    }
        //    sum = A + B;
        //    sub = A - B;
        //}
        #endregion

        #region 04

        //public static int SumDigit(int num)
        //{
        //    int digit, sum = 0;

        //    while (num != 0)
        //    {
        //        digit = num % 10;
        //        sum += digit;
        //        num /= 10;
        //    }
        //    return sum;
        //}

        #endregion

        #region 05
        //public static bool IsPrime(int number)
        //{
        //    if (number < 2)
        //        return false;
        //    else
        //    {
        //        for(int i = 2; i < number; i++)
        //        {
        //            if (number % i == 0)
        //            {
        //                return false;
        //            }
        //        }
        //        return true;
        //    }
        //}

        #endregion

        #region 06
        //public static void MinMaxArray(ref int[] arr,out int Max,out int Min)
        //{
        //    Max = arr[0];
        //    Min = arr[0];
        //    for(int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] < Min)
        //            Min = arr[i];
        //        else if (arr[i] > Max)
        //            Max = arr[i];
        //    }
        //}

        #endregion

        #region 07
        //public static int Fac(int number)
        //{
        //    int res = 1;
        //    for(int i = number; i >= 1; i--)
        //    {
        //        res *= i;
        //    }
        //    return res;
        //}
        #endregion

        #region 08
        public static string ChangeChar(string word, int pos, char character)
        {
            if (pos < 0 || pos >= word.Length)
                return "Try again beacause out of range";

            StringBuilder sb = new StringBuilder(word);
            sb[pos] = character;
            return sb.ToString();
        }
        #endregion

        #endregion
        static void Main(string[] args)
        {
            #region 01

            #region Value Type => passing by value:
            //	I send it the value, not the variable itself.
            //  The change will be in the function, not the variables in main.
            // I mean that the modification is made to the copy of the function and not the original

            //int a = 10, b = 20;

            //Increase(a, b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            #endregion

            #region Value Type => passing by reference :
            // 	I send it the variable itself, not the values.
            // The change will be made to the variables in main, not just the function.
            // What I mean is that the change is made to the original and not the copy. That is, the function receives a reference, meaning that the modification that is made will be made to the original.

            //int a = 10, b = 20;

            //Increase(ref a, ref b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            #endregion

            #endregion

            #region 02
            #region Reference type => passing by value 
            ////Here, a copy of the reference is passed to the method. This means that if the reference is reassigned inside the method, it will not affect the original reference in Main.

            //Student S1 = new Student() { Name = "Ahmed", Id = 10 };

            //Console.WriteLine(S1.Name);
            //Console.WriteLine(S1.Name.GetHashCode());

            //StudentUpdate(S1);

            //Console.WriteLine(S1.Name);
            //Console.WriteLine(S1.Name.GetHashCode());
            #endregion

            #region Reference type => passing by reference
            //// Here I am sending the reference itself, meaning any change to the method will happen to the original in main.
            ////This means I can modify the content of the original variables that are present in main.
            //Student S2 = new Student() { Name = "Moustafa", Id = 20 };

            //Console.WriteLine(S2.Name);
            //Console.WriteLine(S2.Name.GetHashCode());

            //StudentUpdate(ref S2);

            //Console.WriteLine(S2.Name);
            //Console.WriteLine(S2.Name.GetHashCode());

            #endregion
            #endregion

            #region 03
            //Console.Write("Please Enter First Number: ");
            //bool flagnum01 = int.TryParse(Console.ReadLine(), out int num01);
            //Console.Write("Please Enter Second Number: ");
            //bool flagnum02 = int.TryParse(Console.ReadLine(), out int num02);

            //if (flagnum01 && flagnum02)
            //{
            //    SumAndSub(num01, num02, out int sum, out int sub);
            //    Console.WriteLine("Sum two number is {0}",sum);
            //    Console.WriteLine("Sub two number is {0}",sub);
            //}
            //else
            //{
            //    Console.WriteLine("Try again enter two number");
            //}
            #endregion

            #region 04
            //Console.Write("Please Enter First Number: ");
            //bool flagNumber = int.TryParse(Console.ReadLine(), out int num);

            //if (flagNumber)
            //{
            //    int result=SumDigit(num);
            //    Console.WriteLine("Sum Digit is : {0}",result);
            //}
            //else
            //    Console.WriteLine("Try again enter number");
            #endregion

            #region 05
            //Console.Write("Please Enter First Number: ");
            //bool flagNumber = int.TryParse(Console.ReadLine(), out int num);

            //if (flagNumber)
            //{
            //    if(IsPrime(num))
            //        Console.WriteLine("Number is Prime");
            //    else
            //        Console.WriteLine("Number is not prime");
            //}
            //else
            //    Console.WriteLine("Try again enter number");
            #endregion

            #region 06
            //int[] arr = { 1, 2, 3, 4, -2, 50, 4, 6 };

            //MinMaxArray(ref arr, out int Max, out int min);

            //Console.WriteLine("Max of array: {0}",Max);
            //Console.WriteLine("Min of array: {0}",min);

            #endregion

            #region 07
            //Console.Write("Please Enter First Number: ");
            //bool flagNumber = int.TryParse(Console.ReadLine(), out int num);

            //if (flagNumber)
            //{
            //    int result =Fac(num);
            //    Console.WriteLine("!{0} = {1}",num,result);

            //}
            //else
            //    Console.WriteLine("Try again enter number");


            #endregion

            #region 08

            string name = "mahmoud";
            int pos = 3;
            string result = ChangeChar(name, pos, 'M');

            Console.WriteLine(result);



            #endregion


        }
    }
}
