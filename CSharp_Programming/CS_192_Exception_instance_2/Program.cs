using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_192_Exception_instance_2
- Desc: 예외 종류
---------- ---------- ---------- ---------- ---------- */
namespace CS_192_Exception_instance_2 {
    class Program {
        static void Main(string[] args) {
            Console.Write("255 이하의 양수를 입력하세요: ");
            string input = Console.ReadLine();

            try {
                byte num = byte.Parse(input);
                Console.WriteLine("num: {0}", num);

            } catch (OverflowException e) {
                Console.WriteLine("입력한 문자열 {0}은 255 이하의 양수가 아닙니다!", input);
                Console.WriteLine("예외 타입: {0}", e.GetType());

            } catch (FormatException e) {
                Console.WriteLine("입력한 문자열 {0}은 정수가 아닙니다!", input);
                Console.WriteLine("예외 타입: {0}", e.GetType());

            } catch (Exception e) {
                Console.WriteLine("기타 예외 발생!");
                Console.WriteLine("예외 타입: {0}", e.GetType());
            }
        }
    }
}
