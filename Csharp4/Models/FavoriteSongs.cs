using System.Text.Json;

namespace Csharp4.Models;

internal class FavoriteSongs
{
    public string? Name { get; set; }
    public List<Song> FavoriteSongsList { get; }

    public FavoriteSongs(string name) 
    {
        Name = name;
        FavoriteSongsList = new List<Song>();
    }

    public void AddFavoriteSongs(Song song)
    {
        FavoriteSongsList.Add(song);
    }

    public void ShowFavoriteSongs()
    {
        Console.WriteLine($"These are {Name}'s favorite songs");
        foreach(var song in FavoriteSongsList) 
        { 
            Console.WriteLine($"- {song.Name} by {song.Artist}"); 
        }
        Console.WriteLine();
    }

    public void GenerateJsonFile()
    {
        string json = JsonSerializer.Serialize(new
        {
            name = Name,
            songs = FavoriteSongsList
        });
        string fileName = $"favorite-songs-{Name}.json";

        File.WriteAllText(fileName, json);
        Console.WriteLine($"JSON file created successfully {Path.GetFullPath(fileName)}");
    }
}
