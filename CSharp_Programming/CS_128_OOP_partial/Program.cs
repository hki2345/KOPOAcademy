using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_128_OOP_partial
- Desc: 각기 다른 소스 파일에서 단일 클래스로 묶는 방법
---------- ---------- ---------- ---------- ---------- */
namespace CS_128_OOP_partial {
    partial class Dog {
        public void Move() {
            Console.WriteLine("네 발로 이동한다.");
        }
    }

    class Program {
        static void Main(string[] args) {
            Dog dog = new Dog();

            dog.Move();
            dog.Bark();
        }
    }
}
