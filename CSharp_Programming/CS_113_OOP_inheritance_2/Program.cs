using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_113_OOP_inheritance_2
- Desc: 아빠 친구 결혼식
---------- ---------- ---------- ---------- ---------- */
namespace CS_113_inheritance_2 {
    class Father {
        public void Greeting() {
            Console.WriteLine("안녕하세요!");
        }
    }

    class Son : Father {
        public void Repair() {
            Console.WriteLine("의자 고치기");
        }
    }

    class Program {
        static void MyFriendWedding(Son guest) {
            Console.WriteLine("~ 내 친구 결혼식 ~");
        }

        static void FatherFriendWedding(Father guest) {
            Console.WriteLine("~ 아빠 친구 결혼식 ~");

            Console.WriteLine("# 결혼식에서 인사합니다.");
            guest.Greeting();

            Console.WriteLine("# 망가진 의자좀 고쳐주세요.");
            ((Son)guest).Repair();
        }

        static void Main(string[] args) {
            Father father = new Father();
            Son son = new Son();

            // 나 대신 아빠가 내 친구 결혼식에는 갈 수 없다! (오류 발생)
            // MyFriendWedding(father);

            // 아빠 대신 내가 아빠 친구 결혼식에 갈 수 있다!
            FatherFriendWedding(son);
        }
    }
}
