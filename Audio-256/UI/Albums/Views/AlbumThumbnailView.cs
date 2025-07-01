using Audio_256.UI.Albums.Models;

namespace Audio_256.UI.Albums.Views
{
    public partial class AlbumThumbnailView : UserControl
    {
        private AlbumThumbnailModel? _model;
        public AlbumThumbnailView()
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
        public void SetData(AlbumThumbnailModel model)
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
        public AlbumThumbnailModel? GetModel() => _model;

        public event EventHandler? OnClick;
    }
}