using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JohnSimpsonA6
{
    public class Books
    {
        [JsonPropertyName("Title")]
        public string Title { get; set; }
        [JsonPropertyName("Author")]
        public string Author { get; set; }
        [JsonPropertyName("Page Length")]
        public int Pages { get; set; }
        [JsonPropertyName("Genre")]
        public string Genre { get; set; }
        [JsonPropertyName("Year Published")]
        public int Year { get; set; }
        [JsonPropertyName("MSRP")]
        public decimal Price { get; set; }
    }
}
