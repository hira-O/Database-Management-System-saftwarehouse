namespace Softwarehouse_DBMS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            label4 = new Label();
            panel1 = new Panel();
            pbTogglePassword = new PictureBox();
            pictureBox1 = new PictureBox();
            chkDarkMode = new CheckBox();
            pictureBox8 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbTogglePassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.AliceBlue;
            textBox1.Location = new Point(14, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Ebrima", 13F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(14, 31);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 4;
            label3.Text = "Username\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Ebrima", 13F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 97);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.AliceBlue;
            textBox2.Location = new Point(14, 125);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 23);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.AliceBlue;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(14, 186);
            button1.Name = "button1";
            button1.Size = new Size(246, 29);
            button1.TabIndex = 7;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(113, 230);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 8;
            label4.Text = "Clear";
            label4.Click += label4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(pbTogglePassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Location = new Point(365, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 276);
            panel1.TabIndex = 9;
            // 
            // pbTogglePassword
            // 
            pbTogglePassword.BackColor = Color.AliceBlue;
            pbTogglePassword.Image = Properties.Resources.eye_open;
            pbTogglePassword.Location = new Point(227, 128);
            pbTogglePassword.Name = "pbTogglePassword";
            pbTogglePassword.Size = new Size(24, 19);
            pbTogglePassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTogglePassword.TabIndex = 9;
            pbTogglePassword.TabStop = false;
            pbTogglePassword.Click += pbTogglePassword_Click_2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.HighlightText;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(963, 460);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // chkDarkMode
            // 
            chkDarkMode.AutoSize = true;
            chkDarkMode.BackColor = Color.FromArgb(12, 26, 42);
            chkDarkMode.ForeColor = Color.White;
            chkDarkMode.Location = new Point(823, 429);
            chkDarkMode.Name = "chkDarkMode";
            chkDarkMode.Size = new Size(84, 19);
            chkDarkMode.TabIndex = 146;
            chkDarkMode.Text = "Dark Mode";
            chkDarkMode.UseVisualStyleBackColor = false;
            chkDarkMode.CheckedChanged += chkdarkMode_CheckedChanged;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.FromArgb(12, 24, 46);
            pictureBox8.ErrorImage = (Image)resources.GetObject("pictureBox8.ErrorImage");
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(909, 12);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(22, 20);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 165;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(963, 460);
            Controls.Add(pictureBox8);
            Controls.Add(chkDarkMode);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbTogglePassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private Label label4;
        private Panel panel1;
        private PictureBox pictureBox1;
        private CheckBox chkDarkMode;
        private PictureBox pbTogglePassword;
        private PictureBox pictureBox8;
    }
}
