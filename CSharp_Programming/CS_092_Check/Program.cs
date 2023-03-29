using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_092_Check
{
    internal class Program
    {
        static void Print(int i, int j)
        {
            if (i % 3 == 1 && j % 3 == 1)
                Console.Write(' ');
            else
                Print(i / 3, j / 3);
        }
        static void Main(string[] args)
        {
            int n = 3 * 3 * 3;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Print(i, j);
                }

                Console.WriteLine();
            }
        }
    }
}
