using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_161_Generic_Action_3
- Desc: 익명 함수를 변수에 담지 않고 실행하는 방법
---------- ---------- ---------- ---------- ---------- */
namespace CS_161_Generic_Action_3 {
    class Program {
        static void Main(string[] args) {
            // 1. 익명 함수를 변수에 담아 사용하는 방법
            Action temp = () => Console.WriteLine("Hello, world!");

            temp();

            // 2. 익명 함수를 형변환하여 바로 사용하는 방법
            ((Action)(() => Console.WriteLine("Hello, world!")))();

            // 3. 익명 함수 인스턴스를 생성하여 바로 사용하는 방법
            new Action(() => Console.WriteLine("Hello, world!"))();
        }
    }
}
