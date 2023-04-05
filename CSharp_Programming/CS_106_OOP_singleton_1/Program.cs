using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_106_OOP_singleton_1
- Desc: 싱글톤
---------- ---------- ---------- ---------- ---------- */
namespace CS_106_OOP_singleton_1 {
    class President {
        static President president;

        string name;

        private President(string _name) {
            name = _name;
        }

        public static President GetInstance() {
            if (president == null) {
                president = new President("대통령");
            }

            return president;
        }

        public void Speech() {
            Console.WriteLine("안녕하세요, {0} 입니다!", name);
        }
    }

    class Program {
        static void Main(string[] args) {
            President president = President.GetInstance();

            president.Speech();

            // 생성자가 private 이므로 사용할 수 없다!
            // president = new President("철수");
        }
    }
}
