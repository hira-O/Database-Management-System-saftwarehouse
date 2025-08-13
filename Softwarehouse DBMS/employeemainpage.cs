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

namespace Softwarehouse_DBMS
{
    public partial class employeemainpage : Form
    {
        private System.Windows.Forms.Timer timerClock = new System.Windows.Forms.Timer();

        public employeemainpage()
        {
            InitializeComponent();
        }

        private void employeemainpage_Load(object sender, EventArgs e)
        {

            ChatPopup popup = new ChatPopup(this); // ✅ Always pass `this` as the parent
            this.Controls.Add(popup);

            timerClock.Interval = 1000;
            timerClock.Tick += TimerClock_Tick;
            timerClock.Start();
            chkDarkMode.Checked = ThemeManager.IsDarkMode;
            ThemeManager.ApplyTheme(this);

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\PMS.mdf;Integrated Security=True;";
            // Change to use dbo.Announcements
            string query = "SELECT Title, Message, PostedBy, PostedOn FROM dbo.Announcements ORDER BY PostedOn DESC";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridAnnouncements.DataSource = table;
                    if (dataGridAnnouncements.Columns.Contains("PostedOn"))
                    {
                        dataGridAnnouncements.Columns["PostedOn"].Width = 200;
                        dataGridAnnouncements.Columns["PostedOn"].DefaultCellStyle.Format = "f"; // full date/time
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Announcements: " + ex.Message);
            }
        }
        private void TimerClock_Tick(object? sender, EventArgs e)
        {
            label15.Text = DateTime.Now.ToString("dddd, dd-MM-yyyy hh:mm:ss tt");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void taskbutton_Click(object sender, EventArgs e)
        {
            Form2 taskForm = new Form2();
            this.Hide();
            taskForm.Show();
        }


        private void employeebutton_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            this.Hide();
            employees.Show();
        }

        private void Projectbutton_Click(object sender, EventArgs e)
        {
            project projectForm = new project(); // Use PascalCase class name
            this.Hide();
            projectForm.Show();
        }

        private void Reportbutton_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            this.Hide();
        }

        private void label0_Click(object sender, EventArgs e)
        {


        }

        private void taskbutton_MouseEnter(object sender, EventArgs e)
        {
            taskbutton.BackColor = Color.FromArgb(11, 47, 82);
            taskbutton.ForeColor = Color.White;
            pictureBoxTask.Visible = false; // Hide the PictureBox on hover

        }

        private void taskbutton_MouseLeave(object sender, EventArgs e)
        {
            taskbutton.BackColor = Color.FromArgb(224, 224, 224);
            taskbutton.ForeColor = Color.FromArgb(104, 120, 143);
            pictureBoxTask.Visible = true; // Show the PictureBox when mouse leaves

        }

        private void employeebutton_MouseEnter(object sender, EventArgs e)
        {
            employeebutton.BackColor = Color.FromArgb(11, 47, 82);
            employeebutton.ForeColor = Color.White;
            pictureBoxEmployee.Visible = false;

        }

        private void employeebutton_MouseLeave(object sender, EventArgs e)
        {
            employeebutton.BackColor = Color.FromArgb(224, 224, 224);
            employeebutton.ForeColor = Color.FromArgb(104, 120, 143);
            pictureBoxEmployee.Visible = true;

        }

        private void Projectbutton_MouseEnter(object sender, EventArgs e)
        {
            Projectbutton.BackColor = Color.FromArgb(11, 47, 82);
            Projectbutton.ForeColor = Color.White;
            pictureBoxProject.Visible = false;

        }

        private void Projectbutton_MouseLeave(object sender, EventArgs e)
        {
            Projectbutton.BackColor = Color.FromArgb(224, 224, 224);
            Projectbutton.ForeColor = Color.FromArgb(104, 120, 143);
            pictureBoxProject.Visible = true;

        }

        private void Reportbutton_MouseEnter(object sender, EventArgs e)
        {
            Reportbutton.BackColor = Color.FromArgb(11, 47, 82);
            Reportbutton.ForeColor = Color.White;
            pictureBoxReport.Visible = false;

        }

        private void Reportbutton_MouseLeave(object sender, EventArgs e)
        {
            Reportbutton.BackColor = Color.FromArgb(224, 224, 224);
            Reportbutton.ForeColor = Color.FromArgb(104, 120, 143);
            pictureBoxReport.Visible = true;

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void chkdarkMode_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.IsDarkMode = chkDarkMode.Checked;

            foreach (Form openForm in Application.OpenForms)
            {
                ThemeManager.ApplyTheme(openForm);
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            chatBot chatForm = new chatBot();
            chatForm.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Announcements_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxTask_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxProject_Click(object sender, EventArgs e)
        {

        }
    }
}
