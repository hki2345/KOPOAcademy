using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_123_OOP_object
- Desc: 최상위 부모 클래스
---------- ---------- ---------- ---------- ---------- */
namespace CS_123_OOP_object {
    class Student : object { // 모든 클래스는 object를 상속받는다. (따라서 object는 생략 가능)
        public void Study() {
            Console.WriteLine("공부를 합니다!");
        }
    }

    abstract class Mammal : object {
        abstract public void Move();
    }

    class Dog : Mammal {
        override public void Move() {
            Console.WriteLine("네 발로 이동한다.");
        }
    }

    interface ICar {
        void Run();
    }

    interface ICannon {
        void Fire();
    }

    class Tank : object, ICar, ICannon {
        public void Run() {
            Console.WriteLine("탱크가 앞으로 굴러갑니다.");
        }

        public void Fire() {
            Console.WriteLine("탱크에서 대포를 발사합니다.");
        }
    }

    class Program {
        static void Main(string[] args) {
            object student = new Student();
            object dog = new Dog();
            object tank = new Tank();

            Console.WriteLine("student.GetType(): {0}", student.GetType());
            Console.WriteLine("dog.GetType(): {0}", dog.GetType());
            Console.WriteLine("tank.GetType(): {0}", tank.GetType());
        }
    }
}
