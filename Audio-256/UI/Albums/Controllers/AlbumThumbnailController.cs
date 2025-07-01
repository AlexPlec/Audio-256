using Audio_256.Core;
using Audio_256.UI.Albums.Models;
using Audio_256.UI.Albums.Views;

namespace Audio_256.UI.Albums.Controllers
{
    internal class AlbumThumbnailController
    {

        private readonly AlbumThumbnailModel _model;
        private readonly AlbumThumbnailView _view;
        private readonly IMediator _mediator;
        public AlbumThumbnailController(
            AlbumThumbnailModel model,
            AlbumThumbnailView view,
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
            _mediator.Publish("ALBUM_SELECTED", _model);
        }
        public AlbumThumbnailView GetView() => _view;
    }
}