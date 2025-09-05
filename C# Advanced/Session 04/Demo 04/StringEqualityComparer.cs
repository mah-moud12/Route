using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_04
{
    class StringEqualityComparer : IEqualityComparer /*مينفعش استخدم النسخه ال Generic علشان ال Hashtable بياخد العاديه */
    {
        public new bool Equals(object? x, object? y)
        {
            string? X = x as string;
            if (y is string value && X is not null)
                return X.ToLower().Equals(value.ToLower());
            return false;
        }

        public int GetHashCode(object obj)
        {
            string? value = obj as string;
            return value?.ToLower().GetHashCode()??throw new ArgumentException("Object is not string");
        }
        // 🔎 الخلاصة:
        //خاصية واحدة → استخدم GetHashCode() بتاعها مباشرة.
        //أكتر من خاصية → ممكن تعملها يدوي، لكن الأفضل والأبسط تستخدم HashCode.Combine(...).
    }
}
