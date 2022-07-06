using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCharpPractice
{
    internal class JsonSerializationExample
    {
        int a = 12;
        string b = "456";

        public void Run()
        {
            string j = @"{
    ""id"": ""4EAF4717 - 357A - 4545 - 8905 - 44AB94A61D50"",
    ""title"": ""iopop"",
    ""schemaVersion"": ""1.0"",
    ""testVersion"": ""1.0"",
    ""previousVersionId"": ""none"",
    ""authorId"": ""vlad@pro.co.il"",
    ""description"": ""C# and JavaScript final test"",
    ""tags"": [
        ""C#"",
        ""JavaScript"",
        ""Final Test""
    ],
    ""questionsRefs"": [
        ""AEAF4717-357A-4545-8905-D4AB94A61D31"",
        ""AEAF4717-357A-4545-8905-D4AB94A61D34"",
        ""AEAF4717-357A-4545-8905-D4AB94A61D35"",
        ""AEAF4717-357A-4545-8905-D4AB94A61D36""
    ]
}";
           JsonSmapleClass c =  System.Text.Json.JsonSerializer.Deserialize<JsonSmapleClass>(j);
            c.title = "this is a new Json";

            string newJ =System.Text.Json.JsonSerializer.Serialize<JsonSmapleClass>(c);

            Dictionary<string, JsonSmapleClass> dic = new Dictionary<string, JsonSmapleClass>();
            dic.Add("123", c);
            dic.Add("456", c);
            dic.Add("789", c);
            dic.Add("78", c);

            newJ = System.Text.Json.JsonSerializer.Serialize<Dictionary<string, JsonSmapleClass>>(dic);
            Dictionary<string,JsonSmapleClass> dic2 = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string,JsonSmapleClass>>(newJ);
        }
    }
}
