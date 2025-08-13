namespace Softwarehouse_DBMS
{
    partial class InfoEmployees
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
            lblTitle = new Label();
            btnBack = new Button();
            rtbDescription = new RichTextBox();
            panel1 = new Panel();
            chkDarkMode = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(140, 14);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(289, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Employee Page - Information";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.Location = new Point(16, 17);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(63, 28);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click_1;
            // 
            // rtbDescription
            // 
            rtbDescription.BackColor = Color.FromArgb(227, 234, 242);
            rtbDescription.Font = new Font("Segoe UI", 10F);
            rtbDescription.Location = new Point(8, 55);
            rtbDescription.Margin = new Padding(2);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.ReadOnly = true;
            rtbDescription.Size = new Size(547, 425);
            rtbDescription.TabIndex = 2;
            rtbDescription.Text = "";
            rtbDescription.TextChanged += rtbDescription_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 47, 82);
            panel1.Controls.Add(chkDarkMode);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(5, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(561, 55);
            panel1.TabIndex = 3;
            // 
            // chkDarkMode
            // 
            chkDarkMode.AutoSize = true;
            chkDarkMode.ForeColor = Color.White;
            chkDarkMode.Location = new Point(477, 3);
            chkDarkMode.Name = "chkDarkMode";
            chkDarkMode.Size = new Size(84, 19);
            chkDarkMode.TabIndex = 146;
            chkDarkMode.Text = "Dark Mode";
            chkDarkMode.UseVisualStyleBackColor = true;
            chkDarkMode.CheckedChanged += chkdarkMode_CheckedChanged;
            // 
            // InfoEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 482);
            Controls.Add(panel1);
            Controls.Add(rtbDescription);
            Margin = new Padding(2);
            Name = "InfoEmployees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InfoEmployees";
            Load += InfoEmployees_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private Panel panel1;
        private CheckBox chkDarkMode;
    }
}
