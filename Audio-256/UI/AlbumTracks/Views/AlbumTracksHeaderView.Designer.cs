namespace Audio_256.UI.AlbumTracks.Views
{
    partial class AlbumTracksHeaderView
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
            pictureBox = new PictureBox();
            albumTitle = new Label();
            artistTitle = new Label();
            year = new Label();
            tracksCount = new Label();
            albumDuration = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(3, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(100, 50);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // albumTitle
            // 
            albumTitle.AutoSize = true;
            albumTitle.Location = new Point(109, 3);
            albumTitle.Name = "albumTitle";
            albumTitle.Size = new Size(43, 15);
            albumTitle.TabIndex = 1;
            albumTitle.Text = "Album";
            // 
            // artistTitle
            // 
            artistTitle.AutoSize = true;
            artistTitle.Location = new Point(109, 38);
            artistTitle.Name = "artistTitle";
            artistTitle.Size = new Size(35, 15);
            artistTitle.TabIndex = 2;
            artistTitle.Text = "Artist";
            // 
            // year
            // 
            year.AutoSize = true;
            year.Location = new Point(153, 38);
            year.Name = "year";
            year.Size = new Size(31, 15);
            year.TabIndex = 3;
            year.Text = "2000";
            // 
            // tracksCount
            // 
            tracksCount.AutoSize = true;
            tracksCount.Location = new Point(197, 38);
            tracksCount.Name = "tracksCount";
            tracksCount.Size = new Size(19, 15);
            tracksCount.TabIndex = 4;
            tracksCount.Text = "11";
            // 
            // albumDuration
            // 
            albumDuration.AutoSize = true;
            albumDuration.Location = new Point(241, 38);
            albumDuration.Name = "albumDuration";
            albumDuration.Size = new Size(34, 15);
            albumDuration.TabIndex = 5;
            albumDuration.Text = "20:40";
            // 
            // AlbumTracksHeaderView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(albumDuration);
            Controls.Add(tracksCount);
            Controls.Add(year);
            Controls.Add(artistTitle);
            Controls.Add(albumTitle);
            Controls.Add(pictureBox);
            Name = "AlbumTracksHeaderView";
            Size = new Size(294, 64);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private Label albumTitle;
        private Label artistTitle;
        private Label year;
        private Label tracksCount;
        private Label albumDuration;
    }
}
