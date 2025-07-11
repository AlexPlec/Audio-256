﻿namespace Audio_256
{
    partial class MainFormView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            artistsView = new Audio_256.UI.Artists.Views.ArtistsView();
            albumsView = new Audio_256.UI.Albums.Views.AlbumsView();
            artistAlbumsView = new Audio_256.UI.ArtistAlbums.Views.ArtistAlbumsView();
            albumTracksView = new Audio_256.UI.AlbumTracks.Views.AlbumTracksView();
            SuspendLayout();
            // 
            // artistsView
            // 
            artistsView.Location = new Point(12, 12);
            artistsView.Name = "artistsView";
            artistsView.Size = new Size(144, 144);
            artistsView.TabIndex = 0;
            // 
            // albumsView
            // 
            albumsView.Location = new Point(162, 12);
            albumsView.Name = "albumsView";
            albumsView.Size = new Size(150, 150);
            albumsView.TabIndex = 1;
            // 
            // artistAlbumsView
            // 
            artistAlbumsView.Location = new Point(318, 12);
            artistAlbumsView.Name = "artistAlbumsView";
            artistAlbumsView.Size = new Size(150, 150);
            artistAlbumsView.TabIndex = 2;
            // 
            // albumTracksView
            // 
            albumTracksView.Location = new Point(318, 6);
            albumTracksView.Name = "albumTracksView";
            albumTracksView.Size = new Size(315, 218);
            albumTracksView.TabIndex = 3;
            // 
            // MainFormView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(albumTracksView);
            Controls.Add(artistAlbumsView);
            Controls.Add(albumsView);
            Controls.Add(artistsView);
            Name = "MainFormView";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private UI.Artists.Views.ArtistsView artistsView;
        private UI.Albums.Views.AlbumsView albumsView;
        private UI.ArtistAlbums.Views.ArtistAlbumsView artistAlbumsView;
        private UI.AlbumTracks.Views.AlbumTracksView albumTracksView;
    }
}
