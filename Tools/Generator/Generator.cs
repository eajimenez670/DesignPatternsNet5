using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace Tools.Generator
{
    public class Generator
    {
        public List<string> Content { get; set; }
        public string Path { get; set; }
        public TypeFormat Format { get; set; }
        public TypeCharacter Character { get; set; }

        public void Save()
        {
            var result = "";
            result = Format == TypeFormat.Json ? GetJson() : GetPipe();
            if (Character == TypeCharacter.UpperCase) result = result.ToUpper();
            if (Character == TypeCharacter.LowerCase) result = result.ToLower();

            File.WriteAllText(Path, result, Encoding.UTF8);
        }

        private string GetJson() => JsonSerializer.Serialize(Content);

        private string GetPipe() => Content.Aggregate((acc, cur) => acc + "|" + cur);
    }
}
