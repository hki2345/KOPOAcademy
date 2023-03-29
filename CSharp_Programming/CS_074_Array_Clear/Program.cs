using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_074_Array_Clear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = { 111, 222, 333 };

            foreach (var item in numArr)
            {
                Console.Write("[ {0} ]",item);
            }

            Console.WriteLine();

            Array.Clear(numArr, 0, numArr.Length);

            foreach (var item in numArr)
            {
                Console.Write("[ {0} ]", item);
            }

            Console.WriteLine();
        }
    }
}
