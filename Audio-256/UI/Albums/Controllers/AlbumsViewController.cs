using Audio_256.Core;
using Audio_256.UI.Albums.Models;
using Audio_256.UI.Albums.Views;

namespace Audio_256.UI.Albums.Controllers
{
    internal class AlbumsViewController
    {
        private readonly AlbumsViewModel _model;
        private readonly AlbumsView _view;
        private readonly IMediator _mediator;

        public AlbumsViewController(
            AlbumsViewModel model,
            AlbumsView view,
            IMediator mediator)
        {
            _model = model;
            _view = view;
            _mediator = mediator;

            _mediator.Subscribe("ALBUM_SELECTED", OnArtistSelected);

            Initialize();
        }
        private void Initialize()
        {
            _view.ClearItems();

            foreach (var item in _model.AlbumThumbnails)
            {
                var itemView = new AlbumThumbnailView();
                var controller = new AlbumThumbnailController(item, itemView, _mediator);
                _view.AddItem(controller.GetView());
            }
        }
        private void OnArtistSelected(object? data)
        {
            foreach (var model in _model.AlbumThumbnails)
                model.IsSelected = false;

            if (data is AlbumThumbnailModel selected)
                selected.IsSelected = true;

            Initialize();
        }
    }
}