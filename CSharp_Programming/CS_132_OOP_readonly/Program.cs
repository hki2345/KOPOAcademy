using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_132_OOP_readonly
- Desc: 읽기전용
---------- ---------- ---------- ---------- ---------- */
namespace CS_132_OOP_readonly {
    class Account {

        // readonly는 const와 같은 역할 이지만 객체가 생성될 때 값이 고정되는 것.
        // const는 프로그램이 실행될 때 고정, 고정하는 시점이 다르다.
        public readonly string id;
        public string pw;

        public Account(string id, string pw) {
            this.id = id;
            this.pw = pw;
        }
    }

    class Program {
        static void Main(string[] args) {
            Account account = new Account("Kim", "1234");

            // readonly 값은 변경할 수 없다! (오류 발생)
            // account.id = "Lee";

            account.pw = "5678";

            Console.WriteLine("ID: {0}", account.id);
            Console.WriteLine("PW: {0}", account.pw);
        }
    }
}
