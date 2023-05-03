using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_178_Generic_Collection_Sort_2
- Desc: 목록을 정렬하는 방법
---------- ---------- ---------- ---------- ---------- */
namespace CS_178_Generic_Collection_Sort_2 {
    class Program {
        static void Main(string[] args) {
            List<Dictionary<string, object>> list = new List<Dictionary<string, object>> {
                new Dictionary<string, object> { ["name"] = "철수",   ["age"] = 10, ["grade"] = 3 },
                new Dictionary<string, object> { ["name"] = "영희",   ["age"] = 11, ["grade"] = 4 },
                new Dictionary<string, object> { ["name"] = "민수",   ["age"] =  9, ["grade"] = 2 },
                new Dictionary<string, object> { ["name"] = "전학생", ["age"] = 12, ["grade"] = 5 },
                new Dictionary<string, object> { ["name"] = "복학생", ["age"] = 13, ["grade"] = 5 },
            };

            // 정렬 기준이 없으므로 정렬할 수 없다! (오류 발생)
            // list.Sort();

            list.Sort((a, b) => ((string)a["name"]).CompareTo(b["name"])); // 이름순 정렬

            foreach (var item in list) {
                Console.WriteLine("이름: {0}, 나이: {1}, 학년: {2}", item["name"], item["age"], item["grade"]);
            }

            Console.WriteLine();

            list.Sort((a, b) => ((int)a["age"]).CompareTo(b["age"]));      // 나이순 정렬

            foreach (var item in list) {
                Console.WriteLine("이름: {0}, 나이: {1}, 학년: {2}", item["name"], item["age"], item["grade"]);
            }

            Console.WriteLine();

            list.Sort((a, b) => ((int)a["grade"]).CompareTo(b["grade"]));  // 학년순 정렬

            foreach (var item in list) {
                Console.WriteLine("이름: {0}, 나이: {1}, 학년: {2}", item["name"], item["age"], item["grade"]);
            }

            Console.WriteLine();

            list.Sort((a, b) => {
                int compare = ((int)a["grade"]).CompareTo(b["grade"]);

                if (compare == 0) { // 학년이 같으면 이름도 비교한다.
                    compare = ((string)a["name"]).CompareTo(b["name"]);
                }

                return compare;
            });

            foreach (var item in list) {
                Console.WriteLine("이름: {0}, 나이: {1}, 학년: {2}", item["name"], item["age"], item["grade"]);
            }
        }
    }
}
