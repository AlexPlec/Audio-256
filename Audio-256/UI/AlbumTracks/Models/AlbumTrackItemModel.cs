namespace Audio_256.UI.AlbumTracks.Models
{
    public class AlbumTrackItemModel(

         string id,
         int trackNumber,
         string trackTitle,
         string artistTitle,
         int duration
        )
    {
        public string Id { get; set; } = id;
        public int TrackNumber { get; set; } = trackNumber;
        public string TrackTitle { get; set; } = trackTitle;
        public string ArtistTitle { get; set; } = artistTitle;
        public int Duration { get; set; } = duration;
        public bool IsSelected { get; set; } = false;
    }
}
