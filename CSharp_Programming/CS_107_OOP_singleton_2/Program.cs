using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_107_OOP_singleton_2
- Desc: 싱글톤
---------- ---------- ---------- ---------- ---------- */
namespace CS_107_OOP_singleton_2 {
    class President {
        public static President president = new President("대통령");

        string name;

        private President(string _name) {
            name = _name;
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
