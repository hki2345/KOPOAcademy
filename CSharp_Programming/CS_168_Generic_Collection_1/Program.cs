using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_168_Generic_Collection_1
- Desc: 일반화 컬렉션
---------- ---------- ---------- ---------- ---------- */
namespace CS_168_Generic_Collection_1 {
    class Program {
        static void Main(string[] args) {
            // 일반화 ArrayList: List<T>
            List<int> list = new List<int> { 100, 200, 300 };

            // 일반화 Stack: Stack<T>
            Stack<int> stack = new Stack<int>(new int[] { 100, 200, 300 });

            // 일반화 Queue: Queue<T>
            Queue<int> queue = new Queue<int>(new int[] { 100, 200, 300 });

            // 일반화 Hashtable: Dictionary<TKey, TValue>
            Dictionary<string, object> dictionary = new Dictionary<string, object> { ["name"] = "철수", ["age"] = 10, ["grade"] = 3 };

            Console.WriteLine("list type: {0}", list.GetType());
            Console.WriteLine("stack type: {0}", stack.GetType());
            Console.WriteLine("queue type: {0}", queue.GetType());
            Console.WriteLine("dictionary type: {0}", dictionary.GetType());

            Console.WriteLine();

            // Hashtable의 요소는 DictionaryEntry 형식이나, Dictionary의 요소는 KeyValuePair<TKey, TValue> 형식이다.
            foreach (KeyValuePair<string, object> item in dictionary) {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
        }
    }
}
