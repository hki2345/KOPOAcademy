using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_147_ArrayList_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object[] objectArr = new object[] { };
            ArrayList arrayList = new ArrayList() { };

            arrayList.Add(100);
            arrayList.Add(.1);
            arrayList.Add("apple");

            Console.WriteLine(arrayList[0]);
            Console.WriteLine(arrayList[1]);
            Console.WriteLine(arrayList[2]);

            Console.WriteLine();

            foreach (object obj in arrayList)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();


            object[] arr = { 100, 0.1, "apple" };
            ArrayList arrayList2 = new ArrayList(arr);

            foreach (object obj in arrayList2)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
