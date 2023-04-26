using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_152_Collection_Hashtable_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();

            hashtable.Add("name", "철수");
            hashtable.Add("age", "10");
            hashtable.Add("grade", "3");

            Console.WriteLine(hashtable["name"]);
            Console.WriteLine(hashtable["age"]);
            Console.WriteLine(hashtable["grade"]);

            Console.WriteLine();

            foreach (string key in hashtable.Keys)
            {
                Console.WriteLine(hashtable[key]);
            }

            Console.WriteLine();

            foreach (string key in hashtable.Values)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine();

            // 키와 값이 쌍으로 이루어진 객체
            foreach(DictionaryEntry entry in hashtable)
            {
                Console.WriteLine(entry.Value);
            }

            Console.WriteLine();


            // 선언과 동시에 초기화
            Hashtable hashtable1 = new Hashtable 
            { 
                { "name", "철수" },
                { "age", 10 },
                { "grade", 3 }
            };

            foreach (DictionaryEntry entry in hashtable1)
            {
                Console.WriteLine(entry.Value);
            }
        }
    }
}
