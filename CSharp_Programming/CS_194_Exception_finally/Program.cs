using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_194_Exception_finally
- Desc: try catch 절차 이후, 예외 발생과 관련 없이 항상 마지막에 실행하는 절차
---------- ---------- ---------- ---------- ---------- */
namespace CS_194_Exception_finally {
    class Program {
        static void Main(string[] args) {
            Console.Write("정수를 입력하세요: ");
            string input = Console.ReadLine();

            try {
                int num = int.Parse(input);
                Console.WriteLine("num: {0}", num);

            } catch (Exception) {
                Console.WriteLine("입력한 문자열 {0}은 정수가 아닙니다!", input);

            } finally {
                Console.WriteLine("프로그램을 종료합니다.");
            }
        }
    }
}
