using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_102_OOP_information_hiding_1
- Desc: 정보 은닉
---------- ---------- ---------- ---------- ---------- */
namespace CS_102_OOP_information_hiding_1 {
    class Information {
        public string name;
        int age;
        string gender;
        string mbti;
        int weight;

        public string GetName() {
            return name;
        }
        public void SetName(string _name) {
            name = _name;
        }

        public int GetAge() {
            return age;
        }
        public void SetAge(int _age) {
            age = _age;
        }

        public string GetGender() {
            return gender;
        }
        public void SetGender(string _gender) {
            gender = _gender;
        }

        public string GetMbti() {
            return mbti;
        }
        public void SetMbti(string _mbti) {
            mbti = _mbti;
        }

        public int GetWeight() {
            return weight;
        }
        public void SetWeight(int _weight) {
            weight = _weight;
        }
    }

    class Program {
        static void Main(string[] args) {
            Information infomation = new Information();

            infomation.SetName("영희");
            infomation.SetAge(11);
            infomation.SetGender("여자");
            infomation.SetMbti("PRTI");
            infomation.SetWeight(100);

            Console.WriteLine("이름: {0}", infomation.GetName());
            Console.WriteLine("나이: {0}", infomation.GetAge());
            Console.WriteLine("성별: {0}", infomation.GetGender());
            Console.WriteLine("MBTI: {0}", infomation.GetMbti());
            Console.WriteLine("몸무게: {0}", infomation.GetWeight());
        }
    }
}
