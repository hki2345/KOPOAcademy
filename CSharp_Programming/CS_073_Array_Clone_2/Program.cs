using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_073_Array_Clone2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("# 가변 배열에서의 깊은 복사");
            int[][] newArr =
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 }
            };

            int[][] newArrCopy = new int[newArr.Length][];
            for (int i = 0; i < newArr.Length; i++)
            {
                newArrCopy[i] = (int[])newArr[i].Clone();
            }

            newArrCopy[0][0] = 500;

            foreach (var collection in newArr)
            {
                foreach (var item in collection)
                {
                    Console.Write("[ {0} ]", item);
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            foreach (var collection in newArrCopy)
            {
                foreach(var item in collection)
                {
                    Console.Write("[ {0} ]", item);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
