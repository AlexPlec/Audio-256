using Audio_256.Core;
using Audio_256.UI.Albums.Controllers;
using Audio_256.UI.Albums.Models;
using Audio_256.UI.Artists.Controllers;
using Audio_256.UI.Artists.Models;
using Audio_256.UI.MainForm.Models;

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

        public MainFormController(MainFormModel model, MainFormView view, IMediator mediator, MusicLibrary library)
        {
            _model = model;
            _view = view;
            _mediator = mediator;
            _library = library;
            Initialize();
        }

        private void Initialize()
        {
            var artistModel = new ArtistsViewModel();
            var albumModel = new AlbumsViewModel();

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
                string albumName = album.Title;
                string coverPath = album.CoverPath ?? "default.jpg"; // fallback image
                int trackCount = album.Tracks.Count;

                var albumThumb = new AlbumThumbnailModel(
                    albumId,
                    albumName,
                    coverPath,
                    trackCount
                );

                albumModel.AlbumThumbnails.Add(albumThumb);
            }

            _albumsController = new AlbumsViewController(albumModel, _view.AlbumsView, _mediator);
            _artistsController = new ArtistsViewController(artistModel, _view.ArtistView, _mediator);
        }

    }
}
