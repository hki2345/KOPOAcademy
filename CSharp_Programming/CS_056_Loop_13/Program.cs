using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_056_Loop_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if(j == 3)
                    {
                        goto EXIT;
                    }

                    Console.WriteLine("i: {0}, j: {1}", i, j);
                }
            }

        EXIT:;
        }
    }
}
