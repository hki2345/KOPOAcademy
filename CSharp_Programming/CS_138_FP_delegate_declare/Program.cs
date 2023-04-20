using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_138_FP_delegate_declare
{
    internal class Program
    {
        delegate int CalcDelegate(int a, int b);

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Sub(int a, int b)
        {
            return a - b;
        }

        static int Max(int a, int b)
        {
            return a * b;
        }

        static int Div(int a, int b)
        {
            return a / b;
        }
        

        static void Main(string[] args)
        {
            CalcDelegate dgAdd1 = new CalcDelegate(Add);
            CalcDelegate dgAdd2 = Add;
            CalcDelegate dgAdd3 = delegate (int a, int b)
            {
                return a + b;
            };
            CalcDelegate dgAdd4 = (a, b) => a + b;

            Console.WriteLine("1 + 1 = {0}", dgAdd1(1, 1));
            Console.WriteLine("2 + 2 = {0}", dgAdd2(2, 2));
            Console.WriteLine("3 + 3 = {0}", dgAdd3(3, 3));
            Console.WriteLine("4 + 4 = {0}", dgAdd4(4, 4));


            CalcDelegate dgSub1 = new CalcDelegate(Sub);
            CalcDelegate dgSub2 = Sub;
            CalcDelegate dgSub3 = delegate (int a, int b)
            {
                return a - b;
            };
            CalcDelegate dgSub4 = (a, b) => a - b;

            Console.WriteLine("1 - 1 = {0}", dgSub1(1, 1));
            Console.WriteLine("2 - 2 = {0}", dgSub2(2, 2));
            Console.WriteLine("3 - 3 = {0}", dgSub3(3, 3));
            Console.WriteLine("4 - 4 = {0}", dgSub4(4, 4));


            CalcDelegate dgMax1 = new CalcDelegate(Max);
            CalcDelegate dgMax2 = Max;
            CalcDelegate dgMax3 = delegate (int a, int b)
            {
                return a * b;
            };
            CalcDelegate dgMax4 = (a, b) => a * b;

            Console.WriteLine("1 * 1 = {0}", dgMax1(1, 1));
            Console.WriteLine("2 * 2 = {0}", dgMax2(2, 2));
            Console.WriteLine("3 * 3 = {0}", dgMax3(3, 3));
            Console.WriteLine("4 * 4 = {0}", dgMax4(4, 4));


            CalcDelegate dgDiv1 = new CalcDelegate(Div);
            CalcDelegate dgDiv2 = Div;
            CalcDelegate dgDiv3 = delegate (int a, int b)
            {
                return a / b;
            };
            CalcDelegate dgDiv4 = (a, b) => a / b;

            Console.WriteLine("1 / 1 = {0}", dgDiv1(1, 1));
            Console.WriteLine("2 / 2 = {0}", dgDiv2(2, 2));
            Console.WriteLine("3 / 3 = {0}", dgDiv3(3, 3));
            Console.WriteLine("4 / 4 = {0}", dgDiv4(4, 4));
        }
    }
}
