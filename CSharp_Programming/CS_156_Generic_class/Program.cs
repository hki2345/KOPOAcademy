using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_156_Generic_class
- Desc: 일반화 클래스
---------- ---------- ---------- ---------- ---------- */
namespace CS_156_Generic_class {
    class Box<T> {
        public T data;
    }

    class Program {
        static void Main(string[] args) {
            Box<int> box1 = new Box<int>();
            Box<double> box2 = new Box<double>();
            Box<string> box3 = new Box<string>();

            box1.data = 100;
            box2.data = 0.1;
            box3.data = "apple";

            // int로 생성하면 string을 넣을 수 없다! (오류 발생)
            // box1.value = "hundred";

            Console.WriteLine("box1 data: {0}, type: {1}", box1.data, box1.data.GetType());
            Console.WriteLine("box2 data: {0}, type: {1}", box2.data, box2.data.GetType());
            Console.WriteLine("box3 data: {0}, type: {1}", box3.data, box3.data.GetType());
        }
    }
}
