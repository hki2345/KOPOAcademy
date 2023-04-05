using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_094_Challenge
- Desc: 달리기 게임
---------- ---------- ---------- ---------- ---------- */
namespace CS_094_Challenge {
    class Program {
        static void Display(char[] tile, int[,] map, int dispTime) {
            Console.Clear();

            Console.WriteLine("== 달리게 게임 ==");

            Console.WriteLine();

            for (int i = 0; i < map.GetLength(0); i++) {
                for (int j = 0; j < map.GetLength(1); j++) {
                    Console.Write(tile[map[i, j]]);
                }

                Console.WriteLine();
            }

            Thread.Sleep(dispTime);
        }

        static void Main(string[] args) {
            Random rnd = new Random();

            const int MAP_X = 7;
            const int MAP_Y = 31;
            const int DISP_TIME = 100;
                          // 0    1    2    3    4    5    6    7
            char[] tile = { ' ', '-', '|', '1', '2', '3', '4', '5' };

            int[,] map = new int[MAP_X, MAP_Y] {
               // 0  1  2  3  4  5  6  7  8  9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, // 0
                { 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 }, // 1
                { 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 }, // 2
                { 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 }, // 3
                { 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 }, // 4
                { 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 }, // 5
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }  // 6
            };

            int[] player = { 0, 0, 0, 0, 0 };
            bool isFinish = false;

            Display(tile, map, DISP_TIME);

            Console.WriteLine();

            Console.Write("아무 키를 눌러 게임을 시작하세요: ");
            Console.ReadKey();

            while (true) {
                for (int i = 0; i < player.Length; i++) { // 달리기 구현
                    map[i+1, player[i]] = 0;

                    player[i] = player[i] + rnd.Next(1, 3);

                    if (player[i] > 29) {
                        player[i] = 29;
                    }

                    map[i+1, player[i]] = i+3;
                }

                Display(tile, map, DISP_TIME);

                foreach (var item in player) { // 완주한 선수 확인
                    if (item >= 29) {
                        isFinish = true;
                        break;
                    }
                }

                if (isFinish) {
                    Console.WriteLine();

                    for (int i = 0; i < player.Length; i++) {
                        if (player[i] >= 29) {
                            Console.WriteLine("달리기 결과: {0}번 선수 1등!!", i+1);
                            break;
                        }
                    }

                    Console.Write("다시 시작하려면 1을 입력하세요: ");
                    string input = Console.ReadLine();

                    if (input == "1") {
                        Array.Clear(player, 0, player.Length);

                        Array.Clear(map, map.GetLength(1), map.Length - 2*map.GetLength(1));

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
                    } else {
                        Console.WriteLine("게임을 종료합니다.");
                        break;
                    }
                }
            }
        }
    }
}
