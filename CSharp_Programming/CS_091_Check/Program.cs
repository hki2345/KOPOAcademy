using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_091_Check
{
    internal class Program
    {
        static void Fill(int i, int j, char color, char[,] image)
        {
            char preColor = image[i, j];
            image[i, j] = color;

            if (i - 1 >= 0 && preColor == image[i - 1, j])
            {
                Fill(i - 1, j, color, image);
            }
            if (i + 1 < image.GetLength(0) && preColor == image[i + 1, j])
            {
                Fill(i + 1, j, color, image);
            }
            if (j - 1 >= 0 && preColor == image[i, j - 1])
            {
                Fill(i, j - 1, color, image);
            }
            if (j + 1 < image.GetLength(1) && preColor == image[i, j + 1])
            {
                Fill(i, j + 1, color, image);
            }
        }

        static void Display(char[,] image)
        {
            for (int i = 0; i < image.GetLength(0); i++)
            {
                for (int j = 0; j < image.GetLength(1); j++)
                {
                    Console.Write(image[i, j]);
                }

                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            char[,] image =
            {
                { ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                { ' ', ' ', 'R', 'R', 'R', ' ', ' '},
                { ' ', 'R', 'R', ' ', 'R', 'R', ' '},
                { ' ', 'R', ' ', ' ', ' ', 'R', ' '},
                { ' ', 'R', 'R', ' ', 'R', 'R', ' '},
                { ' ', ' ', 'R', 'R', 'R', ' ', ' '},
                { ' ', ' ', ' ', ' ', ' ', ' ', ' '}                
            };


            Console.WriteLine("# 편집 전 이미지");
            Display(image);

            Fill(1, 2, '#', image);

            Console.WriteLine("# 편집 후 이미지");
            Display(image);
        }
    }
}
