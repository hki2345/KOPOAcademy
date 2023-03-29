using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_024_ReadLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("정수를 입력하세요: ");
            string s = Console.ReadLine();

            int a = int.Parse(s);

            Console.WriteLine("입력한 정수: {0}", a);
        }
    }
}
