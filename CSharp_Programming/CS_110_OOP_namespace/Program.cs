using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_110_OOP_namespace
- Desc: 네임스페이스
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

namespace CS_110_OOP_namespace {
    class Program {
        static void Main(string[] args) {
            School.Cheolsu a = new School.Cheolsu();

            a.Greeting();

            Campus.Cheolsu b = new Campus.Cheolsu();

            b.Greeting();
        }
    }
}
