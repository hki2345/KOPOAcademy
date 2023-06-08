using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JsonLearning
{
    internal class Program
    {
        // 옵션으로 클래스 private, public 이랑 대소문자 구분 뚫기, 콤마 처리 뚫기
        // 아래 옵션으로 하면 약간 불안할 수도? -> 시리얼라이즈가 안됌
        static JsonSerializerOptions options = new JsonSerializerOptions { IncludeFields = true, PropertyNameCaseInsensitive = true, AllowTrailingCommas = true};
        static void Main(string[] args)
        {
            // Json File
            string jStr = @"
            {
                ""name"": ""철수"",
                ""age"": 10,
                ""grade"": 3,
                ""hobby"": [{
                    ""title"": ""축구"",
                    ""content"": ""골키퍼""
                },
                {
                    ""title"": ""농구"",
                    ""content"": ""공격수""
                }]
            }";



            // System.Text.json => 마소 공식지원, 단 닷넷 5.0에서 지원 UIPath 및 구형 프로젝트에선 호환 어려움
            // Newtonssoft. json => 다소 효율적이지 못함, 겁나 편함
            // 부가 비교 시리얼라이즈, 위 System.Text.json 아래 - NewtonJson --> 뉴턴은 옵션 없이 대소문자 및 시리얼라이즈 구분 잡아준다.
            // SYstem은 옵션없으니 고장 잘 남 -> 옵션 유무에 따라 하지 않으려면 테그 붙이면 됨, 오히려 정확해서 좋을지도? (성능차이도 이런 부분 때문일듯)
            Console.WriteLine(JsonDocument.Parse(jStr).RootElement.GetProperty("name"));
            Student student = System.Text.Json.JsonSerializer.Deserialize<Student>(jStr, options);
            Console.WriteLine(student.hobby[0].title);
            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(student, options));

            // Dictionary
            var dic2 = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, object>>(jStr, options);
            Console.WriteLine(dic2);


            // *************** //
            Console.WriteLine(JObject.Parse(jStr)["name"].ToString());
            Student student2 = JsonConvert.DeserializeObject<Student>(jStr);
            Console.WriteLine(student2.hobby[1].title);
            Console.WriteLine(JsonConvert.SerializeObject(student2));

            // Dictionary
            var dic = JsonConvert.DeserializeObject<Dictionary<string, object>>(jStr);
            Console.WriteLine(dic);

            // 위에까지 FM
            // Dictionary
            object student4 = JsonConvert.DeserializeObject(jStr);
            dynamic data = (Dictionary<string, object>)DeserializeListDictionary(student4);
            Console.WriteLine(data["hobby"][0]["title"]);
        }


        static object DeserializeListDictionary(object o)
        {
            switch (o)
            {
                case JObject jObject:
                    return ((IEnumerable<KeyValuePair<string, JToken>>)jObject).ToDictionary(
                        j => j.Key,
                        j => DeserializeListDictionary(j.Value)
                        );

                case JArray jArray:
                    return jArray.Select(DeserializeListDictionary).ToList();

                case JValue jValue:
                    return jValue.Value;

                default:
                    throw new Exception(
                        $"Json Convert의 DeserializeObject로 변환한 데이터를 넣어주세요! (들어온 타입: {o.GetType()}");
            }
        }

        class Student
        {
            //[JsonPropertyName("name")] public string Name { get; set; }
            //[JsonPropertyName("age")] public int Age { get; set; }
            //[JsonPropertyName("grade")] public int Grade { get; set; }
            //[JsonPropertyName("hobby")] public Hobby[] hobby { get; set; }

            //public class Hobby
            //{
            //    [JsonPropertyName("title")]     public string Title { get; set; }
            //    [JsonPropertyName("content")]   public string Content { get; set; }
            //}
            public string name;
            public int age;
            public int grade;
            public Hobby[] hobby;

            public class Hobby
            {
                public string title;
                public string content;
            }
        }
    }
}
