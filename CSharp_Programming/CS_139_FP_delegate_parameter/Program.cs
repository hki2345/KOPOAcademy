using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_139_FP_delegate_parameter
{
    internal class Program
    {
        delegate void FuncDelegate();

        class MessageProcess
        {
            public void Message(string msg, FuncDelegate okFunc, FuncDelegate cancleFunc)
            {
                Console.Write("{0} (1: 확인, 2: 취소) ", msg);

                string input = Console.ReadLine();

                if (input == "1")
                {
                    okFunc();
                }
                else
                {
                    cancleFunc();
                }
            }
        }

        static void OkFunc()
        {
            Console.WriteLine("확인하셨습니다.");
        }

        static void CancleFunc()
        {
            Console.WriteLine("취소하셨습니다.");
        }

        static void Main(string[] args)
        {
            MessageProcess msg = new MessageProcess();

            msg.Message("확인하시겠습니까?", OkFunc, CancleFunc);

            msg.Message("정말 확인하시겠습니까?",
                delegate ()
                {
                    Console.WriteLine("정말 확인하셨습니다.");
                },
                delegate ()
                {
                    Console.WriteLine("정말 취소하셨습니다.");
                }
            );
        }
    }
}
