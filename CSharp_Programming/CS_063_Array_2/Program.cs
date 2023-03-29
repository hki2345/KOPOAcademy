using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_063_Array_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArr1 = new int[3] { 0, 1, 2 };
            int[] numArr2 = new int[] { 0, 1, 2 };
            int[] numArr3 = {0, 1 , 2 };

            for (int i = 0; i < numArr1.Length; i++)
            {
                Console.WriteLine(numArr1[i]);
            }

            for (int i = 0;i < numArr2.Length; i++)
            {
                var item = numArr2[i];
                Console.WriteLine(item);
            }

            foreach (var item in numArr3)
            {
                Console.WriteLine(item);
            }
        }
    }
}
