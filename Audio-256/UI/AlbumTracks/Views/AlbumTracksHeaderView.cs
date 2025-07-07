using Audio_256.UI.AlbumTracks.Models;

namespace Audio_256.UI.AlbumTracks.Views
{
    public partial class AlbumTracksHeaderView : UserControl
    {
        private AlbumTracksHeaderModel? _model;
        public AlbumTracksHeaderView()
        {
            InitializeComponent();
        }
        public void SetData(AlbumTracksHeaderModel model)
        {
            _model = model;
            pictureBox.LoadAsync(model.ImagePath);
            albumTitle.Text = model.AlbumTitle;
            artistTitle.Text = model.ArtistTitle;
            year.Text = model.Year;
            tracksCount.Text = model.TracksCount.ToString();
            albumDuration.Text = model.AlbumDuration.ToString(@"mm\:ss");
        }
    }
}
