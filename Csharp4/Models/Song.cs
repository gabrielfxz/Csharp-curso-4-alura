using System.Text.Json.Serialization;

namespace Csharp4.Models
{
    internal class Song
    {
        [JsonPropertyName("artist")]
        public string? Artist { get; set; }

        [JsonPropertyName("song")]
        public string? Name { get; set; }

        [JsonPropertyName("duration_ms")]
        public int Duration { get; set; }

        [JsonPropertyName("genre")]
        public string? Genre { get; set; }
     
        public void ShowSongDetails()
        {
            Console.WriteLine($"Artist: {Artist}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Duration: {Duration/1000}");
            Console.WriteLine($"Genre: {Genre}");

        }
    }
}
