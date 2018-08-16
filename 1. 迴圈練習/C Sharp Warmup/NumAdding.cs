using System;

namespace C_Sharp_Warmup
{
    public class NumAdding
    {
        int i = 1;
        int sum = 0;
        public int AddingByWhile()
        {
            while (i < 100)
            {
                sum += i;
                i += 2;
            }
            return sum;
        }
        public int AddingByFor()
        {
            sum = 0;
            for (i = 1; i < 100; i += 2)
            {
                sum += i;
            }
            return sum;
        }
        public int AddingByDo()
        {
            i = 1;
            sum = 0;
            do
            {
                sum += i;
                i += 2;
            }
            while (i < 100);
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NumAdding W = new NumAdding();
            Console.WriteLine(W.AddingByWhile());
            Console.WriteLine(W.AddingByFor());
            Console.WriteLine(W.AddingByDo());
        }
    }
}
