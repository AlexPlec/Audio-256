using Audio_256.UI.Shared.SystemTrayIcon.Models;

namespace Audio_256.UI.Shared.SystemTrayIcon.Views
{
    internal class SystemTrayIconView : IDisposable
    {
        private readonly NotifyIcon _notifyIcon;
        private readonly SystemTrayIconModel _model;
        private readonly ContextMenuStrip _contextMenu;

        public event EventHandler? OnExitClicked;
        public event EventHandler? OnDoubleClick;

        public SystemTrayIconView(SystemTrayIconModel model)
        {
            _model = model;
            _notifyIcon = new NotifyIcon();
            _contextMenu = new ContextMenuStrip();

            InitializeIcon();
        }
        private void InitializeIcon()
        {
            _notifyIcon.Icon = SystemIcons.Application;
            _notifyIcon.Text = _model.TooltipText;
            _notifyIcon.Visible = _model.IsVisible;

            _notifyIcon.DoubleClick += (s, e) => OnDoubleClick?.Invoke(this, EventArgs.Empty);

            var exitItem = new ToolStripMenuItem("Exit");
            exitItem.Click += (s, e) => OnExitClicked?.Invoke(this, EventArgs.Empty);

            _contextMenu.Items.Add(exitItem);
            _notifyIcon.ContextMenuStrip = _contextMenu;
        }


        public void Dispose()
        {
            _notifyIcon.Dispose();
            _contextMenu.Dispose();
        }
    }
}
