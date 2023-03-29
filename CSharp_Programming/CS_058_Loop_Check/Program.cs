using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_058_Loop_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            num = int.Parse(Console.ReadLine());

            LeftUp(num);
            RightUp(num);
            LeftDown(num);
            RightDown(num);
        }

        static void RightUp(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = num - i; j < num + 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
        static void LeftUp(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (i >= num - (j + 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }

        static void RightDown(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num - i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        static void LeftDown(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (j >= i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
