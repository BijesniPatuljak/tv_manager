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
            this.SuspendLayout();
            // 
            // buttonViewAds
            // 
            this.buttonViewAds.Location = new System.Drawing.Point(12, 125);
            this.buttonViewAds.Name = "buttonViewAds";
            this.buttonViewAds.Size = new System.Drawing.Size(75, 23);
            this.buttonViewAds.TabIndex = 0;
            this.buttonViewAds.Text = "View Ads";
            this.buttonViewAds.UseVisualStyleBackColor = true;
            this.buttonViewAds.Click += new System.EventHandler(this.buttonViewAds_Click);
            // 
            // buttonAddAd
            // 
            this.buttonAddAd.Location = new System.Drawing.Point(193, 125);
            this.buttonAddAd.Name = "buttonAddAd";
            this.buttonAddAd.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAd.TabIndex = 1;
            this.buttonAddAd.Text = "Add Ad";
            this.buttonAddAd.UseVisualStyleBackColor = true;
            this.buttonAddAd.Click += new System.EventHandler(this.buttonAddAd_Click);
            // 
            // buttonAddShow
            // 
            this.buttonAddShow.Location = new System.Drawing.Point(484, 125);
            this.buttonAddShow.Name = "buttonAddShow";
            this.buttonAddShow.Size = new System.Drawing.Size(81, 23);
            this.buttonAddShow.TabIndex = 2;
            this.buttonAddShow.Text = "Add Show";
            this.buttonAddShow.UseVisualStyleBackColor = true;
            this.buttonAddShow.Click += new System.EventHandler(this.buttonAddShow_Click);
            // 
            // buttonViewShows
            // 
            this.buttonViewShows.Location = new System.Drawing.Point(304, 125);
            this.buttonViewShows.Name = "buttonViewShows";
            this.buttonViewShows.Size = new System.Drawing.Size(81, 23);
            this.buttonViewShows.TabIndex = 3;
            this.buttonViewShows.Text = "View Shows";
            this.buttonViewShows.UseVisualStyleBackColor = true;
            this.buttonViewShows.Click += new System.EventHandler(this.buttonViewShows_Click);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(193, 183);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(191, 23);
            this.buttonGenerate.TabIndex = 4;
            this.buttonGenerate.Text = "Generate Schedule";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // MainAds
            // 
            this.MainAds.FormattingEnabled = true;
            this.MainAds.ItemHeight = 15;
            this.MainAds.Location = new System.Drawing.Point(304, 25);
            this.MainAds.Name = "MainAds";
            this.MainAds.Size = new System.Drawing.Size(261, 94);
            this.MainAds.TabIndex = 5;
            this.MainAds.SelectedIndexChanged += new System.EventHandler(this.MainAds_SelectedIndexChanged);
            this.MainAds.DoubleClick += new System.EventHandler(this.MainAds_DoubleClick);
            // 
            // MainShows
            // 
            this.MainShows.FormattingEnabled = true;
            this.MainShows.ItemHeight = 15;
            this.MainShows.Location = new System.Drawing.Point(12, 25);
            this.MainShows.Name = "MainShows";
            this.MainShows.Size = new System.Drawing.Size(256, 94);
            this.MainShows.TabIndex = 6;
            this.MainShows.DoubleClick += new System.EventHandler(this.MainShows_DoubleClick);
            // 
            // MainSchedule
            // 
            this.MainSchedule.FormattingEnabled = true;
            this.MainSchedule.ItemHeight = 15;
            this.MainSchedule.Location = new System.Drawing.Point(12, 212);
            this.MainSchedule.Name = "MainSchedule";
            this.MainSchedule.Size = new System.Drawing.Size(553, 169);
            this.MainSchedule.TabIndex = 7;
            this.MainSchedule.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainSchedule_DragDrop);
            this.MainSchedule.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainSchedule_DragEnter);
            this.MainSchedule.DragLeave += new System.EventHandler(this.MainSchedule_DragLeave);
            this.MainSchedule.DoubleClick += new System.EventHandler(this.MainSchedule_DoubleClick);
            // 
            // HardEdit
            // 
            this.HardEdit.Location = new System.Drawing.Point(470, 183);
            this.HardEdit.Name = "HardEdit";
            this.HardEdit.Size = new System.Drawing.Size(95, 23);
            this.HardEdit.TabIndex = 8;
            this.HardEdit.Text = "Edit Schedule";
            this.HardEdit.UseVisualStyleBackColor = true;
            this.HardEdit.Click += new System.EventHandler(this.HardEdit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Delete Ad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Delete All Ads";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 408);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HardEdit);
            this.Controls.Add(this.MainSchedule);
            this.Controls.Add(this.MainShows);
            this.Controls.Add(this.MainAds);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.buttonViewShows);
            this.Controls.Add(this.buttonAddShow);
            this.Controls.Add(this.buttonAddAd);
            this.Controls.Add(this.buttonViewAds);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
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
    }
}