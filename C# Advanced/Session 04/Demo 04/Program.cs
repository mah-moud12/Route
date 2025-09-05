using System.Collections;
using System.Collections.Generic;

namespace Demo_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Hashtable 
            Hashtable phoneNote = new Hashtable(new StringEqualityComparer()) // كده انا غيرت في behavior بتاع ال Equal في string
            {
                //{"Mahmoud",111},
                //{"Ahmed",222},
                ["Mahmoud"] = 111,
                ["Ahmed"] = 222,
                ["Omar"] = 555
            };
            //phoneNote.Remove("mahmoud");
            //phoneNote.Add("Mahmoud", 111); // باهته علشان ممكن استخدم object initializer لان انا ستخدم فانكشن ال Add لما اكون مش عارف القيم لكن انا لوعارف القيم يفضل اني  استخدم Object Initializer
            //phoneNote.Add("Mohamed", 222);
            //phoneNote.Add("Ahmed", 333);
            //********************************************************************************************
            //phoneNote.Add("Ahmed", 232323); // System.ArgumentException علشان ال key unique مينفعش يتكرر
            //solve problem System.ArgumentException
            //if(!phoneNote.ContainsKey("Ahmed"))
            //    phoneNote.Add("Ahmed", 232323); // كده مش هيضرب exceptions
            //********************************************************************************************

            //phoneNote.Add("ahmed", 242424); // كده هيضيفو مع ان ahmed موجود بس اول حرف capital طب اي حل المشكلة دي علشان ميضيفوش الحل اني اعمل implement IEqualityComparer
            // بعد لما اطبق interface هيضرب Exception 
            //********************************************************************************************
            #region set and get
            //phoneNote["Sara"] = 333;
            //Console.WriteLine(phoneNote["Ahmed"]);
            //Console.WriteLine("===============");
            #endregion

            #region Traverse
            //foreach (DictionaryEntry item in phoneNote)
            //    Console.WriteLine(item);
            //************************************************************************
            //foreach (object item in phoneNote.Keys) // Casting
            //    Console.WriteLine(item);
            //************************************************************************
            //foreach (object item in (Hashtable)phoneNote) // Casting
            //    Console.WriteLine($"{item.Keys}");// error لان انا ممكن ابعت مكان phoneNote array وال array مفيهاش Key and Value فعلشان كده error
            // حل المشكلة دي اني اعمل كل شويه casting وده وحش جدا
            // Solve problem 
            //object obj = phoneNote;
            //if(obj is Hashtable hashtable) // casting
            //{
            //    foreach (DictionaryEntry item in phoneNote) 
            //        Console.WriteLine($"{item.Key}");
            //}
            //************************************************************************
            //foreach (int item in phoneNote.Values)
            //    Console.WriteLine(item);
            #endregion

            #endregion

            #region Dectinary
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>()
            {
                { "mahmoud",111},
                { "ahmed",222},
                { "Amr",333}
            };

            #region Get and Set

            //Console.WriteLine(keyValuePairs["mahmoud"]);

            //keyValuePairs["mahmoud"] = 3456;
            //Console.WriteLine("After Update");
            //Console.WriteLine(keyValuePairs["mahmoud"]);
            //***********************************************************
            //Console.WriteLine(keyValuePairs["Omar"]); // Exception

            //solve problem Exception
            if (keyValuePairs.ContainsKey("Omar"))
                Console.WriteLine(keyValuePairs["Omar"]);

            // another way
            //bool flag = keyValuePairs.TryGetValue("mahmoud",out int number); // هيحاول يجيب ال value لو عرف هيجيبهالك لو معرفش هيرجع صفر 

            //Console.WriteLine(flag ? number : number);

            #endregion

            #region Traverse
            //foreach (KeyValuePair<string, int> item in keyValuePairs)
            //    Console.WriteLine(item);

            //foreach (string item in keyValuePairs.Keys)
            //    Console.WriteLine(item);

            //foreach (int item in keyValuePairs.Values)
            //    Console.WriteLine(item); 
            #endregion

            #region define key Value Pair 
            #region Example 01
            //KeyValuePair<string, int>[] keyValuePairs1 =
            //   {
            //    new KeyValuePair<string, int>("mahmoud",111),
            //    new KeyValuePair<string, int>("ahmed",222),
            //    new KeyValuePair<string, int>("omar",333),
            //};

            //Dictionary<string, int> col2 = new Dictionary<string, int>(keyValuePairs1, new StringEqualityDictionary());// فيه constructor overload بياخد collection من KeyValuePair


            //// col2.Add("Ahmed", 123); // هيضيفه مع انهم نفس ال key بس اول حرف بس هو اللي مختلف فهيعتبرهم مش نفس بعض وهيضيفه طب ازاي اخليه مش يضيه هو اني اعمل IEqualty وغير طريقه ال Equal


            //foreach (var item in col2)
            //    Console.WriteLine(item); 
            #endregion

            #region Example 02

            //Employee employee01 = new Employee(10, "Mahhmoud", 1000.0m);
            //Employee employee02 = new Employee(20, "Ahmed", 20000.00m);
            //Employee employee03 = new Employee(30, "Omar", 30000.00m);


            //KeyValuePair<Employee, string>[] keyValuePair =
            //{
            //    new KeyValuePair<Employee,string> (employee01,"1st"),
            //    new KeyValuePair<Employee,string> (employee02,"2st"),
            //    new KeyValuePair<Employee,string> (employee03,"3st"),
            //};
            //Dictionary<Employee, string> Collection = new Dictionary<Employee, string>(keyValuePair,new EmployeeIEqualityComparer());

            //Employee employee04 = new Employee(20, "Ahmed", 20000.00m);

            //// Collection.Add(employee04,"4st"); // هيضيفه عادي مع انه نفس employee وده غلط لان المفروض مش يضيفوه بس Equal اللي هيا موجوده بتقارن ب references فهما مختلفين في references فهيضيفوه طب علشان امنعه لازم استخدم IEquatable or IEqualityComparer

            //// solve problem Exception
            //if(!Collection.ContainsKey(employee04))
            //    Collection.Add(employee04, "4st");



            //foreach (KeyValuePair<Employee,string> item in Collection)
            //    Console.WriteLine(item);

            #endregion
            #endregion

            #endregion

            #region Sorted Dictionary

            #region Example 01
            //SortedDictionary<string, int> keyValuePairs1 = new SortedDictionary<string, int>(new StringComparerSortedDictionary())
            //{
            //    { "Mahmoud",111},
            //    { "Mohamed",222},
            //    { "Ahmed",333},
            //    { "Bassem",444},
            //    { "Khald",555}
            //};
            ////keyValuePairs1["sss"] = 3344554; // Add
            //foreach (KeyValuePair<string, int> item in keyValuePairs1)
            //    Console.WriteLine(item);
            #endregion

            #region Example 02

            //Employee employee01 = new Employee(10, "Ahmed", 1000.0m);
            //Employee employee02 = new Employee(10, "Ahmed", 200.00m);
            //Employee employee03 = new Employee(30, "Omar", 30000.00m);

            //SortedDictionary<Employee, string> Collection = new SortedDictionary<Employee, string>(new EmployeeSortedDictionary()) {
            //    { employee01,"1st"},
            //    { employee02,"2st"},
            //    { employee03,"3st"},
            //};

            //// في البدايه هيضرب exception لان هو مش عارف يرتب employee على اساس اي بالظبط  Name ولا Id ولا Salary هو مش فاهم فلازم انا فهمه طب افهمه ازاي اروح اعمل Icomparer or Icomparable
            //foreach (var item in Collection)
            //    Console.WriteLine(item);
            #endregion
            #endregion

            #region Sorted List

            //SortedList<string, int> SL = new SortedList<string, int>(new StringComparerSortedDictionary())
            //{
            //    { "Mahmoud",111},
            //    { "Mohamed",333},
            //    { "Ahmed",222}
            //};

            //foreach (var item in SL)
            //{
            //    Console.WriteLine(item);
            //}
            //// Access Index 

            //int Value = SL.GetValueAtIndex(1);
            //string Key = SL.GetKeyAtIndex(1);
            //Console.WriteLine(Value);
            //Console.WriteLine(Key);

            #endregion

            #region HashSet

            #region Example 01
            //HashSet<string> names = new HashSet<string>(new StringEqualityDictionary());

            //names.Add("Ahmed");
            //names.Add("Omar");
            //names.Add("Kareem");
            //names.Add("Moustafa");
            //names.Add("Moustafa"); //  مش هيضيفه ومش هيعمل exception
            //names.Add("omar"); // هيضيفه علشان اول حرف مختلف علشان اخليه مش يضيفو لازم اعمل implement interface 

            //foreach (var item in names)
            //    Console.WriteLine(item); 
            #endregion

            #region Example 02
            HashSet<Car> cars = new HashSet<Car>()
            {
                new Car(10,"kia",65),
                new Car(10,"Hounda",35),
                new Car(10,"Hounda",35),
                new Car(10,"Audi",2225),
                new Car(10,"Audi",2225)
            };// هيضيفهم كلهم لان كلهم مش نفس ال reference طب علشان اخليه يقارن ب state لازم اعمل implement IEqualityComparer or Iequatable

            //foreach (var item in cars)
            //    Console.WriteLine(item);


            Car[] cars1 =
            {
                new Car(111,"Kia",2022200),
                new Car(222,"Nokia hahaha",30000000),
                new Car(222,"Nok22ia hahaha",30000000), // مش هيضيفها لان انا عامل implement IEquatable
                new Car(333,"Mahmoud",40001230),
            };
            HashSet<Car> cars2 = new HashSet<Car>(cars1,new CarIEqualityComparer());

            foreach (var item in cars2)
                Console.WriteLine(item);

            #endregion
            
            #endregion

        }
    }
}
