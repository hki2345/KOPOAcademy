using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_140_FP_delegate_assignment
{
    internal class Program
    {
        delegate void CalcDelegate(int a, int b);

        static void Add(int a, int b) { Console.WriteLine("a + b = {0}", a + b); }
        static void Sub(int a, int b) { Console.WriteLine("a - b = {0}", a - b); }
        static void Mul(int a, int b) { Console.WriteLine("a * b = {0}", a * b); }
        static void Div(int a, int b) { Console.WriteLine("a / b = {0}", a / b); }


        // 반환 값이 있을 경우... 
        // 맨 마지막 리턴값만 들고 있음... 배열로 들고 있으면 좋았을 듯
        static void Main(string[] args)
        {
            CalcDelegate calc = Add;
            calc += Sub;
            calc += Mul;
            calc += Div;

            calc(10, 5);

            Console.WriteLine(calc);
            calc -= Add;
            calc(10, 5);

            calc -= Sub;
            calc(10, 5);

            calc -= Mul;
            calc(10, 5);

            calc -= Div;
            calc(10, 5);
        }
    }
}
