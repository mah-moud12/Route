using Demo_03.Class;
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System;
using Demo_03.Inhertance;
using Common;

namespace Demo_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Class
            //Create Instance Or Object From Car
            //Car C1;
            // Allocate 4 Byte in Stack [Null]  

            //C1 = new Car(11,"BMW",1010);
            //Class
            //اول حاجه ال compiler هيروح يعمل generate empty paramterless Constructor وده مش بعمل intialize ل Attribute لإنه empty مش بيعمل حاجه 
            //طب مين اللي بيعمل initialize ل Attribute اللي بعملها هي (new) هيا اللي بتروع تعمل initialize في Heap
            //note: empty parameterless Constructor بيتعمل وقت لما ميكونش فيه Constructor 
            //اعمل debug وانت تفهم 

            //Struct
            //ده كله على عكس اللي كان بيعملة Struct لإنه كان Compiler بيعمل Generate parameterless Constructor وده اللي كان بيعمل initialize ل Attribute 
            //note: parameterless Constructor سواء انت عملتو او مش عملتو هو بيتعمل 

            //Console.WriteLine(C1);

            //-------------------------------------------------------

            //Car C1 = new Car(10);
            //Console.WriteLine(C1);


            #endregion

            #region Stack 
            //The stack is a memory region used for storing local variables and function call information.
            //It operates in a last -in, first -out (LIFO)manner.
            //Each function call allocates a new block of memory on the stack. البلوك ده بيكون فيه [parametre,local variable]
            //When the function returns, its memory block is deallocated.
            //Stack memory allocation and deallocation is very fast وبيكون سريع لما بعمل access 
            //بيكون سريع برضو انه بيكون عبارة عن تسلسل يعني كلو ورا بعضو  مش متنتورين : 
            //        [Stack Pointer]
            //              ↓
            //          [آخر دالة]
            //         [اللي قبلها]
            //        [اللي قبل كده]
            //The stack has a fixed size and limited capacity.
            //Exceeding the stack limit causes a stack overflow, which can crash the program or cause unpredictable behavior.
            #endregion

            #region Heap
            //The heap is a memory region used to store objects [actual data]
            //It is called a “heap” because it is unordered and allows random access.
            //يعني اي بطريقة عشوائيه يعني عن طريق المؤشر بوصل للي انا عاوز مش بوصل بالترتيب 
            //In C#, objects are dynamically allocated on the heap using the new keyword.
            //The garbage collector(GC) is responsible for automatically deallocating memory when objects are no longer needed.
            //The heap is more flexible than the stack(not limited in size).
            //However, memory allocation and deallocation is slower on the heap.
            //This slowness is due to the GC needing to monitor, track, and manage memory usage continuously.
            // وبرضو لما بيجي يعم allocate في الميموري بياخد اقرب مكان ليه مش بيروح على مكان محدد
            #endregion

            #region Inhertance 
            //Parent P01 = new Parent();// Error علشان فيه User-Define Constructor
            Parent P01 = new Parent(10,20);

            Console.WriteLine(P01);
            Console.WriteLine(P01.Product());
            Parent.myFun();

            //--------------------------------------------
            Child C01 = new Child(10,20,30);
            C01.myFun();
            Console.WriteLine(C01);
            Console.WriteLine(C01.Product());
            #endregion

            #region Access Modifier
            //TypeA T01 = new TypeA();
            ////T01.A = 10; // Error
            ////T01.B = 20; // Error
            ////T01.C = 30; // Error
            ////T01.X = 80; // Error
            ////T01.Y = 20;  // Error
            //T01.Z = 50;

            //------------------
            //TypeB T01 = new TypeB();
            //T01.A = 10; // Error
            //T01.B = 20; // Error
            //T01.C = 30; // Error
            //T01.X = 80; // Error
            //T01.Y = 20;  // Error
            //T01.Z = 50;

            Inher I01 = new Inher();
            //I01.C = 10;
            #endregion
        }
    }
}
