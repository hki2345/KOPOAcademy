using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_124_OOP_is_as
- Desc: A is B 관계와 is/as 연산자
---------- ---------- ---------- ---------- ---------- */
namespace CS_124_OOP_is_as {
    class Phone {
        public void Call() {
            Console.WriteLine("전화하기");
        }
    }

    class MobilePhone : Phone {
        public void Wireless() {
            Console.WriteLine("무선연결");
        }
    }

    class SmartPhone : MobilePhone {
        public void Game() {
            Console.WriteLine("게임하기");
        }
    }

    internal class Program {
        static void Main(string[] args) {
            //object thing = new Phone();

            // 다른 인스턴스로도 실습해보세요!!
            // object thing = new MobilePhone();
             object thing = new SmartPhone();

            {
                if (thing is Phone) {
                    Console.WriteLine("이것은 전화기입니다.");
                }

                if (thing is MobilePhone) {
                    Console.WriteLine("이것은 휴대폰입니다.");
                }

                if (thing is SmartPhone) {
                    Console.WriteLine("이것은 스마트폰입니다.");
                }
            }

            {
                if (thing is Phone) {
                    ((Phone)thing).Call();
                }

                if (thing is MobilePhone) {
                    ((MobilePhone)thing).Wireless();
                }

                if (thing is SmartPhone) {
                    ((SmartPhone)thing).Game();
                }
            }

            {
                if (thing is Phone phone) {
                    phone.Call();
                }

                if (thing is MobilePhone mobilePhone) {
                    mobilePhone.Wireless();
                }

                if (thing is SmartPhone smartPhone) {
                    smartPhone.Game();
                }
            }

            {
                Phone phone = thing as Phone;
                if (phone != null) {
                    phone.Call();
                }

                MobilePhone mobilePhone = thing as MobilePhone;
                if (mobilePhone != null) {
                    mobilePhone.Wireless();
                }

                SmartPhone smartPhone = thing as SmartPhone;
                if (smartPhone != null) {
                    smartPhone.Game();
                }
            }
        }
    }
}
