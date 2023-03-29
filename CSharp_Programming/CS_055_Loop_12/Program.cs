using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_055_Loop_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    goto EXIT;
                }

                Console.WriteLine(i);
            }

            Console.WriteLine("EXIT 라벨 이전 출력");

        EXIT:
            Console.WriteLine("EXIT 라벨 이후 출력");
        }
    }
}
