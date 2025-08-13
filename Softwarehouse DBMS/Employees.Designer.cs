namespace Softwarehouse_DBMS
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            label1 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            comboBox2 = new ComboBox();
            textBox7 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            button6 = new Button();
            logout1 = new Button();
            Reportbutton = new Button();
            Projectbutton1 = new Button();
            employeebutton1 = new Button();
            taskbutton1 = new Button();
            label16 = new Label();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            label3 = new Label();
            chkDarkMode = new CheckBox();
            pictureBox10 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Ebrima", 24F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(11, 47, 82);
            label1.Location = new Point(558, 116);
            label1.Name = "label1";
            label1.Size = new Size(373, 45);
            label1.TabIndex = 1;
            label1.Text = "Employee Management";
            label1.Click += label1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(60, 80, 100);
            label10.Location = new Point(509, 234);
            label10.Name = "label10";
            label10.Size = new Size(136, 21);
            label10.TabIndex = 93;
            label10.Text = "Employee Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(60, 80, 100);
            label9.Location = new Point(856, 234);
            label9.Name = "label9";
            label9.Size = new Size(59, 21);
            label9.TabIndex = 92;
            label9.Text = "Phone";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(60, 80, 100);
            label8.Location = new Point(693, 234);
            label8.Name = "label8";
            label8.Size = new Size(65, 21);
            label8.TabIndex = 91;
            label8.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(60, 80, 100);
            label7.Location = new Point(300, 234);
            label7.Name = "label7";
            label7.Size = new Size(105, 21);
            label7.TabIndex = 90;
            label7.Text = "Employee Id";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(227, 234, 242);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Male", "Female", "Other" });
            comboBox2.Location = new Point(693, 260);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(120, 23);
            comboBox2.TabIndex = 97;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.FromArgb(227, 234, 242);
            textBox7.Location = new Point(855, 260);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(165, 23);
            textBox7.TabIndex = 96;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(227, 234, 242);
            textBox2.Location = new Point(306, 258);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(163, 23);
            textBox2.TabIndex = 95;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(227, 234, 242);
            textBox1.Location = new Point(509, 260);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 23);
            textBox1.TabIndex = 94;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(227, 234, 242);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(425, 418);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(490, 218);
            dataGridView1.TabIndex = 102;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_2;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(227, 234, 242);
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button4.Location = new Point(389, 342);
            button4.Name = "button4";
            button4.Size = new Size(108, 29);
            button4.TabIndex = 101;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(227, 234, 242);
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button3.Location = new Point(518, 342);
            button3.Name = "button3";
            button3.Size = new Size(110, 29);
            button3.TabIndex = 100;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(227, 234, 242);
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button2.Location = new Point(651, 342);
            button2.Name = "button2";
            button2.Size = new Size(107, 29);
            button2.TabIndex = 99;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(227, 234, 242);
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button1.Location = new Point(794, 342);
            button1.Name = "button1";
            button1.Size = new Size(121, 29);
            button1.TabIndex = 98;
            button1.Text = "Print";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(logout1);
            panel1.Controls.Add(Reportbutton);
            panel1.Controls.Add(Projectbutton1);
            panel1.Controls.Add(employeebutton1);
            panel1.Controls.Add(taskbutton1);
            panel1.Location = new Point(0, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 760);
            panel1.TabIndex = 112;
            panel1.Paint += panel1_Paint;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(227, 234, 242);
            button6.Dock = DockStyle.Top;
            button6.Font = new Font("Ebrima", 14.25F, FontStyle.Bold);
            button6.ForeColor = Color.FromArgb(104, 120, 143);
            button6.Location = new Point(0, 128);
            button6.Name = "button6";
            button6.Size = new Size(247, 32);
            button6.TabIndex = 146;
            button6.Text = "Upload File";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // logout1
            // 
            logout1.BackColor = Color.FromArgb(227, 234, 242);
            logout1.Dock = DockStyle.Bottom;
            logout1.Font = new Font("Ebrima", 14.25F, FontStyle.Bold);
            logout1.ForeColor = Color.FromArgb(104, 120, 143);
            logout1.Location = new Point(0, 728);
            logout1.Name = "logout1";
            logout1.Size = new Size(247, 32);
            logout1.TabIndex = 145;
            logout1.Text = "Logout";
            logout1.UseVisualStyleBackColor = false;
            logout1.Click += logout1_Click;
            logout1.MouseEnter += logout1_MouseEnter;
            logout1.MouseLeave += logout1_MouseLeave;
            // 
            // Reportbutton
            // 
            Reportbutton.BackColor = Color.FromArgb(227, 234, 242);
            Reportbutton.Dock = DockStyle.Top;
            Reportbutton.Font = new Font("Ebrima", 14.25F, FontStyle.Bold);
            Reportbutton.ForeColor = Color.FromArgb(104, 120, 143);
            Reportbutton.Location = new Point(0, 96);
            Reportbutton.Name = "Reportbutton";
            Reportbutton.Size = new Size(247, 32);
            Reportbutton.TabIndex = 132;
            Reportbutton.Text = "Report";
            Reportbutton.UseVisualStyleBackColor = false;
            Reportbutton.Click += Reportbutton_Click;
            Reportbutton.MouseEnter += Reportbutton_MouseEnter;
            Reportbutton.MouseLeave += Reportbutton_MouseLeave;
            // 
            // Projectbutton1
            // 
            Projectbutton1.BackColor = Color.FromArgb(227, 234, 242);
            Projectbutton1.Dock = DockStyle.Top;
            Projectbutton1.Font = new Font("Ebrima", 14.25F, FontStyle.Bold);
            Projectbutton1.ForeColor = Color.FromArgb(104, 120, 143);
            Projectbutton1.Location = new Point(0, 64);
            Projectbutton1.Name = "Projectbutton1";
            Projectbutton1.Size = new Size(247, 32);
            Projectbutton1.TabIndex = 131;
            Projectbutton1.Text = "Project";
            Projectbutton1.UseVisualStyleBackColor = false;
            Projectbutton1.Click += Projectbutton1_Click;
            Projectbutton1.MouseEnter += Projectbutton1_MouseEnter;
            Projectbutton1.MouseLeave += Projectbutton1_MouseLeave;
            Projectbutton1.MouseUp += Projectbutton1_MouseUp;
            // 
            // employeebutton1
            // 
            employeebutton1.BackColor = Color.FromArgb(227, 234, 242);
            employeebutton1.Dock = DockStyle.Top;
            employeebutton1.Font = new Font("Ebrima", 14.25F, FontStyle.Bold);
            employeebutton1.ForeColor = Color.FromArgb(104, 120, 143);
            employeebutton1.Location = new Point(0, 32);
            employeebutton1.Name = "employeebutton1";
            employeebutton1.Size = new Size(247, 32);
            employeebutton1.TabIndex = 130;
            employeebutton1.Text = "Employee";
            employeebutton1.UseVisualStyleBackColor = false;
            employeebutton1.Click += employeebutton1_Click;
            employeebutton1.MouseEnter += employeebutton1_MouseEnter;
            employeebutton1.MouseLeave += employeebutton1_MouseLeave;
            // 
            // taskbutton1
            // 
            taskbutton1.BackColor = Color.FromArgb(227, 234, 242);
            taskbutton1.Dock = DockStyle.Top;
            taskbutton1.Font = new Font("Ebrima", 14.25F, FontStyle.Bold);
            taskbutton1.ForeColor = Color.FromArgb(104, 120, 143);
            taskbutton1.Location = new Point(0, 0);
            taskbutton1.Name = "taskbutton1";
            taskbutton1.Size = new Size(247, 32);
            taskbutton1.TabIndex = 129;
            taskbutton1.Text = "Task";
            taskbutton1.UseVisualStyleBackColor = false;
            taskbutton1.Click += taskbutton1_Click;
            taskbutton1.MouseEnter += taskbutton1_MouseEnter;
            taskbutton1.MouseLeave += taskbutton1_MouseLeave;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(11, 47, 82);
            label16.Location = new Point(587, 728);
            label16.Name = "label16";
            label16.Size = new Size(77, 17);
            label16.TabIndex = 149;
            label16.Text = "lblDateTime";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(11, 47, 82);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1201, 41);
            panel2.TabIndex = 155;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1038, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 155;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1098, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 154;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 151;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Ebrima", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(32, 7);
            label2.Name = "label2";
            label2.Size = new Size(112, 32);
            label2.TabIndex = 152;
            label2.Text = "   CODES";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Ebrima", 14F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(182, 19);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 150;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Ebrima", 14F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(201, 20);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 149;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Ebrima", 14F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(0, 0, 64);
            label6.Location = new Point(182, 16);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Ebrima", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(139, 7);
            label3.Name = "label3";
            label3.Size = new Size(132, 32);
            label3.TabIndex = 153;
            label3.Text = "LOGISTICS";
            // 
            // chkDarkMode
            // 
            chkDarkMode.AutoSize = true;
            chkDarkMode.BackColor = Color.Transparent;
            chkDarkMode.Location = new Point(1063, 63);
            chkDarkMode.Name = "chkDarkMode";
            chkDarkMode.Size = new Size(84, 19);
            chkDarkMode.TabIndex = 156;
            chkDarkMode.Text = "Dark Mode";
            chkDarkMode.UseVisualStyleBackColor = false;
            chkDarkMode.CheckedChanged += chkdarkMode_CheckedChanged;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(1138, 762);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(26, 26);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 160;
            pictureBox10.TabStop = false;
            pictureBox10.Click += pictureBox10_Click;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1200, 800);
            Controls.Add(pictureBox10);
            Controls.Add(chkDarkMode);
            Controls.Add(panel2);
            Controls.Add(label16);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(textBox7);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employees";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employees";
            Load += Employees_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private ComboBox comboBox2;
        private TextBox textBox7;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel1;
        private Button taskbutton1;
        private Button employeebutton1;
        private Button Projectbutton1;
        private Button Reportbutton;
        private Button logout1;
        private Label label16;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label3;
        private PictureBox pictureBox2;
        private CheckBox chkDarkMode;
        private PictureBox pictureBox3;
        private PictureBox pictureBox10;
        private Button button6;
    }
}