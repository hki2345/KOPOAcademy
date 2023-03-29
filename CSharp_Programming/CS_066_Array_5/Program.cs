using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_066_Array_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "APPLE";

            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }

            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
        }
    }
}
