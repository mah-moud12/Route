using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task
{
    static class Remove
    {


        public static ArrayList RemoveDublicate(int[] arr)
        {
           
            ArrayList arrayList = new ArrayList();
            if (arr?.Length > 0)
            {
                int max = arr[0];
                for (int i = 0; i < arr.Length; i++)
                    max = Math.Max(arr[i], max);

                bool[] falgs = new bool [max + 1];
                

                for (int i = 0; i < arr.Length; i++)
                {
                    if (!falgs[arr[i]])
                    {
                        falgs[arr[i]] = true;
                        arrayList.Add(arr[i]);
                    }
                }
            }
            return arrayList;
        }
        
        public static List<T> RemoveDublicate<T>(T[] arr)
        {
            List<T> values = new List<T>();
            HashSet <T> set= new HashSet<T>(arr);
            foreach (var item in set)
            {
                values.Add(item);
            }
            return values;
        } 

    }
}
