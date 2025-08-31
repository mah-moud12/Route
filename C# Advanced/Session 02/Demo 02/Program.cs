using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Demo_02
{
    internal class Program
    {
        #region Array List
        public static int SumArrayList(ArrayList arrayList)
        {
            int sum = 0;
            if (arrayList?.Count > 0)
                for (int i = 0; i < arrayList.Count; i++)
                    sum += (int?)arrayList[i] ?? 0; // Unboxing
            return sum;
        }
        #endregion

        #region List
        public static int SumList(List<int> list)
        {
            int sum = 0;
            if (list?.Count > 0)
                for (int i = 0; i < list.Count; i++)
                    sum += list[i] ; 
            return sum;
        } // هنا مش هيطلع اي exception لان انا هنا بعتمد عل Generic مش Object 
        #endregion

        static void Main(string[] args)
        {
            #region Non Generic Collections - ArrayList

            //ArrayList arrayList = new ArrayList();
            //Console.WriteLine($"Capacity => {arrayList.Capacity}  ,  Number Of Element => {arrayList.Count}");

            #region Add 
            //// هنا capacity 0 فلو ضفت عنصر هيروح يعمل array جديده ب capacity ضعف ال array القديمه 
            //arrayList.Add(1); // Boxing
            //arrayList.Add(2);
            //arrayList.Add(3);

            //Console.WriteLine($"Capacity => {arrayList.Capacity}  ,  Number Of Element => {arrayList.Count}");

            //arrayList.AddRange(new int[] {  5, 6, 7, 8 }); // Add Range ( ICollection ) -> يعني اللي انت هتضيفو لازم يكون عامل implement لل interface ده

            //Console.WriteLine($"Capacity => {arrayList.Capacity}  ,  Number Of Element => {arrayList.Count}");

            //foreach (int item in arrayList)
            //    Console.WriteLine(item); // Unboxing

            #endregion

            #region Insert Element
            //arrayList.Insert(1,10); // Boxing
            //Console.WriteLine("===============");

            //arrayList.InsertRange(2, new int[] { 20, 30, 40 }); // Insert Range ( ICollection ) -> يعني اللي انت هتضيفو لازم يكون عامل implement لل interface ده
            //Console.WriteLine($"Capacity => {arrayList.Capacity}  ,  Number Of Element => {arrayList.Count}");

            //arrayList.Insert(13, 90);// ArgumentOutOfRangeException

            //foreach (int item in arrayList)
            //    Console.WriteLine(item); // Unboxing
            #endregion

            #region Trim
            //arrayList.Add(1);
            //arrayList.Add(2);
            //arrayList.Add(3);

            //Console.WriteLine($"Capacity => {arrayList.Capacity}  ,  Number Of Element => {arrayList.Count}"); // 4  -  3

            //arrayList.TrimToSize();// هنا هيكون ال capacity 4 وانا مستخدم منها تلاته بس ف trim هتشيل الاتنين دول علشان الميموري 
            //Console.WriteLine($"Capacity => {arrayList.Capacity}  ,  Number Of Element => {arrayList.Count}"); // 3  -  3

            //arrayList.Add(4);
            //Console.WriteLine($"Capacity => {arrayList.Capacity}  ,  Number Of Element => {arrayList.Count}"); // 6  -  4

            #endregion

            #region Remove 
            //arrayList.Add(1);
            //arrayList.Add(2);
            //arrayList.Add(3);
            //arrayList.Add(4);

            //for (int i = 0; i < arrayList.Count; i++)
            //    Console.WriteLine(arrayList[i]);

            ////arrayList.Remove(4); // لو لقى العنصر هيمسحه مش لقاه مش هيعمل حاجه 
            ////arrayList.RemoveAt(1);

            //arrayList.RemoveRange(1, 3); // RemoveRange( index , count )

            //Console.WriteLine("After Remove");


            //for (int i = 0; i < arrayList.Count; i++)
            //    Console.WriteLine(arrayList[i]); // بعرف اعمل access علشان فيه property indexer
            #endregion

            #region Contain 
            //arrayList.Add(1);
            //int firstElement = (int?)arrayList[0]??0; // ده عيب في ArrayList لان انا بعمل casting (Unboxing)

            //if(arrayList.Contains(1))
            //    Console.WriteLine("Found");
            //else
            //    Console.WriteLine("Not Found");

            #endregion

            #region 3 Constructor 
            //// 1 Constructor()
            //arrayList = new ArrayList() { 1,2,3,4,5,6,7}; // 4 defualt capacity
            //Console.WriteLine($"Capacity => {arrayList.Capacity}  ,  Number Of Element => {arrayList.Count}");

            //// 2 Constructor( Capacity )
            //arrayList = new ArrayList(10) { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //arrayList.Add(11); //هيزود ال capacity وهيعمل array جديده 

            //Console.WriteLine($"Capacity => {arrayList.Capacity}  ,  Number Of Element => {arrayList.Count}"); // 20  -  11

            //// 3 Constructor( Interface )

            //arrayList = new ArrayList(new int[] { 10, 2, 3 });

            //Console.WriteLine(arrayList[0]);
            #endregion

            #region Example 
            //ArrayList arrayList1 = new ArrayList(20);
            //arrayList1.Add(1); // boxing 
            //arrayList1.Add(2);
            //arrayList1.Add(3);
            //arrayList1.Add(4);
            //arrayList1.Add("Mahmoud"); // Exception

            //int sum = SumArrayList(arrayList1);

            //Console.WriteLine(sum); 
            #endregion

            #region Notes
            // - كله الفانكشن O(n) ماعدا (Add and Count and Capacity) => O(n)
            // Mixed Data Types => زي ما هيا ميزا فهي عيب زي مضفنا string وجينا نجمع ضرب exception 
            #endregion
            #endregion

            #region Generic Collections - List
            //List<int> ints = new List<int>();
            //Console.WriteLine($"Capacity => {ints.Capacity}  ,  Number Of Element => {ints.Count}");

            #region Add
            //ints.Add(1);
            //ints.Add(2);
            //ints.Add(3);
            //Console.WriteLine($"Capacity => {ints.Capacity}  ,  Number Of Element => {ints.Count}");

            ////ints.AddRange(1, 2, 3); //  ints.AddRange( params )
            //ints.AddRange(new int[] { 4, 5, 6, 7, 5 }); //  ints.AddRange( Interface )
            //ints.AddRange(8); //  ints.AddRange( Interface )

            //Console.WriteLine($"Capacity => {ints.Capacity}  ,  Number Of Element => {ints.Count}");

            #endregion

            #region Insert Element

            //ints.Insert(0,10);
            //ints.Add(20);
            //ints.InsertRange(2, new int[] { 30, 40, 50 });

            //for (int i = 0; i < ints.Count; i++)
            //    Console.WriteLine($"{ints[i]} ");

            #endregion

            #region Trim
            //ints.Add(10);
            //ints.Add(20);
            //ints.Add(30);
            //ints.Add(40);
            //ints.Add(50);
            //Console.WriteLine($"Capacity => {ints.Capacity}  ,  Number Of Element => {ints.Count}");

            //Console.WriteLine("After Trim");
            //ints.TrimExcess(); // هنا هيكون ال capacity 4 وانا مستخدم منها تلاته بس ف trim هتشيل الاتنين دول علشان الميموري 
            //Console.WriteLine($"Capacity => {ints.Capacity}  ,  Number Of Element => {ints.Count}");
            #endregion

            #region Remove 
            //ints.Add(10);
            //ints.Add(20);
            //ints.Add(30);
            //ints.Add(40);
            //ints.Add(50);

            //foreach (var item in ints)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("=================");
            ////ints.Remove(10);
            ////ints.RemoveAt(0);
            //ints.RemoveRange(1, 1);

            //foreach (var item in ints)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Contain
            //ints.Add(10);
            //ints.Add(20);
            //ints.Add(30);

            //int firstElement = ints[0]; // هنا ينفع اعمل كده لانها بتعتمد على Generic وليس object فمش محتاج اعمل casting 

            //if (ints.Contains(10)) { Console.WriteLine("Found"); }
            //else Console.WriteLine("Not Found");
            #endregion

            #region 3 Constructor 
            //// 1 Constructor()
            //ints = new List<int>() { 1, 2, 3, 4 };
            //Console.WriteLine($"Capacity => {ints.Capacity}  ,  Number Of Element => {ints.Count}");

            //// 2 Constructor(Capacity)
            //ints = new List<int>(10) { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0,1 };
            //Console.WriteLine($"Capacity => {ints.Capacity}  ,  Number Of Element => {ints.Count}");

            //// 3 Constructor( Interface )
            //ints = new List<int>(new int[] { 1, 2, 3, 4 });
            //Console.WriteLine($"Capacity => {ints.Capacity}  ,  Number Of Element => {ints.Count}"); // 4  -  4 
            //// بياخد capacity على قد ال size
            #endregion

            #region EnsureCapacity

            //ints.EnsureCapacity(5); // هتسال هل تقدر تشيل capacity 5 لو هيقدر هيسيبها زي ماهيا لو مش هيقدر هيضاعف ال list القديمه 
            //Console.WriteLine($"Capacity => {ints.Capacity}  ,  Number Of Element => {ints.Count}");

            //ints.EnsureCapacity(4); // هيسيبها زي ماهيا 
            //Console.WriteLine($"Capacity => {ints.Capacity}  ,  Number Of Element => {ints.Count}");
            #endregion

            #region Example
            //ints.Add(1);
            //ints.Add(2);
            //ints.Add(3);
            ////ints.Add("Mahmoud"); // Invalid  لان دي Generic وانا محدد Type بتاعها فهيطلع error في compile time .

            //int res = SumList(ints);
            //Console.WriteLine($"Sum List is => {res}");
            #endregion

            #region ReadOnlyCollection and Binary Search
            //ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

            //ints.Add(10);
            //ReadOnlyCollection<int> ints1 = ints.AsReadOnly<int>();
            //// بعمل كده لما اكون عاوز اعمل Read فقط
            //// readOnly دي مش نسخه مستقلة يعني اي الكلام ده يعني لو عدلت في الاصل هيا كمان هتتاثر زي منا عملت فوق كده 

            //foreach (var item in ints1)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            //////inst1[0] = 10;// Invalid علشان هيا readOnly 
            ////*****************************************************************************
            //int elem =ints.BinarySearch(3); 
            //Console.WriteLine(elem);
            //Time Complexity: O(log n).
            //// لو موجود → بيرجع الـ index.
            //// لو مش موجود → بيرجع قيمة سالبة = -(المكان اللي المفروض يتحط فيه +1).
            #endregion

            #region Clear and GetRange and indexOf and LastIndexOf and CopyTo
            //ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7 ,1};
            //Console.WriteLine($"Capacity => {ints.Capacity}  ,  Number Of Element => {ints.Count}");
            //List<int> s = ints.GetRange(0, 3);

            //foreach (var item in s)
            //{
            //    Console.WriteLine(item);
            //}

            //ints.Clear();
            //Console.WriteLine($"Capacity => {ints.Capacity}  ,  Number Of Element => {ints.Count}");
            //// هتمسح العناصر وهتسيب ال capacity زي ما هيا 
            //*****************************************

            //Console.WriteLine(ints.IndexOf(1));
            //Console.WriteLine(ints.LastIndexOf(1));

            //int[] arr = new int[10];
            //ints.CopyTo(arr);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion

            #region Generic Collections - LinkedList
            //LinkedList<int> list = new LinkedList<int>();
            //list.AddFirst(10);
            //list.AddFirst(20);
            //LinkedListNode<int> firstNode  = list.AddFirst(30);
            ////   null <-[30]->    <-[20]->   <-[10]->  null
            ////   Ref  <-[node]-> <-[node]-> <-[node]-> Ref

            //LinkedListNode<int> node = new LinkedListNode<int>(30); // هنا انا بعمل node وبضيفها عادي في linked list  
            //list.AddLast(node);
            ////   null <-[30]->    <-[20]->   <-[10]->  <-[30]->   null
            ////   Ref  <-[node]-> <-[node]-> <-[node]-> <-[node]-> Ref
            //LinkedListNode<int> nodeSec = new LinkedListNode<int>(40);
            //list.AddBefore(node, nodeSec); // first overload
            ////   null <-[30]->    <-[20]->   <-[10]->   <-[40]->  <-[30]->   null
            ////   Ref  <-[node]-> <-[node]-> <-[node]-> <-[node]-> <-[node]-> Ref
            //Console.WriteLine($"Prev Node => {node?.Previous?.Value}");

            //list.AddAfter(node!, 50);  // second overload
            ////   null <-[30]->    <-[20]->   <-[10]->   <-[40]->  <-[30]->   <-[50]->   null
            ////   Ref  <-[node]-> <-[node]-> <-[node]-> <-[node]-> <-[node]-> <-[node]-> Ref

            //Console.WriteLine($"The Next Value => {firstNode?.Next?.Next?.Next?.Value}");
            //Console.WriteLine($"The Count Of Linked List => {list.Count}");


            //LinkedListNode<int> FNode = list.First!;
            //LinkedListNode<int> LNode = list.Last!;

            //Console.WriteLine($"Firts Node => {FNode.ValueRef}");



            //LinkedList<int>? newList = FNode.List; // هنا انا بقولة هاتلي ال list بتاعت ال node دي
            //if(newList is not null)
            //    foreach (int elem in newList)
            //        Console.WriteLine(elem);

            //// هيا زي deque 
            //// شوف ال notes 
            #endregion

            #region Stack
            //Stack<int> st=new Stack<int>();
            //Console.WriteLine($"Capacity => {st.Capacity}  ,  Number Of Element => {st.Count}");
            //st.Push(10);
            //st.Push(20);
            //st.Push(30);
            //st.Push(40);
            //Console.WriteLine($"Capacity => {st.Capacity}  ,  Number Of Element => {st.Count}");//  4  -  4  
            //st.Push(50);
            //Console.WriteLine($"Capacity => {st.Capacity}  ,  Number Of Element => {st.Count}");//  8  -  5  
            //st.Pop();
            //st.Pop();
            //st.Pop();
            //st.Pop();
            //st.Pop();
            //Console.WriteLine($"Capacity => {st.Capacity}  ,  Number Of Element => {st.Count}");//  8  -  5  
            ////st.Pop();//exception 
            ////st.Peek();//exception 
            ////Solve Problem Exception 
            //st.TryPop(out int res);// هيحاول يمسح لو عرف هيمسح وهيرجع القيمه اللي مسحها في res
            //st.TryPeek(out int Top);// هيحاول يجيب ال top لو عرف هيجيبة وهيرجع قيمة ال top  في res
            #endregion

            #region Queue
            //Queue<int> q = new Queue<int>(new int[] { 1,2});
            //Console.WriteLine($"Capacity => {q.Capacity}  ,  Number Of Element => {q.Count}");//  2  -  2
            //q.Enqueue(3);
            //q.Enqueue(4);
            //int elem = q.Peek();
            //q.TryPeek(out int top);
            //q.TryDequeue(out int pop);
            //Console.WriteLine($"Capacity => {q.Capacity}  ,  Number Of Element => {q.Count}");//  4  -  2
            #endregion
        }
    }
}
