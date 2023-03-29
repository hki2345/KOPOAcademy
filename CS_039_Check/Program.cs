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



            switch(score / 10)
            {
                case 9:
                    Console.WriteLine("해당 점수의 등급은 A입니다.");
                    break;

                case 8:
                    Console.WriteLine("해당 점수의 등급은 B입니다.");
                    break;

                case 7:
                    Console.WriteLine("해당 점수의 등급은 C입니다.");
                    break;

                case 6:
                    Console.WriteLine("해당 점수의 등급은 D입니다.");
                    break;

                default:
                    Console.WriteLine("해당 점수의 등급은 F입니다.");
                    break;
            }
        }
    }
}
