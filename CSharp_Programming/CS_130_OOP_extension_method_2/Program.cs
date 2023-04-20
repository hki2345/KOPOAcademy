using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_130_OOP_extension_method_2
- Desc: 기본 데이터 타입 값에 확장 메서드 적용
---------- ---------- ---------- ---------- ---------- */
namespace CS_130_OOP_extension_method_2 {
    static class Util {
        public static string Star(this int num) {
            string str = "";

            for (int i = 0; i < num; i++) {
                str += "*";
            }

            return str;
        }
    }

    class Program {
        static void Main(string[] args) {
            Console.WriteLine("10.Star(): {0}", 10.Star());
        }
    }
}
