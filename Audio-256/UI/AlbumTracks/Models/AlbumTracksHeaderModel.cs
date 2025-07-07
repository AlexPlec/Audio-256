namespace Audio_256.UI.AlbumTracks.Models
{
    public class AlbumTracksHeaderModel(

        string id,
        string imagePath,
        string albumTitle,
        string artistTitle,
        string year,
        int tracksCount,
        TimeSpan albumDuration
        )
    {
        public string Id { get; set; } = id;
        public string ImagePath { get; set; } = imagePath;
        public string AlbumTitle { get; set; } = albumTitle;
        public string ArtistTitle { get; set; } = artistTitle;
        public string Year { get; set; } = year;
        public int TracksCount { get; set; } = tracksCount;
        public TimeSpan AlbumDuration { get; set; } = albumDuration;
    }
}
