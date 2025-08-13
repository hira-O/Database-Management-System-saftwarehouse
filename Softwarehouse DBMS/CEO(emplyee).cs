using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Softwarehouse_DBMS
{
    public partial class CEO_emplyee_ : Form
    {
        private System.Windows.Forms.Timer timerClock = new System.Windows.Forms.Timer();
        public CEO_emplyee_()
        {
            InitializeComponent();
        }
        private void LoadAllEmployees()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PMS.mdf;Integrated Security=True;"))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Employees";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    if (dataGridView1.Columns.Contains("EmpName"))
                    {
                        dataGridView1.Columns["EmpName"].Width = 150;
                        dataGridView1.Columns["EmpName"].DefaultCellStyle.Format = "f"; // full date/time
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading employees: " + ex.Message);
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            CEO_task_cs CEO_task_cs = new CEO_task_cs();
            this.Hide();
            CEO_task_cs.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            CEO_report_ CEO_report_ = new CEO_report_();
            this.Hide();
            CEO_report_.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            CEO_project_ CEO_project_ = new CEO_project_();
            this.Hide();
            CEO_project_.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            CEO_emplyee_ CEO_emplyee_ = new CEO_emplyee_();
            this.Hide();
            CEO_emplyee_.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            LoginForm Loginform = new LoginForm();
            LoginForm.Show();
            this.Close();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void CEO_emplyee__Load(object sender, EventArgs e)
        {

        }

        private void Reportbuttonceo1_Click(object sender, EventArgs e)
        {
            CEO_report_ CEO_report_ = new CEO_report_();
            this.Hide();
            CEO_report_.Show();
        }

        private void Projectbuttonceo1_Click(object sender, EventArgs e)
        {
            CEO_project_ CEO_project_ = new CEO_project_();
            this.Hide();
            CEO_project_.Show();
        }

        private void employeebuttonceo1_Click(object sender, EventArgs e)
        {
            CEO_emplyee_ CEO_emplyee_ = new CEO_emplyee_();
            this.Hide();
            CEO_emplyee_.Show();
        }

        private void taskbuttonceo1_Click(object sender, EventArgs e)
        {
            CEO_task_cs CEO_task_cs = new CEO_task_cs();
            this.Hide();
            CEO_task_cs.Show();



        }

        private void logoutceo1_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void CEO_emplyee__Load_1(object sender, EventArgs e)
        {
            LoadAllEmployees();
            timerClock.Interval = 1000;
            timerClock.Tick += TimerClock_Tick;
            timerClock.Start();
            chkDarkMode.Checked = ThemeManager.IsDarkMode;
            ThemeManager.ApplyTheme(this);

        }

        private void TimerClock_Tick(object? sender, EventArgs e)
        {
            label11.Text = DateTime.Now.ToString("dddd, dd-MM-yyyy hh:mm:ss tt");
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void taskbuttonceo1_MouseEnter(object sender, EventArgs e)
        {

            taskbuttonceo1.BackColor = Color.FromArgb(11, 47, 82);
            taskbuttonceo1.ForeColor = Color.White;
        }

        private void taskbuttonceo1_MouseLeave(object sender, EventArgs e)
        {

            taskbuttonceo1.BackColor = Color.FromArgb(227, 234, 242);
            taskbuttonceo1.ForeColor = Color.FromArgb(104, 120, 143);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Projectbuttonceo1_MouseEnter(object sender, EventArgs e)
        {
            Projectbuttonceo1.BackColor = Color.FromArgb(11, 47, 82);
            Projectbuttonceo1.ForeColor = Color.White;
        }

        private void Projectbuttonceo1_MouseLeave(object sender, EventArgs e)
        {
            Projectbuttonceo1.BackColor = Color.FromArgb(227, 234, 242);
            Projectbuttonceo1.ForeColor = Color.FromArgb(104, 120, 143);
        }

        private void Reportbuttonceo1_MouseLeave(object sender, EventArgs e)
        {
            Reportbuttonceo1.BackColor = Color.FromArgb(227, 234, 242);
            Reportbuttonceo1.ForeColor = Color.FromArgb(104, 120, 143);
        }

        private void Reportbuttonceo1_MouseEnter(object sender, EventArgs e)
        {
            Reportbuttonceo1.BackColor = Color.FromArgb(11, 47, 82);
            Reportbuttonceo1.ForeColor = Color.White;
        }

        private void employeebuttonceo1_MouseLeave(object sender, EventArgs e)
        {
            employeebuttonceo1.BackColor = Color.FromArgb(227, 234, 242);
            employeebuttonceo1.ForeColor = Color.FromArgb(104, 120, 143);
        }
        private void employeebuttonceo1_MouseEnter(object sender, EventArgs e)
        {
            employeebuttonceo1.BackColor = Color.FromArgb(11, 47, 82);
            employeebuttonceo1.ForeColor = Color.White;
        }

        private void logoutceo1_MouseEnter(object sender, EventArgs e)
        {
            logoutceo1.BackColor = Color.FromArgb(11, 47, 82);
            logoutceo1.ForeColor = Color.White;
        }

        private void logoutceo1_MouseLeave(object sender, EventArgs e)
        {
            logoutceo1.BackColor = Color.FromArgb(11, 47, 82);
            logoutceo1.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            CEOmainform CEOmainform = new CEOmainform(); // Replace with your actual CEO main form class name
            CEOmainform.Show();
            this.Hide();
        }

        private void chkDarkMode_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ApplyTheme(bool isDark)
        {
        }

        private void chkdarkMode_CheckedChanged_1(object sender, EventArgs e)
        {
            ThemeManager.IsDarkMode = chkDarkMode.Checked;

            foreach (Form openForm in Application.OpenForms)
            {
                ThemeManager.ApplyTheme(openForm);
            }

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            using (InfoCEOEmp empForm = new InfoCEOEmp())
            {
                empForm.ShowDialog();  // This will open the form and block the main form
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UploadForm upfile = new UploadForm(this); // pass current form
            this.Hide();
            upfile.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string empName = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(empName))
            {
                MessageBox.Show("Please enter an employee name.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PMS.mdf;Integrated Security=True;"))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Employees WHERE EmpName = @EmpName";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@EmpName", empName);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching by name: " + ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string empId = textBox2.Text.Trim();
            if (string.IsNullOrEmpty(empId))
            {
                MessageBox.Show("Please enter an employee ID.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PMS.mdf;Integrated Security=True;"))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Employees WHERE EmpId = @EmpId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@EmpId", empId);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching by ID: " + ex.Message);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintGrid);
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            {
                //Document = printDocument
                previewDialog.Document = printDocument;
            }
            ;
            previewDialog.ShowDialog();
        }
        private void PrintGrid(object sender, PrintPageEventArgs e)
        {
            int x = 50, y = 100;
            int cellHeight = 40;
            int[] columnWidths = new int[dataGridView1.Columns.Count];

            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font tableFont = new Font("Arial", 10);
            Brush brush = Brushes.Black;
            Pen pen = new Pen(Color.Black, 1);
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                columnWidths[j] = Math.Max(100, (int)e.Graphics.MeasureString(dataGridView1.Columns[j].HeaderText, headerFont).Width + 20);

            }
            string title = "PROJECT REPORT";
            SizeF titleSize = e.Graphics.MeasureString(title, new Font("Arial", 16, FontStyle.Bold));
            float titleX = (e.PageBounds.Width - titleSize.Width) / 2;
            e.Graphics.DrawString(title, new Font("Arial", 16, FontStyle.Bold), brush, titleX, 40);

            string generationOn = "Generated On: " + DateTime.Now.ToString("MM/dd/yyyy");
            e.Graphics.DrawString(generationOn, new Font("Arial", 10, FontStyle.Italic), brush, x, y - 30);

            // int tempX = x;
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, x, y, columnWidths[j], cellHeight);
                e.Graphics.DrawRectangle(pen, x, y, columnWidths[j], cellHeight);
                e.Graphics.DrawString(dataGridView1.Columns[j].HeaderText, headerFont, brush, x + 5, y + 10);
                x += columnWidths[j];

            }
            y += cellHeight;
            x = 50;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].IsNewRow) continue;

                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    string value = dataGridView1.Rows[i].Cells[j].Value?.ToString() ?? "";
                    e.Graphics.DrawRectangle(pen, x, y, columnWidths[j], cellHeight);
                    e.Graphics.DrawString(value, tableFont, brush, x + 5, y + 10);
                    x += columnWidths[j];
                }

                y += cellHeight;
                x = 50;
            }
        }
    }
}