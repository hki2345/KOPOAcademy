using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_160_Generic_Action_2
- Desc: 오브젝트 변수에 함수를 담는 방법
---------- ---------- ---------- ---------- ---------- */
namespace CS_160_Generic_Action_2 {
    class Program {
        static void Main(string[] args) {
            // 1. 담으려는 함수를 액션 타입 변수에 담은 뒤 해당 변수를 오브젝트 변수에 담는다.
            Action temp = () => Console.WriteLine("Hello, world!");

            object a = temp;

            ((Action)a)();

            // 2. 액션 타입으로 형변환하여 담는다.
            object b = (Action)(() => Console.WriteLine("Hello, world!"));

            ((Action)b)();

            // 3. 액션 생성자로 인스턴스를 생성한 뒤 담는다.
            object c = new Action(() => Console.WriteLine("Hello, world!"));

            ((Action)c)();
        }
    }
}
