using Audio_256.Core;
using Audio_256.UI.ArtistAlbums.Models;
using Audio_256.UI.ArtistAlbums.Views;

namespace Audio_256.UI.ArtistAlbums.Controllers
{
    internal class ArtistAlbumThumbnailController
    {
        private readonly ArtistAlbumThumbnailModel _model;
        private readonly ArtistAlbumThumbnailView _view;
        private readonly IMediator _mediator;
        public ArtistAlbumThumbnailController(
            ArtistAlbumThumbnailModel model,
            ArtistAlbumThumbnailView view,
            IMediator mediator)
        {
            _model = model;
            _view = view;
            _mediator = mediator;

            _view.SetData(_model);
            _view.OnClick += HandleClick;
        }
        private void HandleClick(object? sender, EventArgs e)
        {
            _mediator.Publish("ARTISTALBUM_SELECTED", _model);
        }
        public ArtistAlbumThumbnailView GetView() => _view;
    }
}
