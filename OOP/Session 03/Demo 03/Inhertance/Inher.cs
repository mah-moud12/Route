using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
namespace Demo_03.Inhertance
{
    class Inher:TypeB
    {
        public Inher()
        {
            //A = 10; // Error لإنه لازم يكون وارث في نفس البروجكت 
            B = 20;// اكني عرفتها هنا   protected 
            C = 30;// اكني عرفتها هنا   protected internal
            //X = 80; // Error
            //Y = 20; // internal
            Z = 50;
        }


    }
}
