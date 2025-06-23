namespace Audio_256
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
            SuspendLayout();
            // 
            // artistsView
            // 
            artistsView.Location = new Point(12, 12);
            artistsView.Name = "artistsView";
            artistsView.Size = new Size(144, 144);
            artistsView.TabIndex = 0;
            // 
            // MainFormView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(artistsView);
            Name = "MainFormView";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private UI.Artists.Views.ArtistsView artistsView;
    }
}
