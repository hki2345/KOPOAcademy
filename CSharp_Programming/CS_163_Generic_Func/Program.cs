using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_163_Generic_Func
- Desc: 간편하게 (반환값이 있는)함수 변수를 만드는 방법
---------- ---------- ---------- ---------- ---------- */
namespace CS_163_Generic_Func {
    class Program {
        delegate int MyDelegate(int a, int b);

        static void Main(string[] args) {
            // 함수 변수를 만들려면 delegate로 형식을 만든 뒤에 해당 형식으로 변수를 만들어야 한다.
            MyDelegate myDelegate = (a, b) => a + b;

            Console.WriteLine("1 + 2 = {0}", myDelegate(1, 2));

            // Func로 delegate 형식 선언 없이 간편하게 (반환값이 있는)함수 변수를 만들 수 있다.
            Func<int, int, int> Func = (a, b) => a + b;

            Console.WriteLine("1 + 2 = {0}", Func(1, 2));
        }
    }
}
