using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TypeA
    {
        private int X;
        internal int Y;//ملهاش دعوه بالوراثه
        public int Z;
        private protected int A;
        protected int B;
        protected internal int C;
        // بدون inhertance
        //   private -> تقدر تشوفه جوه نفس الكلاس 
        //   internal -> تقدر تشوفه في كلاس تاني عادي بس لازم يكون جوا نفس البروجكت 
        //   public  -> تقدر تشوفه من اي حته 
        //   private protected -> شيل protected وعاملها عادي 
        //   protected ->  protected وعاملها عادي 
        //   protected internal ->  protected وعاملها عادي 


        //لو فيه inhertance
        //   private -> تقدر تشوفه جوه نفس الكلاس 
        //   internal -> تقدر تشوفه في كلاس تاني عادي بس لازم يكون جوا نفس البروجكت 
        //   public  -> تقدر تشوفه من اي حته 
        //   private protected -> دي لو ورثتها مثلا لكلاس في نفس البروجكت هتتورث بس اكنك عرفتها في الكلاس ده بس private protected بس لو اخدت منها instance بشيل protected واتعامل معاها  
        //   protected ->  دي لو ورثتها مثلا لكلاس في نفس البروجكت هتتورث بس اكنك عرفتها في الكلاس ده بس protected بس لو اخدت منها instance بشيل protected واتعامل معاها 
        //   protected internal  ->  دي لو ورثتها مثلا لكلاس في نفس البروجكت هتتورث بس اكنك عرفتها في الكلاس ده بس protected internal بس لو اخدت منها instance بشيل protected واتعامل معاها 

        public TypeA()
        {
            X = 0;
            Y = 10;
            Z = 20;
            A = 40;
            B = 50;
            C = 60;
        }

    }
}
