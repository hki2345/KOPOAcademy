using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_117_OOP_base
- Desc: 부모클래스 참조
---------- ---------- ---------- ---------- ---------- */
namespace CS_117_OOP_base {
    class Mammal {
        virtual public void Move() {
            Console.WriteLine("이동한다.");
        }
    }

    class Dog : Mammal {
        override public void Move() {
            Console.Write("네 발로 ");

            base.Move();
        }
    }

    class Kangaroo : Mammal {
        override public void Move() {
            Console.Write("두 발로 ");

            base.Move();
        }
    }

    class Whale : Mammal {
        override public void Move() {
            Console.Write("헤엄쳐서 ");

            base.Move();
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
