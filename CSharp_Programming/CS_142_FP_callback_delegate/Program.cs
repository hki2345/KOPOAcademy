using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_142_FP_callback_delegate
{
    delegate void CallbackDelegate();

    class Computer
    {
        public void TurnOn()
        {
            Console.WriteLine("컴퓨터 전원 켜짐");
        }
    }
    internal class Program
    {
        static void ButtonPush(Computer computer)
        {
            Console.WriteLine("컴퓨터 전원 버튼 누름");
            computer.TurnOn();
        }

        static void Main(string[] args)
        {
            // 컴퓨터를 전체 복사해서 함수호출 함 매우 비효율적
            Computer computer = new Computer();
            ButtonPush(computer);

            // 델리게이트를 이용한 함수 호출
            CallbackDelegate callback = computer.TurnOn;
            callback();
        }
    }
}
