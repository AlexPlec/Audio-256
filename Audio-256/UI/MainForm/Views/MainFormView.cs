using Audio_256.UI.Artists.Views;
using Audio_256.UI.MainForm.Controllers;
using Audio_256.UI.MainForm.Models;

namespace Audio_256
{
    public partial class MainFormView : Form
    {
        private readonly MainFormController? _controller;
        public ArtistsView ArtistView => artistsView;
        public MainFormView()
        {
            InitializeComponent();

            var model = new MainFormModel();
            _controller = new MainFormController(model, this, AppInitializer.Mediator);
        }
    }
}
