using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_180_Generic_Collection_Sort_Check
- Desc: 학생 성적 목록 정렬
---------- ---------- ---------- ---------- ---------- */
namespace CS_180_Generic_Collection_Sort_Check {
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

    class Program {
        static void Main(string[] args) {
            List<Student> list = new List<Student> {
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

            Console.WriteLine("학생 성적 목록을 정렬할 방법을 선택해주세요.");
            Console.Write("1. 이름 정렬    2. 국어점수 정렬    3. 영어점수 정렬    4. 수학점수 정렬    5. 총합점수 정렬 >> ");
            string target = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("오름차순으로 정렬할까요 내림차순으로 정렬할까요?");
            Console.Write("1. 오름차순 정렬    2. 내림차순 정렬 >> ");
            string sortOrder = Console.ReadLine();

            Console.WriteLine();

            ////////// ////////// ////////// ////////// //////////
            switch (target) {
            case "1": // for문 사용 예시 (버블 정렬 알고리즘)
                for (int i = 0; i < list.Count-1; i++) {
                    for (int j = 0; j < list.Count-1-i; j++) {
                        if (sortOrder == "1") {
                            if (list[j].Name.CompareTo(list[j+1].Name) > 0) {
                                Student temp = list[j];
                                list[j] = list[j+1];
                                list[j+1] = temp;
                            }
                        } else {
                            if (list[j].Name.CompareTo(list[j+1].Name) < 0) {
                                Student temp = list[j];
                                list[j] = list[j+1];
                                list[j+1] = temp;
                            }
                        }
                    }
                }

                break;

            case "2": // for문 사용 예시 (위의 예시에서 보다 간결하게 작성)
                for (int i = 0; i < list.Count-1; i++) {
                    for (int j = 0; j < list.Count-1-i; j++) {
                        if (list[j].Kor > list[j+1].Kor ^ sortOrder == "2") {
                            (list[j], list[j+1]) = (list[j+1], list[j]);
                        }
                    }
                }

                break;

            case "3": // Sort 메서드와 Reverse 메서드 사용 예시
                list.Sort((a, b) => a.Eng.CompareTo(b.Eng));

                if (sortOrder == "2") {
                    list.Reverse();
                }

                break;

            case "4": // Sort 메서드에 내림차순 정렬을 적용한 예시
                list.Sort((a, b) => (sortOrder == "1" ? 1 : -1) * a.Math.CompareTo(b.Math));

                break;

            case "5": // LINQ 사용 예시
                list = new List<Student>(from data in list
                                         orderby sortOrder == "1" ? data.Total : 0,
                                                 sortOrder == "1" ? 0 : data.Total descending
                                         select data);

                break;
            }
            ////////// ////////// ////////// ////////// //////////

            Console.WriteLine("이름\t국어\t영어\t수학\t총합");

            foreach (var item in list) {
                Console.WriteLine("{0,3}\t{1,3}\t{2,3}\t{3,3}\t{4,3}", item.Name, item.Kor, item.Eng, item.Math, item.Total);
            }
        }
    }
}
