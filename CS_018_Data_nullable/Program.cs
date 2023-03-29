using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_018_Data_nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int? b = null;

            Console.WriteLine("a: {0}", a);
            Console.WriteLine("b: {0}", b);

            if(b.HasValue)
            {
                Console.WriteLine("변수 b에는 값이 있습니다!");
            }
        }
    }
}
