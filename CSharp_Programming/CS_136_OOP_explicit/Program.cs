using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_136_OOP_explicit
- Desc: 형변환 오버로딩 (암시적 형변환 불가, 명시적 형변환 가능)
---------- ---------- ---------- ---------- ---------- */
namespace CS_136_OOP_explicit {
    class Won {
        public decimal money;

        public Won(decimal money) {
            this.money = money;
        }

        static public explicit operator Dollar(Won won) {
            return new Dollar(won.money / 1300);
        }

        public override string ToString() {
            return money + "원";
        }
    }

    class Dollar {
        public decimal money;

        public Dollar(decimal money) {
            this.money = money;
        }

        static public explicit operator Won(Dollar dollar) {
            return new Won(dollar.money * 1300);
        }

        public override string ToString() {
            return money + "달러";
        }
    }

    class Program {
        static void Main(string[] args) {
            Dollar dollar = new Dollar(1);

            // 형변환을 explicit로 오버로딩하면 암시적 형변환 불가! (오류 발생)
            // Won won = dollar;

            Won won = (Won)dollar;

            Console.WriteLine("{0}는 {1}입니다.", dollar, won);
        }
    }
}
