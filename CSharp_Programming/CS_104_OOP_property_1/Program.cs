using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_104_OOP_property_1
- Desc: 프로퍼티
---------- ---------- ---------- ---------- ---------- */
namespace CS_104_OOP_property_1 {
    class Information {
        public string name;
        int age;
        string gender;
        string mbti;
        int weight;

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public int Age {
            get { return age; }
            set { age = value; }
        }

        public string Gender {
            get { return gender; }
            set { gender = value; }
        }

        public string Mbti {
            get { return mbti; }
            set { mbti = value; }
        }

        public int Weight {
            get { return weight; }
            set { weight = value; }
        }
    }

    class Program {
        static void Main(string[] args) {
            Information infomation = new Information();

            infomation.Name = "영희";
            infomation.Age = 11;
            infomation.Gender = "여자";
            infomation.Mbti = "PRTI";
            infomation.Weight = 100;

            Console.WriteLine("이름: {0}", infomation.Name);
            Console.WriteLine("나이: {0}", infomation.Age);
            Console.WriteLine("성별: {0}", infomation.Gender);
            Console.WriteLine("MBTI: {0}", infomation.Mbti);
            Console.WriteLine("몸무게: {0}", infomation.Weight);
        }
    }
}
