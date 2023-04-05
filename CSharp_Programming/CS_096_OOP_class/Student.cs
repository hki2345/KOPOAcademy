using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_096_OOP_class
- Desc: 객체 지향 프로그래밍 (object-oriented programming)
---------- ---------- ---------- ---------- ---------- */
namespace CS_096_OOP_class {
    class Student {
        // 필드: 객체 내 변수, 객체의 속성을 표현한다.
        ////////// ////////// ////////// ////////// //////////
        string name;
        int age;
        int grade;
        ////////// ////////// ////////// ////////// //////////

        // 메서드: 객체 내 함수, 객체의 행위를 표현한다.
        ////////// ////////// ////////// ////////// //////////
        void Greeting() {
            Console.WriteLine("안녕하세요!");
        }

        void Study() {
            Console.WriteLine("공부를 합니다!");
        }
        ////////// ////////// ////////// ////////// //////////

        // 메인: 프로그램의 시작 지점, 현실 세계를 표현한다.
        ////////// ////////// ////////// ////////// //////////
        static void Main(string[] args) {
            Student a = new Student();
            a.name = "철수";
            a.age = 10;
            a.grade = 3;

            Student b = new Student();
            b.name = "영희";
            b.age = 11;
            b.grade = 4;

            Console.WriteLine("교실에 {0}와 {1}가 있습니다.", a.name, b.name);

            Console.WriteLine("철수는 {0}살 입니다.", a.age);
            Console.WriteLine("영희는 {0}학년 입니다.", b.grade);

            Console.WriteLine("철수가 인사합니다.");
            a.Greeting();

            Console.WriteLine("영희야 뭐해?");
            b.Study();
        }
        ////////// ////////// ////////// ////////// //////////
    }
}
