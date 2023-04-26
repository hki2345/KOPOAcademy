using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_148_Collection_ArrayList_2
- Desc: ArrayList의 다양한 초기화 방법
---------- ---------- ---------- ---------- ---------- */
namespace CS_148_Collection_ArrayList_2 {
    class Program {
        static void Main(string[] args) {
            // 선언 이후 추가하는 방법
            ArrayList arrayList1 = new ArrayList();

            arrayList1.Add(100);
            arrayList1.Add(0.1);
            arrayList1.Add("apple");

            foreach (var item in arrayList1) {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            // 선언과 동시에 초기화하는 방법
            ArrayList arrayList2 = new ArrayList { 100, 0.1, "apple" };

            foreach (var item in arrayList2) {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            // 배열 데이터로 초기화하는 방법
            object[] arr = { 100, 0.1, "apple" };

            ArrayList arrayList3 = new ArrayList(arr);

            foreach (var item in arrayList3) {
                Console.WriteLine(item);
            }
        }
    }
}
