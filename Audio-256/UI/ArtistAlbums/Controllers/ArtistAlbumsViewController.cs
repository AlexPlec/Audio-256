using Audio_256.Core;
using Audio_256.UI.ArtistAlbums.Models;
using Audio_256.UI.ArtistAlbums.Views;
using Audio_256.UI.Artists.Models;

namespace Audio_256.UI.ArtistAlbums.Controllers
{
    internal class ArtistAlbumsViewController
    {
        private readonly ArtistAlbumsViewModel _model;
        private readonly ArtistAlbumsView _view;
        private readonly IMediator _mediator;
        private readonly MusicLibrary _library;

        public ArtistAlbumsViewController(
            ArtistAlbumsViewModel model,
            ArtistAlbumsView view,
            IMediator mediator,
             MusicLibrary library)
        {
            _model = model;
            _view = view;
            _mediator = mediator;
            _library = library;

            _mediator.Subscribe("ARTIST_SELECTED", OnArtistSelected);
            _mediator.Subscribe("ARTISTAlBUM_SELECTED", OnArtistAlbumSelected);

            Initialize();
        }
        private void Initialize()
        {
            _view.ClearItems();

            foreach (var item in _model.ArtistAlbumThumbnails)
            {
                var itemView = new ArtistAlbumThumbnailView();
                var controller = new ArtistAlbumThumbnailController(item, itemView, _mediator);
                _view.AddItem(controller.GetView());
            }
        }
        private void OnArtistAlbumSelected(object? data)
        {
            foreach (var model in _model.ArtistAlbumThumbnails)
                model.IsSelected = false;

            if (data is ArtistAlbumThumbnailModel selected)
                selected.IsSelected = true;

            Initialize(); // Refresh views
        }
        private void OnArtistSelected(object? data)
        {
            if (data is not ArtistThumbnailModel artistModel)
                return;
            System.Diagnostics.Debug.WriteLine($"Selected Artist: {artistModel}");

            string artistName = artistModel.Name; // or Title if you use that naming

            var albums = _library.GetAlbums(artistName);
            _model.ArtistAlbumThumbnails.Clear();

            foreach (var album in albums)
            {
                var model = new ArtistAlbumThumbnailModel(
                    Guid.NewGuid().ToString(),
                    album.Title,
                    album.CoverPath ?? "default_album.jpg",
                    album.Tracks.Count
                )

                {
                    IsSelected = false
                };

                _model.ArtistAlbumThumbnails.Add(model);
            }

            Initialize(); // Refresh view
        }
    }
}
