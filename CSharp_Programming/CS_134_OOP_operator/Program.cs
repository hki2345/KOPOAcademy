using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_134_OOP_operator
- Desc: 연산자 오버로딩
---------- ---------- ---------- ---------- ---------- */
namespace CS_134_OOP_operator {
    class Kilogram {
        double mass;

        public Kilogram(double mass) {
            this.mass = mass;
        }

        public static Kilogram operator +(Kilogram op1, Kilogram op2) {
            return new Kilogram(op1.mass + op2.mass);
        }

        public override string ToString() {
            return mass + "kg";
        }
    }

    class Program {
        static void Main(string[] args) {
            Kilogram kg1 = new Kilogram(5);
            Kilogram kg2 = new Kilogram(10);

            Kilogram kg3 = kg1 + kg2;

            Console.WriteLine("kg3: {0}", kg3);
        }
    }
}
