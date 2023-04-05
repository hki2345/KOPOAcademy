using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_097_OOP_constructor
- Desc: 생성자
---------- ---------- ---------- ---------- ---------- */
namespace CS_097_OOP_constructor {
    class Student {
        // 필드
        ////////// ////////// ////////// ////////// //////////
        string name;
        int age;
        int grade;
        ////////// ////////// ////////// ////////// //////////

        // 생성자: 객체를 생성할 때 실행되는 메서드
        ////////// ////////// ////////// ////////// //////////
        Student(string _name, int _int, int _grade) {
            name = _name;
            age = _int;
            grade = _grade;
        }

        Student() { } // 기본 생성자: 생성자를 정의하지 않을 경우 빈 생성자가 자동으로 생성된다.
        ////////// ////////// ////////// ////////// //////////

        // 메서드
        ////////// ////////// ////////// ////////// //////////
        void Greeting() {
            Console.WriteLine("안녕하세요!");
        }

        void Study() {
            Console.WriteLine("공부를 합니다!");
        }
        ////////// ////////// ////////// ////////// //////////

        // 메인
        ////////// ////////// ////////// ////////// //////////
        static void Main(string[] args) {
            Student a = new Student("철수", 10, 3);
            Student b = new Student("영희", 11, 4);

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
