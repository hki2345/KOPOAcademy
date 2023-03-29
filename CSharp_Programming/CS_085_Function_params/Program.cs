using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_085_Function_params
{
    internal class Program
    {
        static int TotalScore(params int[] score)
        {
            int result = 0;

            for (int i = 0; i< score.Length; i++)
            {
                result += score[i];
            }

            return result;
        }

        static void Main(string[] args)
        {
            int kor = 80;
            int eng = 60;
            int math = 100;

            Console.WriteLine("TotalScore(kor, eng, math): {0}", TotalScore(kor, eng, math, 50, 60));
        }
    }
}
