using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_133_OOP_indexer
- Desc: 인덱서
---------- ---------- ---------- ---------- ---------- */
namespace CS_133_OOP_indexer {
    class PhoneNumber {
        string[] phoneNumber = new string[3];

        public PhoneNumber(string phoneNumber) {
            this.phoneNumber = phoneNumber.Split('-');
        }

        // 인덱서 사용
        public string this[int index] {
            get { return phoneNumber[index]; }
            set { phoneNumber[index] = value; }
        }
    }
    class Program {
        static void Main(string[] args) {
            PhoneNumber phoneNumber = new PhoneNumber("041-539-9300");

            Console.WriteLine("첫 번째 번호: {0}", phoneNumber[0]);
            Console.WriteLine("두 번째 번호: {0}", phoneNumber[1]);
            Console.WriteLine("세 번째 번호: {0}", phoneNumber[2]);
        }
    }
}
