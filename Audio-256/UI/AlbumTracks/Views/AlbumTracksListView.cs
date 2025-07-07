namespace Audio_256.UI.AlbumTracks.Views
{
    public partial class AlbumTracksListView : UserControl
    {
        public AlbumTracksListView()
        {
            InitializeComponent();
        }
        public void AddItem(UserControl item)
        {
            flowLayoutPanel.Controls.Add(item);
        }
        public void ClearItems()
        {
            flowLayoutPanel.Controls.Clear();
        }
    }
}
