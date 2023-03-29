using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_029_Operator_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            Console.WriteLine("i: {0}", i++); // 후치 연산
            Console.WriteLine("i: {0}", i);
            Console.WriteLine("i: {0}", ++i); // 전치 연산

            Console.WriteLine();

            int j = 10;

            Console.WriteLine("j: {0}", j--); // 후치 연산
            Console.WriteLine("j: {0}", j);
            Console.WriteLine("j: {0}", --j); // 전치 연산
        }
    }
}
