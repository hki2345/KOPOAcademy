using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_125_OOP_has
- Desc: A has B 관계
---------- ---------- ---------- ---------- ---------- */
namespace CS_125_OOP_has {
    class HardDisk {
        Platter platter;
        Head head;

        public HardDisk() {
            platter = new Platter();
            head = new Head();
        }

        public void Read() {
            platter.Spin();
            head.Scan();

            Console.WriteLine("데이터를 읽습니다.");
        }
    }

    class Platter {
        public void Spin() {
            Console.WriteLine("플래터가 회전합니다.");
        }
    }

    class Head {
        public void Scan() {
            Console.WriteLine("헤드가 스캔합니다.");
        }
    }

    class Program {
        static void Main(string[] args) {
            HardDisk hardDisk = new HardDisk();

            hardDisk.Read();
        }
    }
}
