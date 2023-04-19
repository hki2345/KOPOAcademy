using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_122_OOP_multiple_inheritance
- Desc: 인터페이스 다중상속
---------- ---------- ---------- ---------- ---------- */
namespace CS_122_OOP_multiple_inheritance {
    interface ICar {
        void Run();
    }

    interface ICannon {
        void Fire();
    }

    class Tank : ICar, ICannon {
        public void Run() {
            Console.WriteLine("탱크가 앞으로 굴러갑니다.");
        }

        public void Fire() {
            Console.WriteLine("탱크에서 대포를 발사합니다.");
        }
    }

    class Program {
        static void Main(string[] args) {
            Tank tank = new Tank();

            tank.Run();
            tank.Fire();
        }
    }
}
