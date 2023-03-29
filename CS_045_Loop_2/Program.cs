using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_045_Loop_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.Write("1부터 N까지 합, N을 입력하세요: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0}번째: {1} + {2}", i, sum, i);
                sum += i;
                Console.WriteLine(" = {0}", sum);
            }

            Console.WriteLine("1부터 {0}까지 합은 {1}입니다.", n, sum);
        }
    }
}
