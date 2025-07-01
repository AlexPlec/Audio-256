namespace Audio_256.UI.Artists.Models
{
    public class ArtistThumbnailModel(

          string id,
          string name,
          string imagePath,
          int albumCount,
          int trackCount)
    {
        public string Id { get; set; } = id;
        public string Name { get; set; } = name;
        public string ImagePath { get; set; } = imagePath;
        public int AlbumCount { get; set; } = albumCount;
        public int TrackCount { get; set; } = trackCount;
        public bool IsSelected { get; set; } = false;
    }
}
