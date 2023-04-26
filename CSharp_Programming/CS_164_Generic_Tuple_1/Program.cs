using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_164_Generic_Tuple_1
- Desc: 여러 개의 데이터를 리턴하는 방법
---------- ---------- ---------- ---------- ---------- */
namespace CS_164_Generic_Tuple_1 {
    class Program {
        static Tuple<int, int> Divide(int a, int b) {
            int quotient = a / b;
            int remainder = a % b;

            return new Tuple<int, int>(quotient, remainder);
        }

        static void Main(string[] args) {
            Tuple<int, int> data = Divide(7, 3);

            Console.WriteLine("7 / 3 = {0} ··· {1}", data.Item1, data.Item2);
        }
    }
}
