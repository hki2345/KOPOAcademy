using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_071_Array_Jagged
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] numArr = 
            {
                new int[] { 0, 1 },
                new int[] { 0, 1, 2 },
                new int[] { 0, 1, 2, 3 }
            };

            for (int i = 0; i < numArr.Length; i++)
            {
                for (int j = 0; j < numArr[i].Length; j++)
                {
                    Console.Write("[ {0} ]", numArr[i][j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine("numArr.Length: " + numArr.Length);
            Console.WriteLine("numArr.Length[0]: " + numArr[0].Length);
            Console.WriteLine("numArr.Length[1]: " + numArr[1].Length);
            Console.WriteLine("numArr.Length[2]: " + numArr[2].Length);

            foreach (var collection in numArr)
            {
                foreach (var item in collection)
                {
                    Console.Write("[ {0} ]", item);
                }

                Console.WriteLine();
            }
        }
    }
}
