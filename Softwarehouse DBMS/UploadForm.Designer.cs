namespace Softwarehouse_DBMS
{
    partial class UploadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadForm));
            chkDarkMode = new CheckBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            logoutceo3 = new Button();
            label13 = new Label();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            panel1 = new Panel();
            panel3 = new Panel();
            btnClearFilter = new Button();
            btnApplyFilter = new Button();
            dateTimePickerTo = new DateTimePicker();
            label9 = new Label();
            label14 = new Label();
            dateTimePickerFrom = new DateTimePicker();
            label10 = new Label();
            btnBack = new Button();
            label1 = new Label();
            label7 = new Label();
            lblProjectTitle = new Label();
            txtProjectTitle = new TextBox();
            txtEmployeeName = new TextBox();
            btnUpload = new Button();
            btnBrowse = new Button();
            openFileDialog1 = new OpenFileDialog();
            lblZipFile = new Label();
            txtFilePath = new TextBox();
            dgvUploads = new DataGridView();
            btnDownload = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            pictureBox10 = new PictureBox();
            saveFileDialog1 = new SaveFileDialog();
            lbluploadid = new TextBox();
            lblupload = new Label();
            pictureBox4 = new PictureBox();
            button2 = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUploads).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // chkDarkMode
            // 
            chkDarkMode.AutoSize = true;
            chkDarkMode.Location = new Point(1026, 82);
            chkDarkMode.Name = "chkDarkMode";
            chkDarkMode.Size = new Size(84, 19);
            chkDarkMode.TabIndex = 168;
            chkDarkMode.Text = "Dark Mode";
            chkDarkMode.UseVisualStyleBackColor = true;
            chkDarkMode.CheckedChanged += chkDarkMode_CheckedChanged;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(11, 47, 82);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1185, 47);
            panel2.TabIndex = 167;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1092, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 173;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
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
            // logoutceo3
            // 
            logoutceo3.BackColor = Color.FromArgb(227, 234, 242);
            logoutceo3.Dock = DockStyle.Bottom;
            logoutceo3.Font = new Font("Ebrima", 14.25F, FontStyle.Bold);
            logoutceo3.ForeColor = Color.FromArgb(104, 120, 143);
            logoutceo3.Location = new Point(0, 688);
            logoutceo3.Name = "logoutceo3";
            logoutceo3.Size = new Size(240, 32);
            logoutceo3.TabIndex = 144;
            logoutceo3.Text = "Logout";
            logoutceo3.UseVisualStyleBackColor = false;
            logoutceo3.Click += logoutceo3_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(11, 47, 82);
            label13.Location = new Point(587, 728);
            label13.Name = "label13";
            label13.Size = new Size(77, 17);
            label13.TabIndex = 166;
            label13.Text = "lblDateTime";
            label13.Click += label13_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(logoutceo3);
            panel1.Location = new Point(0, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 720);
            panel1.TabIndex = 165;
            panel1.Paint += panel1_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(btnClearFilter);
            panel3.Controls.Add(btnApplyFilter);
            panel3.Controls.Add(dateTimePickerTo);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(dateTimePickerFrom);
            panel3.Controls.Add(label10);
            panel3.Location = new Point(12, 214);
            panel3.Name = "panel3";
            panel3.Size = new Size(259, 351);
            panel3.TabIndex = 175;
            // 
            // btnClearFilter
            // 
            btnClearFilter.BackColor = Color.FromArgb(227, 234, 242);
            btnClearFilter.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnClearFilter.Location = new Point(24, 298);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(156, 29);
            btnClearFilter.TabIndex = 174;
            btnClearFilter.Text = "Clear Filter";
            btnClearFilter.UseVisualStyleBackColor = false;
            btnClearFilter.Click += btnClearFilter_Click;
            // 
            // btnApplyFilter
            // 
            btnApplyFilter.BackColor = Color.FromArgb(227, 234, 242);
            btnApplyFilter.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnApplyFilter.Location = new Point(24, 247);
            btnApplyFilter.Name = "btnApplyFilter";
            btnApplyFilter.Size = new Size(161, 29);
            btnApplyFilter.TabIndex = 173;
            btnApplyFilter.Text = "Apply Filter";
            btnApplyFilter.UseVisualStyleBackColor = false;
            btnApplyFilter.Click += btnApplyFilter_Click;
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerTo.CalendarMonthBackground = Color.AliceBlue;
            dateTimePickerTo.Font = new Font("Segoe UI", 8F);
            dateTimePickerTo.Location = new Point(4, 177);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(203, 22);
            dateTimePickerTo.TabIndex = 171;
            dateTimePickerTo.Value = new DateTime(2025, 3, 18, 13, 4, 39, 0);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(60, 80, 100);
            label9.Location = new Point(4, 153);
            label9.Name = "label9";
            label9.Size = new Size(79, 21);
            label9.TabIndex = 172;
            label9.Text = "End Date";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(57, 41);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(63, 30);
            label14.TabIndex = 168;
            label14.Text = "Filter";
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerFrom.CalendarMonthBackground = Color.AliceBlue;
            dateTimePickerFrom.Font = new Font("Segoe UI", 8F);
            dateTimePickerFrom.Location = new Point(4, 113);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(203, 22);
            dateTimePickerFrom.TabIndex = 169;
            dateTimePickerFrom.Value = new DateTime(2025, 3, 18, 13, 4, 39, 0);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(60, 80, 100);
            label10.Location = new Point(4, 89);
            label10.Name = "label10";
            label10.Size = new Size(86, 21);
            label10.TabIndex = 170;
            label10.Text = "Start Date";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(227, 234, 242);
            btnBack.Dock = DockStyle.Top;
            btnBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBack.Location = new Point(0, 0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(240, 45);
            btnBack.TabIndex = 145;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ebrima", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(11, 47, 82);
            label1.Location = new Point(594, 95);
            label1.Name = "label1";
            label1.Size = new Size(237, 45);
            label1.TabIndex = 157;
            label1.Text = "UPLOAD FILES";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(60, 80, 100);
            label7.ImageAlign = ContentAlignment.BottomLeft;
            label7.Location = new Point(485, 245);
            label7.Name = "label7";
            label7.Size = new Size(136, 21);
            label7.TabIndex = 158;
            label7.Text = "Employee Name";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProjectTitle
            // 
            lblProjectTitle.AutoSize = true;
            lblProjectTitle.Font = new Font("Ebrima", 11F, FontStyle.Bold);
            lblProjectTitle.ForeColor = Color.FromArgb(60, 80, 100);
            lblProjectTitle.Location = new Point(647, 247);
            lblProjectTitle.Name = "lblProjectTitle";
            lblProjectTitle.Size = new Size(93, 20);
            lblProjectTitle.TabIndex = 159;
            lblProjectTitle.Text = "Project Title";
            // 
            // txtProjectTitle
            // 
            txtProjectTitle.BackColor = Color.FromArgb(227, 234, 242);
            txtProjectTitle.Location = new Point(647, 286);
            txtProjectTitle.Name = "txtProjectTitle";
            txtProjectTitle.Size = new Size(131, 23);
            txtProjectTitle.TabIndex = 160;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.BackColor = Color.FromArgb(227, 234, 242);
            txtEmployeeName.Location = new Point(485, 286);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(148, 23);
            txtEmployeeName.TabIndex = 161;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.FromArgb(227, 234, 242);
            btnUpload.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnUpload.ForeColor = Color.Black;
            btnUpload.Location = new Point(520, 363);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(138, 31);
            btnUpload.TabIndex = 162;
            btnUpload.Text = "Upload File";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.FromArgb(227, 234, 242);
            btnBrowse.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBrowse.ForeColor = Color.Black;
            btnBrowse.Location = new Point(340, 363);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(146, 31);
            btnBrowse.TabIndex = 163;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblZipFile
            // 
            lblZipFile.AutoSize = true;
            lblZipFile.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblZipFile.ForeColor = Color.FromArgb(60, 80, 100);
            lblZipFile.ImageAlign = ContentAlignment.BottomLeft;
            lblZipFile.Location = new Point(784, 247);
            lblZipFile.Name = "lblZipFile";
            lblZipFile.Size = new Size(124, 21);
            lblZipFile.TabIndex = 169;
            lblZipFile.Text = "Project Zip File";
            lblZipFile.TextAlign = ContentAlignment.MiddleCenter;
            lblZipFile.Click += label8_Click;
            // 
            // txtFilePath
            // 
            txtFilePath.BackColor = Color.FromArgb(227, 234, 242);
            txtFilePath.Location = new Point(784, 286);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.ReadOnly = true;
            txtFilePath.Size = new Size(146, 23);
            txtFilePath.TabIndex = 170;
            // 
            // dgvUploads
            // 
            dgvUploads.BackgroundColor = Color.FromArgb(227, 234, 242);
            dgvUploads.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUploads.Location = new Point(363, 412);
            dgvUploads.Name = "dgvUploads";
            dgvUploads.Size = new Size(634, 219);
            dgvUploads.TabIndex = 171;
            // 
            // btnDownload
            // 
            btnDownload.BackColor = Color.FromArgb(227, 234, 242);
            btnDownload.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnDownload.ForeColor = Color.Black;
            btnDownload.Location = new Point(701, 363);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(144, 31);
            btnDownload.TabIndex = 172;
            btnDownload.Text = "Download Selected";
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += btnExtract_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(1117, 721);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(26, 26);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 174;
            pictureBox10.TabStop = false;
            pictureBox10.Click += pictureBox10_Click;
            // 
            // lbluploadid
            // 
            lbluploadid.BackColor = Color.FromArgb(227, 234, 242);
            lbluploadid.Location = new Point(340, 286);
            lbluploadid.Name = "lbluploadid";
            lbluploadid.Size = new Size(139, 23);
            lbluploadid.TabIndex = 175;
            // 
            // lblupload
            // 
            lblupload.AutoSize = true;
            lblupload.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblupload.ForeColor = Color.FromArgb(60, 80, 100);
            lblupload.ImageAlign = ContentAlignment.BottomLeft;
            lblupload.Location = new Point(340, 245);
            lblupload.Name = "lblupload";
            lblupload.Size = new Size(87, 21);
            lblupload.TabIndex = 176;
            lblupload.Text = "Upload ID";
            lblupload.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(227, 234, 242);
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(363, 664);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(16, 21);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 174;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(227, 234, 242);
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(350, 654);
            button2.Name = "button2";
            button2.Size = new Size(129, 41);
            button2.TabIndex = 177;
            button2.Text = "     Open GItHub";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(227, 234, 242);
            txtSearch.Location = new Point(936, 286);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(107, 23);
            txtSearch.TabIndex = 178;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(227, 234, 242);
            btnSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(897, 363);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(136, 31);
            btnSearch.TabIndex = 179;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(60, 80, 100);
            label8.ImageAlign = ContentAlignment.BottomLeft;
            label8.Location = new Point(936, 247);
            label8.Name = "label8";
            label8.Size = new Size(61, 21);
            label8.TabIndex = 180;
            label8.Text = "Search";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UploadForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1184, 761);
            Controls.Add(label8);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(pictureBox4);
            Controls.Add(button2);
            Controls.Add(lblupload);
            Controls.Add(lbluploadid);
            Controls.Add(pictureBox10);
            Controls.Add(btnDownload);
            Controls.Add(dgvUploads);
            Controls.Add(txtFilePath);
            Controls.Add(lblZipFile);
            Controls.Add(chkDarkMode);
            Controls.Add(panel2);
            Controls.Add(label13);
            Controls.Add(panel1);
            Controls.Add(btnBrowse);
            Controls.Add(btnUpload);
            Controls.Add(txtEmployeeName);
            Controls.Add(txtProjectTitle);
            Controls.Add(lblProjectTitle);
            Controls.Add(label7);
            Controls.Add(label1);
            Name = "UploadForm";
            Text = "UploadForm";
            Load += UploadForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUploads).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkDarkMode;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label6;
        private Panel panel2;
        private Label label3;
        private Button logoutceo3;
        private Label label13;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Panel panel1;
        private Label label1;
        private Label label7;
        private Label lblProjectTitle;
        private TextBox txtProjectTitle;
        private TextBox txtEmployeeName;
        private Button btnUpload;
        private Button btnBrowse;
        private OpenFileDialog openFileDialog1;
        private Label lblZipFile;
        private TextBox txtFilePath;
        private DataGridView dgvUploads;
        private Button btnDownload;
        private FolderBrowserDialog folderBrowserDialog1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox10;
        private SaveFileDialog saveFileDialog1;
        private TextBox lbluploadid;
        private Label lblupload;
        private PictureBox pictureBox4;
        private Button button2;
        private Button btnBack;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label label8;
        private DateTimePicker dateTimePickerTo;
        private Label label9;
        private Label label14;
        private DateTimePicker dateTimePickerFrom;
        private Label label10;
        private Button btnApplyFilter;
        private Button btnClearFilter;
        private Panel panel3;
    }
}