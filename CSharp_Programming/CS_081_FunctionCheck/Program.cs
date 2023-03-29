using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CS_081_FunctionCheck
{
    internal class Program
    {
        static int Hap(int a, int b, int c)
        {
            return a + b + c;
        }

        static int Pyung(int a, int b, int c)
        {
            return (a + b + c) / 3;
        }

        static int MaxScore(int a, int b, int c)
        {
            //if (a > b)
            //{
            //    if (a > c)  return a;
            //    else        return c;
            //}

            //else if (b > c)
            //{
            //    if (b > a)  return b;
            //    else        return a;
            //}

            return a > b && a > c ? a : b > c ? b : c;
        }

        static void Main(string[] args)
        {
            Console.Write("국어 점수를 입력하세요: ");
            int tmpX = int.Parse(Console.ReadLine());

            Console.Write("영어 점수를 입력하세요: ");
            int tmpY = int.Parse(Console.ReadLine());

            Console.Write("수학 점수를 입력하세요: ");
            int tmpZ = int.Parse(Console.ReadLine());

            Console.WriteLine("합계: {0}", Hap(tmpX, tmpY, tmpZ));
            Console.WriteLine("평균: {0}", Pyung(tmpX, tmpY, tmpZ));
            Console.WriteLine("가장 높은 점수: {0}", MaxScore(tmpX, tmpY, tmpZ));
        }
    }
}
