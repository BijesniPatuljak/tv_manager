namespace TvManager.View.View
{
    partial class MainMenu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonViewAds = new System.Windows.Forms.Button();
            this.buttonAddAd = new System.Windows.Forms.Button();
            this.buttonAddShow = new System.Windows.Forms.Button();
            this.buttonViewShows = new System.Windows.Forms.Button();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.MainAds = new System.Windows.Forms.ListBox();
            this.MainShows = new System.Windows.Forms.ListBox();
            this.MainSchedule = new System.Windows.Forms.ListBox();
            this.HardEdit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.delete_show = new System.Windows.Forms.Button();
            this.delete_all_shows = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonViewAds
            // 
            this.buttonViewAds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonViewAds.Location = new System.Drawing.Point(188, 139);
            this.buttonViewAds.Name = "buttonViewAds";
            this.buttonViewAds.Size = new System.Drawing.Size(75, 23);
            this.buttonViewAds.TabIndex = 0;
            this.buttonViewAds.Text = "View Ads";
            this.buttonViewAds.UseVisualStyleBackColor = true;
            this.buttonViewAds.Click += new System.EventHandler(this.buttonViewAds_Click);
            // 
            // buttonAddAd
            // 
            this.buttonAddAd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddAd.Location = new System.Drawing.Point(188, 113);
            this.buttonAddAd.Name = "buttonAddAd";
            this.buttonAddAd.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAd.TabIndex = 1;
            this.buttonAddAd.Text = "Add Ad";
            this.buttonAddAd.UseVisualStyleBackColor = true;
            this.buttonAddAd.Click += new System.EventHandler(this.buttonAddAd_Click);
            // 
            // buttonAddShow
            // 
            this.buttonAddShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddShow.Location = new System.Drawing.Point(171, 113);
            this.buttonAddShow.Name = "buttonAddShow";
            this.buttonAddShow.Size = new System.Drawing.Size(81, 23);
            this.buttonAddShow.TabIndex = 2;
            this.buttonAddShow.Text = "Add Show";
            this.buttonAddShow.UseVisualStyleBackColor = true;
            this.buttonAddShow.Click += new System.EventHandler(this.buttonAddShow_Click);
            // 
            // buttonViewShows
            // 
            this.buttonViewShows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonViewShows.Location = new System.Drawing.Point(171, 139);
            this.buttonViewShows.Name = "buttonViewShows";
            this.buttonViewShows.Size = new System.Drawing.Size(81, 23);
            this.buttonViewShows.TabIndex = 3;
            this.buttonViewShows.Text = "View Shows";
            this.buttonViewShows.UseVisualStyleBackColor = true;
            this.buttonViewShows.Click += new System.EventHandler(this.buttonViewShows_Click);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(12, 3);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(135, 23);
            this.buttonGenerate.TabIndex = 4;
            this.buttonGenerate.Text = "Generate Schedule";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // MainAds
            // 
            this.MainAds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainAds.FormattingEnabled = true;
            this.MainAds.ItemHeight = 15;
            this.MainAds.Location = new System.Drawing.Point(12, 13);
            this.MainAds.Name = "MainAds";
            this.MainAds.Size = new System.Drawing.Size(251, 94);
            this.MainAds.TabIndex = 5;
            this.MainAds.SelectedIndexChanged += new System.EventHandler(this.MainAds_SelectedIndexChanged);
            this.MainAds.DoubleClick += new System.EventHandler(this.MainAds_DoubleClick);
            // 
            // MainShows
            // 
            this.MainShows.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainShows.FormattingEnabled = true;
            this.MainShows.ItemHeight = 15;
            this.MainShows.Location = new System.Drawing.Point(4, 13);
            this.MainShows.Name = "MainShows";
            this.MainShows.Size = new System.Drawing.Size(248, 94);
            this.MainShows.TabIndex = 6;
            this.MainShows.DoubleClick += new System.EventHandler(this.MainShows_DoubleClick);
            // 
            // MainSchedule
            // 
            this.MainSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainSchedule.FormattingEnabled = true;
            this.MainSchedule.ItemHeight = 15;
            this.MainSchedule.Location = new System.Drawing.Point(24, 227);
            this.MainSchedule.Name = "MainSchedule";
            this.MainSchedule.Size = new System.Drawing.Size(520, 259);
            this.MainSchedule.TabIndex = 7;
            this.MainSchedule.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainSchedule_DragDrop);
            this.MainSchedule.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainSchedule_DragEnter);
            this.MainSchedule.DragLeave += new System.EventHandler(this.MainSchedule_DragLeave);
            this.MainSchedule.DoubleClick += new System.EventHandler(this.MainSchedule_DoubleClick);
            // 
            // HardEdit
            // 
            this.HardEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HardEdit.Location = new System.Drawing.Point(46, 3);
            this.HardEdit.Name = "HardEdit";
            this.HardEdit.Size = new System.Drawing.Size(101, 23);
            this.HardEdit.TabIndex = 8;
            this.HardEdit.Text = "Edit Schedule";
            this.HardEdit.UseVisualStyleBackColor = true;
            this.HardEdit.Click += new System.EventHandler(this.HardEdit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Delete Ad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Delete All Ads";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.MainAds);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.buttonViewAds);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAddAd);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.delete_all_shows);
            this.splitContainer1.Panel2.Controls.Add(this.delete_show);
            this.splitContainer1.Panel2.Controls.Add(this.MainShows);
            this.splitContainer1.Panel2.Controls.Add(this.buttonAddShow);
            this.splitContainer1.Panel2.Controls.Add(this.buttonViewShows);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(546, 165);
            this.splitContainer1.SplitterDistance = 276;
            this.splitContainer1.TabIndex = 11;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer2.Location = new System.Drawing.Point(12, 194);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.buttonGenerate);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.HardEdit);
            this.splitContainer2.Size = new System.Drawing.Size(546, 29);
            this.splitContainer2.SplitterDistance = 381;
            this.splitContainer2.TabIndex = 12;
            // 
            // delete_show
            // 
            this.delete_show.Location = new System.Drawing.Point(4, 113);
            this.delete_show.Name = "delete_show";
            this.delete_show.Size = new System.Drawing.Size(87, 23);
            this.delete_show.TabIndex = 11;
            this.delete_show.Text = "Delete Show";
            this.delete_show.UseVisualStyleBackColor = true;
            this.delete_show.Click += new System.EventHandler(this.delete_show_Click);
            // 
            // delete_all_shows
            // 
            this.delete_all_shows.Location = new System.Drawing.Point(4, 139);
            this.delete_all_shows.Name = "delete_all_shows";
            this.delete_all_shows.Size = new System.Drawing.Size(116, 23);
            this.delete_all_shows.TabIndex = 11;
            this.delete_all_shows.Text = "Delete All Shows";
            this.delete_all_shows.UseVisualStyleBackColor = true;
            this.delete_all_shows.Click += new System.EventHandler(this.delete_all_shows_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 505);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.MainSchedule);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonViewAds;
        private System.Windows.Forms.Button buttonAddAd;
        private System.Windows.Forms.Button buttonAddShow;
        private System.Windows.Forms.Button buttonViewShows;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.ListBox MainAds;
        private System.Windows.Forms.ListBox MainShows;
        private System.Windows.Forms.ListBox MainSchedule;
        private System.Windows.Forms.Button HardEdit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button delete_all_shows;
        private System.Windows.Forms.Button delete_show;
    }
}