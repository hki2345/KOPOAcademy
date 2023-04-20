using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_131_OOP_struct
- Desc: 구조체
---------- ---------- ---------- ---------- ---------- */
namespace CS_131_OOP_struct {

    // 인스턴스로 생성
    class Point {
        public int x;
        public int y;

        public Point(int x, int y) {
            this.x = x;
            this.y = y;
        }
    }

    // Value 형태로 생성
    struct Vector {
        public int x;
        public int y;

        public Vector(int x, int y) {
            this.x = x;
            this.y = y;
        }
    }

    class Program {
        static void Main(string[] args) {
            Point a = new Point(1, 2);
            Point b = a;    // 얕은 복사 -> 주소값이 같아짐 -> 포인터 형태로 복사

            b.x = 3;
            b.y = 4;

            Console.WriteLine("class Point a.x: {0}, a.y: {1}", a.x, a.y);
            Console.WriteLine("class Point b.x: {0}, b.y: {1}", b.x, b.y);

            Vector c = new Vector(1, 2);
            Vector d = c;   // 깊은 복사 -> 주소값이 달라짐 -> 값형태로 통째로 복사

            d.x = 3;
            d.y = 4;

            Console.WriteLine("struct Vector c.x: {0}, c.y: {1}", c.x, c.y);
            Console.WriteLine("struct Vector d.x: {0}, d.y: {1}", d.x, d.y);
        }
    }
}
