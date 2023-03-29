using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_016_Data_enum_1
{
    enum DAY_OF_WEEK
    {
        SUN,
        MON,
        TUE,
        WED = 300,
        THU,
        FRI,
        SAT,
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.SUN, (int)DAY_OF_WEEK.SUN);
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.MON, (int)DAY_OF_WEEK.MON);
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.TUE, (int)DAY_OF_WEEK.TUE);
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.WED, (int)DAY_OF_WEEK.WED);
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.THU, (int)DAY_OF_WEEK.THU);
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.FRI, (int)DAY_OF_WEEK.FRI);
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.SAT, (int)DAY_OF_WEEK.SAT);
        }
    }
}
