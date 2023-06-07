using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_191_Exception_instance_1 {
    class Program {
        static void Main(string[] args) {
            Console.Write("정수를 입력하세요: ");
            string input = Console.ReadLine();

            try {
                int num = int.Parse(input);
                Console.WriteLine("num: {0}", num);

            } catch (Exception e) {
                Console.WriteLine("# 예외 발생: {0}", e.GetType());
                Console.WriteLine("# 예외 내용: {0}", e.Message);
                Console.WriteLine("# 스택 트레이스\n{0}", e.StackTrace);

                Console.WriteLine();

                Console.WriteLine(e); // 위의 GetType(), Message, StackTrace를 모두 출력한다.
            }
        }
    }
}
