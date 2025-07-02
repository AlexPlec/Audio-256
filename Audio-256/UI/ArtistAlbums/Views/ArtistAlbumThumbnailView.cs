using Audio_256.UI.ArtistAlbums.Models;

namespace Audio_256.UI.ArtistAlbums.Views
{
    public partial class ArtistAlbumThumbnailView : UserControl
    {
        private ArtistAlbumThumbnailModel? _model;
        public ArtistAlbumThumbnailView()
        {
            InitializeComponent();
            CreateEvents();
        }
        private void CreateEvents()
        {
            Click += (s, e) => OnClick?.Invoke(this, e);
            pictureBox.Click += (s, e) => OnClick?.Invoke(this, e);
            label.Click += (s, e) => OnClick?.Invoke(this, e);
        }
        public void SetData(ArtistAlbumThumbnailModel model)
        {
            _model = model;
            label.Text = model.Name;
            pictureBox.LoadAsync(model.ImagePath);
            SetSelected(model.IsSelected);
        }
        public void SetSelected(bool selected)
        {
            BackColor = selected ? Color.LightBlue : Color.Transparent;
        }
        public ArtistAlbumThumbnailModel? GetModel() => _model;

        public event EventHandler? OnClick;
    }
}
