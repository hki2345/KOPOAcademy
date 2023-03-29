using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_017_Data_enum_2
{
    internal class Program
    {
        enum DAY_OF_WEEK
        {
            SUN,
            MON,
            TUE,
            WED,
            THU,
            FRI,
            SAT
        }
        static void Main(string[] args)
        {
            DAY_OF_WEEK today = DAY_OF_WEEK.WED;

            Console.WriteLine("오늘의 요일: {0}", today);
            Console.WriteLine("내일의 요일: {0}", today + 1);
        }
    }
}
