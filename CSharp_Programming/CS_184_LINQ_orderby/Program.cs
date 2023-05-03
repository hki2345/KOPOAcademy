using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_184_LINQ_orderby
- Desc: 링크로 데이터를 정렬하는 방법
---------- ---------- ---------- ---------- ---------- */
namespace CS_184_LINQ_orderby {
    class Student {
        string name;
        int grade;
        int kor;
        int eng;
        int math;

        public Student(string name, int grade, int kor, int eng, int math) {
            this.name = name;
            this.grade = grade;
            this.kor = kor;
            this.eng = eng;
            this.math = math;
        }

        public string Name { get { return name; } }
        public int Grade { get { return grade; } }
        public int Kor { get { return kor; } }
        public int Eng { get { return eng; } }
        public int Math { get { return math; } }
    }

    class Program {
        static void Main(string[] args) {
            Student[] studentArr = new Student[] {
                new Student("철수",   3, 80, 90, 70),
                new Student("영희",   4, 80, 60, 90),
                new Student("민수",   2, 70, 70, 80),
                new Student("전학생", 5, 60,100, 90),
                new Student("복학생", 5, 90, 90, 60)
            };

            // 학년순 정렬
            var result1 = from data in studentArr
                          orderby data.Grade ascending  // 오름차순 정렬 (ascending 생략 가능)
                       // orderby data.Grade descending // 내림차순 정렬
                          select data;

            foreach (var item in result1) {
                Console.WriteLine("이름: {0}, 학년: {1}, 총합: {2}", item.Name, item.Grade, item.Kor + item.Eng + item.Math);
            }

            Console.WriteLine();

            // 학년순으로 정렬한 다음 이름순 정렬
            var result2 = from data in studentArr
                          orderby data.Grade ascending, data.Name ascending
                          select data;

            foreach (var item in result2) {
                Console.WriteLine("이름: {0}, 학년: {1}, 총합: {2}", item.Name, item.Grade, item.Kor + item.Eng + item.Math);
            }

            Console.WriteLine();

            // 성적순 정렬
            var result3 = from data in studentArr
                          orderby data.Kor + data.Eng + data.Math ascending
                          select data;

            foreach (var item in result3) {
                Console.WriteLine("이름: {0}, 학년: {1}, 총합: {2}", item.Name, item.Grade, item.Kor + item.Eng + item.Math);
            }
        }
    }
}
