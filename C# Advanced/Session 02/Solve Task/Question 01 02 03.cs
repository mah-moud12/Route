using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task
{
    class Question_01_02_03
    {
        public static int[] GetGreaterCount(int[]arr,int[] query,int max)
        {
            int[] freq = new int[max + 1];
            int[] prefixSumFreq = new int[max+1];
            int[] ans = new int[query.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                freq[arr[i]] += 1;
            }
            prefixSumFreq[0] = freq[0];
            for (int i = 1; i < max+1; i++)
            {
                prefixSumFreq[i] = prefixSumFreq[i - 1] + freq[i];
            }

            for (int i = 0; i < query.Length; i++)
            {
                ans[i] = arr.Length-prefixSumFreq[query[i]];
            }

            return ans;
        } 

        public static bool Palindrome(int n)
        {
            int[] arr = new int[n];
            bool flag = true;
            for (int i = 0; i < n; i++)
                if(int.TryParse(Console.ReadLine(), out int x))
                    arr[i] = x;

            for (int i = 0; i < arr.Length/2; i++)
                if (arr[i] != arr[arr.Length - i - 1])
                {
                    flag = false;
                    break;
                }
            return flag;
        }  

        public static void ReverseUsingStackAndQueue<T>(Queue<T>q)
        {
            if (q.Count == 0 || q is null)
                return;
            Stack<T> st = new Stack<T>(q);
           
            q.Clear();
            while (st.Count != 0)
                q.Enqueue(st.Pop());
        }  

    }
}
