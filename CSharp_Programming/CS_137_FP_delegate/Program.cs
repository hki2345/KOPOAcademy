using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_137_FP_delegate
- Desc: 함수형 프로그래밍 (functional programming)
---------- ---------- ---------- ---------- ---------- */
namespace CS_137_FP_delegate {
    delegate void MethodDelegate(string tool);

    class Woodcutter {
        public string tool = "도끼";

        public MethodDelegate method = Method;

        static void Method(string tool) {
            Console.WriteLine("{0}을(를) 휘둘러 나무를 팹니다.", tool);
        }
    }

    class Lumberjack {
        public string tool = "전기톱";

        public MethodDelegate method = Method;

        static void Method(string tool) {
            Console.WriteLine("{0}을(를) 켜서 나무를 자릅니다.", tool);
        }
    }

    class Program {
        static void Main(string[] args) {
            Woodcutter woodcutter = new Woodcutter();

            Console.WriteLine("나무꾼이 나무를 수집합니다.");
            woodcutter.method(woodcutter.tool);

            Console.WriteLine();

            Lumberjack lumberjack = new Lumberjack();

            Console.WriteLine("벌목꾼이 나무꾼에게 전기톱을 줍니다.");
            woodcutter.tool = lumberjack.tool;

            Console.WriteLine();

            Console.WriteLine("나무꾼이 벌목꾼에게 받은 도구로 나무를 수집합니다.");
            woodcutter.method(woodcutter.tool);

            Console.WriteLine();

            Console.WriteLine("벌목꾼이 나무꾼에게 전기톱 사용 방법을 알려줍니다.");
            woodcutter.method = lumberjack.method;

            Console.WriteLine();

            Console.WriteLine("나무꾼이 벌목꾼에게 배운 방법으로 나무를 수집합니다.");
            woodcutter.method(woodcutter.tool);

            Console.WriteLine();
        }
    }
}
