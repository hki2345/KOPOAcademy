using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_149_Collection_ArrayList_3
- Desc: ArrayList의 요소 제거 방법
---------- ---------- ---------- ---------- ---------- */
namespace CS_149_Collection_ArrayList_3 {
    class Program {
        static void Main(string[] args) {
            // RemoveAt(int index): 특정 인덱스의 요소를 제거한다.
            ArrayList arrayList1 = new ArrayList { 100, 200, 300, 400, 500 };

            arrayList1.RemoveAt(0);

            foreach (var item in arrayList1) {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            // RemoveRange(int index, int count): 특정 인덱스의 요소부터 특정 개수만큼 제거한다.
            ArrayList arrayList2 = new ArrayList { 100, 200, 300, 400, 500 };

            arrayList2.RemoveRange(0, 3);

            foreach (var item in arrayList2) {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            // Remove(object obj): 인덱스 0부터 시작하여 가장 먼저 발견되는 특정 데이터를 제거한다.
            ArrayList arrayList3 = new ArrayList { 100, 200, 300, 400, 500 };

            arrayList3.Remove(300);

            foreach (var item in arrayList3) {
                Console.WriteLine(item);
            }
        }
    }
}
