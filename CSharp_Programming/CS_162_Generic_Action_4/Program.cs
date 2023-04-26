using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_162_Generic_Action_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iFound = 0;
            int jFound = 0;


            // 이중 for 문을 람다문을 사용하여 빠져나온다.
            new Action(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (j == 3)
                        {
                            iFound = i;
                            jFound = j;

                            return;
                        }

                        Console.WriteLine("i: {0}, j: {1}", i, j);
                    }
                }
            })();
            

            Console.WriteLine("iFound: {0}, jFound: {1}", iFound, jFound);
        }
    }
}
