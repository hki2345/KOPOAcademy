using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_112_OOP_inheritance_1
- Desc: 상속
---------- ---------- ---------- ---------- ---------- */
namespace CS_112_OOP_inheritance_1 {
    class Mammal {
        public void Move() {
            Console.WriteLine("이동한다.");
        }
    }

    class Dog : Mammal {
        public void Move() {
            Console.WriteLine("네 발로 이동한다.");
        }
    }

    class Kangaroo : Mammal {
        public void Move() {
            Console.WriteLine("두 발로 이동한다.");
        }
    }

    class Whale : Mammal {
        public void Move() {
            Console.WriteLine("헤엄쳐서 이동한다.");
        }
    }

    class Program {
        static void Main(string[] args) {
            Dog dog = new Dog();
            Kangaroo kangaroo = new Kangaroo();
            Whale whale = new Whale();

            dog.Move();
            kangaroo.Move();
            whale.Move();
        }
    }
}
