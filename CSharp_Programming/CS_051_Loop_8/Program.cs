using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_051_Loop_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Check = 0;
            for (; ; ) 
            {
                Console.WriteLine("for (; ;), {0}", Check++);
            }

            while (true)
            {
                Console.WriteLine("while (true)");
            }
        }
    }
}
