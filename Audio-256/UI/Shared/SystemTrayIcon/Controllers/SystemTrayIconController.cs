using Audio_256.UI.Shared.SystemTrayIcon.Models;
using Audio_256.UI.Shared.SystemTrayIcon.Views;

namespace Audio_256.UI.Shared.SystemTrayIcon.Controllers
{
    internal class SystemTrayIconController
    {
        private readonly SystemTrayIconModel _model;
        private readonly SystemTrayIconView _view;

        public SystemTrayIconController(SystemTrayIconModel model, SystemTrayIconView view)
        {
            _model = model;
            _view = view;

            _view.OnExitClicked += HandleExitClicked;
        }

        private void HandleExitClicked(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
