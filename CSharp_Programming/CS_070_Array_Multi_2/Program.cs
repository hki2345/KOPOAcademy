using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_070_Array_Multi_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] numArr =
            {
                {
                    {111,112,113,114 },
                    {121,122,123,124 },
                    {131,132,133,134 }
                },
                {
                    {211,212,213,214 },
                    {221,222,223,224 },
                    {231,232,233,234 }
                }
            };

            for (int x = 0; x < numArr.GetLength(0); x++)
            {
                for (int y = 0; y < numArr.GetLength(1); y++)
                {
                    for(int z = 0; z < numArr.GetLength(2); z++)
                    {
                        Console.Write("[ {0} ]", numArr[x, y, z]);
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();
            }

            Console.WriteLine("numArr.Length: " + numArr.Rank);
            Console.WriteLine("numArr.GetLength(0): " + numArr.GetLength(0));
            Console.WriteLine("numArr.GetLength(1): " + numArr.GetLength(1));
            Console.WriteLine("numArr.GetLength(2): " + numArr.GetLength(2));
        }
    }
}
