using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_099_OOP_static
- Desc: 정적 필드와 정적 메서드
---------- ---------- ---------- ---------- ---------- */
namespace CS_099_OOP_static {
    class Student {
        // 필드
        ////////// ////////// ////////// ////////// //////////
        string name;
        int age;
        int grade;

        static string classMotto = "슬기로운 학생이 됩시다!";
        ////////// ////////// ////////// ////////// //////////

        // 생성자
        ////////// ////////// ////////// ////////// //////////
        Student(string _name, int _int, int _grade) {
            name = _name;
            age = _int;
            grade = _grade;
        }
        ////////// ////////// ////////// ////////// //////////

        // 메서드
        ////////// ////////// ////////// ////////// //////////
        void Greeting() {
            Console.WriteLine("안녕하세요!");
        }

        void Study() {
            Console.WriteLine("공부를 합니다!");
        }

        static void ClassMotto() {
            Console.WriteLine(classMotto);
        }
        ////////// ////////// ////////// ////////// //////////

        // 메인
        ////////// ////////// ////////// ////////// //////////
        static void Main(string[] args) {
            Console.WriteLine("급훈");
            Student.ClassMotto();

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
