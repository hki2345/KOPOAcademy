using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_159_Generic_Action_1
- Desc: 간편하게 (반환값이 없는)함수 변수를 만드는 방법
---------- ---------- ---------- ---------- ---------- */
namespace CS_159_Generic_Action_1 {
    class Program {
        delegate void MyDelegate(int a, int b);

        static void Main(string[] args) {
            // 함수 변수를 만들려면 delegate로 형식을 만든 뒤에 해당 형식으로 변수를 만들어야 한다.
            MyDelegate myDelegate = (a, b) => Console.WriteLine("{0} + {1} = {2}", a, b, a + b);

            myDelegate(1, 2);

            // Action으로 delegate 형식 선언 없이 간편하게 (반환값이 없는)함수 변수를 만들 수 있다.
            Action<int, int> action = (a, b) => Console.WriteLine("{0} + {1} = {2}", a, b, a + b);

            action(1, 2);
        }
    }
}
