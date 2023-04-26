using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_155_Generic_function
- Desc: 일반화 함수
---------- ---------- ---------- ---------- ---------- */
namespace CS_155_Generic_function {
    class Program {
        static void Print<T>(T data) {
            Console.WriteLine("data: {0}, type: {1}", data, data.GetType());
        }

        static void Main(string[] args) {
            Print(100);
            Print(0.1);
            Print("apple");
        }
    }
}
