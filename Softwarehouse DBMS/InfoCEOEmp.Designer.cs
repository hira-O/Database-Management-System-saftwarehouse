namespace Softwarehouse_DBMS
{
    partial class InfoCEOEmp
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
            chkDarkMode = new CheckBox();
            panel1 = new Panel();
            label1 = new Label();
            btnBack = new Button();
            rtbDescription = new RichTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // chkDarkMode
            // 
            chkDarkMode.AutoSize = true;
            chkDarkMode.BackColor = Color.Transparent;
            chkDarkMode.ForeColor = Color.White;
            chkDarkMode.Location = new Point(481, 3);
            chkDarkMode.Name = "chkDarkMode";
            chkDarkMode.Size = new Size(84, 19);
            chkDarkMode.TabIndex = 149;
            chkDarkMode.Text = "Dark Mode";
            chkDarkMode.UseVisualStyleBackColor = false;
            chkDarkMode.CheckedChanged += chkDarkMode_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 47, 82);
            panel1.Controls.Add(chkDarkMode);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnBack);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(568, 57);
            panel1.TabIndex = 148;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(110, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(333, 28);
            label1.TabIndex = 0;
            label1.Text = "CEO Employee Page - Information";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(7, 19);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(91, 20);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click_1;
            // 
            // rtbDescription
            // 
            rtbDescription.BackColor = Color.FromArgb(227, 234, 242);
            rtbDescription.Location = new Point(8, 62);
            rtbDescription.Margin = new Padding(2);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(562, 359);
            rtbDescription.TabIndex = 147;
            rtbDescription.Text = "";
            rtbDescription.TextChanged += rtbDescription_TextChanged_1;
            // 
            // InfoCEOEmp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 424);
            Controls.Add(panel1);
            Controls.Add(rtbDescription);
            Margin = new Padding(2);
            Name = "InfoCEOEmp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InfoCEOEmp";
            Load += InfoCEOEmp_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox chkDarkMode;
        private Panel panel1;
        private Label label1;
        private Button btnBack;
        private RichTextBox rtbDescription;
    }
}