using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_154_Collection_Hashtable_3
- Desc: Hashtable의 요소 제거 방법
---------- ---------- ---------- ---------- ---------- */
namespace CS_154_Collection_Hashtable_3 {
    internal class Program {
        static void Main(string[] args) {
            // Remove(object obj): 특정 키의 요소를 제거한다.
            Hashtable hashtable = new Hashtable { ["name"] = "철수", ["age"] = 10, ["grade"] = 3 };

            hashtable.Remove("name");

            foreach (DictionaryEntry item in hashtable) {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
        }
    }
}
