using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_167_Generic_ValueTuple_2
- Desc: Func의 리턴 타입으로 ValueTuple 사용
---------- ---------- ---------- ---------- ---------- */
namespace CS_167_Generic_ValueTuple_2 {
    class Program {
        static void Main(string[] args) {

            // 실무에서는
            // var data = new Func<int, int, (int, int)>((a, b) 식으로 리턴형을 var로 받는다고 한다.
            (int, int) data = new Func<int, int, (int, int)>((a, b) => {
                int quotient = a / b;
                int remainder = a % b;

                return (quotient, remainder);
            })(7, 3);

            Console.WriteLine("7 / 3 = {0} ··· {1}", data.Item1, data.Item2);
        }
    }
}
