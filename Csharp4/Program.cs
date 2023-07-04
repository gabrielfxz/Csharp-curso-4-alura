using Csharp4.Models;
using System.Text.Json;
using Csharp4.Filters;
using System.ComponentModel.Design.Serialization;

using (HttpClient  client = new HttpClient())
{
    try
    {
        string answer = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var songs = JsonSerializer.Deserialize<List<Song>>(answer);
        //LinqFilter.FilterAllGenres(songs!);
        //LinqOrder.ShowOrdenatedArtistList(songs!);
        //LinqFilter.FilterArtistsByGenre(songs!,"hip hop");
        //LinqFilter.FilterSongsFromArtist(songs!, "Juice WRLD");
        //LinqFilter.FilterSongsByYear(songs!, "2018");
        //var gabrielFavoriteSongs = new FavoriteSongs("Gabriel");
        //gabrielFavoriteSongs.AddFavoriteSongs(songs[286]);
        //gabrielFavoriteSongs.AddFavoriteSongs(songs[937]);
        //gabrielFavoriteSongs.AddFavoriteSongs(songs[177]);
        //gabrielFavoriteSongs.AddFavoriteSongs(songs[436]);
        //gabrielFavoriteSongs.AddFavoriteSongs(songs[90]);
        //gabrielFavoriteSongs.ShowFavoriteSongs();
        //gabrielFavoriteSongs.GenerateJsonFile();
        //songs![109].ShowSongDetails();
        //LinqFilter.FilterSongsByNotes(songs!, "C#");
    }
    catch(Exception ex)
    {
        Console.WriteLine($"we got a problem: {ex.Message}");
    }
    
}
