using Audio_256.Core;
using Audio_256.UI.Artists.Models;
using Audio_256.UI.Artists.Views;

namespace Audio_256.UI.Artists.Controllers
{
    internal class ArtistThumbnailController
    {
        private readonly ArtistThumbnailModel _model;
        private readonly ArtistThumbnailView _view;
        private readonly IMediator _mediator;
        public ArtistThumbnailController(
            ArtistThumbnailModel model,
            ArtistThumbnailView view,
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
            _mediator.Publish("ARTIST_SELECTED", _model);
        }
        public ArtistThumbnailView GetView() => _view;
    }
}
