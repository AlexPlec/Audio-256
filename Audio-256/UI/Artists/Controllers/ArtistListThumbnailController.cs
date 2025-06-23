using Audio_256.Core;
using Audio_256.UI.Artists.Models;
using Audio_256.UI.Artists.Views;

namespace Audio_256.UI.Artists.Controllers
{
    internal class ArtistListThumbnailController
    {
        private readonly ArtistListThumbnailModel _model;
        private readonly ArtistListThumbnailView _view;
        private readonly IMediator _mediator;
        public ArtistListThumbnailController(
            ArtistListThumbnailModel model,
            ArtistListThumbnailView view,
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
        public ArtistListThumbnailView GetView() => _view;
    }
}
