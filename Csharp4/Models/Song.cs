using System.Text.Json.Serialization;

namespace Csharp4.Models
{
    internal class Song
    {

        private readonly string[] notes = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

        [JsonPropertyName("artist")]
        public string? Artist { get; set; }

        [JsonPropertyName("song")]
        public string? Name { get; set; }

        [JsonPropertyName("duration_ms")]
        public int Duration { get; set; }

        [JsonPropertyName("genre")]
        public string? Genre { get; set; }

        [JsonPropertyName("year")]
        public string? Year { get; set; }

        [JsonPropertyName("key")]
        public int Key { get; set; }

        public string Note
        {
            get 
            {
                return notes[Key];
            }
        }
     
        public void ShowSongDetails()
        {
            Console.WriteLine($"Artist: {Artist}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Duration: {Duration/1000}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Key: {Note}");
        }

        
    }
}
