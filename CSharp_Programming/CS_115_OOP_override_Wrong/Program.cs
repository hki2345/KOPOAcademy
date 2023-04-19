using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_115_OOP_override_Wrong
- Desc: 오버라이드 (틀린 예시)
---------- ---------- ---------- ---------- ---------- */
namespace CS_115_OOP_override_Wrong {
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

            dog.Move();

            Mammal mammal = dog;

            mammal.Move();
        }
    }
}
