using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace CS_053_Loop_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            while (true)
            {
                Console.Write("출력하고 싶은 구구단을 입력하세요 (0을 입력하면 종료): ");
                num = int.Parse(Console.ReadLine());

                if (num == 0)
                {
                    break;
                }

                for (int i = 1; i <= 9; i++)
                    Console.WriteLine("{0} * {1} = {2,2}", num, i, num * i);
            }

            Console.WriteLine("프로그램을 종료합니다.");
        }
    }
}
