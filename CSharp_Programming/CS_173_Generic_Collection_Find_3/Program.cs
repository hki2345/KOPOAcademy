using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_173_Generic_Collection_Find_3
- Desc: 주어진 조건을 만족하는 요소를 찾는 방법
---------- ---------- ---------- ---------- ---------- */
namespace CS_173_Generic_Collection_Find_3 {
    class Student {
        public string name;
        public int age;
        public int grade;

        public Student(string name, int age, int grade) {
            this.name = name;
            this.age = age;
            this.grade = grade;
        }
    }

    class Program {
        static void Main(string[] args) {
            List<Student> list = new List<Student> {
                new Student("철수",   10, 3),
                new Student("영희",   11, 4),
                new Student("민수",    9, 2),
                new Student("전학생", 12, 5),
                new Student("복학생", 13, 5)
            };

            var findData = list.Find( x => x.name == "민수" );

            Console.WriteLine("이름: {0}, 나이: {1}, 학년: {2}", findData.name, findData.age, findData.grade);

            Console.WriteLine();

            List<Student> findList = list.FindAll( x => x.age > 10 );

            foreach (var item in findList) {
                Console.WriteLine("이름: {0}, 나이: {1}, 학년: {2}", item.name, item.age, item.grade);
            }
        }
    }
}
