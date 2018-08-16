using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Warmup_2
{
    class FindName
    {
        string[] name = { "Gary", "Peanut", "Harry", "Joker", "Panther", "Skull","Mona", "Fox", "Noir", "Queen" };
        public string LongName()
        {
            string temp;
            for (int j = 0; j < name.Length - 1; j++)
            {
                for (int i = 0; i < name.Length - 1 - j; i++)
                {
                    if (name[i].Length < name[i + 1].Length)
                    {
                        temp = name[i];
                        name[i] = name[i + 1];
                        name[i + 1] = temp;
                    }
                }
            }
            return name[0];
        }
        public int HowManyNames()
        {
            int count = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i].Contains("o"))
                {
                    count++;
                }
            }
            return count;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FindName name = new FindName();
            Console.WriteLine("The longest name is : " + name.LongName());
            Console.WriteLine("The number of  names contain o is : " + name.HowManyNames());
        }
    }
}
