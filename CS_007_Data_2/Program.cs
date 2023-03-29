using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CS_007_Data_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("byte 최솟값: {0} ~ byte 최대값: {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("short 최솟값: {0} ~ short 최대값: {1}", short.MinValue, short.MaxValue);
            Console.WriteLine("int 최솟값: {0} ~ int 최대값: {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("long 최솟값: {0} ~ long 최대값: {1}", long.MinValue, long.MaxValue);
        }
    }
}
