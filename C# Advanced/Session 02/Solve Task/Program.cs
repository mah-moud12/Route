using System.Collections;

namespace Solve_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //int[] arr, query;
            //if (int.TryParse(Console.ReadLine(), out int nArr01))
            //    if (int.TryParse(Console.ReadLine(), out int nQuery))
            //    {
            //        arr = new int[nArr01];
            //        query = new int[nQuery];
            //        int Max = int.MinValue;
            //        for (int i = 0; i < nArr01; i++)
            //        {
            //            int.TryParse(Console.ReadLine(), out int x);
            //            arr[i] = x;
            //            Max = Math.Max(Max, arr[i]);
            //        }
            //        for (int i = 0; i < nQuery; i++)
            //        {
            //            int.TryParse(Console.ReadLine(), out int x);
            //            query[i] = x;
            //            Max = Math.Max(Max, query[i]);
            //        }

            //        int[] ans = Question_01_02_03.GetGreaterCount(arr, query, Max);
            //        foreach (var item in ans)
            //        {
            //            Console.WriteLine(item);
            //        }
            //    } 
            #endregion

            #region Q02
            //if (int.TryParse(Console.ReadLine(), out int nArr01))
            //    if (Question_01_02_03.Palindrome(nArr01))
            //        Console.WriteLine("YES");
            //    else
            //        Console.WriteLine("NO");
            #endregion

            #region Q03
            //Queue<string> q = new Queue<string>(new string[] { "mahmoud", "mohamed", "yousef" });
            //Question_01_02_03.ReverseUsingStackAndQueue(q);
            //foreach (var item in q)
            //    Console.Write($"{item} ");


            #endregion

            #region Q04
            //if(Balanced.IsBalanced("(()([])){}"))
            //    Console.WriteLine("YES");
            //else
            //    Console.WriteLine("NO");
            #endregion

            #region Q05
            //string[]? parts = Console.ReadLine()?.Split();
            //if (parts?.Length > 0)
            //{
            //    int[] arr = new int[parts.Length];
            //    for (int i = 0; i < arr.Length; i++)
            //        arr[i] = int.Parse(parts[i]);

            //    List<int> AfterRemove = Remove.RemoveDublicate<int>(arr);
            //    foreach (var item in AfterRemove)
            //    {
            //        Console.Write($"{item} ");
            //    }
            //} 
            #endregion

            #region Q06
            //string[]? parts = Console.ReadLine()?.Split();
            //if (parts?.Length > 0)
            //{
            //    int[] arr = new int[parts.Length];
            //    for (int i = 0; i < arr.Length; i++)
            //        arr[i] = int.Parse(parts[i]);

            //    List<int> AfterRemove = RemoveOddNumber.RemoveOdd(arr);
            //    foreach (var item in AfterRemove)
            //    {
            //        Console.Write($"{item} ");
            //    }
            //} 
            #endregion

            #region Q07
            //Queue queue = new Queue();
            //queue.Enqueue("Mahmoud");
            //queue.Enqueue(10);
            //queue.Enqueue(1.5); 
            #endregion

            #region Q08
            //if (int.TryParse(Console.ReadLine(), out int target))
            //{
            //    int c = 0;
            //    string[]? parts = Console.ReadLine()?.Split();
            //    if (parts?.Length > 0)
            //    {
            //        Stack<int> st = new Stack<int>();
            //        for (int i = 0; i < parts.Length; i++)
            //            st.Push(int.Parse(parts[i]));

            //       while(st.Count!=0)
            //        {
            //            if (st.Peek() == target)
            //                break;
            //            else
            //            {
            //                c++;
            //                st.Pop();
            //            }
            //        }
            //        if (st.Peek() == target)
            //            Console.WriteLine($"Target is found => {target}  , Number of attempts =>{c}");
            //        else
            //            Console.WriteLine("Not found");
            //    }

            //} 
            #endregion

            #region Q09
            //if (int.TryParse(Console.ReadLine(), out int nArr01) && int.TryParse(Console.ReadLine(), out int nArr02))
            //{
            //    List<int> ans = new List<int>();
            //    string[]? parts01 = Console.ReadLine()?.Split();
            //    string[]? parts02 = Console.ReadLine()?.Split();
            //    if (parts01?.Length > 0 && parts02?.Length > 0)
            //    {
            //        int[] arr01 = new int[nArr01];
            //        int[] arr02 = new int[nArr02];
            //        int maxArr01 = int.MinValue, maxArr02 = int.MinValue;
            //        for (int i = 0; i < arr01.Length; i++)
            //        {
            //            arr01[i] = int.Parse(parts01[i]);
            //            maxArr01 = Math.Max(maxArr01, arr01[i]);
            //        }

            //        for (int i = 0; i < arr02.Length; i++)
            //        {
            //            arr02[i] = int.Parse(parts02[i]);
            //            maxArr02 = Math.Max(maxArr02, arr02[i]);
            //        }

            //        int[] freqArr01 = new int[maxArr01 + 1];
            //        int[] freqArr02 = new int[maxArr02 + 1];
            //        for (int i = 0; i < arr01.Length; i++)
            //            freqArr01[arr01[i]]++;

            //        for (int i = 0; i < arr02.Length; i++)
            //            freqArr02[arr02[i]]++;

            //        for (int i = 0; i < Math.Min(freqArr01.Length, freqArr02.Length); i++)
            //        {
            //            for (int j = 0; j < Math.Min(freqArr01[i], freqArr02[i]); j++)
            //            {
            //                ans.Add(i);
            //            }
            //        }

            //        foreach (var item in ans)
            //        {
            //            Console.Write($"{item} ");
            //        }
            //    }

            //}
            #endregion

            #region Q11
            string[]? parts01 = Console.ReadLine()?.Split();
            if (parts01?.Length > 0)
            {
                int[] arr01 = new int[parts01.Length];
                for (int i = 0; i < arr01.Length; i++)
                    arr01[i] = int.Parse(parts01[i]);

                if (int.TryParse(Console.ReadLine(), out int k))
                {
                    int temp;
                    for (int i = 0; i < k / 2; i++)
                    {
                        temp = arr01[i];
                        arr01[i] = arr01[k - i - 1];
                        arr01[k - i - 1] = temp;
                    }
                }
                foreach (var item in arr01)
                {
                    Console.Write($"{item} ");
                }
            } 
            #endregion

        }

    }
}
