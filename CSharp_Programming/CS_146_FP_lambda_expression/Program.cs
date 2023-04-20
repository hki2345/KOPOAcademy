using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_146_FP_lambda_expression
{
    internal class Program
    {
        delegate int SquareDelegate(int a);
        delegate void VoidDelegate();
        static void Main(string[] args)
        {
            // 1. 람다 식 기본형
            // 파라미터는 소괄호로, 함수내부는 중괄호로 묶어주며, 파라미터와 함수내부 사이에는 => 작성
            SquareDelegate d1 = (a) =>
            {
                return a * a;
            };

            // 2. 파라미터 괄호 생략
            // 파라미터가 1개일 경우 소괄호 생략 가능
            SquareDelegate d2 = a =>
            {
                return a * a;
            };

            // 3. 함수내부 괄호, return 생략
            // 함수 내부가 1줄일 경우 중괄호와 함께 return 생략 가능
            SquareDelegate d3 = (a) => a * a;

            // 4. 람다식 최종 단축 표현
            // 파라미터 1개, 함수내부 1줄 모두 만족
            SquareDelegate d4 = a => a * a;

            Console.WriteLine("1 * 1 = {0}", d1(1));
            Console.WriteLine("2 * 2 = {0}", d2(2));
            Console.WriteLine("3 * 3 = {0}", d3(3));
            Console.WriteLine("4 * 4 = {0}", d4(4));


            // 5. 파라미터가 없는 람다식
            // 파라미터가 없을 경우 소괄호만 작성
            VoidDelegate d5 = () =>
            {
                Console.WriteLine("d5() 람다식");
            };

            // 6. 함수 내부가 없는 람다식
            // 함수내부가 없을 경우 중괄호만 작성
            VoidDelegate d6 = () => { };

            // 7. 함수 내부 괄호 생략
            // 반환값이 없더라도 함수내부가 1줄일 경우 중괄호 생략 가능
            VoidDelegate d7 = () => Console.WriteLine("d7() 람다식");

            d5();
            d6();
            d7();
        }
    }
}
