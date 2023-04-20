using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_127_OOP_sealed
- Desc: 봉인 한정자
---------- ---------- ---------- ---------- ---------- */
namespace CS_127_OOP_sealed {
    abstract class Mammal : object {
        abstract public void Move();
    }

    sealed class Dog : Mammal {
        override public void Move() {
            Console.WriteLine("네 발로 이동한다.");
        }
    }

    // 상속받으려는 부모 클래스 Dog가 sealed라서 상속받을 수 없다! (오류 발생)
    //class chimera : dog
    //{
    //    public void breath()
    //    {
    //        console.write("브레스를 발사한다!!");
    //    }
    //}

    class Program {
        static void Main(string[] args) {
            Dog dog = new Dog();

            dog.Move();
        }
    }
}
