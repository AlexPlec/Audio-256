namespace Audio_256.UI.AlbumTracks.Views
{
    partial class AlbumTracksView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            albumTracksHeaderView = new AlbumTracksHeaderView();
            albumTracksListView = new AlbumTracksListView();
            SuspendLayout();
            // 
            // albumTracksHeaderView
            // 
            albumTracksHeaderView.Location = new Point(0, 0);
            albumTracksHeaderView.Name = "albumTracksHeaderView";
            albumTracksHeaderView.Size = new Size(278, 100);
            albumTracksHeaderView.TabIndex = 0;
            // 
            // albumTracksListView
            // 
            albumTracksListView.Location = new Point(3, 106);
            albumTracksListView.Name = "albumTracksListView";
            albumTracksListView.Size = new Size(214, 163);
            albumTracksListView.TabIndex = 1;
            // 
            // AlbumTracksView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(albumTracksListView);
            Controls.Add(albumTracksHeaderView);
            Name = "AlbumTracksView";
            Size = new Size(346, 298);
            ResumeLayout(false);
        }

        #endregion

        private AlbumTracksHeaderView albumTracksHeaderView;
        private AlbumTracksListView albumTracksListView;
    }
}
