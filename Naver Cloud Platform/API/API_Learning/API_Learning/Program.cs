using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open

namespace API_Learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string s = Console.ReadLine();
                Run(s);
            }
        }

        static async Task Process(string s)
        {
            OpenAIService openAIService = new OpenAIService(new OpenAIService());
        }


        private static async void Run(string s)
        {
            // 비동기로 Worker Thread에서 도는 stask
            var task1 = Task.Run(() => Process(s));

            await task1;
        }
    }
}
