namespace Audio_256.UI.Albums.Models
{
    public class AlbumThumbnailModel(

        string id,
        string name,
        string imagePath,
        int trackCount)
    {
        public string Id { get; set; } = id;
        public string Name { get; set; } = name;
        public string ImagePath { get; set; } = imagePath;
        public int TrackCount { get; set; } = trackCount;
        public bool IsSelected { get; set; } = false;
    }
}