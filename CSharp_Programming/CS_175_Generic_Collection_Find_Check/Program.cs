using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_175_Generic_Collection_Find_Check
- Desc: 학생 성적 목록 조회
---------- ---------- ---------- ---------- ---------- */
namespace CS_175_Generic_Collection_Find_Check {
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

            Console.WriteLine("학생 성적 목록을 가져올 기준 과목을 선택해주세요.");
            Console.Write("1. 국어점수    2. 영어점수    3. 수학점수    4. 총합점수    5. 수학점수(일반함수)     6. 수학점수(람다함수) >> ");
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

            ////////// ////////// ////////// ////////// //////////
            List<Student> temp = new List<Student>();

            switch (subject) {
            case "1": // foreach문 사용 예시
                foreach( var item in list)
                {
                    if (comparison == "1")
                    { 
                        if(item.Kor > score)
                        {
                            temp.Add(item);
                        }
                    }
                    else
                    {
                        if(item.Kor < score)
                        {
                            temp.Add(item);
                        }
                    }
                }
                break;

            case "2": // ForEach 메서드 사용 예시
                list.ForEach(x =>
                {
                    if(comparison == "1")
                    {
                        if(x.Kor > score)
                        {
                            temp.Add(x);
                        }
                    }
                    else
                    {
                        if(x.Kor < score)
                        { 
                            temp.Add(x);
                        }
                    }    
                });
                break;

            case "3": // FindAll 메서드 사용 예시
                temp = list.FindAll(x => comparison == "1" ? x.Math > score : x.Math < score);
                    break;

            case "4": // LINQ 사용 예시
                temp = new List<Student>(from data in list
                                         where comparison == "1" ? data.Total > score : data.Total < score
                                         select data);
                break;

            case "5": // FindAll Func
                temp = list.FindAll(x =>
                {
                    if (comparison == "1")
                    {
                        return x.Math > score;
                    }
                    else
                    {
                        return x.Math < score;
                    }
                });

                // 삼항 연산자
                // temp = list.FindAll(x => comparison == "1" ? x.Math < score : x.Math > score);
                break;

            case "6": // FindAll Lambda
                temp = list.FindAll(x =>
                {
                    if (comparison == "1")
                    {
                        return x.Math > score;
                    }
                    else
                    {
                        return x.Math < score;
                    }
                });
                break;  
            }

            list = temp;
            ////////// ////////// ////////// ////////// //////////

            Console.WriteLine("이름\t국어\t영어\t수학\t총합");

            foreach (var item in list) {
                Console.WriteLine("{0,3}\t{1,3}\t{2,3}\t{3,3}\t{4,3}", item.Name, item.Kor, item.Eng, item.Math, item.Total);
            }
        }
    }
}
