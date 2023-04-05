using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CS_094_Challenge_Game
{
    internal class Program
    {
        const int MAP_X = 7;
        const int MAP_Y = 31;
        const int DISP_TIME = 100;


        static void Display(char[] tile, int[,] map)
        {

            Console.Clear();
            Console.WriteLine("== 달리기 게임 ==");
            Console.WriteLine();

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(tile[map[i, j]]);
                }

                Console.WriteLine();
            }

            Thread.Sleep(DISP_TIME);
        }

        static void Main(string[] args)
        {
            bool isFinish = false;
            char[] tile = { ' ', '-', '|', '1', '2', '3', '4', '5', };
            int[,] map = new int[MAP_X, MAP_Y]
            {
                { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },
                { 3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0 },
                { 4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0 },
                { 5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0 },
                { 6,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0 },
                { 7,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0 },
                { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 }
            };

            int[] player = { 0, 0, 0, 0, 0 };

            Display(tile, map);
            Console.Write("아무 키를 눌러 게임을 시작하세요: ");
            Console.ReadKey();

            Random rnd = new Random();

            while (true) 
            {
                for (int i = 0; i < player.Length; i++)
                {
                    map[i + 1, player[i]] = 0;

                    player[i] = player[i] + rnd.Next(1, 3);
                    if (player[i] > 29)
                    {
                        player[i] = 29;
                    }



                    map[i + 1, player[i]] = i + 3;
                }


                Display(tile, map);



                foreach(var item in player)
                {
                    if (item >= 29)
                    {
                        isFinish = true;
                        break;
                    }
                }

                if (isFinish)
                {
                    Console.WriteLine();

                    for (int i = 0; i < player.Length; i++)
                    {
                        if (player[i] >= 29)
                        {
                            Console.WriteLine("달리기 결과: {0}번 선수 1등!", i+1);
                            break;
                        }
                    }


                    string input = Console.ReadLine();

                    if(input == "1")
                    {
                        Array.Clear(player, 0, player.Length);
                        Array.Clear(map, map.GetLength(1), map.Length - 2 * map.GetLength(1));

                        map[1, 0] = 3;
                        map[2, 0] = 4;
                        map[3, 0] = 5;
                        map[4, 0] = 6;
                        map[5, 0] = 7;

                        map[1, 29] = 2;
                        map[2, 29] = 2;
                        map[3, 29] = 2;
                        map[4, 29] = 2;
                        map[5, 29] = 2;

                        isFinish = false;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
