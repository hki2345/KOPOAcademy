using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_149_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            for (int i = 0; i < 10; i++)
            {
                stack.Push(i);
            }

            Console.WriteLine("Peek(): {0}", stack.Peek());

            while (stack.Count > 0)
            {
                Console.WriteLine("Pop(): {0}, Count: {1}", stack.Pop(), stack.Count);
            }
        }
    }
}
