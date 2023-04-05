using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_092_Check
{
    internal class Program
    {
        static void Print(int i, int j, int m)
        {
            if (i / m % 3 == 1 && j / m % 3 == 1)
                Console.Write(' ');
            else
                if(m == 1)
                    Console.Write("*");
                else    
                    Print(i, j, m / 3);
        }
        static void Main(string[] args)
        {
            int n = 3 * 3 * 3;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Print(i, j, n / 3);
                }

                Console.WriteLine();
            }
        }
    }
}
