using Csharp4.Models;

namespace Csharp4.Filters;

internal class LinqFilter
{
    public static void FilterAllGenres(List<Song> songs)
    {
        var allGenres = songs.Select(genres =>
            genres.Genre).Distinct().ToList();
        foreach (var genre in allGenres)
        {
            Console.WriteLine($"- {genre}");
        }
    }

    public static void FilterArtistsByGenre(List<Song> songs, string genre)
    {
        var artistsByGenre = songs.Where(song =>
            song.Genre!.Contains(genre)).Select(song =>
            song.Artist).Distinct().ToList();
        Console.WriteLine($"Showing artists by musical genre --> {genre}");
        foreach (var artist in artistsByGenre) 
        {
            Console.WriteLine($"- {artist}");
        }

    }

    public static void FilterSongsFromArtist(List<Song> songs, string artistName)
    {
        var artistSongs = songs.Where(song => song.Artist!.Equals(artistName)).ToList();
        Console.WriteLine(artistName);
        foreach (var song in artistSongs)
        {
            Console.WriteLine($"- {song.Name}");
        }
    }

    public static void FilterSongsByYear(List<Song> songs, string songYear)
    {
        var yearSongs = songs.Where(song => song.Year!.Equals(songYear)).ToList();
        Console.WriteLine(songYear);
        foreach (var song in yearSongs)
        {
            Console.WriteLine($"- {song.Name}");
        }
    }

    public static void FilterSongsByNotes(List<Song> songs, string songNotes)
    {
        var noteSongs = songs.Where(song => song.Note.Equals(songNotes)).Distinct().ToList();
        Console.WriteLine($"songs in {songNotes}");
        foreach (var song in noteSongs)
        {
            song.ShowSongDetails();
            Console.WriteLine();
        }
    }
}
