namespace Audio_256.UI.AlbumTracks.Views
{
    partial class AlbumTracksListView
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
            flowLayoutPanel = new FlowLayoutPanel();
            trackNumber = new Label();
            trackTitle = new Label();
            trackDuration = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel.Location = new Point(3, 18);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(200, 101);
            flowLayoutPanel.TabIndex = 0;
            flowLayoutPanel.WrapContents = false;
            // 
            // trackNumber
            // 
            trackNumber.AutoSize = true;
            trackNumber.Location = new Point(12, 0);
            trackNumber.Name = "trackNumber";
            trackNumber.Size = new Size(14, 15);
            trackNumber.TabIndex = 1;
            trackNumber.Text = "#";
            // 
            // trackTitle
            // 
            trackTitle.AutoSize = true;
            trackTitle.Location = new Point(78, 0);
            trackTitle.Name = "trackTitle";
            trackTitle.Size = new Size(30, 15);
            trackTitle.TabIndex = 2;
            trackTitle.Text = "Title";
            // 
            // trackDuration
            // 
            trackDuration.AutoSize = true;
            trackDuration.Location = new Point(150, 0);
            trackDuration.Name = "trackDuration";
            trackDuration.Size = new Size(53, 15);
            trackDuration.TabIndex = 3;
            trackDuration.Text = "Duration";
            // 
            // AlbumTracksListView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(trackDuration);
            Controls.Add(trackTitle);
            Controls.Add(trackNumber);
            Controls.Add(flowLayoutPanel);
            Name = "AlbumTracksListView";
            Size = new Size(207, 122);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel;
        private Label trackNumber;
        private Label trackTitle;
        private Label trackDuration;
    }
}
