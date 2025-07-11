﻿using Audio_256.UI.Artists.Models;

namespace Audio_256.UI.Artists.Views
{
    public partial class ArtistThumbnailView : UserControl
    {
        private ArtistThumbnailModel? _model;
        public ArtistThumbnailView()
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
        public void SetData(ArtistThumbnailModel model)
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
        public ArtistThumbnailModel? GetModel() => _model;

        public event EventHandler? OnClick;
    }
}
