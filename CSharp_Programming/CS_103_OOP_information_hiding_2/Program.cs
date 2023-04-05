using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_103_OOP_information_hiding_2
- Desc: 정보 은닉
---------- ---------- ---------- ---------- ---------- */
namespace CS_103_OOP_information_hiding_2 {
    class Information {
        string name = "영희";
        int age = 11;
        string gender = "여자";
        string mbti = "PRTI";
        int weight = 100;

        public string GetName() {
            return name;
        }
        // SetName()가 없으므로 이름을 바꿀 수 없다.

        public int GetAge() {
            return age - 1; // 만 나이를 리턴해야 하므로 1살 빼고 리턴
        }
        // SetAge()가 없으므로 나이를 바꿀 수 없다.

        public string GetGender() {
            return gender;
        }
        // SetGender()가 없으므로 성별을 바꿀 수 없다.

        public string GetMbti() {
            return mbti;
        }
        public void SetMbti(string _mbti) {
            mbti = _mbti;
        }

        // GetWeight()가 없으므로 몸무게를 물어볼 수 없다.
        public void SetWeight(int _weight) {
            weight = _weight;
        }
    }

    class Program {
        static void Main(string[] args) {
            Information infomation = new Information();

            infomation.SetMbti("VERY PRTI");
            infomation.SetWeight(200);

            Console.WriteLine("이름: {0}", infomation.GetName());
            Console.WriteLine("만 나이: {0}", infomation.GetAge());
            Console.WriteLine("성별: {0}", infomation.GetGender());
            Console.WriteLine("MBTI: {0}", infomation.GetMbti());
        }
    }
}
