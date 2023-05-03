using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_183_LINQ_select
- Desc: 링크로 원하는 데이터만 가져오는 방법
---------- ---------- ---------- ---------- ---------- */
namespace CS_183_LINQ_select {
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
                new Student("철수", 3, 80, 90, 70),
                new Student("영희", 4, 80, 60, 90),
                new Student("민수", 2, 70, 70, 80)
            };

            // 모든 데이터 가져오기
            IEnumerable<Student> result1 = from data in studentArr
                                           select data;

            foreach (Student item in result1) {
                Console.WriteLine("이름: {0}, 학년: {1}, 국어: {2}, 영어: {3}, 수학: {4}", item.Name, item.Grade, item.Kor, item.Eng, item.Math);
            }

            Console.WriteLine();

            // 학생 명단만 가져오기
            IEnumerable<string> result2 = from data in studentArr
                                          select data.Name;

            foreach (string item in result2) {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            // 이름과 학년만 가져오기 (익명 형식)
            var result3 = from data in studentArr
                          select new { data.Name, data.Grade };

            foreach (var item in result3) {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            // 이름과 학년만 가져오기 (Dictionary<string, object> 형식)
            IEnumerable<Dictionary<string, object>> result4 = from data in studentArr
                                                              select new Dictionary<string, object> { ["name"] = data.Name, ["grade"] = data.Grade };

            foreach (Dictionary<string, object> item in result4) {
                Console.WriteLine("이름: {0}, 학년: {1}", item["name"], item["grade"]);
            }

            Console.WriteLine();

            // 학생별 점수 총합 가져오기
            IEnumerable<int> result5 = from data in studentArr
                                       select data.Kor + data.Eng + data.Math;

            foreach (int item in result5) {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            // 학생별 점수 총합 가져오기 (익명 형식)
            var result6 = from data in studentArr
                          select new {
                              data.Name,
                              Total = data.Kor + data.Eng + data.Math
                          };

            foreach (var item in result6) {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            // 학생별 점수 총합 가져오기 (Dictionary<string, object> 형식)
            IEnumerable<Dictionary<string, object>> result7 = from data in studentArr
                                                              select new Dictionary<string, object> {
                                                                  ["name"] = data.Name,
                                                                  ["total"] = data.Kor + data.Eng + data.Math
                                                              };

            foreach (Dictionary<string, object> item in result7) {
                Console.WriteLine("이름: {0}, 총합: {1}", item["name"], item["total"]);
            }
        }
    }
}
