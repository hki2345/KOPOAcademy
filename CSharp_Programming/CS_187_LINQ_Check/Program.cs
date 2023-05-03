using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_187_LINQ_Check
- Desc: 학생 성적 목록
---------- ---------- ---------- ---------- ---------- */
namespace CS_187_LINQ_Check {
    class Student {
        string name;
        int kor;
        int eng;
        int math;

        public Student(string name, int kor, int eng, int math) {
            this.name = name;
            this.kor = kor;
            this.eng = eng;
            this.math = math;
        }

        public string Name { get { return name; } }
        public int Kor { get { return kor; } }
        public int Eng { get { return eng; } }
        public int Math { get { return math; } }
        public int Total { get { return kor + eng + math; } }
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
                new Student("갑", 80, 90, 70),
                new Student("을",100, 80, 60),
                new Student("병", 30, 20, 80),
                new Student("정", 75, 75, 75),
                new Student("무", 90,100, 50),
                new Student("기", 50, 50,100),
                new Student("경", 30, 95, 95),
                new Student("신", 70, 80, 65),
                new Student("임", 65, 70, 80),
                new Student("계", 80, 90, 95)
            };

            Member[] memberArr = new Member[] {
                new Member("갑", "A"),
                new Member("을", "A"),
                new Member("병", "A"),
                new Member("정", "A"),
                new Member("무", "A"),
                new Member("기", "B"),
                new Member("경", "B"),
                new Member("신", "B"),
                new Member("임", "B"),
                new Member("계", "B")
            };

            Console.WriteLine("학생 성적 목록을 가져올 반을 선택해주세요.");
            Console.Write("1. A반    2. B반    3. 전체 >> ");
            string classroom = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("학생 성적 목록을 가져올 기준 과목을 선택해주세요.");
            Console.Write("1. 국어점수    2. 영어점수    3. 수학점수    4. 총합점수 >> ");
            string subject = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("학생 성적 목록을 가져올 기준 점수를 입력해주세요.");
            Console.Write(">> ");
            int score = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("기준 점수를 넘는 학생을 가져올까요 미달되는 학생을 가져올까요?");
            Console.Write("1. 초과    2. 미만 >> ");
            string comparison = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("오름차순으로 정렬할까요 내림차순으로 정렬할까요?");
            Console.Write("1. 오름차순 정렬    2. 내림차순 정렬 >> ");
            string sortOrder = Console.ReadLine();

            Console.WriteLine();

            ////////// ////////// ////////// ////////// //////////
            var result = from student in studentArr
                         join member in memberArr on student.Name equals member.Name

                         where
                         classroom == "1" ? member.Classroom == "A" :
                         classroom == "2" ? member.Classroom == "B" : true

                         where
                         subject == "1" ? comparison == "1" ? student.Kor > score : student.Kor < score : false ||
                         subject == "2" ? comparison == "1" ? student.Eng > score : student.Eng < score : false ||
                         subject == "3" ? comparison == "1" ? student.Math > score : student.Math < score : false ||
                         subject == "4" ? comparison == "1" ? student.Total > score : student.Total < score : false

                         orderby
                         sortOrder == "1" ? student.Name : "",
                         sortOrder == "1" ? "" : student.Name descending

                         select new { student.Name, member.Classroom, student.Kor, student.Eng, student.Math, student.Total };
            ////////// ////////// ////////// ////////// ////////// 

            Console.WriteLine("이름\t반\t국어\t영어\t수학\t총합");

            foreach (var item in result) {
                Console.WriteLine("{0,3}\t{1,3}\t{2,3}\t{3,3}\t{4,3}\t{5,3}", item.Name, item.Classroom, item.Kor, item.Eng, item.Math, item.Total);
            }
        }
    }
}
