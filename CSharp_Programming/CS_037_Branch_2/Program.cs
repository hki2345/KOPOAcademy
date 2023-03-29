using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_037_Branch_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("정수를 입력하세요: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("입력한 수는 짝수입니다.");
            }
            else
            {
                Console.WriteLine("입력한 수는 홀수입니다.");
            }
        }
    }
}
