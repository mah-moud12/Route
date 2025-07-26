using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task_02
{
    struct Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        

        public static string? GetOldestPerson(Person p01,Person p02, Person p03)
        {
            Person[] personArr = new Person[3];
            personArr[0] = p01;
            personArr[1] = p02;
            personArr[2] = p03;

            int max = p01.Age;
            if (p02.Age > max)
                max = p02.Age;
            if (p03.Age > max)
                max = p03.Age;
            
            for (int i = 0; i < personArr.Length; i++)
            {
                if (personArr[i].Age == max)
                    return $"Name : {personArr[i].Name} | Age : {personArr[i].Age}";
            }
            return null;
        }

        public static void SetPerson(ref Person p01, ref Person p02, ref Person p03)
        {

            Console.Write("Enter Your Name For Point 01 : ");
            string Name01 = Console.ReadLine() ?? "No Name Entered";
            Console.Write("Enter Your Age For Point 01 : ");
            bool falgAge01;
            int Age01;
            int i01 = 0;
            do
            {
                falgAge01 = int.TryParse(Console.ReadLine(), out Age01);
                if (i01 > 0)
                {
                    Console.Write("Try Again Enter age : ");
                }
                i01++;
            } while (!falgAge01);

            Console.Write("Enter Your Name For Point 02 : ");
            string Name02 = Console.ReadLine() ?? "No Name Entered";
            Console.Write("Enter Your Age For Point 02 : ");
            bool falgAge02;
            int Age02;
            int i02 = 0;
            do
            {
                falgAge02 = int.TryParse(Console.ReadLine(), out Age02);
                if (i02 > 0)
                {
                    Console.Write("Try Again Enter age : ");
                }
                i02++;
            } while (!falgAge02);

            Console.Write("Enter Your Name For Point 03 : ");
            string Name03 = Console.ReadLine() ?? "No Name Entered";
            Console.Write("Enter Your Age For Point 03 : ");
            bool falgAge03;
            int Age03;
            int i03 = 0;
            do
            {
                falgAge03 = int.TryParse(Console.ReadLine(), out Age03);
                if (i03 > 0)
                {
                    Console.Write("Try Again Enter age : ");
                }
                i03++;
            } while (!falgAge03);



            p01.Name = Name01;
            p01.Age = Age01;

            p02.Name = Name02;
            p02.Age = Age02;

            p03.Name = Name03;
            p03.Age = Age03;
        }
    }
}
