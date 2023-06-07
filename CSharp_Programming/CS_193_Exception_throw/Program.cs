using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_193_Exception_throw
- Desc: 예외 던지기
---------- ---------- ---------- ---------- ---------- */
namespace CS_193_Exception_throw {
    class Program {
        static void Main(string[] args) {
            Console.Write("0을 제외한 정수를 입력하세요: ");
            string input = Console.ReadLine();

            try {
                int num = int.Parse(input);

                if (num == 0) {
                    throw new Exception("0을 입력했습니다.");
                }

                Console.WriteLine("num: {0}", num);

            } catch (Exception e) {
                Console.WriteLine("예외 내용: {0}", e.Message);
            }
        }
    }
}
