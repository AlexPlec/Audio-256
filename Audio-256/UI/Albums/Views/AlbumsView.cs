namespace Audio_256.UI.Albums.Views
{
    public partial class AlbumsView : UserControl
    {
        public AlbumsView()
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
