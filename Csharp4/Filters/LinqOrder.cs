using Csharp4.Models;

namespace Csharp4.Filters;

internal class LinqOrder
{
    public static void ShowOrdenatedArtistList(List<Song> songs)
    {
        var ordenatedArtists = songs.OrderBy(song => song.Artist).Select
            (song => song.Artist).Distinct().ToList();
        Console.WriteLine("Ordenated artists list");
        foreach (var artist in ordenatedArtists)
        {
            Console.WriteLine($"- {artist}");
        }
    }
}