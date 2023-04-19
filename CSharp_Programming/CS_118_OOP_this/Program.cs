using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_118_OOP_this
- Desc: 자기 자신 클래스 참조
---------- ---------- ---------- ---------- ---------- */
namespace CS_118_OOP_this {
    class Mammal {
        public string name;
        public int age;

        public Mammal(string name, int age) {
            this.name = name;
            this.age = age;
        }
    }

    class Program {
        static void Main(string[] args) {
            Mammal mammal = new Mammal("초코", 10);

            Console.WriteLine("이름: {0}", mammal.name);
            Console.WriteLine("나이: {0}", mammal.age);
        }
    }
}
