using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_095_ReadLine_Array
- Desc: 콘솔에서 입력받은 문자열을 나눠 활용하는 방법
---------- ---------- ---------- ---------- ---------- */
namespace CS_095_ReadLine_Array {
    class Program {
        static void Main(string[] args) {
            Console.Write("정수를 두 개 입력하세요 (두 정수 사이에는 공백으로 분리): ");
            string s = Console.ReadLine();

            string[] sArr = s.Split();

            int a = int.Parse(sArr[0]);
            int b = int.Parse(sArr[1]);

            Console.WriteLine("입력한 첫 번째 정수: {0}", a);
            Console.WriteLine("입력한 두 번째 정수: {0}", b);
        }
    }
}
