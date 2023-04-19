using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_108_OOP_singleton_3
- Desc: 싱글톤
---------- ---------- ---------- ---------- ---------- */
namespace CS_108_OOP_singleton_3 {
    class President {
        public static President president;

        string name;

        private President(string _name) {
            name = _name;
        }

        static President() {
            president = new President("대통령");
        }

        public void Speech() {
            Console.WriteLine("안녕하세요, {0} 입니다!", name);
        }
    }

    class Program {
        static void Main(string[] args) {
            President president = President.president;

            president.Speech();
        }
    }
}
