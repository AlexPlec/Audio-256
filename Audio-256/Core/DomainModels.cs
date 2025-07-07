namespace Audio_256.Core
{
    public class DomainModels
    {
        public class Track
        {
            public int TrackNumber { get; set; }
            public string Title { get; set; } = "";
            public string FilePath { get; set; } = "";
            public TimeSpan Duration { get; set; }
        }
        public class Album
        {
            public string Title { get; set; } = "";
            public string? Year { get; set; } = null;
            public string? CoverPath { get; set; } = null;
            public List<Track> Tracks { get; set; } = [];
            public TimeSpan Duration { get; set; }
        }
        public class Artist
        {
            public string Title { get; set; } = "";
            public string? CoverPath { get; set; } = null;
            public List<Album> Albums { get; set; } = [];
            public TimeSpan Duration { get; set; }
        }
        public class Playlist
        {
            public string Title { get; set; } = "";
            public List<string> TrackPaths { get; set; } = [];
        }
        public class MusicJsonData
        {
            public List<Artist> Artists { get; set; } = [];
        }
    }
}
