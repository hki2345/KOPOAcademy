using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_086_Function_default
{
    internal class Program
    {
        static void PrintScore(int kor = 0, int eng = 0, int math = 0)
        {
            Console.WriteLine("kor: {0}, eng: {1}, math: {2}", kor, eng, math);
        }

        static void Main(string[] args)
        {
            PrintScore();
            PrintScore(80);
            PrintScore(80, 60);
            PrintScore(80, 60, 100);
        }
    }
}
