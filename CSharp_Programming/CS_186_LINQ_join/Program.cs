using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_186_LINQ_join
- Desc: 링크로 데이터를 연결하는 방법
---------- ---------- ---------- ---------- ---------- */
namespace CS_186_LINQ_join {
    class Student {
        string name;
        int age;
        int grade;

        public Student(string name, int age, int grade) {
            this.name = name;
            this.age = age;
            this.grade = grade;
        }

        public string Name { get { return name; } }
        public int Age { get { return age; } }
        public int Grade { get { return grade; } }
    }

    class Member {
        string name;
        string classroom;

        public Member(string name, string classroom) {
            this.name = name;
            this.classroom = classroom;
        }

        public string Name { get { return name; } }
        public string Classroom { get { return classroom; } }
    }

    class Program {
        static void Main(string[] args) {
            Student[] studentArr = new Student[] {
                new Student("철수",   10, 3),
                new Student("영희",   11, 4),
                new Student("민수",    9, 2),
                new Student("전학생", 12, 5),
                new Student("복학생", 13, 5)
            };

            Member[] memberArr = new Member[] {
                new Member("철수", "A"),
                new Member("영희", "A"),
                new Member("민수", "A"),
                new Member("갑",   "B"),
                new Member("을",   "B"),
                new Member("병",   "B")
            };

            // 내부 조인 (inner join)
            var result1 = from student in studentArr
                          join member in memberArr on student.Name equals member.Name
                          select new { student.Name, student.Age, student.Grade, member.Classroom };

            foreach (var item in result1) {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            // 외부 조인 (outer join)
            var result2 = from student in studentArr
                          join member in memberArr on student.Name equals member.Name into memberEx
                          from member in memberEx.DefaultIfEmpty(new Member(null, "미정"))
                          select new { student.Name, student.Age, student.Grade, member.Classroom };

            foreach (var item in result2) {
                Console.WriteLine(item);
            }
        }
    }
}
