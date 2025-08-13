namespace Softwarehouse_DBMS
{
    partial class InfoTasks
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
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            rtbDescription = new RichTextBox();
            btnBack = new Button();
            lblTitle = new Label();
            chkDarkMode = new CheckBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // rtbDescription
            // 
            rtbDescription.BackColor = Color.FromArgb(227, 234, 242);
            rtbDescription.Location = new Point(8, 63);
            rtbDescription.Margin = new Padding(2);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.ReadOnly = true;
            rtbDescription.Size = new Size(566, 281);
            rtbDescription.TabIndex = 5;
            rtbDescription.Text = "";
            rtbDescription.TextChanged += rtbDescription_TextChanged;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(14, 14);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(78, 20);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(139, 14);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(265, 30);
            lblTitle.TabIndex = 3;
            lblTitle.Text = " Task Page - Information";
            // 
            // chkDarkMode
            // 
            chkDarkMode.AutoSize = true;
            chkDarkMode.ForeColor = Color.White;
            chkDarkMode.Location = new Point(473, 8);
            chkDarkMode.Name = "chkDarkMode";
            chkDarkMode.Size = new Size(84, 19);
            chkDarkMode.TabIndex = 146;
            chkDarkMode.Text = "Dark Mode";
            chkDarkMode.UseVisualStyleBackColor = true;
            chkDarkMode.CheckedChanged += chkdarkMode_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 47, 82);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(chkDarkMode);
            panel1.Controls.Add(btnBack);
            panel1.Location = new Point(8, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(568, 57);
            panel1.TabIndex = 149;
            // 
            // InfoTasks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 349);
            Controls.Add(panel1);
            Controls.Add(rtbDescription);
            Margin = new Padding(2);
            Name = "InfoTasks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InfoTasks";
            Load += InfoTasks_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private CheckBox chkDarkMode;
        private Panel panel1;
    }
}
