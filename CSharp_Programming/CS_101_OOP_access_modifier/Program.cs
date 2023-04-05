using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_101_OOP_access_modifier
- Desc: 접근 제한자
---------- ---------- ---------- ---------- ---------- */
namespace CS_101_OOP_access_modifier {
    class Information {
        public string name = "영희";
        public int age = 11;
        public string gender = "여자";
        public string mbti = "PRTI";
        private int weight = 100; // 필드와 메서드는 private가 기본값이므로, private를 생략할 수 있다.
    }

    class Program {
        static void Main(string[] args) {
            Information infomation = new Information();

            Console.WriteLine("이름: {0}", infomation.name);
            Console.WriteLine("나이: {0}", infomation.age);
            Console.WriteLine("성별: {0}", infomation.gender);
            Console.WriteLine("MBTI: {0}", infomation.mbti);

            // weight 필드는 private 이므로 사용할 수 없다!
            // Console.WriteLine("몸무게: {0}", infomation.weight);
        }
    }
}
