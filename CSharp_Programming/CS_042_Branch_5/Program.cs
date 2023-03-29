using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_042_Branch_5
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
            string todayStr = "";

            switch (today)
            {
                case DAY_OF_WEEK.SUN:
                todayStr = "일";
                break;

                case DAY_OF_WEEK.MON:
                todayStr = "월";
                break;

                case DAY_OF_WEEK.TUE:
                todayStr = "화";
                break;

                case DAY_OF_WEEK.WED:
                todayStr = "수";
                break;

                case DAY_OF_WEEK.THU:
                todayStr = "목";
                break;  

                case DAY_OF_WEEK.FRI:
                todayStr = "금";
                break;

                case DAY_OF_WEEK.SAT:
                todayStr = "토";
                break;
            }

            Console.WriteLine("오늘의 요일은 {0}요일 입니다.", todayStr);
        }
    }
}
