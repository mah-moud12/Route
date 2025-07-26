using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Demo_02.Encapsulation
{
    struct PhoneNotebook
    {
        #region Attribute 
        string[] names;
        int[] numbers;
        int size;
        #endregion
        public int Size { get { return size; } }

        #region Constructor
        public PhoneNotebook(int Size)
        {
            size = Size;
            names = new string[size];
            numbers = new int[size];
        }
        #endregion

        #region Getter and Setter

        public void AddPerson(int position,string name,int number)
        {
            if (size != 0) 
                if(position>=0 && position < size)
                {
                    numbers[position] = number;
                    names[position] = name;
                }
        }

        public int? GetPosition(string name)
        {
            if(names is not null)
                for (int i = 0; i < size; i++)
                    if (names[i] == name)
                        return i;
            return null;
        }

        public string? GetNumber(string name)
        {
            int? pos = GetPosition(name);
            if (pos is not null)
                return Convert.ToString(numbers[(int)pos]);
            else
                return "Person Is Not Exist";
        }

        public void SetNumber(string name,int newNumber)
        {
            int? pos = GetPosition(name);
            if (pos is not null)
                numbers[(int)pos] = newNumber;
        }

        public void DisplayAllPerson()
        {
            if (size != 0 && names[0] != null)
            {
                Console.WriteLine($"Index|Name|Number\n-----------------");
                for(int i = 0; i < size; i++)
                    Console.Write($"{GetPosition(names[i])}|{names[i]}|{numbers[i]}\n");
            }
        }

        #endregion

        public int? this [string name]
        {
            get
            {
                int? pos = GetPosition(name);
                if (pos is not null)
                    return numbers[(int)pos];
                else
                    return null;
            }
            set
            {
                int? pos = GetPosition(name);
                if (pos is not null)
                    if(value is not null)
                        numbers[(int)pos] = (int)value;
            }
        }

        public string this[int index]
        {
            get
            {
               if(size!=0 && names[0]!=null)
                    return $"{index}|{names[index]}|{numbers[index]}";
                else
                    return "";
            }
        }


    }
}
