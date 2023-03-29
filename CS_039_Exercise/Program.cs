using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_039_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score;

            Console.Write("점수를 입력하세요: ");
            score = Convert.ToInt32(Console.ReadLine());

            if (score > 100 || score < 0)
            {
                Console.WriteLine("유효하지 않는 점수입니다.");
            }
            else if (score >= 90)
            {
                Console.WriteLine("해당 점수의 등급은 A입니다.");
            }
            else if (score >= 80)
            {
                Console.WriteLine("해당 점수의 등급은 B입니다.");
            }
            else if (score >= 70)
            {
                Console.WriteLine("해당 점수의 등급은 C입니다.");
            }
            else if (score >= 60)
            {
                Console.WriteLine("해당 점수의 등급은 D입니다.");
            }
            else
            {
                Console.WriteLine("해당 점수의 등급은 F입니다.");
            }
        }
    }
}
