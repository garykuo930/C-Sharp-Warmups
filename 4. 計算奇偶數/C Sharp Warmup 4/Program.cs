using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Warmup_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Odd_num = 0, Even_num = 0;
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                System.Threading.Thread.Sleep(10);
                int RN = new Random().Next(1, 101);
                numbers[i] = RN;
            }
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    Even_num++;
                }
                else
                {
                    Odd_num++;
                }
            }
            Console.WriteLine("偶數個數為：" + Even_num);
            Console.WriteLine("奇數個數為：" + Odd_num);
            Console.ReadKey();
        }
    }
}
