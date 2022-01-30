namespace TvManager.View.View
{
    partial class EditShow
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
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_timeslot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.priorities = new System.Windows.Forms.GroupBox();
            this.radio7 = new System.Windows.Forms.RadioButton();
            this.radio9 = new System.Windows.Forms.RadioButton();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.radio8 = new System.Windows.Forms.RadioButton();
            this.radio4 = new System.Windows.Forms.RadioButton();
            this.radio6 = new System.Windows.Forms.RadioButton();
            this.radio5 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox_duration = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.priorities.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(339, 81);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(114, 23);
            this.textBox_id.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "Show ID";
            // 
            // textBox_timeslot
            // 
            this.textBox_timeslot.Location = new System.Drawing.Point(339, 139);
            this.textBox_timeslot.Name = "textBox_timeslot";
            this.textBox_timeslot.Size = new System.Drawing.Size(114, 23);
            this.textBox_timeslot.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Preffered time slot";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(339, 110);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(114, 23);
            this.textBox_name.TabIndex = 21;
            // 
            // priorities
            // 
            this.priorities.Controls.Add(this.radio7);
            this.priorities.Controls.Add(this.radio9);
            this.priorities.Controls.Add(this.radio3);
            this.priorities.Controls.Add(this.radio8);
            this.priorities.Controls.Add(this.radio4);
            this.priorities.Controls.Add(this.radio6);
            this.priorities.Controls.Add(this.radio5);
            this.priorities.Location = new System.Drawing.Point(19, 13);
            this.priorities.Name = "priorities";
            this.priorities.Size = new System.Drawing.Size(200, 225);
            this.priorities.TabIndex = 20;
            this.priorities.TabStop = false;
            this.priorities.Text = "Priority";
            this.priorities.Enter += new System.EventHandler(this.priorities_Enter);
            // 
            // radio7
            // 
            this.radio7.AutoSize = true;
            this.radio7.Location = new System.Drawing.Point(22, 76);
            this.radio7.Name = "radio7";
            this.radio7.Size = new System.Drawing.Size(31, 19);
            this.radio7.TabIndex = 4;
            this.radio7.TabStop = true;
            this.radio7.Text = "7";
            this.radio7.UseVisualStyleBackColor = true;
            // 
            // radio9
            // 
            this.radio9.AutoSize = true;
            this.radio9.Location = new System.Drawing.Point(22, 26);
            this.radio9.Name = "radio9";
            this.radio9.Size = new System.Drawing.Size(31, 19);
            this.radio9.TabIndex = 2;
            this.radio9.TabStop = true;
            this.radio9.Text = "9";
            this.radio9.UseVisualStyleBackColor = true;
            this.radio9.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Location = new System.Drawing.Point(22, 176);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(31, 19);
            this.radio3.TabIndex = 8;
            this.radio3.TabStop = true;
            this.radio3.Text = "3";
            this.radio3.UseVisualStyleBackColor = true;
            // 
            // radio8
            // 
            this.radio8.AutoSize = true;
            this.radio8.Location = new System.Drawing.Point(22, 51);
            this.radio8.Name = "radio8";
            this.radio8.Size = new System.Drawing.Size(31, 19);
            this.radio8.TabIndex = 3;
            this.radio8.TabStop = true;
            this.radio8.Text = "8";
            this.radio8.UseVisualStyleBackColor = true;
            // 
            // radio4
            // 
            this.radio4.AutoSize = true;
            this.radio4.Location = new System.Drawing.Point(22, 151);
            this.radio4.Name = "radio4";
            this.radio4.Size = new System.Drawing.Size(31, 19);
            this.radio4.TabIndex = 7;
            this.radio4.TabStop = true;
            this.radio4.Text = "4";
            this.radio4.UseVisualStyleBackColor = true;
            // 
            // radio6
            // 
            this.radio6.AutoSize = true;
            this.radio6.Location = new System.Drawing.Point(22, 101);
            this.radio6.Name = "radio6";
            this.radio6.Size = new System.Drawing.Size(31, 19);
            this.radio6.TabIndex = 5;
            this.radio6.TabStop = true;
            this.radio6.Text = "6";
            this.radio6.UseVisualStyleBackColor = true;
            // 
            // radio5
            // 
            this.radio5.AutoSize = true;
            this.radio5.Location = new System.Drawing.Point(22, 126);
            this.radio5.Name = "radio5";
            this.radio5.Size = new System.Drawing.Size(31, 19);
            this.radio5.TabIndex = 6;
            this.radio5.TabStop = true;
            this.radio5.Text = "5";
            this.radio5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Apply and Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Show name";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(339, 56);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 19);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "New ID";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox_duration
            // 
            this.textBox_duration.Location = new System.Drawing.Point(339, 168);
            this.textBox_duration.Name = "textBox_duration";
            this.textBox_duration.Size = new System.Drawing.Size(114, 23);
            this.textBox_duration.TabIndex = 29;
            this.textBox_duration.TextChanged += new System.EventHandler(this.textBox_duration_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Duration";
            // 
            // EditShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 265);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_duration);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_timeslot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.priorities);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "EditShow";
            this.Text = "EditShow";
            this.Load += new System.EventHandler(this.EditShow_Load);
            this.priorities.ResumeLayout(false);
            this.priorities.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_timeslot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.GroupBox priorities;
        private System.Windows.Forms.RadioButton radio7;
        private System.Windows.Forms.RadioButton radio9;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.RadioButton radio8;
        private System.Windows.Forms.RadioButton radio4;
        private System.Windows.Forms.RadioButton radio6;
        private System.Windows.Forms.RadioButton radio5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox_duration;
        private System.Windows.Forms.Label label3;
    }
}