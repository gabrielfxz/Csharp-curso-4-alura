using Csharp4.Models;
using System.Text.Json;

using (HttpClient  client = new HttpClient())
{
    try
    {
        string answer = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(answer);
        var songs = JsonSerializer.Deserialize<List<Song>>(answer);
        songs[999].ShowSongDetails();
    }
    catch(Exception ex)
    {
        Console.WriteLine($"we got a problem: {ex.Message}");
    }
    
}
