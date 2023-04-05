using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_105_OOP_property_2
- Desc: 프로퍼티
---------- ---------- ---------- ---------- ---------- */
namespace CS_105_OOP_property_2 {
    class Information {
        string name = "영희";
        int age = 11;
        string gender = "여자";
        string mbti = "PRTI";
        int weight = 100;

        public string Name {
            get { return name; }
            // set이 없으므로 이름을 바꿀 수 없다.
        }

        public int Age {
            get { return age + 1; } // 만 나이를 리턴해야 하므로 1살 빼고 리턴
            // set이 없으므로 나이를 바꿀 수 없다.
        }

        public string Gender {
            get { return gender; }
            // set이 없으므로 성별을 바꿀 수 없다.
        }

        public string Mbti {
            get { return mbti; }
            set { mbti = value; }
        }

        public int Weight {
            // get이 없으므로 몸무게를 물어볼 수 없다.
            set { weight = value; }
        }
    }

    class Program {
        static void Main(string[] args) {
            Information infomation = new Information();

            infomation.Mbti = "VERY PRTI";
            infomation.Weight = 200;

            Console.WriteLine("이름: {0}", infomation.Name);
            Console.WriteLine("나이: {0}", infomation.Age);
            Console.WriteLine("성별: {0}", infomation.Gender);
            Console.WriteLine("MBTI: {0}", infomation.Mbti);
        }
    }
}
