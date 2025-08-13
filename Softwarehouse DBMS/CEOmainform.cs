using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace Softwarehouse_DBMS
{


    public partial class CEOmainform : Form
    {
        private System.Windows.Forms.Timer timerClock = new System.Windows.Forms.Timer();

        public CEOmainform()
        {
            InitializeComponent();


        }

        private void taskbuttonceo_Click(object sender, EventArgs e)
        {
            CEO_task_cs CEO_task_cs = new CEO_task_cs();
            this.Hide();
            CEO_task_cs.Show();
        }

        private void employeebuttonceo_Click(object sender, EventArgs e)
        {
            CEO_emplyee_ CEO_emplyee_ = new CEO_emplyee_();
            this.Hide();
            CEO_emplyee_.Show();
        }

        private void Projectbuttonceo_Click(object sender, EventArgs e)
        {
            CEO_project_ CEO_project_ = new CEO_project_();
            this.Hide();
            CEO_project_.Show();
        }

        private void Reportbuttonceo_Click(object sender, EventArgs e)
        {
            CEO_report_ CEO_report_ = new CEO_report_();
            this.Hide();
            CEO_report_.Show();
        }

        private void CEOmainform_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            timerClock.Interval = 1000;
            timerClock.Tick += TimerClock_Tick;
            timerClock.Start();
            chkDarkMode.Checked = ThemeManager.IsDarkMode;
            ThemeManager.ApplyTheme(this);

            
            EnsureAnnouncementsTableExists();

        }

        private void EnsureAnnouncementsTableExists()
        {
            string createTableQuery = @"
    IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Announcements')
    BEGIN
        CREATE TABLE [dbo].[Announcements] (
            [AnnouncementId] INT IDENTITY(1,1) PRIMARY KEY,
            [Title] VARCHAR(100) NOT NULL,
            [Message] TEXT NULL,
            [PostedBy] VARCHAR(50) NOT NULL,
            [PostedOn] DATETIME DEFAULT GETDATE() NOT NULL
        )
    END";

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PMS.mdf;Integrated Security=True;"))
                {
                    SqlCommand cmd = new SqlCommand(createTableQuery, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating announcements table: {ex.Message}");
            }
        }


        private void TimerClock_Tick(object? sender, EventArgs e)
        {
            label0.Text = DateTime.Now.ToString("dddd, dd-MM-yyyy hh:mm:ss tt");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void taskbuttonceo_MouseEnter(object sender, EventArgs e)
        {
            taskbuttonceo.BackColor = Color.FromArgb(11, 47, 82);
            taskbuttonceo.ForeColor = Color.White;
            pictureBox5.Visible = false; // Hide the PictureBox on hover
        }

        private void taskbuttonceo_MouseLeave(object sender, EventArgs e)
        {
            taskbuttonceo.BackColor = Color.FromArgb(227, 234, 242);
            taskbuttonceo.ForeColor = Color.FromArgb(104, 120, 143);
            pictureBox5.Visible = true; // Show the PictureBox when mouse leaves
        }

        private void employeebuttonceo_MouseEnter(object sender, EventArgs e)
        {
            employeebuttonceo.BackColor = Color.FromArgb(11, 47, 82);
            employeebuttonceo.ForeColor = Color.White;
            pictureBox6.Visible = false;
        }

        private void employeebuttonceo_MouseLeave(object sender, EventArgs e)
        {
            employeebuttonceo.BackColor = Color.FromArgb(227, 234, 242);
            employeebuttonceo.ForeColor = Color.FromArgb(104, 120, 143);
            pictureBox6.Visible = true;
        }

        private void Projectbuttonceo_MouseEnter(object sender, EventArgs e)
        {
            Projectbuttonceo.BackColor = Color.FromArgb(11, 47, 82);
            Projectbuttonceo.ForeColor = Color.White;
            pictureBox4.Visible = false;
        }

        private void Projectbuttonceo_MouseLeave(object sender, EventArgs e)
        {
            Projectbuttonceo.BackColor = Color.FromArgb(227, 234, 242);
            Projectbuttonceo.ForeColor = Color.FromArgb(104, 120, 143);
            pictureBox4.Visible = true;
        }

        private void Reportbuttonceo_MouseEnter(object sender, EventArgs e)
        {
            Reportbuttonceo.BackColor = Color.FromArgb(11, 47, 82);
            Reportbuttonceo.ForeColor = Color.White;
            pictureBox7.Visible = false;
        }

        private void Reportbuttonceo_MouseLeave(object sender, EventArgs e)
        {
            Reportbuttonceo.BackColor = Color.FromArgb(227, 234, 242);
            Reportbuttonceo.ForeColor = Color.FromArgb(104, 120, 143);
            pictureBox7.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.IsDarkMode = chkDarkMode.Checked;

            foreach (Form openForm in Application.OpenForms)
            {
                ThemeManager.ApplyTheme(openForm);
            }

        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            // Collect inputs
            string title = txtTitle.Text.Trim();
            string message = txtMessage.Text.Trim();
            string postedBy = "CEO"; // You can replace this with logged-in user if needed
            DateTime postedOn = DateTime.Now;

            // Connection string to your database
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\PMS.mdf;Integrated Security=True;";

            // SQL Insert query
            string query = "INSERT INTO dbo.Announcements (Title, Message, PostedBy, PostedOn) VALUES (@Title, @Message, @PostedBy, @PostedOn)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@Title", title);
                        cmd.Parameters.AddWithValue("@Message", message);
                        cmd.Parameters.AddWithValue("@PostedBy", postedBy);
                        cmd.Parameters.AddWithValue("@PostedOn", postedOn);

                        // Open connection and execute
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Announcement posted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Optionally clear the form
                        txtTitle.Clear();
                        txtMessage.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
