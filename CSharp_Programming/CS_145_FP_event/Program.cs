using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_145_FP_event
{
    internal class Program
    {
        public delegate void TestDelegate(string msg);

        class Test
        {
            public TestDelegate d;
            public event TestDelegate e;

            public void DoEvent(string msg)
            {
                e(msg);
            }
        }

        static public void Method(string msg)
        {
            Console.WriteLine(msg);
        }

        static void Main(string[] args)
        {
            Test test = new Test();
            test.d = Method;

            test.d("테스트 클래스 외부에서 델리게이트 호출");

            // 이벤트는 대입연산자를 사용할 수 없다. (오류 발생)
            // test.e = Method;

            test.e += Method;

            // 이벤트는 클래스 외부에서 직접 호출할 수 없다.(오류 발생)
            // test.e("테스트 클래스 외부에서 이벤트 호출");

            // 이벤트는 이렇게 따로 함수로 묶어서 실행
            test.DoEvent("테스트 클래스 내부에서 이벤트 호출");
        }
    }
}
