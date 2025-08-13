namespace Softwarehouse_DBMS
{
    partial class InfoProject
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
        /// Required method for Designer support — do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBack = new Button();
            rtbDescription = new RichTextBox();
            panel1 = new Panel();
            label1 = new Label();
            chkDarkMode = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(10, 17);
            btnBack.Margin = new Padding(2, 2, 2, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(78, 20);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // rtbDescription
            // 
            rtbDescription.BackColor = Color.FromArgb(227, 234, 242);
            rtbDescription.Location = new Point(8, 62);
            rtbDescription.Margin = new Padding(2, 2, 2, 2);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(562, 359);
            rtbDescription.TabIndex = 2;
            rtbDescription.Text = "";
            rtbDescription.TextChanged += rtbDescription_TextChanged;
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
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(158, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(264, 28);
            label1.TabIndex = 0;
            label1.Text = "Project Page - Information";
            label1.Click += label1_Click;
            // 
            // chkDarkMode
            // 
            chkDarkMode.AutoSize = true;
            chkDarkMode.ForeColor = Color.White;
            chkDarkMode.Location = new Point(472, 3);
            chkDarkMode.Name = "chkDarkMode";
            chkDarkMode.Size = new Size(84, 19);
            chkDarkMode.TabIndex = 146;
            chkDarkMode.Text = "Dark Mode";
            chkDarkMode.UseVisualStyleBackColor = true;
            // 
            // InfoProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 423);
            Controls.Add(panel1);
            Controls.Add(rtbDescription);
            Margin = new Padding(2, 2, 2, 2);
            Name = "InfoProject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InfoProject";
            Load += InfoProject_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private Panel panel1;
        private Label label1;
        private CheckBox chkDarkMode;
    }
}
