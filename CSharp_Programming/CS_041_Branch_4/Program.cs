using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_041_Branch_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("등급(A, B, C, D, F)을 입력하세요: ");
            string grade = Console.ReadLine();

            switch (grade) 
            {
                case "A":
                    Console.WriteLine("90점 이상입니다.");
                    break;

                case "B":
                    Console.WriteLine("80점 이상입니다.");
                    break;

                case "C":
                    Console.WriteLine("70점 이상입니다.");
                    break;

                case "D":
                    Console.WriteLine("60점 이상입니다.");
                    break;

                case "F":
                    Console.WriteLine("60점 미만입니다.");
                    break;

                default:
                    Console.WriteLine("잘못 입력했습니다.");
                    break;
            }
        }
    }
}
