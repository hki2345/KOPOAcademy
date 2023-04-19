using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_120_OOP_abstract
- Desc: 추상 클래스
---------- ---------- ---------- ---------- ---------- */
namespace CS_120_OOP_abstract {
    abstract class Mammal {
        virtual public void Move() {
            Console.WriteLine("이동한다.");
        }

        abstract public void breathe(); // 추상 메서드는 추상 클래스에서 명시만 하고 구현하지 않는다.
    }

    class Dog : Mammal {
        override public void Move() {
            Console.Write("네 발로 ");

            base.Move();
        }

        override public void breathe() { // 추상 메서드는 추상 클래스가 아닌 자식 클래스에서 반드시 구현해야한다.
            Console.WriteLine("들숨날숨");
        }
    }

    class Program {
        static void Main(string[] args) {
            // 추상 클래스로는 인스턴스를 직접 생성할 수 없다! (오류 발생)
            // Mammal mammal = new Mammal();

            Dog dog = new Dog();

            dog.Move();
            dog.breathe();

            Mammal mammal = dog;

            mammal.Move();
            mammal.breathe();
        }
    }
}
