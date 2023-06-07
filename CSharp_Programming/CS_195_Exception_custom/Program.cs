using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_195_Exception_custom
- Desc: 사용자 정의 예외 클래스
---------- ---------- ---------- ---------- ---------- */
namespace CS_195_Exception_custom {
    class MoneyException : ApplicationException {
        int money;

        public MoneyException(int money) {
            this.money = money;
        }

        public override string ToString() {
            return "금액이 부족합니다! (보유중인 돈: " + money + ")";
        }
    }

    class Program {
        static void Main(string[] args) {
            Console.Write("돈을 얼마나 가지고 있나요? ");
            int money = int.Parse(Console.ReadLine());

            try {
                Console.Write("정말 5000원 상품을 구입하시겠습니까? (Y, N) ");
                string s = Console.ReadLine().ToUpper();

                if (s == "Y") {
                    if (money < 5000) {
                        throw new MoneyException(money);
                    }

                    Console.WriteLine("상품을 구입했습니다!");
                }

            } catch (MoneyException e) {
                Console.WriteLine(e);
            }
        }
    }
}
