using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_100_check
- Desc: 금고
---------- ---------- ---------- ---------- ---------- */
namespace CS_100_check {
    class SafeBox {
        void Unlock(string password) {
            if (password == "1234") {
                Console.WriteLine("Top Secret!!");
            }
        }

        static void Main(string[] args) {
            SafeBox safeBox = new SafeBox();

            safeBox.Unlock(Console.ReadLine());
        }
    }
}
