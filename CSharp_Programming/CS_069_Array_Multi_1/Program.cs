using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_069_Array_Multi_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numArr = { { 11, 12, 13 }, { 21, 22, 23 } };

            for (int i = 0; i < numArr.GetLength(0); i++)
            {
                for (int j = 0; j < numArr.GetLength(1); j++)
                {
                    Console.Write("[ {0} ]", numArr[i, j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine("numArr.Length: " + numArr.Length);
            Console.WriteLine("numArr.GetLength(0): " + numArr.GetLength(0));
            Console.WriteLine("numArr.GetLength(1): " + numArr.GetLength(1));
        }
    }
}
