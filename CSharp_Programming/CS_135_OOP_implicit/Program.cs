using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_135_OOP_implicit
- Desc: 형변환 오버로딩 (암시적 형변환 가능)
---------- ---------- ---------- ---------- ---------- */
namespace CS_135_OOP_implicit {
    class Won {
        public decimal money;

        public Won(decimal money) {
            this.money = money;
        }

        static public implicit operator Dollar(Won won) {
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

        static public implicit operator Won(Dollar dollar) {
            return new Won(dollar.money * 1300);
        }

        public override string ToString() {
            return money + "달러";
        }
    }

    class Program {
        static void Main(string[] args) {
            Dollar dollar = new Dollar(1);

            // 형변환이 일어나는 시점
            Won won = dollar;

            Console.WriteLine("{0}는 {1}입니다.", dollar, won);
        }
    }
}
