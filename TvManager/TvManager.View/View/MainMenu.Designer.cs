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
            this.HardEdit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.table_ads = new System.Windows.Forms.DataGridView();
            this.AdTableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdTableStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdTableDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableAdPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.show_table = new System.Windows.Forms.DataGridView();
            this.TableShowName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableShowStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableShowDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableShowPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete_all_shows = new System.Windows.Forms.Button();
            this.delete_show = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.buttonSave = new System.Windows.Forms.Button();
            this.result_table = new System.Windows.Forms.DataGridView();
            this.ResultName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableResultPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_ads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.result_table)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonViewAds
            // 
            this.buttonViewAds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonViewAds.Location = new System.Drawing.Point(319, 237);
            this.buttonViewAds.Name = "buttonViewAds";
            this.buttonViewAds.Size = new System.Drawing.Size(75, 23);
            this.buttonViewAds.TabIndex = 0;
            this.buttonViewAds.Text = "View Ads";
            this.buttonViewAds.UseVisualStyleBackColor = true;
            this.buttonViewAds.Click += new System.EventHandler(this.buttonViewAds_Click);
            // 
            // buttonAddAd
            // 
            this.buttonAddAd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddAd.Location = new System.Drawing.Point(319, 211);
            this.buttonAddAd.Name = "buttonAddAd";
            this.buttonAddAd.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAd.TabIndex = 1;
            this.buttonAddAd.Text = "Add Ad";
            this.buttonAddAd.UseVisualStyleBackColor = true;
            this.buttonAddAd.Click += new System.EventHandler(this.buttonAddAd_Click);
            // 
            // buttonAddShow
            // 
            this.buttonAddShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddShow.Location = new System.Drawing.Point(321, 211);
            this.buttonAddShow.Name = "buttonAddShow";
            this.buttonAddShow.Size = new System.Drawing.Size(81, 23);
            this.buttonAddShow.TabIndex = 2;
            this.buttonAddShow.Text = "Add Show";
            this.buttonAddShow.UseVisualStyleBackColor = true;
            this.buttonAddShow.Click += new System.EventHandler(this.buttonAddShow_Click);
            // 
            // buttonViewShows
            // 
            this.buttonViewShows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonViewShows.Location = new System.Drawing.Point(321, 237);
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
            // HardEdit
            // 
            this.HardEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HardEdit.Enabled = false;
            this.HardEdit.Location = new System.Drawing.Point(132, 3);
            this.HardEdit.Name = "HardEdit";
            this.HardEdit.Size = new System.Drawing.Size(101, 23);
            this.HardEdit.TabIndex = 8;
            this.HardEdit.Text = "Edit Schedule";
            this.HardEdit.UseVisualStyleBackColor = true;
            this.HardEdit.Click += new System.EventHandler(this.HardEdit_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(12, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Delete Ad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(12, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Delete All Ads";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.table_ads);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.buttonViewAds);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAddAd);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.show_table);
            this.splitContainer1.Panel2.Controls.Add(this.delete_all_shows);
            this.splitContainer1.Panel2.Controls.Add(this.delete_show);
            this.splitContainer1.Panel2.Controls.Add(this.buttonAddShow);
            this.splitContainer1.Panel2.Controls.Add(this.buttonViewShows);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(827, 263);
            this.splitContainer1.SplitterDistance = 407;
            this.splitContainer1.TabIndex = 11;
            // 
            // table_ads
            // 
            this.table_ads.AllowUserToAddRows = false;
            this.table_ads.AllowUserToDeleteRows = false;
            this.table_ads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_ads.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_ads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_ads.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdTableName,
            this.AdTableStartTime,
            this.AdTableDuration,
            this.TableAdPriority});
            this.table_ads.Location = new System.Drawing.Point(12, 12);
            this.table_ads.Name = "table_ads";
            this.table_ads.ReadOnly = true;
            this.table_ads.RowTemplate.Height = 25;
            this.table_ads.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_ads.Size = new System.Drawing.Size(382, 191);
            this.table_ads.TabIndex = 14;
            this.table_ads.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_ads_CellContentClick);
            this.table_ads.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.editAdRow);
            // 
            // AdTableName
            // 
            this.AdTableName.HeaderText = "Name";
            this.AdTableName.Name = "AdTableName";
            this.AdTableName.ReadOnly = true;
            // 
            // AdTableStartTime
            // 
            this.AdTableStartTime.HeaderText = "Start Time";
            this.AdTableStartTime.Name = "AdTableStartTime";
            this.AdTableStartTime.ReadOnly = true;
            // 
            // AdTableDuration
            // 
            this.AdTableDuration.HeaderText = "Duration";
            this.AdTableDuration.Name = "AdTableDuration";
            this.AdTableDuration.ReadOnly = true;
            // 
            // TableAdPriority
            // 
            this.TableAdPriority.HeaderText = "Priority";
            this.TableAdPriority.Name = "TableAdPriority";
            this.TableAdPriority.ReadOnly = true;
            // 
            // show_table
            // 
            this.show_table.AllowUserToAddRows = false;
            this.show_table.AllowUserToDeleteRows = false;
            this.show_table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.show_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.show_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.show_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableShowName,
            this.TableShowStartTime,
            this.TableShowDuration,
            this.TableShowPriority});
            this.show_table.Location = new System.Drawing.Point(18, 12);
            this.show_table.Name = "show_table";
            this.show_table.ReadOnly = true;
            this.show_table.RowTemplate.Height = 25;
            this.show_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.show_table.Size = new System.Drawing.Size(384, 191);
            this.show_table.TabIndex = 13;
            this.show_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.result_table_CellContentClick);
            this.show_table.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.editShowRow);
            // 
            // TableShowName
            // 
            this.TableShowName.HeaderText = "Name";
            this.TableShowName.Name = "TableShowName";
            this.TableShowName.ReadOnly = true;
            // 
            // TableShowStartTime
            // 
            this.TableShowStartTime.HeaderText = "Start Time";
            this.TableShowStartTime.Name = "TableShowStartTime";
            this.TableShowStartTime.ReadOnly = true;
            // 
            // TableShowDuration
            // 
            this.TableShowDuration.HeaderText = "Duration";
            this.TableShowDuration.Name = "TableShowDuration";
            this.TableShowDuration.ReadOnly = true;
            // 
            // TableShowPriority
            // 
            this.TableShowPriority.HeaderText = "Priority";
            this.TableShowPriority.Name = "TableShowPriority";
            this.TableShowPriority.ReadOnly = true;
            // 
            // delete_all_shows
            // 
            this.delete_all_shows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.delete_all_shows.Location = new System.Drawing.Point(18, 237);
            this.delete_all_shows.Name = "delete_all_shows";
            this.delete_all_shows.Size = new System.Drawing.Size(116, 23);
            this.delete_all_shows.TabIndex = 11;
            this.delete_all_shows.Text = "Delete All Shows";
            this.delete_all_shows.UseVisualStyleBackColor = true;
            this.delete_all_shows.Click += new System.EventHandler(this.delete_all_shows_Click);
            // 
            // delete_show
            // 
            this.delete_show.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.delete_show.Location = new System.Drawing.Point(18, 211);
            this.delete_show.Name = "delete_show";
            this.delete_show.Size = new System.Drawing.Size(87, 23);
            this.delete_show.TabIndex = 11;
            this.delete_show.Text = "Delete Show";
            this.delete_show.UseVisualStyleBackColor = true;
            this.delete_show.Click += new System.EventHandler(this.delete_show_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer2.Location = new System.Drawing.Point(12, 282);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.buttonGenerate);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.buttonSave);
            this.splitContainer2.Panel2.Controls.Add(this.HardEdit);
            this.splitContainer2.Size = new System.Drawing.Size(827, 29);
            this.splitContainer2.SplitterDistance = 576;
            this.splitContainer2.TabIndex = 12;
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(3, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(104, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save Schedule";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // result_table
            // 
            this.result_table.AllowDrop = true;
            this.result_table.AllowUserToAddRows = false;
            this.result_table.AllowUserToDeleteRows = false;
            this.result_table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.result_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.result_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ResultName,
            this.ResultStartTime,
            this.ResultDuration,
            this.TableResultPriority});
            this.result_table.Location = new System.Drawing.Point(24, 317);
            this.result_table.Name = "result_table";
            this.result_table.RowTemplate.Height = 25;
            this.result_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.result_table.Size = new System.Drawing.Size(801, 175);
            this.result_table.TabIndex = 14;
            this.result_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.result_table_CellContentClick_1);
            // 
            // ResultName
            // 
            this.ResultName.HeaderText = "Name";
            this.ResultName.Name = "ResultName";
            // 
            // ResultStartTime
            // 
            this.ResultStartTime.HeaderText = "Start Time";
            this.ResultStartTime.Name = "ResultStartTime";
            // 
            // ResultDuration
            // 
            this.ResultDuration.HeaderText = "Duration";
            this.ResultDuration.Name = "ResultDuration";
            // 
            // TableResultPriority
            // 
            this.TableResultPriority.HeaderText = "Priority";
            this.TableResultPriority.Name = "TableResultPriority";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 504);
            this.Controls.Add(this.result_table);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_ads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_table)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.result_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonViewAds;
        private System.Windows.Forms.Button buttonAddAd;
        private System.Windows.Forms.Button buttonAddShow;
        private System.Windows.Forms.Button buttonViewShows;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button HardEdit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button delete_all_shows;
        private System.Windows.Forms.Button delete_show;
        private System.Windows.Forms.DataGridView show_table;
        private System.Windows.Forms.DataGridView table_ads;
        private System.Windows.Forms.DataGridView result_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdTableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdTableStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdTableDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableAdPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableShowName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableShowStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableShowDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableShowPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableResultPriority;
    }
}