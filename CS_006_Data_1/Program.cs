using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_006_Data_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b = 255;
            short s = 32767;
            int i = 2147483647;
            long l = 1000000000000000000;
            int j = 0b00001111;
            int f = 0x0F;


            Console.WriteLine("byte b = {0}", b);
            Console.WriteLine("short s = {0}", s);
            Console.WriteLine("int i = {0}", i);
            Console.WriteLine("long l = {0}", l);
            Console.WriteLine("2jin j = {0}", j);
            Console.WriteLine("10jin f = {0}", f);
        }
    }
}
