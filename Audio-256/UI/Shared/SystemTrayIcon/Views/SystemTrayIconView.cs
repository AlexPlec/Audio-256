namespace Audio_256.UI.Shared.SystemTrayIcon.Views
{
    internal class SystemTrayIconView
    {
        private readonly NotifyIcon _notifyIcon = new();
        private readonly ContextMenuStrip _contextMenu = new();

        public event EventHandler? OnExitClicked;
        public event EventHandler? OnDoubleClick;

        public SystemTrayIconView()
        {
            InitializeIcon();
        }
        private void InitializeIcon()
        {
            _notifyIcon.Icon = SystemIcons.Application;
            _notifyIcon.Text = "Audio-256";
            _notifyIcon.Visible = true;

            _notifyIcon.DoubleClick += (s, e) => OnDoubleClick?.Invoke(this, EventArgs.Empty);

            var exitItem = new ToolStripMenuItem("Exit");
            exitItem.Click += (s, e) => OnExitClicked?.Invoke(this, EventArgs.Empty);

            _contextMenu.Items.Add(exitItem);
            _notifyIcon.ContextMenuStrip = _contextMenu;
        }
    }
}
