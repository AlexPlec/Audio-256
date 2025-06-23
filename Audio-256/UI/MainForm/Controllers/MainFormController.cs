using Audio_256.Core;
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

        private ArtistsViewController? _artistsController;

        public MainFormController(MainFormModel model, MainFormView view, IMediator mediator)
        {
            _model = model;
            _view = view;
            _mediator = mediator;

            Initialize();
        }

        private void Initialize()
        {
            var artistModel = new ArtistsViewModel();
            artistModel.ArtistThumbnails.Add(new ArtistListThumbnailModel("1", "Radiohead", "radiohead.jpg", 5, 42));
            artistModel.ArtistThumbnails.Add(new ArtistListThumbnailModel("2", "Daft Punk", "daftpunk.jpg", 3, 28));
            artistModel.ArtistThumbnails.Add(new ArtistListThumbnailModel("1", "Radiohead", "radiohead.jpg", 5, 42));
            artistModel.ArtistThumbnails.Add(new ArtistListThumbnailModel("2", "Daft Punk", "daftpunk.jpg", 3, 28));
            artistModel.ArtistThumbnails.Add(new ArtistListThumbnailModel("1", "Radiohead", "radiohead.jpg", 5, 42));
            artistModel.ArtistThumbnails.Add(new ArtistListThumbnailModel("2", "Daft Punk", "daftpunk.jpg", 3, 28));
            artistModel.ArtistThumbnails.Add(new ArtistListThumbnailModel("1", "Radiohead", "radiohead.jpg", 5, 42));
            artistModel.ArtistThumbnails.Add(new ArtistListThumbnailModel("2", "Daft Punk", "daftpunk.jpg", 3, 28));

            _artistsController = new ArtistsViewController(artistModel, _view.ArtistView, _mediator);
        }
    }
}
