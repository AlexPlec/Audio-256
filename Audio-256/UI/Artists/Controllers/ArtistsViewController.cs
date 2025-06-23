using Audio_256.Core;
using Audio_256.UI.Artists.Models;
using Audio_256.UI.Artists.Views;

namespace Audio_256.UI.Artists.Controllers
{
    internal class ArtistsViewController
    {
        private readonly ArtistsViewModel _model;
        private readonly ArtistsView _view;
        private readonly IMediator _mediator;
        public ArtistsViewController(
            ArtistsViewModel model,
            ArtistsView view,
            IMediator mediator)
        {
            _model = model;
            _view = view;
            _mediator = mediator;

            _mediator.Subscribe("ARTIST_SELECTED", OnArtistSelected);

            Initialize();
        }
        private void Initialize()
        {
            _view.ClearItems();

            foreach (var item in _model.ArtistThumbnails)
            {
                var itemView = new ArtistListThumbnailView();
                var controller = new ArtistListThumbnailController(item, itemView, _mediator);
                _view.AddItem(controller.GetView());
            }
        }
        private void OnArtistSelected(object? data)
        {
            foreach (var model in _model.ArtistThumbnails)
                model.IsSelected = false;

            if (data is ArtistListThumbnailModel selected)
                selected.IsSelected = true;

            Initialize(); // Refresh views
        }
    }
}
