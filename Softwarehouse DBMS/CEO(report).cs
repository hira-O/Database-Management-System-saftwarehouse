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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Softwarehouse_DBMS
{
    public partial class CEO_report_ : Form
    {
        private System.Windows.Forms.Timer timerClock = new System.Windows.Forms.Timer();
        public CEO_report_()
        {
            InitializeComponent();
        }
        private void LoadAllReports()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PMS.mdf;Integrated Security=True;"))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Reports";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading reports: " + ex.Message);
                }
            }
        }
        private void LoadProjectIDs()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PMS.mdf;Integrated Security=True;"))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ProId FROM Projects";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    comboBox2.Items.Clear();
                    while (reader.Read())
                    {
                        comboBox2.Items.Add(reader["ProId"].ToString());
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading project IDs: " + ex.Message);
                }
            }
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

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void taskbuttonceo3_Click(object sender, EventArgs e)
        {
            CEO_task_cs CEO_task_cs = new CEO_task_cs();
            this.Hide();
            CEO_task_cs.Show();
        }

        private void employeebuttonceo3_Click(object sender, EventArgs e)
        {
            CEO_emplyee_ CEO_emplyee_ = new CEO_emplyee_();
            this.Hide();
            CEO_emplyee_.Show();
        }

        private void Projectbuttonceo3_Click(object sender, EventArgs e)
        {
            CEO_project_ CEO_project_ = new CEO_project_();
            this.Hide();
            CEO_project_.Show();
        }

        private void Reportbuttonceo3_Click(object sender, EventArgs e)
        {
            CEO_report_ CEO_report_ = new CEO_report_();
            this.Hide();
            CEO_report_.Show();
        }

        private void logoutceo3_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void CEO_report__Load(object sender, EventArgs e)
        {
            LoadProjectIDs();
            LoadAllReports();
            timerClock.Interval = 1000;
            timerClock.Tick += TimerClock_Tick;
            timerClock.Start();
            chkDarkMode.Checked = ThemeManager.IsDarkMode;
            ThemeManager.ApplyTheme(this);
        }
        private void TimerClock_Tick(object? sender, EventArgs e)
        {
            label13.Text = DateTime.Now.ToString("dddd, dd-MM-yyyy hh:mm:ss tt");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string reportId = textBox2.Text.Trim();
            if (string.IsNullOrEmpty(reportId))
            {
                MessageBox.Show("Please enter a Report ID.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PMS.mdf;Integrated Security=True;"))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Reports WHERE RId = @RId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@RId", reportId);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching by Report ID: " + ex.Message);
                }
            }
        }

        private void taskbuttonceo3_MouseEnter(object sender, EventArgs e)
        {
            taskbuttonceo3.BackColor = Color.FromArgb(11, 47, 82);
            taskbuttonceo3.ForeColor = Color.White;

        }

        private void taskbuttonceo3_MouseLeave(object sender, EventArgs e)
        {

            taskbuttonceo3.BackColor = Color.FromArgb(227, 234, 242);
            taskbuttonceo3.ForeColor = Color.FromArgb(104, 120, 143);


        }

        private void employeebuttonceo3_MouseEnter(object sender, EventArgs e)
        {
            employeebuttonceo3.BackColor = Color.FromArgb(11, 47, 82);
            employeebuttonceo3.ForeColor = Color.White;

        }

        private void employeebuttonceo3_MouseLeave(object sender, EventArgs e)
        {
            employeebuttonceo3.BackColor = Color.FromArgb(227, 234, 242);
            employeebuttonceo3.ForeColor = Color.FromArgb(104, 120, 143);


        }

        private void Projectbuttonceo3_MouseEnter(object sender, EventArgs e)
        {
            Projectbuttonceo3.BackColor = Color.FromArgb(11, 47, 82);
            Projectbuttonceo3.ForeColor = Color.White;

        }

        private void Projectbuttonceo3_MouseLeave(object sender, EventArgs e)
        {
            Projectbuttonceo3.BackColor = Color.FromArgb(227, 234, 242);
            Projectbuttonceo3.ForeColor = Color.FromArgb(104, 120, 143);
        }

        private void logoutceo3_MouseEnter(object sender, EventArgs e)
        {
            logoutceo3.BackColor = Color.FromArgb(11, 47, 82);
            logoutceo3.ForeColor = Color.White;

        }

        private void logoutceo3_MouseLeave(object sender, EventArgs e)
        {
            logoutceo3.BackColor = Color.FromArgb(227, 234, 242);
            logoutceo3.ForeColor = Color.FromArgb(104, 120, 143);
        }

        private void Reportbuttonceo3_MouseEnter(object sender, EventArgs e)
        {
            Reportbuttonceo3.BackColor = Color.FromArgb(11, 47, 82);
            Reportbuttonceo3.ForeColor = Color.White;
        }

        private void Reportbuttonceo3_MouseLeave(object sender, EventArgs e)
        {
            Reportbuttonceo3.BackColor = Color.FromArgb(227, 234, 242);
            Reportbuttonceo3.ForeColor = Color.FromArgb(104, 120, 143);
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

        private void button6_Click(object sender, EventArgs e)
        {
            UploadForm upfile = new UploadForm(this);
            this.Hide();
            upfile.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select a Project ID.");
                return;
            }

            string selectedProjectId = comboBox2.SelectedItem.ToString();

            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PMS.mdf;Integrated Security=True;"))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Reports WHERE PId = @PId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PId", selectedProjectId);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching by Project ID: " + ex.Message);
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            using (InfoCEOReports empForm = new InfoCEOReports())
            {
                empForm.ShowDialog();  // This will open the form and block the main form
            }
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
    }
}
        
