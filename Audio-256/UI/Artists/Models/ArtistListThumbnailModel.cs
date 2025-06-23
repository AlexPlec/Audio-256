namespace Audio_256.UI.Artists.Models
{
    public class ArtistListThumbnailModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public int AlbumCount { get; set; }
        public int TrackCount { get; set; }
        public bool IsSelected { get; set; }
        public ArtistListThumbnailModel(

              string id,
              string name,
              string imagePath,
              int albumCount,
              int trackCount)
        {
            Id = id;
            Name = name;
            ImagePath = imagePath;
            AlbumCount = albumCount;
            TrackCount = trackCount;
            IsSelected = false;
        }
    }
}
