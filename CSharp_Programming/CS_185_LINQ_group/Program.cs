using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_185_LINQ_group
- Desc: 링크로 데이터를 분류하는 방법
---------- ---------- ---------- ---------- ---------- */
namespace CS_185_LINQ_group {
    class Student {
        string name;
        string classroom;
        int kor;
        int eng;
        int math;

        public Student(string name, string classroom, int kor, int eng, int math) {
            this.name = name;
            this.classroom = classroom;
            this.kor = kor;
            this.eng = eng;
            this.math = math;
        }

        public string Name { get { return name; } }
        public string Classroom { get { return classroom; } }
        public int Kor { get { return kor; } }
        public int Eng { get { return eng; } }
        public int Math { get { return math; } }
    }

    class Program {
        static void Main(string[] args) {
            Student[] studentArr = new Student[] {
                new Student("철수", "A", 80, 90, 70),
                new Student("영희", "A", 80, 60, 90),
                new Student("민수", "A", 70, 70, 80),
                new Student("갑",   "B", 80, 90, 70),
                new Student("을",   "B",100, 80, 60),
                new Student("병",   "B", 30, 20, 80)
            };

            // 학급별 그룹
            var result1 = from data in studentArr
                          group data by data.Classroom;

            foreach (var group in result1) {
                Console.WriteLine("# {0}반 학생", group.Key);

                foreach (var item in group) {
                    Console.WriteLine("이름: {0}, 학년: {1}, 총합: {2}", item.Name, item.Classroom, item.Kor + item.Eng + item.Math);
                }
            }

            Console.WriteLine();

            // 점수 총합이 225점을 넘는 그룹
            var result2 = from data in studentArr
                          group data by data.Kor + data.Eng + data.Math > 225;

            foreach (var group in result2) {
                Console.WriteLine("# 225점 초과: {0}", group.Key);

                foreach (var item in group) {
                    Console.WriteLine("이름: {0}, 학년: {1}, 총합: {2}", item.Name, item.Classroom, item.Kor + item.Eng + item.Math);
                }
            }

            Console.WriteLine();

            // 점수대별 그룹
            var result3 = from data in studentArr
                          group data by (data.Kor + data.Eng + data.Math) / 10;

            foreach (var group in result3) {
                Console.WriteLine("# {0}점대 학생", group.Key * 10);

                foreach (var item in group) {
                    Console.WriteLine("이름: {0}, 학년: {1}, 총합: {2}", item.Name, item.Classroom, item.Kor + item.Eng + item.Math);
                }
            }
        }
    }
}
