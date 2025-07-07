using Audio_256.UI.AlbumTracks.Models;
using Audio_256.UI.AlbumTracks.Views;

namespace Audio_256.UI.AlbumTracks.Controllers
{
    internal class AlbumTracksHeaderController
    {
        private readonly AlbumTracksHeaderModel _model;
        private readonly AlbumTracksHeaderView _view;

        public AlbumTracksHeaderController(
            AlbumTracksHeaderModel model,
            AlbumTracksHeaderView view)
        {
            _model = model;
            _view = view;

            _view.SetData(_model);
        }
        public AlbumTracksHeaderView GetView() => _view;
    }
}
