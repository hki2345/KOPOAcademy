using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_060_Loop_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int a;
            int b;
            int input;
            int count;
            int correct = 0;


            Console.WriteLine("== 수학문제 풀기 ==");
            Console.Write("수학문제 개수를 입력하세요: ");

            count = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < count; i++)
            {
                a = rand.Next(1, 100);
                b = rand.Next(1, 100);

                Console.WriteLine("{0}, 다음 두 수의 합을 구하세요. (총 {1}문제)", i + 1, count);
                Console.Write("{0} + {1} = ", a, b);
                input = int.Parse(Console.ReadLine());

                if(a+b == input)
                {
                    Console.WriteLine("정답!");
                    correct++;
                }
                else
                {
                    Console.WriteLine("오답! (정답은: {0})", a + b);
                }

                Console.WriteLine();
            }

            Console.WriteLine("== 결과 ==");
            Console.WriteLine("총 점수: {0}, ({1}개 정답)", 100 / count * correct, correct);
        }
    }
}
