using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_171_Generic_Collection_Find_1
- Desc: 주어진 조건을 만족하는 요소를 찾는 방법
---------- ---------- ---------- ---------- ---------- */
namespace CS_171_Generic_Collection_Find_1 {
    class Program {
        static void Main(string[] args) {
            List<int> list = new List<int> { 100, 200, 300, 400, 500 };

            int findData = list.Find( x => x == 300 );

            Console.WriteLine(findData);

            Console.WriteLine();

            List<int> findList = list.FindAll( x => x > 300 );

            foreach (var item in findList) {
                Console.WriteLine(item);
            }
        }
    }
}
