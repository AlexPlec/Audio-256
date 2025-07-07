namespace Audio_256.UI.Albums.Models
{
    public class AlbumThumbnailModel(

        string id,
        string albumTitle,
        string artistTitle,
        int year,
        string imagePath,
        int duration,
        int trackCount)
    {
        public string Id { get; set; } = id;
        public string AlbumTitle { get; set; } = albumTitle;
        public string ArtistTitle { get; set; } = artistTitle;
        public int Year { get; set; } = year;
        public string ImagePath { get; set; } = imagePath;
        public int Duration { get; set; } = duration;
        public int TrackCount { get; set; } = trackCount;
        public bool IsSelected { get; set; } = false;
    }
}