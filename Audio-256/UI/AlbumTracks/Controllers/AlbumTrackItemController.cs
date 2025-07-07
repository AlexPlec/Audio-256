using Audio_256.Core;
using Audio_256.UI.AlbumTracks.Models;
using Audio_256.UI.AlbumTracks.Views;

namespace Audio_256.UI.AlbumTracks.Controllers
{
    internal class AlbumTrackItemController
    {
        private readonly AlbumTrackItemModel _model;
        private readonly AlbumTrackItemView _view;
        private readonly IMediator _mediator;

        public AlbumTrackItemController(
            AlbumTrackItemModel model,
            AlbumTrackItemView view,
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
            _mediator.Publish("ALBUMTRACK_SELECTED", _model);
        }
        public AlbumTrackItemView GetView() => _view;
    }
}