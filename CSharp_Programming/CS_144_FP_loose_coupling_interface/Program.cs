using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_144_FP_loose_coupling_interface
- Desc: 인터페이스로 느슨한 결합 구성
---------- ---------- ---------- ---------- ---------- */
namespace CS_144_FP_loose_coupling_interface {
    interface IPower {
        void TurnOn();
    }

    class Computer : IPower {
        public void TurnOn() {
            Console.WriteLine("컴퓨터 전원 켜짐");
        }
    }

    class Monitor : IPower {
        public void TurnOn() {
            Console.WriteLine("모니터 전원 켜짐");
        }
    }

    class Program {
        static void ButtonPush(IPower machine) {
            Console.WriteLine("무언가의 전원 버튼 누름");

            machine.TurnOn();
        }

        static void Main(string[] args) {
            Computer computer = new Computer();
            Monitor monitor = new Monitor();

            ButtonPush(computer);
            ButtonPush(monitor);
        }
    }
}
