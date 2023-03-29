using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_026_Opeartor_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1 + 2; // 더하기
            Console.WriteLine("1 + 2 = {0}", a);

            int b = 5 + 3; // 빼기
            Console.WriteLine("5 + 3 = {0}", b);

            int c = 2 * 3; // 곱하기
            Console.WriteLine("2 * 3 = {0}", c);

            int d = 6 / 2; // 나누기
            Console.WriteLine("6 / 2 = {0}", d);

            int e = 7 % 3; // 나머지
            Console.WriteLine("7 % 3 = {0}", e);

            int f = 1 + 2 * 3;
            Console.WriteLine("1 + 2 * 3 = {0}", f);

            int g = (1 + 2) * 3;
            Console.WriteLine("(1 + 2) * 3 = {0}", g);
        }
    }
}
