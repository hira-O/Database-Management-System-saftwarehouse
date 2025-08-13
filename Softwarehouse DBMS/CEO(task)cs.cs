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
    public partial class CEO_task_cs : Form
    {
        private System.Windows.Forms.Timer timerClock = new System.Windows.Forms.Timer();
        public CEO_task_cs()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PMS.mdf;Integrated Security=True;");

        private void DisplayAllTasks()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM Tasks";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tasks: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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
            LoginForm Loginform = new LoginForm();
            LoginForm.Show();
            this.Close();

        }

        private void CEO_task_cs_Load(object sender, EventArgs e)
        {
            DisplayAllTasks();
            timerClock.Interval = 1000;
            timerClock.Tick += TimerClock_Tick;
            timerClock.Start();
            chkDarkMode.Checked = ThemeManager.IsDarkMode;
            ThemeManager.ApplyTheme(this);
        }
        private void TimerClock_Tick(object? sender, EventArgs e)
        {
            label14.Text = DateTime.Now.ToString("dddd, dd-MM-yyyy hh:mm:ss tt");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void taskbuttonceo4_Click(object sender, EventArgs e)
        {
            CEO_task_cs CEO_task_cs = new CEO_task_cs();
            this.Hide();
            CEO_task_cs.Show();
        }

        private void employeebuttonceo4_Click(object sender, EventArgs e)
        {
            CEO_emplyee_ CEO_emplyee_ = new CEO_emplyee_();
            this.Hide();
            CEO_emplyee_.Show();
        }

        private void Reportbuttonceo4_Click(object sender, EventArgs e)
        {

            CEO_report_ CEO_report_ = new CEO_report_();
            this.Hide();
            CEO_report_.Show();
        }

        private void Projectbuttonceo4_Click(object sender, EventArgs e)
        {
            CEO_project_ CEO_project_ = new CEO_project_();
            this.Hide();
            CEO_project_.Show();
        }

        private void logoutceo4_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void taskbuttonceo4_MouseEnter(object sender, EventArgs e)
        {
            taskbuttonceo4.BackColor = Color.FromArgb(11, 47, 82);
            taskbuttonceo4.ForeColor = Color.White;

        }

        private void taskbuttonceo4_MouseLeave(object sender, EventArgs e)
        {
            taskbuttonceo4.BackColor = Color.FromArgb(227, 234, 242);
            taskbuttonceo4.ForeColor = Color.FromArgb(104, 120, 143);

        }

        private void employeebuttonceo4_MouseEnter(object sender, EventArgs e)
        {

            employeebuttonceo4.BackColor = Color.FromArgb(11, 47, 82);
            employeebuttonceo4.ForeColor = Color.White;
        }

        private void employeebuttonceo4_MouseLeave(object sender, EventArgs e)
        {
            employeebuttonceo4.BackColor = Color.FromArgb(227, 234, 242);
            employeebuttonceo4.ForeColor = Color.FromArgb(104, 120, 143);
        }

        private void Projectbuttonceo4_MouseEnter(object sender, EventArgs e)
        {

            Projectbuttonceo4.BackColor = Color.FromArgb(11, 47, 82);
            Projectbuttonceo4.ForeColor = Color.White;
        }

        private void Projectbuttonceo4_MouseLeave(object sender, EventArgs e)
        {
            Projectbuttonceo4.BackColor = Color.FromArgb(227, 234, 242);
            Projectbuttonceo4.ForeColor = Color.FromArgb(104, 120, 143);
        }

        private void Reportbuttonceo4_MouseLeave(object sender, EventArgs e)
        {
            Reportbuttonceo4.BackColor = Color.FromArgb(227, 234, 242);
            Reportbuttonceo4.ForeColor = Color.FromArgb(104, 120, 143);
        }

        private void Reportbuttonceo4_MouseEnter(object sender, EventArgs e)
        {

            Reportbuttonceo4.BackColor = Color.FromArgb(11, 47, 82);
            Reportbuttonceo4.ForeColor = Color.White;
        }

        private void logoutceo4_MouseEnter(object sender, EventArgs e)
        {

            logoutceo4.BackColor = Color.FromArgb(11, 47, 82);
            logoutceo4.ForeColor = Color.White;
        }

        private void logoutceo4_MouseLeave(object sender, EventArgs e)
        {
            logoutceo4.BackColor = Color.FromArgb(227, 234, 242);
            logoutceo4.ForeColor = Color.FromArgb(104, 120, 143);
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
            using (TaskDashboard tskdashForm = new TaskDashboard())
            {
                tskdashForm.ShowDialog();
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
            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Tasks WHERE TaskId = @TaskId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TaskId", textBox2.Text.Trim());
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Search error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                DisplayAllTasks();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Tasks WHERE TName = @TName";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TName", textBox1.Text.Trim());
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Search error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                DisplayAllTasks();
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            using (InfoCEOTasks empForm = new InfoCEOTasks())
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
       