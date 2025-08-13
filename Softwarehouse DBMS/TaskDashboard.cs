using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using System.Data;
using Microsoft.Data.SqlClient;


namespace Softwarehouse_DBMS
{
    public partial class TaskDashboard : Form
    {
        private System.Windows.Forms.Timer timerClock = new System.Windows.Forms.Timer();
        private readonly string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\PMS.mdf;Integrated Security=True";

        public TaskDashboard()
        {
            InitializeComponent();
        }
        private void LoadEmployees()
        {
            cmbEmployees.Items.Clear();
            cmbEmployees.Items.Add("All Employees"); // Default option

            try
            {
                using var conn = new SqlConnection(connStr);
                conn.Open();

                const string query = "SELECT DISTINCT AssignedTo FROM Tasks WHERE AssignedTo IS NOT NULL";
                using var cmd = new SqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbEmployees.Items.Add(reader["AssignedTo"].ToString());
                }

                cmbEmployees.SelectedIndex = 0; // Select "All Employees" by default
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message);
            }
        }

        private void TaskDashboard_Load(object sender, EventArgs e)
        {
            ChatPopup popup = new ChatPopup(this); // ✅ Always pass `this` as the parent
            this.Controls.Add(popup); chkDarkMode.Checked = ThemeManager.IsDarkMode;
            ThemeManager.ApplyTheme(this);
            timerClock.Interval = 1000;
            timerClock.Tick += TimerClock_Tick;
            timerClock.Start();

            LoadEmployees(); // Add this line to load employees when form opens

            var taskCounts = GetTaskStatusCounts();

            lblTotalTasks.Text = taskCounts["Total"].ToString();
            lblCompletedTasks.Text = taskCounts["Completed"].ToString();
            lblInProgressTasks.Text = taskCounts["In Progress"].ToString();
            lblPendingTasks.Text = taskCounts["To Do"].ToString();


        }
        private void TimerClock_Tick(object? sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("dddd, dd-MM-yyyy hh:mm:ss tt");
        }
        private void chkdarkMode_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.IsDarkMode = chkDarkMode.Checked;

            foreach (Form openForm in Application.OpenForms)
            {
                ThemeManager.ApplyTheme(openForm);
            }

        }

        private Dictionary<string, int> GetTaskStatusCounts(string employee = null)
        {
            var counts = new Dictionary<string, int>
            {
                ["Total"] = 0,
                ["Completed"] = 0,
                ["In Progress"] = 0,
                ["To Do"] = 0
            };

            try
            {
                using var conn = new SqlConnection(connStr);
                conn.Open();

                string query = "SELECT Status, COUNT(*) AS Count FROM Tasks WHERE 1=1";

                if (!string.IsNullOrEmpty(employee) && employee != "All Employees")
                {
                    query += " AND AssignedTo = @Employee";
                }

                query += " GROUP BY Status";

                using var cmd = new SqlCommand(query, conn);

                if (!string.IsNullOrEmpty(employee) && employee != "All Employees")
                {
                    cmd.Parameters.AddWithValue("@Employee", employee);
                }

                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var status = reader["Status"].ToString().ToLower();
                    var count = Convert.ToInt32(reader["Count"]);

                    switch (status)
                    {
                        case "completed":
                            counts["Completed"] = count;
                            break;
                        case "in progress":
                            counts["In Progress"] = count;
                            break;
                        case "to do":
                            counts["To Do"] = count;
                            break;
                    }

                    counts["Total"] += count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading task data: " + ex.Message);
            }

            return counts;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            chatBot chatForm = new chatBot();
            chatForm.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedEmployee = cmbEmployees.SelectedItem?.ToString();
            var taskCounts = GetTaskStatusCounts(selectedEmployee);

            lblTotalTasks.Text = taskCounts["Total"].ToString();
            lblCompletedTasks.Text = taskCounts["Completed"].ToString();
            lblInProgressTasks.Text = taskCounts["In Progress"].ToString();
            lblPendingTasks.Text = taskCounts["To Do"].ToString();
        }
    }
}
