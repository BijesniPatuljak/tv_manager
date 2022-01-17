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
            this.SuspendLayout();
            // 
            // buttonViewAds
            // 
            this.buttonViewAds.Location = new System.Drawing.Point(12, 26);
            this.buttonViewAds.Name = "buttonViewAds";
            this.buttonViewAds.Size = new System.Drawing.Size(75, 23);
            this.buttonViewAds.TabIndex = 0;
            this.buttonViewAds.Text = "View Ads";
            this.buttonViewAds.UseVisualStyleBackColor = true;
            this.buttonViewAds.Click += new System.EventHandler(this.buttonViewAds_Click);
            // 
            // buttonAddAd
            // 
            this.buttonAddAd.Location = new System.Drawing.Point(12, 69);
            this.buttonAddAd.Name = "buttonAddAd";
            this.buttonAddAd.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAd.TabIndex = 1;
            this.buttonAddAd.Text = "Add Ad";
            this.buttonAddAd.UseVisualStyleBackColor = true;
            this.buttonAddAd.Click += new System.EventHandler(this.buttonAddAd_Click);
            // 
            // buttonAddShow
            // 
            this.buttonAddShow.Location = new System.Drawing.Point(122, 69);
            this.buttonAddShow.Name = "buttonAddShow";
            this.buttonAddShow.Size = new System.Drawing.Size(81, 23);
            this.buttonAddShow.TabIndex = 2;
            this.buttonAddShow.Text = "Add Show";
            this.buttonAddShow.UseVisualStyleBackColor = true;
            this.buttonAddShow.Click += new System.EventHandler(this.buttonAddShow_Click);
            // 
            // buttonViewShows
            // 
            this.buttonViewShows.Location = new System.Drawing.Point(122, 26);
            this.buttonViewShows.Name = "buttonViewShows";
            this.buttonViewShows.Size = new System.Drawing.Size(81, 23);
            this.buttonViewShows.TabIndex = 3;
            this.buttonViewShows.Text = "View Shows";
            this.buttonViewShows.UseVisualStyleBackColor = true;
            this.buttonViewShows.Click += new System.EventHandler(this.buttonViewShows_Click);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(12, 126);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(191, 23);
            this.buttonGenerate.TabIndex = 4;
            this.buttonGenerate.Text = "Generate Schedule";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 179);
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
    }
}