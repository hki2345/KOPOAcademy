using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_067_Value_type_Reference_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            int numCopy = num;
            numCopy = 200;

            Console.WriteLine("num: {0}, numCopy: {1}, ReferenceEquals: {2}", num, numCopy, ReferenceEquals(num, numCopy));

            int[] numArr = { 100 };
            // int[] numArrCopy = new int[1];
            int[] numArrCopy = numArr;
            numArrCopy[0] = 200;

            Console.WriteLine("numArr[0]: {0}, numArrCopy: {1}, RefernceEquals: {2}", numArr[0], numArrCopy[0], ReferenceEquals(numArr, numArrCopy));
        }
    }
}
