using Audio_256.Core;
using Audio_256.UI.AlbumTracks.Controllers;
using Audio_256.UI.AlbumTracks.Models;
using Audio_256.UI.AlbumTracks.Views;

internal class AlbumTracksListController
{
    private readonly AlbumTracksListModel _model;
    private readonly AlbumTracksListView _view;
    private readonly IMediator _mediator;

    public AlbumTracksListController(
        AlbumTracksListModel model,
        AlbumTracksListView view,
        IMediator mediator)
    {
        _model = model;
        _view = view;
        _mediator = mediator;

        _mediator.Subscribe("ALBUMTRACK_SELECTED", OnTrackSelected);

        Refresh();
    }

    public void Refresh()
    {
        _view.ClearItems();

        foreach (var item in _model.AlbumTrackItemModels)
        {
            var itemView = new AlbumTrackItemView();
            var controller = new AlbumTrackItemController(item, itemView, _mediator);
            _view.AddItem(controller.GetView());
        }
    }

    private void OnTrackSelected(object? data)
    {
        foreach (var model in _model.AlbumTrackItemModels)
            model.IsSelected = false;

        if (data is AlbumTrackItemModel selected)
            selected.IsSelected = true;

        Refresh();
    }
}
