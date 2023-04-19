using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using School;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_111_OOP_using
- Desc: 유징
---------- ---------- ---------- ---------- ---------- */
namespace School {
    class Cheolsu {
        public void Greeting() {
            Console.WriteLine("안녕하세요, 저는 김철수입니다.");
        }
    }
}

namespace Campus {
    class Cheolsu {
        public void Greeting() {
            Console.WriteLine("안녕하세요, 저는 박철수입니다.");
        }
    }
}

namespace CS_111_OOP_using {
    class Program {
        static void Main(string[] args) {
            Cheolsu a = new Cheolsu();

            a.Greeting();

            Campus.Cheolsu b = new Campus.Cheolsu();

            b.Greeting();
        }
    }
}
