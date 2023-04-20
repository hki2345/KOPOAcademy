using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_143_FP_loose_coupling_delegate
- Desc: 델리게이트로 느슨한 결합 구성
---------- ---------- ---------- ---------- ---------- */
namespace CS_143_FP_loose_coupling_delegate {
    delegate void TurnOnDelegate();

    class Computer {
        public void TurnOn() {
            Console.WriteLine("컴퓨터 전원 켜짐");
        }
    }

    class Monitor {
        public void TurnOn() {
            Console.WriteLine("모니터 전원 켜짐");
        }
    }

    class Program {
        static void ButtonPush(TurnOnDelegate trunOn) {
            Console.WriteLine("무언가의 전원 버튼 누름");

            trunOn();
        }

        static void Main(string[] args) {
            Computer computer = new Computer();
            Monitor monitor = new Monitor();

            ButtonPush(computer.TurnOn);
            ButtonPush(monitor.TurnOn);
        }
    }
}
