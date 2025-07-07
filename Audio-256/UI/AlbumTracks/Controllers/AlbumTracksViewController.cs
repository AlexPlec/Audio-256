using Audio_256.Core;
using Audio_256.UI.Albums.Models;
using Audio_256.UI.AlbumTracks.Controllers;
using Audio_256.UI.AlbumTracks.Models;
using Audio_256.UI.AlbumTracks.Views;

internal class AlbumTracksViewController
{
    private readonly AlbumTracksViewModel _model;
    private readonly AlbumTracksView _view;
    private readonly IMediator _mediator;
    private readonly MusicLibrary _library;
    private readonly AlbumTracksListController _listController;
    private AlbumTracksHeaderController _headerController;

    public AlbumTracksViewController(
        AlbumTracksViewModel model,
        AlbumTracksView view,
        IMediator mediator,
        MusicLibrary library)
    {
        _model = model;
        _view = view;
        _mediator = mediator;
        _library = library;

        // Initialize list controller with model and nested view
        _listController = new AlbumTracksListController(model.ListModel, _view.AlbumTracksListView, mediator);
        _mediator.Subscribe("ALBUM_SELECTED", OnAlbumSelected);
    }

    private void OnAlbumSelected(object? data)
    {
        if (data is not AlbumThumbnailModel albumModel)
            return;

        string albumName = albumModel.AlbumTitle;
        string artistName = albumModel.ArtistTitle;
        string imagePath = albumModel.ImagePath ?? "default_album.jpg";

        var tracks = _library.GetTracks(artistName, albumName).ToList();
        _model.AlbumTrackItemModels.Clear();

        int trackNumber = 1;
        int totalDuration = 0;

        foreach (var track in tracks)
        {
            totalDuration += (int)track.Duration.TotalSeconds;

            var model = new AlbumTrackItemModel(
                Guid.NewGuid().ToString(),
                trackNumber++,
                track.Title,
                artistName,
                (int)track.Duration.TotalSeconds
            )
            {
                IsSelected = false
            };

            _model.AlbumTrackItemModels.Add(model);
        }
        // Update the header view with real album data
        var headerModel = new AlbumTracksHeaderModel(
            albumModel.Id,
            imagePath,
            albumModel.AlbumTitle,
            albumModel.ArtistTitle,
            albumModel.Year.ToString(),
            tracks.Count,
            TimeSpan.FromSeconds(totalDuration)
          );

        _headerController = new AlbumTracksHeaderController(headerModel, _view.AlbumTracksHeaderView);

        _listController.Refresh(); // Update track list
    }

}
