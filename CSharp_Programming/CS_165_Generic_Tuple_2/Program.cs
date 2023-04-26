using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_165_Generic_Tuple_2
- Desc: Func의 리턴 타입으로 Tuple 사용
---------- ---------- ---------- ---------- ---------- */
namespace CS_165_Generic_Tuple_2 {
    class Program {
        static void Main(string[] args) {
            Tuple<int, int> data = new Func<int, int, Tuple<int, int>>((a, b) => {
                int quotient = a / b;
                int remainder = a % b;

                return new Tuple<int, int>(quotient, remainder);
            })(7, 3);

            Console.WriteLine("7 / 3 = {0} ··· {1}", data.Item1, data.Item2);
        }
    }
}
