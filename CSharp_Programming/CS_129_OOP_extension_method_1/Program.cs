using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_129_OOP_extension_method_1
- Desc: 확장 메서드
---------- ---------- ---------- ---------- ---------- */
namespace CS_129_OOP_extension_method_1 {
    class Horse {
        public void Move() {
            Console.WriteLine("네 발로 이동한다.");
        }
    }

    static class Saddle {
        public static void Ride(this Horse horse) {
            Console.WriteLine("말 위에 탑승한다.");

            horse.Move();
        }
    }

    class Program {
        static void Main(string[] args) {
            Horse horse = new Horse();

            horse.Ride();
        }
    }
}
