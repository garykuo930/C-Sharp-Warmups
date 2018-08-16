using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Warmup_3
{
    class CompareScore
    {
        public int MaxScore(int[] score)        //找出最高分數
        {
            int temp;
            for (int i = 0; i < score.Length - 1; i++)
            {
                for (int j = 0; j < score.Length - 1 - i; j++)
                {
                    if (score[j] < score[j + 1])
                    {
                        temp = score[j];
                        score[j] = score[j + 1];
                        score[j + 1] = temp;
                    }
                }
            }
            return score[0];
        }

        public int MinScore(int[] score)        //找出最低分數
        {
            int temp;
            for (int i = 0; i < score.Length - 1; i++)
            {
                for (int j = 0; j < score.Length - 1 - i; j++)
                {
                    if (score[j] > score[j + 1])
                    {
                        temp = score[j];
                        score[j] = score[j + 1];
                        score[j + 1] = temp;
                    }
                }
            }
            return score[0];
        }

        public int AvgScore(int[] score)        //計算平均分數
        {
            int avg, sum = 0;
            foreach (int i in score)
            {
                sum += i;
            }
            avg = sum / score.Length;
            return avg;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] score = new int[10];                                        //產生資料數為10的陣列
            CompareScore CS = new CompareScore();
            for (int i = 0; i < score.Length; i++)
            {
                System.Threading.Thread.Sleep(10);          //使Random產生真正的隨機數
                int RN = new Random().Next(1, 101);
                score[i] = RN;
            }
            Console.WriteLine("The Max Score is : " + CS.MaxScore(score));
            Console.WriteLine("The Min Score is : " + CS.MinScore(score));
            Console.WriteLine("The Avg Score is : " + CS.AvgScore(score));
            Console.ReadKey();
        }
    }
}
