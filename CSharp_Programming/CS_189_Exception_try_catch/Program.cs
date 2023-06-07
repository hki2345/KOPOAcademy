using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_189_Exception_try_catch
- Desc: 예외 처리
---------- ---------- ---------- ---------- ---------- */
namespace CS_189_Exception_try_catch {
    class Program {
        static void Main(string[] args) {
            Console.Write("정수를 입력하세요: ");
            string input = Console.ReadLine();

			try {
                int num = int.Parse(input);
                Console.WriteLine("num: {0}", num);

            } catch (Exception) {
                Console.WriteLine("입력한 문자열 {0}은 정수가 아닙니다!", input);
            }
        }
    }
}
