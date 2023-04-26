using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_166_Generic_ValueTuple_1
- Desc: 여러 개의 데이터를 리턴하는 다양한 방법들
---------- ---------- ---------- ---------- ---------- */
namespace CS_166_Generic_ValueTuple_1 {
    class Program {
        static Tuple<int, int> TupleDivide(int a, int b) {
            int quotient = a / b;
            int remainder = a % b;

            return new Tuple<int, int>(quotient, remainder);
        }

        static (int, int) ValueTupleDivide(int a, int b) {
            int quotient = a / b;
            int remainder = a % b;

            return (quotient, remainder);
        }

        static (int quotient, int remainder) ValueTupleDivideComplete(int a, int b) {
            int quotient = a / b;
            int remainder = a % b;

            return (quotient, remainder);
        }

        static void Main(string[] args) {
            Tuple<int, int> tupleData = TupleDivide(7, 3);

            Console.WriteLine("7 / 3 = {0} ··· {1}", tupleData.Item1, tupleData.Item2);

            (int, int) valueTupleData = ValueTupleDivide(7, 3);
            (int quotient, int remainder) valueTupleDataComplete = ValueTupleDivide(7, 3);
            (int quotient, int remainder) = ValueTupleDivide(7, 3);

            Console.WriteLine("7 / 3 = {0} ··· {1}", valueTupleData.Item1, valueTupleData.Item2);
            Console.WriteLine("7 / 3 = {0} ··· {1}", valueTupleDataComplete.quotient, valueTupleDataComplete.remainder);
            Console.WriteLine("7 / 3 = {0} ··· {1}", quotient, remainder);

            Console.WriteLine("7 / 3 = {0}", ValueTupleDivideComplete(7, 3).quotient);
            Console.WriteLine("7 % 3 = {0}", ValueTupleDivideComplete(7, 3).remainder);

            // 실무에선 이방식 쓸듯?? 왜냐면 애초에 줄여서 쓰는 거면 이름 없애고 받을 떄도 튜풀로 안 받고 바로 함수에 넣는 식으로
            Console.WriteLine("T 7 / 3 = {0}", ValueTupleDivide(7, 3).Item1);
            Console.WriteLine("T 7 % 3 = {0}", ValueTupleDivide(7, 3).Item2);

            var data = ValueTupleDivideComplete(7, 3);

            Console.WriteLine("7 / 3 = {0} ··· {1}", data.quotient, data.remainder);
        }
    }
}
