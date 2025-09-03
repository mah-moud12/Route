using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03.StringFun
{
    static class StringFunctions
    {
        internal static int GetCountOfUpperCase(string s)
        {   int count = 0;
            if (s?.Length > 0)
                for (int i = 0; i < s.Length; i++)
                    if (s[i]>=65 && s[i]<=90 )
                        count++;
            return count;
        }
        public static int GetCountOfLowerCase(string s)
        {   
            int count = 0;
            if (s?.Length > 0)
                for (int i = 0; i < s.Length; i++)
                    if (s[i]>=97 && s[i]<=122 )
                        count++;
            return count;
        }
    }
}
