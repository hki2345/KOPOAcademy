using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_157_Generic_dynamic
- Desc: 실행할 때 정해지는 데이터 타입
---------- ---------- ---------- ---------- ---------- */
namespace CS_157_Generic_dynamic {
    class Program {
        static T DynamicSum<T>(T[] arr) {
            // T data = 0;      // 오류 발생!
            // object data = 0; // 박싱 발생!
            dynamic data = default(T); // default(값 형식): 0으로 초기화
                                       // default(참조 형식): null로 초기화
            for (int i = 0; i < arr.Length; i++) {
                data += arr[i];
            }

            return data;
        }

        static T TSum<T>(T[] arr) {
            T data = default; // 변수 형식과 기본값을 찾을 형식이 같을 경우 형식입력괄호 생략 가능

            for (int i = 0; i < arr.Length; i++) {
                data += (dynamic)arr[i];
            }

            return data;
        }

        static void Main(string[] args) {
            int[] intArr = new int[] { 100, 200, 300 };
            double[] doubleArr = new double[] { 0.1, 0.2, 0.3 };
            string[] stringArr = new string[] { "a", "b", "c" };

            Console.WriteLine("DynamicSum<int>: {0}", DynamicSum<int>(intArr));
            Console.WriteLine("DynamicSum<double>: {0}", DynamicSum<double>(doubleArr));
            Console.WriteLine("DynamicSum<string>: {0}", DynamicSum<string>(stringArr));

            Console.WriteLine("TSum<int>: {0}", TSum<int>(intArr));
            Console.WriteLine("TSum<double>: {0}", TSum<double>(doubleArr));
            Console.WriteLine("TSum<string>: {0}", TSum<string>(stringArr));
        }
    }
}
