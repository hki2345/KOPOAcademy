using OpenAI.GPT3.Managers;
using OpenAI.GPT3;
using OpenAI.GPT3.ObjectModels;
using OpenAI.GPT3.ObjectModels.RequestModels;

namespace API_Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("질문할 것을 입력하세요!");
                string s = Console.ReadLine();
                Run(s);
            }
        }

        static async Task Process(string s)
        {
            OpenAIService openAIService = new OpenAIService(new OpenAiOptions()
            {
                ApiKey = "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",
                Organization = "org-l6NPPl7h3m5x68onaFj0gT7d"
            });

            var completionResult = await openAIService.Completions.CreateCompletion(new CompletionCreateRequest()
            {
                Prompt = s,
                Model = Models.TextAdaV1,
                MaxTokens = 150,
                N = 1
            });

            if (completionResult.Successful)
            {
                foreach (var choice in completionResult.Choices)
                {
                    Console.WriteLine("답변이 도착했습니다!");
                    Console.WriteLine(choice.Text.Trim());
                }
            }
        }

        private static async void Run(string s)
        {
            var task1 = Task.Run(() => Process(s));

            await task1;
        }
    }
}