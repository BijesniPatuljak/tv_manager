namespace TvManager.View.View
{
    partial class ViewAds
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AddAd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(776, 259);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // AddAd
            // 
            this.AddAd.Location = new System.Drawing.Point(711, 277);
            this.AddAd.Name = "AddAd";
            this.AddAd.Size = new System.Drawing.Size(75, 23);
            this.AddAd.TabIndex = 2;
            this.AddAd.Text = "Add Ad";
            this.AddAd.UseVisualStyleBackColor = true;
            this.AddAd.Click += new System.EventHandler(this.AddAd_Click);
            // 
            // ViewAds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 308);
            this.Controls.Add(this.AddAd);
            this.Controls.Add(this.listBox1);
            this.Name = "ViewAds";
            this.Text = "ViewAds";
            this.Load += new System.EventHandler(this.ViewAds_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button AddAd;
    }
}