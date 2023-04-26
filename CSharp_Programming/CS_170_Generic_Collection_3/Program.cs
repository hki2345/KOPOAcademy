using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_170_Generic_Collection_3
- Desc: 학생 목록
---------- ---------- ---------- ---------- ---------- */
namespace CS_170_Generic_Collection_3 {
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
                new Student("철수", 10, 3),
                new Student("영희", 11, 4),
                new Student("민수",  9, 2)
            };

            foreach (var item in list) {
                Console.WriteLine("이름: {0}, 나이: {1}, 학년: {2}", item.name, item.age, item.grade);
            }
        }
    }
}
