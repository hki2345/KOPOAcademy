using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_116_OOP_override
- Desc: 오버라이드
---------- ---------- ---------- ---------- ---------- */
namespace CS_116_OOP_override {
    class Mammal {
        virtual public void Move() {
            Console.WriteLine("이동한다.");
        }
    }

    class Dog : Mammal {
        override public void Move() {
            Console.WriteLine("네 발로 이동한다.");
        }
    }

    class Kangaroo : Mammal {
        override public void Move() {
            Console.WriteLine("두 발로 이동한다.");
        }
    }

    class Whale : Mammal {
        override public void Move() {
            Console.WriteLine("헤엄쳐서 이동한다.");
        }
    }

    class Program {
        static void Main(string[] args) {
            Dog dog = new Dog();

            dog.Move();

            Mammal mammal = dog;

            mammal.Move();
        }
    }
}
