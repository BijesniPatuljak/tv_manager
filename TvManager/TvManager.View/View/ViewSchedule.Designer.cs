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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Reklama1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Film", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 409);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // treeView1
            // 
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeView1.Location = new System.Drawing.Point(258, 21);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Reklama1";
            treeNode1.Text = "Reklama1";
            treeNode2.Name = "Film";
            treeNode2.Text = "Film";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 1;
            // 
            // ViewSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listBox1);
            this.Name = "ViewSchedule";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.ViewSchedule_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TreeView treeView1;
    }
}