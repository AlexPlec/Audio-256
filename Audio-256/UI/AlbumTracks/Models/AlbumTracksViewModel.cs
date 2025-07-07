namespace Audio_256.UI.AlbumTracks.Models
{
    public class AlbumTracksViewModel
    {
        public AlbumTracksListModel ListModel { get; } = new();
        public List<AlbumTrackItemModel> AlbumTrackItemModels => ListModel.AlbumTrackItemModels;
    }
}
