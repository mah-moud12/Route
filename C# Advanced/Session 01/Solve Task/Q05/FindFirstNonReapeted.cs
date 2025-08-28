using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Q05
{
    class FindFirstNonReapeted
    {
        public static char FirstCahracterNonReapted(string str)
        {
            Dictionary<char, int> countChar=new Dictionary<char, int>();
            char res=' ';
            if (str?.Length > 0)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (countChar.ContainsKey(str[i]))
                        countChar[str[i]] += 1;
                    else
                        countChar[str[i]] = 1;
                }

                for (int i = 0; i < str.Length; i++)
                    if (countChar[str[i]] == 1)
                    {
                        res = str[i];
                        break;
                    }
            }
            return res;
        }
    }
}
