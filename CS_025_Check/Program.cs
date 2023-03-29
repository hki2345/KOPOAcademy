using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_025_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("국어 점수를 입력하세요: ");
            int kor = int.Parse(Console.ReadLine());

            Console.Write("영어 점수를 입력하세요: ");
            int eng = int.Parse(Console.ReadLine());

            Console.Write("수학 점수를 입력하세요: ");
            int math = int.Parse(Console.ReadLine());

            Console.WriteLine("국어: {0}, 영어: {1}, 수학: {2}", kor, eng, math);
        }
    }
}
