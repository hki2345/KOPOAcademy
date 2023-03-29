using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_034_Operator_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 15;                               // 0000 1111
            int b = 22;                               // 0001 0110
            int c = (a & b);                   // 0000 0110 -> 6
            Console.WriteLine("a & b = {0}", c);

            // 0000 1111
            // 0001 0110
            int d = (a | b);                   // 0001 1111 -> 31
            Console.WriteLine("a | b = {0}", d);

            // 0000 1111
            // 0001 0110
            int e = (a ^ b);                   // 0001 1001 -> 25
            Console.WriteLine("a ^ b = {0}", e);


            // 0000 1111
            int f = (a<< 1);                   // 0001 1110 -> 30 (왼쪽으로 1시프트 -> 2배 증가)
            Console.WriteLine("a << 1 = {0}", f);

            // 0001 0110
            int g = (b >> 1);                  // 0000 1011 -> 11 (왼쪽으로 1시프트 -> 2로 나눔)
            Console.WriteLine("b >> 1 = {0}", g);

            // 0000 1111
            int h = (~a);                      // 1111 0000 -> -16
            Console.WriteLine("~a = {0}", h);

            // 0000 1111
            // 1111 0000 -> -16                                                     
            int i = (~a >> 1);                 // 1111 1000 -> -8 (CPU에 따라 다른 결과가 나올 수 있음)
            Console.WriteLine("~a >> 1 = {0}", i);

            Console.WriteLine();


            // 비트 출력 방법
            Console.WriteLine(Convert.ToString(a, 2).PadLeft(8, '0'));
            Console.WriteLine(Convert.ToString(b, 2).PadLeft(8, '0'));
        }
    }
}
