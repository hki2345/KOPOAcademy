using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_181_LINQ_where
- Desc: Language-Integrated Query
---------- ---------- ---------- ---------- ---------- */
namespace CS_181_LINQ_where {
    class Program {
        static void Main(string[] args) {
            // LINQ
            ////////// ////////// ////////// ////////// //////////
            int[] arr = new int[] { 100, 200, 300, 400, 500 };

            IEnumerable<int> result = from data in arr
                                      where data > 300
                                      select data;

            foreach (var item in result) {
                Console.WriteLine(item);
            }
            ////////// ////////// ////////// ////////// //////////

            Console.WriteLine();

            // 동일한 작업을 FindAll 메서드와 람다 식을 사용하여 작성
            ////////// ////////// ////////// ////////// //////////
            List<int> list = new List<int> { 100, 200, 300, 400, 500 };

            List<int> findList = list.FindAll(x => x > 300);

            foreach (var item in findList) {
                Console.WriteLine(item);
            }
            ////////// ////////// ////////// ////////// //////////
        }
    }
}
