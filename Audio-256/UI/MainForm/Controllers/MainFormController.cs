using Audio_256.Core;
using Audio_256.UI.Albums.Controllers;
using Audio_256.UI.Albums.Models;
using Audio_256.UI.AlbumTracks.Models;
using Audio_256.UI.ArtistAlbums.Controllers;
using Audio_256.UI.ArtistAlbums.Models;
using Audio_256.UI.Artists.Controllers;
using Audio_256.UI.Artists.Models;
using Audio_256.UI.MainForm.Models;
using Audio_256.UI.Shared.SystemTrayIcon.Controllers;
using Audio_256.UI.Shared.SystemTrayIcon.Models;
using Audio_256.UI.Shared.SystemTrayIcon.Views;

namespace Audio_256.UI.MainForm.Controllers
{
    internal class MainFormController
    {
        private readonly MainFormModel _model;
        private readonly MainFormView _view;
        private readonly IMediator _mediator;
        private readonly MusicLibrary _library;

        private ArtistsViewController? _artistsController;
        private AlbumsViewController? _albumsController;
        private ArtistAlbumsViewController? _artistAlbumsController;
        private SystemTrayIconController? _trayController;
        private AlbumTracksViewController? _albumTracksController;

        public MainFormController(MainFormModel model, MainFormView view, IMediator mediator, MusicLibrary library)
        {
            _model = model;
            _view = view;
            _mediator = mediator;
            _library = library;
            Initialize();
            InitializeTrayIcon();
        }

        private void Initialize()
        {
            var artistModel = new ArtistsViewModel();
            var albumModel = new AlbumsViewModel();
            var artistAlbumsModel = new ArtistAlbumsViewModel();
            var albumTracksModel = new AlbumTracksViewModel();

            foreach (var artist in _library.GetArtists())
            {
                string artistId = Guid.NewGuid().ToString(); // or any unique ID
                string artistName = artist.Title;
                string coverPath = artist.CoverPath ?? "default.jpg"; // fallback image
                int albumCount = artist.Albums.Count;
                int trackCount = artist.Albums.Sum(a => a.Tracks.Count);

                var artistThumb = new ArtistThumbnailModel(
                    artistId,
                    artistName,
                    coverPath,
                    albumCount,
                    trackCount
                );

                artistModel.ArtistThumbnails.Add(artistThumb);
            }

            foreach (var album in _library.GetAllAlbums())
            {
                string albumId = Guid.NewGuid().ToString(); // or any unique ID
                string albumTitle = album.Title;
                string artistTitle = _library.Artists.FirstOrDefault(artist => artist.Albums.Contains(album))?.Title ?? "Unknown Artist";
                int albumYear = int.TryParse(album.Year, out var parsedYear) ? parsedYear : 0;
                int albumDuration = (int)album.Duration.TotalSeconds;
                string coverPath = album.CoverPath ?? "default.jpg"; // fallback image
                int trackCount = album.Tracks.Count;

                var albumThumb = new AlbumThumbnailModel(
                    albumId,
                    albumTitle,
                    artistTitle,
                    albumYear,
                    coverPath,
                    albumDuration,
                    trackCount
                );

                albumModel.AlbumThumbnails.Add(albumThumb);
            }

            _albumsController = new AlbumsViewController(albumModel, _view.AlbumsView, _mediator);
            _artistsController = new ArtistsViewController(artistModel, _view.ArtistView, _mediator);
            _artistAlbumsController = new ArtistAlbumsViewController(artistAlbumsModel, _view.ArtistAlbumsView, _mediator, _library);
            _albumTracksController = new AlbumTracksViewController(albumTracksModel, _view.AlbumTracksView, _mediator, _library);
        }
        private void InitializeTrayIcon()
        {
            var trayModel = new SystemTrayIconModel();
            var trayView = new SystemTrayIconView();
            _trayController = new SystemTrayIconController(trayModel, trayView, _view, _mediator);
        }
    }
}
