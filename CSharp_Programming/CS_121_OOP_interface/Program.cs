using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_121_OOP_interface
- Desc: 인터페이스
---------- ---------- ---------- ---------- ---------- */
namespace CS_121_OOP_interface {
    interface ICar {
        void Run();
    }

    class Sedan : ICar {
        public void Run() {
            Console.WriteLine("승용차가 사람을 태우고 달립니다.");
        }
    }

    class Truck : ICar {
        public void Run() {
            Console.WriteLine("트럭이 짐을 싣고 달립니다.");
        }
    }

    class Program {
        static void Main(string[] args) {
            Sedan sedan = new Sedan();

            sedan.Run();

            Truck truck = new Truck();

            truck.Run();
        }
    }
}
