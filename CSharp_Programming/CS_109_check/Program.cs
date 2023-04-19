using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_109_check
- Desc: 금고
---------- ---------- ---------- ---------- ---------- */
namespace CS_109_check {
    class SafeBox {
        static SafeBox safeBox;

        public static SafeBox GetInstance(string password) {
            if (password == "1234") {
                if (safeBox == null) {
                    safeBox = new SafeBox();
                }

                return safeBox;
            } else {
                return null;
            }
        }

        public void Unlock(string password) {
            if (password == "1234") {
                Console.WriteLine("Top Secret!!");
            }
        }
    }

    class Program {
        static void Main(string[] args) {
            SafeBox safeBox = SafeBox.GetInstance(Console.ReadLine());
            
            safeBox.Unlock(Console.ReadLine());
        }
    }
}
