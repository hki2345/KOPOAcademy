using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_061_Loop_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();


            int curMin = 1;
            int curMax = 100;
            int randNumber = rand.Next(curMin, curMax + 1);
            int index = 1;
            while (true)
            {
                Console.WriteLine("[{0}번째] {1} ~ {2} 사이 어떤 숫자일까요? (단, 0을 입력하면 종료)", index, curMin, curMax);
                int input = int.Parse(Console.ReadLine());

                if (input == 0)
                {
                    break;
                }
                
                if (input > randNumber)
                {
                    Console.WriteLine("{0}보다 작아요!", input);
                    if (curMax > input)
                    {
                        curMax = input;
                    }
                }
                else if (input < randNumber)
                {
                    Console.WriteLine("{0}보다 커요!", input);
                    if (curMin < input)
                    {
                        curMin = input;
                    }
                }
                else
                {
                    Console.WriteLine("정답!! {0}입니다. {1}번 도전하셨네유ㅎㅎ", randNumber, index);
                    break;
                }

                index++;
            }
        }
    }
}
