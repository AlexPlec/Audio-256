using static Audio_256.Core.DomainModels;

namespace Audio_256.Core
{
    public class MusicLibrary
    {
        public List<Artist> Artists { get; } = [];
        public List<Playlist> Playlists { get; } = [];

        public IEnumerable<Artist> GetArtists() => Artists;
        public IEnumerable<Album> GetAlbums(string artistName) =>
            Artists.FirstOrDefault(a => a.Title == artistName)?.Albums ?? Enumerable.Empty<Album>();

        public IEnumerable<Track> GetTracks(string artistName, string albumName) =>
            GetAlbums(artistName).FirstOrDefault(a => a.Title == albumName)?.Tracks ?? Enumerable.Empty<Track>();

        public IEnumerable<Playlist> GetPlaylists() => Playlists;

        public IEnumerable<Album> GetAllAlbums() => Artists.SelectMany(artist => artist.Albums);
    }
}
