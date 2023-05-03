using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_176_Generic_Collection_Count
- Desc: 주어진 조건을 만족하는 요소의 개수를 찾는 방법
---------- ---------- ---------- ---------- ---------- */
namespace CS_176_Generic_Collection_Count {
    class Program {
        static void Main(string[] args) {
            List<int> list = new List<int> { 100, 200, 300, 400, 500 };

            List<int> findList = list.FindAll(x => x > 300);
            Console.WriteLine(findList.Count);

            int findListCount = list.Count(x => x > 300);
            Console.WriteLine(findListCount);
        }
    }
}
