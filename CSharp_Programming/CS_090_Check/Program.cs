using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_090_Check
{
    internal class Program
    {
        static void FileExplore(string path)
        {
            string[] folder = Directory.GetDirectories(path);

            foreach (string item in folder)
            {
                Console.WriteLine(item);

                FileExplore(item);
            }

            string[] file = Directory.GetFiles(path);

            foreach(var item in file)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            string path = @"C:\Program Files\dotnet";

            FileExplore(path);
        }
    }
}
