namespace Audio_256.UI.AlbumTracks.Views
{
    partial class AlbumTrackItemView
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
            trackNumber = new Label();
            trackTitle = new Label();
            artistTitle = new Label();
            addToLiked = new Label();
            duration = new Label();
            options = new Label();
            SuspendLayout();
            // 
            // trackNumber
            // 
            trackNumber.AutoSize = true;
            trackNumber.Location = new Point(3, 11);
            trackNumber.Name = "trackNumber";
            trackNumber.Size = new Size(13, 15);
            trackNumber.TabIndex = 0;
            trackNumber.Text = "1";
            // 
            // trackTitle
            // 
            trackTitle.AutoSize = true;
            trackTitle.Location = new Point(22, 0);
            trackTitle.Name = "trackTitle";
            trackTitle.Size = new Size(35, 15);
            trackTitle.TabIndex = 1;
            trackTitle.Text = "Track";
            // 
            // artistTitle
            // 
            artistTitle.AutoSize = true;
            artistTitle.Location = new Point(22, 20);
            artistTitle.Name = "artistTitle";
            artistTitle.Size = new Size(35, 15);
            artistTitle.TabIndex = 2;
            artistTitle.Text = "Artist";
            // 
            // addToLiked
            // 
            addToLiked.AutoSize = true;
            addToLiked.Location = new Point(128, 11);
            addToLiked.Name = "addToLiked";
            addToLiked.Size = new Size(15, 15);
            addToLiked.TabIndex = 3;
            addToLiked.Text = "+";
            // 
            // duration
            // 
            duration.AutoSize = true;
            duration.Location = new Point(165, 11);
            duration.Name = "duration";
            duration.Size = new Size(28, 15);
            duration.TabIndex = 4;
            duration.Text = "0:00";
            // 
            // options
            // 
            options.AutoSize = true;
            options.Location = new Point(212, 11);
            options.Name = "options";
            options.Size = new Size(16, 15);
            options.TabIndex = 5;
            options.Text = "...";
            // 
            // AlbumTrackItemView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(options);
            Controls.Add(duration);
            Controls.Add(addToLiked);
            Controls.Add(artistTitle);
            Controls.Add(trackTitle);
            Controls.Add(trackNumber);
            Name = "AlbumTrackItemView";
            Size = new Size(250, 44);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label trackNumber;
        private Label trackTitle;
        private Label artistTitle;
        private Label addToLiked;
        private Label duration;
        private Label options;
    }
}
