using Audio_256.Core;
using Audio_256.UI.Shared.SystemTrayIcon.Models;
using Audio_256.UI.Shared.SystemTrayIcon.Views;

namespace Audio_256.UI.Shared.SystemTrayIcon.Controllers
{
    internal class SystemTrayIconController
    {
        private readonly SystemTrayIconModel _model;
        private readonly SystemTrayIconView _view;
        private readonly Form _mainForm;
        private readonly IMediator _mediator;

        public SystemTrayIconController(SystemTrayIconModel model, SystemTrayIconView view, Form mainForm, IMediator mediator)
        {
            _model = model;
            _view = view;
            _mainForm = mainForm;
            _mediator = mediator;

            _view.OnExitClicked += HandleExitClicked;
            _view.OnDoubleClick += HandleTrayDoubleClick;
        }
        private void HandleExitClicked(object? sender, EventArgs e)
        {
            Application.Exit();
        }
        private void HandleTrayDoubleClick(object? sender, EventArgs e)
        {
            _mainForm.Invoke(() =>
            {
                if (_mainForm.Visible)
                {
                    _mainForm.Hide();
                }
                else
                {
                    _mainForm.Show();
                    _mainForm.WindowState = FormWindowState.Normal;
                    _mainForm.BringToFront();
                }
            });
        }

    }
}
