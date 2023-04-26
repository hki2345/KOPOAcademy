using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_169_Generic_Collection_2
- Desc: List<Dictionary<string, object>>
---------- ---------- ---------- ---------- ---------- */
namespace CS_169_Generic_Collection_2 {
    class Program {
        static void Main(string[] args) {
            // var list = ...
            List<Dictionary<string, object>> list = new List<Dictionary<string, object>> {
                new Dictionary<string, object> { ["name"] = "철수", ["age"] = 10, ["grade"] = 3 },
                new Dictionary<string, object> { ["name"] = "영희", ["age"] = 11, ["grade"] = 4 },
                new Dictionary<string, object> { ["name"] = "민수", ["age"] =  9, ["grade"] = 2 }
            };

            foreach (var dictionary in list) {
                foreach (var item in dictionary) {
                    Console.Write("[{0}] = {1}\t", item.Key, item.Value);
                }

                Console.WriteLine();
            }
        }
    }
}
