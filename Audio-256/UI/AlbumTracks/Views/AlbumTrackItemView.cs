using Audio_256.UI.AlbumTracks.Models;

namespace Audio_256.UI.AlbumTracks.Views
{
    public partial class AlbumTrackItemView : UserControl
    {
        private AlbumTrackItemModel? _model;
        public AlbumTrackItemView()
        {
            InitializeComponent();
            CreateEvents();
        }
        private void CreateEvents()
        {
            Click += (s, e) => OnClick?.Invoke(this, e);
            trackNumber.Click += (s, e) => OnClick?.Invoke(this, e);
            trackTitle.Click += (s, e) => OnClick?.Invoke(this, e);
            artistTitle.Click += (s, e) => OnClick?.Invoke(this, e);
            duration.Click += (s, e) => OnClick?.Invoke(this, e);
        }
        public void SetData(AlbumTrackItemModel model)
        {
            _model = model;
            trackNumber.Text = model.TrackNumber.ToString();
            trackTitle.Text = model.TrackTitle;
            artistTitle.Text = model.ArtistTitle;
            duration.Text = TimeSpan.FromSeconds(model.Duration).ToString(@"mm\:ss");
            SetSelected(model.IsSelected);
        }
        public void SetSelected(bool selected)
        {
            BackColor = selected ? Color.LightBlue : Color.Transparent;
        }
        public AlbumTrackItemModel? GetModel() => _model;

        public event EventHandler? OnClick;
    }
}
