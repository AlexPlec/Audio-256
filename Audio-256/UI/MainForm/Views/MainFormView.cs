using Audio_256.App;
using Audio_256.Core;
using Audio_256.UI.Albums.Views;
using Audio_256.UI.AlbumTracks.Views;
using Audio_256.UI.ArtistAlbums.Views;
using Audio_256.UI.Artists.Views;
using Audio_256.UI.MainForm.Controllers;
using Audio_256.UI.MainForm.Models;

namespace Audio_256
{
    public partial class MainFormView : Form
    {
        private readonly MainFormController? _controller;
        private readonly MusicLibrary _library;
        public ArtistsView ArtistView => artistsView;
        public AlbumsView AlbumsView => albumsView;
        public ArtistAlbumsView ArtistAlbumsView => artistAlbumsView;
        public AlbumTracksView AlbumTracksView => albumTracksView;
        public MainFormView()
        {
            InitializeComponent();

            var model = new MainFormModel();
            _library = new MusicLibrary();
            var loader = new LibraryLoader(_library);
            loader.MusicInitialization();
            _controller = new MainFormController(model, this, AppInitializer.Mediator, _library);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }

            base.OnFormClosing(e);
        }
    }
}
