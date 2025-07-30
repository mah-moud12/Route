using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TypeB:TypeA
    {
        public TypeB()
        {
            #region Not inhertance
            ////Not inhertance
            //TypeA T01 = new TypeA();
            ////T01.A = 10; // Error
            ////T01.B = 20; // Error
            //T01.C = 30;
            ////T01.X = 80; // Error
            //T01.Y = 20;
            //T01.Z = 50; 
            #endregion

            #region inhertance
            
            A = 10; // اكني عرفتها هنا   private protected
            B = 20;// اكني عرفتها هنا   protected 
            C = 30;// اكني عرفتها هنا   protected internal
            //X = 80; // Error
            Y = 20;
            Z = 50; 
            #endregion
        }
    }
}
