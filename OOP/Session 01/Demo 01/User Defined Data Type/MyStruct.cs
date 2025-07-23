using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_01.User_Defined_Data_Type
{
    internal struct MyStruct
    {
        //int Id;// Default Private
        // 1. Attributes [Fields] => Member Variable  
        public int Id01;
        public string name;
        //3. Properties[Full Property, Automatic Property, Indexer]
        //protected int Id02 { get; set; } //Error =>الاختلاف الحقيقي بين struct و class في access modifiers هو إن struct ما بيدعمش protected لأن مفيش وراثة!

        // Functions [Constructor , Getter Setter , Method]
        public static void funn01()
        {
            Console.WriteLine("Hello, Mahmoud");
        }


    }
}
