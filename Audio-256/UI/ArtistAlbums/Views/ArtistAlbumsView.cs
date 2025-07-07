namespace Audio_256.UI.ArtistAlbums.Views
{
    public partial class ArtistAlbumsView : UserControl
    {
        public ArtistAlbumsView()
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
