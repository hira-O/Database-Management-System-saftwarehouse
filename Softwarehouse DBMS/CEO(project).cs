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
    public partial class CEO_project_ : Form
    {
        private System.Windows.Forms.Timer timerClock = new System.Windows.Forms.Timer();
        public CEO_project_()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PMS.mdf;Integrated Security=True;");
        private void LoadAllProjects()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PMS.mdf;Integrated Security=True;"))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Projects";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    if (dataGridView1.Columns.Contains("ProNamd"))
                    {
                        dataGridView1.Columns["ProName"].Width = 200;
                        dataGridView1.Columns["ProName"].DefaultCellStyle.Format = "f"; // full date/time
                    }
                    if (dataGridView1.Columns.Contains("ProDesc"))
                    {
                        dataGridView1.Columns["ProDesc"].Width = 150;
                        dataGridView1.Columns["ProDesc"].DefaultCellStyle.Format = "f"; // full date/time
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading projects: " + ex.Message);
                }
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {
            LoginForm Loginform = new LoginForm();
            LoginForm.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            CEO_task_cs CEO_task_cs = new CEO_task_cs();
            this.Hide();
            CEO_task_cs.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            CEO_emplyee_ CEO_emplyee_ = new CEO_emplyee_();
            this.Hide();
            CEO_emplyee_.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            CEO_project_ CEO_project_ = new CEO_project_();
            this.Hide();
            CEO_project_.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            CEO_report_ CEO_report_ = new CEO_report_();
            this.Hide();
            CEO_report_.Show();
        }

        private void taskbuttonceo2_Click(object sender, EventArgs e)
        {
            CEO_task_cs CEO_task_cs = new CEO_task_cs();
            this.Hide();
            CEO_task_cs.Show();
        }

        private void employeebuttonceo2_Click(object sender, EventArgs e)
        {
            CEO_emplyee_ CEO_emplyee_ = new CEO_emplyee_();
            this.Hide();
            CEO_emplyee_.Show();
        }

        private void Reportbuttonceo2_Click(object sender, EventArgs e)
        {
            CEO_report_ CEO_report_ = new CEO_report_();
            this.Hide();
            CEO_report_.Show();
        }

        private void Projectbuttonceo2_Click(object sender, EventArgs e)
        {
            CEO_project_ CEO_project_ = new CEO_project_();
            this.Hide();
            CEO_project_.Show();
        }

        private void logoutceo2_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void CEO_project__Load(object sender, EventArgs e)
        {
            LoadAllProjects();
            timerClock.Interval = 1000;
            timerClock.Tick += TimerClock_Tick;
            timerClock.Start();
            chkDarkMode.Checked = ThemeManager.IsDarkMode;
            ThemeManager.ApplyTheme(this);
        }
        private void TimerClock_Tick(object? sender, EventArgs e)
        {
            label20.Text = DateTime.Now.ToString("dddd, dd-MM-yyyy hh:mm:ss tt");
        }

        private void taskbuttonceo2_MouseEnter(object sender, EventArgs e)
        {
            taskbuttonceo2.BackColor = Color.FromArgb(11, 47, 82);
            taskbuttonceo2.ForeColor = Color.White;

        }

        private void taskbuttonceo2_MouseLeave(object sender, EventArgs e)
        {
            taskbuttonceo2.BackColor = Color.FromArgb(227, 234, 242);
            taskbuttonceo2.ForeColor = Color.FromArgb(104, 120, 143);

        }

        private void employeebuttonceo2_MouseEnter(object sender, EventArgs e)
        {
            employeebuttonceo2.BackColor = Color.FromArgb(11, 47, 82);
            employeebuttonceo2.ForeColor = Color.White;

        }

        private void employeebuttonceo2_MouseLeave(object sender, EventArgs e)
        {
            employeebuttonceo2.BackColor = Color.FromArgb(227, 234, 242);
            employeebuttonceo2.ForeColor = Color.FromArgb(104, 120, 143);

        }

        private void Projectbuttonceo2_MouseEnter(object sender, EventArgs e)
        {
            Projectbuttonceo2.BackColor = Color.FromArgb(11, 47, 82);
            Projectbuttonceo2.ForeColor = Color.White;

        }

        private void Projectbuttonceo2_MouseLeave(object sender, EventArgs e)
        {
            Projectbuttonceo2.BackColor = Color.FromArgb(227, 234, 242);
            Projectbuttonceo2.ForeColor = Color.FromArgb(104, 120, 143);

        }

        private void Reportbuttonceo2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void Reportbuttonceo2_MouseMove(object sender, MouseEventArgs e)
        {
            Reportbuttonceo2.BackColor = Color.FromArgb(11, 47, 82);
            Reportbuttonceo2.ForeColor = Color.White;

        }

        private void Reportbuttonceo2_MouseLeave(object sender, EventArgs e)
        {
            Reportbuttonceo2.BackColor = Color.FromArgb(227, 234, 242);
            Reportbuttonceo2.ForeColor = Color.FromArgb(104, 120, 143);

        }

        private void logoutceo2_MouseEnter(object sender, EventArgs e)
        {
            logoutceo2.BackColor = Color.FromArgb(11, 47, 82);
            logoutceo2.ForeColor = Color.White;

        }

        private void logoutceo2_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void logoutceo2_MouseLeave(object sender, EventArgs e)
        {
            logoutceo2.BackColor = Color.FromArgb(11, 47, 82);
            logoutceo2.ForeColor = Color.White;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CEOmainform CEOmainform = new CEOmainform(); // Replace with your actual CEO main form class name
            CEOmainform.Show();
            this.Hide();
        }

        private void chkdarkMode_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.IsDarkMode = chkDarkMode.Checked;

            foreach (Form openForm in Application.OpenForms)
            {
                ThemeManager.ApplyTheme(openForm);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (ProjectsDashboard projdashForm = new ProjectsDashboard())
            {
                projdashForm.ShowDialog();
            }
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UploadForm upfile = new UploadForm(this);
            this.Hide();
            upfile.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string projectName = textBox2.Text.Trim();
            if (string.IsNullOrEmpty(projectName))
            {
                MessageBox.Show("Please enter a project name.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PMS.mdf;Integrated Security=True;"))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Projects WHERE ProName = @ProName";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProName", projectName);
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

        private void button2_Click(object sender, EventArgs e)
        {

            string progress = comboBox2.Text;
            if (string.IsNullOrEmpty(progress))
            {
                MessageBox.Show("Please select a progress status.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PMS.mdf;Integrated Security=True;"))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Projects WHERE Status = @Status";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Status", progress);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching by progress: " + ex.Message);
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            using (InfoCEOProjects empForm = new InfoCEOProjects())
            {
                empForm.ShowDialog();  // This will open the form and block the main form
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string status = e.Value.ToString().ToLower();

                if (status == "to do")
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                }
                else if (status == "in progress")
                {
                    e.CellStyle.BackColor = Color.Gray;
                    e.CellStyle.ForeColor = Color.Black;
                }
                else if (status == "completed")
                {
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.White;
                }
            }
        }
    }
}