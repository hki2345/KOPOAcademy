using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_153_Collection_Hashtable_2
- Desc: Hashtable의 다양한 초기화 방법
---------- ---------- ---------- ---------- ---------- */
namespace CS_153_Collection_Hashtable_2 {
    internal class Program {
        static void Main(string[] args) {
            // 선언 이후 추가하는 방법
            Hashtable hashtable1 = new Hashtable();

            hashtable1.Add("name", "철수");
            hashtable1.Add("age", 10);
            hashtable1.Add("grade", 3);

            foreach (DictionaryEntry item in hashtable1) {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }

            Console.WriteLine();

            // 선언 이후 추가하는 또다른 방법
            Hashtable hashtable2 = new Hashtable();

            hashtable2["name"] = "철수";
            hashtable2["age"] = 10;
            hashtable2["grade"] = 3;

            foreach (DictionaryEntry item in hashtable2) {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }

            Console.WriteLine();

            // 선언과 동시에 초기화하는 방법
            Hashtable hashtable3 = new Hashtable { { "name", "철수" }, { "age", 10 }, { "grade", 3 } };

            foreach (DictionaryEntry item in hashtable3) {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }

            Console.WriteLine();

            // 선언과 동시에 초기화하는 또다른 방법
            Hashtable hashtable4 = new Hashtable { ["name"] = "철수", ["age"] = 10, ["grade"] = 3 };

            foreach (DictionaryEntry item in hashtable4) {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
        }
    }
}
