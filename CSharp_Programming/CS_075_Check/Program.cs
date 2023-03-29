using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CS_075_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== 학생부 성적표 ==");
            Console.Write("총 학생 수를 입력하세요: ");
            int studentNum = int.Parse(Console.ReadLine());

            int[,] scoreArr = new int[studentNum, 3];
            int[] sumArr = new int[3];
            double[] avgArr = new double[3];

            Console.WriteLine();

            for (int i = 0; i < studentNum; i++)
            {
                Console.Write("{0}번째 학생의 국어 점수를 입력하세요: ", i + 1);
                scoreArr[i, 0] = int.Parse(Console.ReadLine());

                Console.Write("{0}번째 학생의 영어 점수를 입력하세요: ", i + 1);
                scoreArr[i, 1] = int.Parse(Console.ReadLine());

                Console.Write("{0}번째 학생의 수학 점수를 입력하세요: ", i + 1);
                scoreArr[i, 2] = int.Parse(Console.ReadLine());

                sumArr[0] = sumArr[0] + scoreArr[i, 0];
                sumArr[1] = sumArr[1] + scoreArr[i, 1];
                sumArr[2] = sumArr[2] + scoreArr[i, 2];

                Console.WriteLine();
            }

            avgArr[0] = (double)sumArr[0] / scoreArr.GetLength(0);
            avgArr[1] = (double)sumArr[1] / scoreArr.GetLength(0);
            avgArr[2] = (double)sumArr[2] / scoreArr.GetLength(0);

            Console.WriteLine("번호\t국어\t영어\t수학");

            for (int i = 0; i < scoreArr.GetLength(0); i++)
            {
                Console.WriteLine("{0,3}\t{1,3}\t{2,3}\t{3,3}", i + 1, scoreArr[i, 0], scoreArr[i, 1], scoreArr[i, 2]);
            }

            Console.WriteLine("-------------------------------");
            Console.WriteLine("총합: \t{0}\t{1}\t{2}", sumArr[0], sumArr[1], sumArr[2]);
            Console.WriteLine("평균: \t{0,5:F1}\t{1,5:F1}\t{2,5:F1}", avgArr[0], avgArr[1], avgArr[2]);
        }
    }
}
