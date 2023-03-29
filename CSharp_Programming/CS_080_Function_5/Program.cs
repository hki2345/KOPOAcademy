using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_080_Function_5
{
    class Program
    {
        static void Calculate(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            Console.WriteLine("{0} / {1} = {2}", a, b, (double)a / b);
        }

        static void Main(string[] args)
        {
            Console.Write("계산할 두 정수를 입력하세요: ");
            string input = Console.ReadLine();

            string[] inputArr = input.Split();

            int a = int.Parse(inputArr[0]);
            int b = int.Parse(inputArr[1]);

            Calculate(a, b);
        }
    }
}
