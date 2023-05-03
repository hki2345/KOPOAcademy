using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_177_Generic_Collection_Sort_3
- Desc: 목록을 정렬하는 방법
---------- ---------- ---------- ---------- ---------- */
namespace CS_177_Generic_Collection_Sort_3 {
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

    class Program {
        static void Main(string[] args) {
            List<Student> list = new List<Student> {
                new Student("철수",   10, 3),
                new Student("영희",   11, 4),
                new Student("민수",    9, 2),
                new Student("전학생", 12, 5),
                new Student("복학생", 13, 5)
            };

            // 정렬 기준이 없으므로 정렬할 수 없다! (오류 발생)
            // list.Sort();

            list.Sort((a, b) => a.Name.CompareTo(b.Name));   // 이름순 정렬

            foreach (var item in list) {
                Console.WriteLine("이름: {0}, 나이: {1}, 학년: {2}", item.Name, item.Age, item.Grade);
            }

            Console.WriteLine();

            list.Sort((a, b) => a.Age.CompareTo(b.Age));     // 나이순 정렬

            foreach (var item in list) {
                Console.WriteLine("이름: {0}, 나이: {1}, 학년: {2}", item.Name, item.Age, item.Grade);
            }

            Console.WriteLine();

            list.Sort((a, b) => a.Grade.CompareTo(b.Grade)); // 학년순 정렬

            foreach (var item in list) {
                Console.WriteLine("이름: {0}, 나이: {1}, 학년: {2}", item.Name, item.Age, item.Grade);
            }

            Console.WriteLine();

            list.Sort((a, b) => {
                int compare = a.Grade.CompareTo(b.Grade);

                if (compare == 0) { // 학년이 같으면 이름도 비교한다.
                    compare = a.Name.CompareTo(b.Name);
                }

                return compare;
            });

            foreach (var item in list) {
                Console.WriteLine("이름: {0}, 나이: {1}, 학년: {2}", item.Name, item.Age, item.Grade);
            }
        }
    }
}
