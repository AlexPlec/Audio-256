namespace Audio_256.UI.Artists.Views
{
    public partial class ArtistsView : UserControl
    {
        public ArtistsView()
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
