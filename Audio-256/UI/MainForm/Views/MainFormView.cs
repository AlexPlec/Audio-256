using Audio_256.App;
using Audio_256.Core;
using Audio_256.UI.Albums.Views;
using Audio_256.UI.ArtistAlbums.Views;
using Audio_256.UI.Artists.Views;
using Audio_256.UI.MainForm.Controllers;
using Audio_256.UI.MainForm.Models;
using Audio_256.UI.Shared.SystemTrayIcon.Controllers;
using Audio_256.UI.Shared.SystemTrayIcon.Models;
using Audio_256.UI.Shared.SystemTrayIcon.Views;

namespace Audio_256
{
    public partial class MainFormView : Form
    {
        private readonly MainFormController? _controller;
        private readonly MusicLibrary _library;
        private SystemTrayIconController? _trayController;
        public ArtistsView ArtistView => artistsView;
        public AlbumsView AlbumsView => albumsView;
        public ArtistAlbumsView ArtistAlbumsView => artistAlbumsView;
        public event EventHandler? OnDoubleClick;
        public MainFormView()
        {
            InitializeComponent();

            var model = new MainFormModel();
            _library = new MusicLibrary();
            var loader = new LibraryLoader(_library);
            loader.MusicInitialization();
            _controller = new MainFormController(model, this, AppInitializer.Mediator, _library);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var trayModel = new SystemTrayIconModel();
            var trayView = new SystemTrayIconView(trayModel);
            _trayController = new SystemTrayIconController(trayModel, trayView);
            trayView.OnDoubleClick += (s, e) =>
            {
                Show();
                WindowState = FormWindowState.Normal;
            };
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Cancel close and hide instead (unless exiting from tray)
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }

            base.OnFormClosing(e);
        }
    }
}
