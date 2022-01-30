namespace TvManager.View.View
{
    partial class ViewSchedule
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
            this.button1 = new System.Windows.Forms.Button();
            this.result_table = new System.Windows.Forms.DataGridView();
            this.ResultName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.result_table)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(632, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // result_table
            // 
            this.result_table.AllowDrop = true;
            this.result_table.AllowUserToOrderColumns = true;
            this.result_table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.result_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.result_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ResultName,
            this.ResultStartTime,
            this.ResultDuration});
            this.result_table.Location = new System.Drawing.Point(12, 12);
            this.result_table.Name = "result_table";
            this.result_table.RowTemplate.Height = 25;
            this.result_table.Size = new System.Drawing.Size(695, 411);
            this.result_table.TabIndex = 15;
            this.result_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.result_table_CellContentClick);
            // 
            // ResultName
            // 
            this.ResultName.HeaderText = "Name";
            this.ResultName.Name = "ResultName";
            this.ResultName.ReadOnly = true;
            // 
            // ResultStartTime
            // 
            this.ResultStartTime.HeaderText = "Start Time";
            this.ResultStartTime.Name = "ResultStartTime";
            this.ResultStartTime.ReadOnly = true;
            // 
            // ResultDuration
            // 
            this.ResultDuration.HeaderText = "Duration";
            this.ResultDuration.Name = "ResultDuration";
            this.ResultDuration.ReadOnly = true;
            // 
            // ViewSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 458);
            this.Controls.Add(this.result_table);
            this.Controls.Add(this.button1);
            this.Name = "ViewSchedule";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.ViewSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.result_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView result_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultDuration;
    }
}