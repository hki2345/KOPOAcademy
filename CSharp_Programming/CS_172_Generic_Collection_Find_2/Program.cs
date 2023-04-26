using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_172_Generic_Collection_Find_2
- Desc: 주어진 조건을 만족하는 요소를 찾는 방법
---------- ---------- ---------- ---------- ---------- */
namespace CS_172_Generic_Collection_Find_2 {
    class Program {
        static void Main(string[] args) {
            List<Dictionary<string, object>> list = new List<Dictionary<string, object>> {
                new Dictionary<string, object> { ["name"] = "철수",   ["age"] = 10, ["grade"] = 3 },
                new Dictionary<string, object> { ["name"] = "영희",   ["age"] = 11, ["grade"] = 4 },
                new Dictionary<string, object> { ["name"] = "민수",   ["age"] =  9, ["grade"] = 2 },
                new Dictionary<string, object> { ["name"] = "전학생", ["age"] = 12, ["grade"] = 5 },
                new Dictionary<string, object> { ["name"] = "복학생", ["age"] = 13, ["grade"] = 5 },
            };

            var findData = list.Find( x => (string)x["name"] == "민수" );

            Console.WriteLine("이름: {0}, 나이: {1}, 학년: {2}", findData["name"], findData["age"], findData["grade"]);

            Console.WriteLine();

            List<Dictionary<string, object>> findList = list.FindAll( x => (int)x["age"] > 10 );

            foreach (var item in findList) {
                Console.WriteLine("이름: {0}, 나이: {1}, 학년: {2}", item["name"], item["age"], item["grade"]);
            }
        }
    }
}
