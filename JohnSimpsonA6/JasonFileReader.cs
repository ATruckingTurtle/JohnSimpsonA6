using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace JohnSimpsonA6
{
    public class JasonFileReader
    { 
        public static Text Read<Text>(string filepath){
            string text = File.ReadAllText(filepath);
            return JsonSerializer.Deserialize<Text>(text);
        }
    }
}
