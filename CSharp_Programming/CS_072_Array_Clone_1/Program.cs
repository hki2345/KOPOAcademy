using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_072_Array_Clone_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("# 얕은 복사");

            int[] numArr1 = { 0, 1, 2 };
            int[] numArr1Copy = numArr1;

            numArr1Copy[0] = 5;

            foreach(var item in numArr1)
                Console.Write("[ {0} ]", item);

            Console.WriteLine();

            foreach (var item in numArr1Copy)
                Console.Write("[ {0} ]", item);

            Console.WriteLine();


            Console.WriteLine("# 깊은 복사");

            int[] numArr2 = { 0, 1, 2 };
            int[] numArr2Copy = (int[])numArr1.Clone();

            numArr2Copy[0] = 5;

            foreach (var item in numArr2)
                Console.Write("[ {0} ]", item);

            Console.WriteLine();

            foreach (var item in numArr2Copy)
                Console.Write("[ {0} ]", item);

            Console.WriteLine();


        }
    }
}
