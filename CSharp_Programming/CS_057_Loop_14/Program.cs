using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_057_Loop_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    return;
                }

                Console.WriteLine(i);
            }

            Console.WriteLine("for문 이후 출력");
        }
    }
}
