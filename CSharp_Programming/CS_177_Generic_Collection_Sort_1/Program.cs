using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_177_Generic_Collection_Sort_1
- Desc: 목록을 정렬하는 방법
---------- ---------- ---------- ---------- ---------- */
namespace CS_177_Generic_Collection_Sort_1 {
    class Program {
        static void Main(string[] args) {
            List<int> list = new List<int> { 100, 300, 500, 200, 400 };

            list.Sort();    // 오름차순 정렬

            foreach (var item in list) {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            list.Reverse(); // 역순으로

            foreach (var item in list) {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            list.Sort((a, b) => a.CompareTo(b));  // 오름차순 정렬

            foreach (var item in list) {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            list.Sort((a, b) => -a.CompareTo(b)); // 내림차순 정렬

            foreach (var item in list) {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("100과 200의 비교: {0}", 100.CompareTo(200)); // 앞의 값보다 뒤의 값이 크면:  -1
            Console.WriteLine("200과 100의 비교: {0}", 200.CompareTo(100)); // 앞의 값보다 뒤의 값이 작으면: 1
            Console.WriteLine("500과 500의 비교: {0}", 500.CompareTo(500)); // 앞의 값과 뒤의 값이 같으면:   0

            Console.WriteLine();

            List<string> strList = new List<string> { "가", "다", "마", "나", "라" };

            strList.Sort(); // 문자열도 정렬 가능

            foreach (var item in strList) {
                Console.WriteLine(item);
            }
        }
    }
}
