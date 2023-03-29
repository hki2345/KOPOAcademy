using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_038_Operator_Branch_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("정수를 입력하세요: ");
            int num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("입력한 수는 양수입니다.");
            }
            else if(num<0)
            {
                Console.WriteLine("입력한 수는 음수입니다.");
            }
            else
            {
                Console.WriteLine("입력한 수는 0 입니다.");
            }
        }
    }
}
