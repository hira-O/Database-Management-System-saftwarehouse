using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using System.Diagnostics;


namespace Softwarehouse_DBMS
{
    public partial class UploadForm : Form
    {
        private System.Windows.Forms.Timer timerClock = new System.Windows.Forms.Timer();

        private Form _previousForm;
        private DataTable uploadTable; // Store your data source globally

        public UploadForm(Form previousForm)
        {
            InitializeComponent();
            _previousForm = previousForm;

        }
        private void OpenGitHub()
        {
            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = "https://github.com",
                    UseShellExecute = true  // This is crucial
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open GitHub: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "ZIP Files (*.zip)|*.zip";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)

        {
            if (txtEmployeeName.Text == "" || txtProjectTitle.Text == "" || txtFilePath.Text == "")
            {
                MessageBox.Show("Please fill all fields and select a file.");
                return;
            }

            byte[] fileData = File.ReadAllBytes(txtFilePath.Text);
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PMS.mdf;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO ProjectUploads 
                         (UploadID, EmployeeName, ProjectTitle, FileName, FileData, UploadDate)
                         VALUES (@UploadID, @EmployeeName, @ProjectTitle, @FileName, @FileData, @UploadDate)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UploadID", lbluploadid.Text);
                    cmd.Parameters.AddWithValue("@EmployeeName", txtEmployeeName.Text);
                    cmd.Parameters.AddWithValue("@ProjectTitle", txtProjectTitle.Text);
                    cmd.Parameters.AddWithValue("@FileName", Path.GetFileName(txtFilePath.Text));
                    cmd.Parameters.AddWithValue("@FileData", fileData);
                    cmd.Parameters.AddWithValue("@UploadDate", DateTime.Now);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Project uploaded successfully.");
                }
            }

            LoadUploads(); // refresh the table
        }

        private void LoadUploads()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PMS.mdf;Integrated Security=True;";
            DataTable table = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT UploadID, EmployeeName, ProjectTitle, FileName, UploadDate FROM ProjectUploads", conn);
                //DataTable table = new DataTable();
                adapter.Fill(table);
                dgvUploads.DataSource = table;
                if (dgvUploads.Columns.Contains("UploadDate"))
                {
                    dgvUploads.Columns["UploadDate"].Width = 200;
                    dgvUploads.Columns["UploadDate"].DefaultCellStyle.Format = "f"; // full date/time
                }
            }
            //uploadTable = table; // No more error

            uploadTable = table; // Add this in LoadUploads()
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void UploadForm_Load(object sender, EventArgs e)
        {
            //LoadData(); // Your method that sets dataGridView1.DataSource

            ChatPopup popup = new ChatPopup(this); // ✅ Always pass `this` as the parent
            this.Controls.Add(popup);
            timerClock.Interval = 1000;
            timerClock.Tick += TimerClock_Tick;
            timerClock.Start();

            chkDarkMode.Checked = ThemeManager.IsDarkMode;
            ThemeManager.ApplyTheme(this);
            LoadUploads();
        }
        private void TimerClock_Tick(object? sender, EventArgs e)
        {
            label13.Text = DateTime.Now.ToString("dddd, dd-MM-yyyy hh:mm:ss tt");
        }
        private void btnExtract_Click(object sender, EventArgs e)
        {
            if (dgvUploads.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a file to download.");
                return;
            }

            int uploadID = Convert.ToInt32(dgvUploads.SelectedRows[0].Cells["UploadID"].Value);
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PMS.mdf;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT FileName, FileData FROM ProjectUploads WHERE UploadID = @UploadID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UploadID", uploadID);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string fileName = reader["FileName"].ToString();
                            byte[] fileData = (byte[])reader["FileData"];

                            saveFileDialog1.FileName = fileName;
                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                File.WriteAllBytes(saveFileDialog1.FileName, fileData);
                                MessageBox.Show("Download complete.");
                            }
                        }
                    }
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            chatBot chatForm = new chatBot();
            chatForm.Show();
        }

        private void chkDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.IsDarkMode = chkDarkMode.Checked;

            foreach (Form openForm in Application.OpenForms)
            {
                ThemeManager.ApplyTheme(openForm);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void taskbuttonceo3_Click(object sender, EventArgs e)
        {
            Form2 taskForm = new Form2();
            this.Hide();
            taskForm.Show();
        }

        private void employeebuttonceo3_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            this.Hide();
            employees.Show();
        }

        private void Projectbuttonceo3_Click(object sender, EventArgs e)
        {
            project projectForm = new project(); // Use PascalCase class name
            this.Hide();
            projectForm.Show();
        }

        private void Reportbuttonceo3_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            this.Hide();
        }

        private void logoutceo3_Click(object sender, EventArgs e)
        {

            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OpenGitHub();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenGitHub();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            _previousForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            using (InfoUploadFile rptForm = new InfoUploadFile(this))  // ✅ PASS the current form
            {
                rptForm.ShowDialog();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string filterText = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(filterText))
            {
                (dgvUploads.DataSource as DataTable).DefaultView.RowFilter =
                    $"EmployeeName LIKE '%{filterText}%' OR ProjectTitle LIKE '%{filterText}%'";
            }
            else
            {
                // Clear filter
                (dgvUploads.DataSource as DataTable).DefaultView.RowFilter = "";
            }
            if (dgvUploads.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Emter a Keyword to Search.");
                return;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtSearch.Text.Trim().Replace("'", "''");
            if (!string.IsNullOrEmpty(filterText))
            {
                (dgvUploads.DataSource as DataTable).DefaultView.RowFilter =
                    $"ProjectTitle LIKE '%{filterText}%' OR EmployeeName LIKE '%{filterText}%' OR FileName LIKE '%{filterText}%'";
            }
            else
            {
                (dgvUploads.DataSource as DataTable).DefaultView.RowFilter = "";
            }

        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            if (uploadTable == null) return;

            DateTime fromDate = dateTimePickerFrom.Value.Date;
            DateTime toDate = dateTimePickerTo.Value.Date.AddDays(1).AddSeconds(-1); // inclusive

            DataView dv = uploadTable.DefaultView; // Declare only once
            dv.RowFilter = string.Format(
                "UploadDate >= #{0}# AND UploadDate <= #{1}#",
                fromDate.ToString("MM/dd/yyyy HH:mm:ss"),
                toDate.ToString("MM/dd/yyyy HH:mm:ss")
            );


        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            if (uploadTable != null)
            {
                uploadTable.DefaultView.RowFilter = "";
            }
            dgvUploads.DataSource = uploadTable;
        }
    }
}
