using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_150_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");

            Console.WriteLine("Peek(): {0}", queue.Peek());

            while(queue.Count > 0)
            {
                Console.WriteLine("Dequeue: {0}, Count: {1}", queue.Dequeue(), queue.Count);
            }
        }
    }
}
