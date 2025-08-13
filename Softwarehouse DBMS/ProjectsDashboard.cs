using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using Microsoft.Data.SqlClient;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Diagnostics;


namespace Softwarehouse_DBMS
{
    public partial class ProjectsDashboard : Form
    {
        private System.Windows.Forms.Timer timerClock = new System.Windows.Forms.Timer();

        private readonly string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\PMS.mdf;Integrated Security=True";
        private System.Windows.Forms.Timer updateTimer = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer timerCounts = new System.Windows.Forms.Timer();

        public ProjectsDashboard()
        {
            InitializeComponent();
            //projectStatusChart.Location = new Point(68, 250); // Move higher
            //this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            //projectStatusChart.Location = new Point(68, 331);
            //projectStatusChart.Size = new Size(653, 349);



        }

        private void ProjectsDashboard_Load(object sender, EventArgs e)
        {
            ChatPopup popup = new ChatPopup(this); // ✅ Always pass `this` as the parent
            this.Controls.Add(popup); timerClock.Interval = 1000;
            timerClock.Tick += TimerClock_Tick;
            timerClock.Start();

            //SetupStatusChart();
            SetupUpdateTimer();
            UpdateProjectCounts(); // Initial load
            timerCounts.Interval = 5000;
            timerCounts.Tick += (s, ev) => UpdateProjectCounts();
            timerCounts.Start();
            chkDarkMode.Checked = ThemeManager.IsDarkMode;
            ThemeManager.ApplyTheme(this);

            // Existing initialization...
            UpdateProjectCounts(); // Load initial counts
        }
        private void TimerClock_Tick(object? sender, EventArgs e)
        {
            label16.Text = DateTime.Now.ToString("dddd, dd-MM-yyyy hh:mm:ss tt");
        }
        //private void SetupStatusChart(DateTime? startDate = null, DateTime? endDate = null)
        //{
            //var statusCounts = GetProjectStatusCounts(startDate, endDate);

            // Debug: Print counts to Immediate Window (Ctrl+G)
            //Debug.WriteLine($"Counts - Completed: {statusCounts["Completed"]}, In Progress: {statusCounts["In Progress"]}, Pending: {statusCounts["Pending"]}");
            //var statusCounts = GetProjectStatusCounts(startDate, endDate);

            //projectStatusChart.Series = Array.Empty<ISeries>();

            //projectStatusChart.Series = new ISeries[]
            //{
            //    new ColumnSeries<int>
            //    {
            //        Values = new[]
            //        {
            //    statusCounts["Completed"],
            //    statusCounts["In Progress"],
            //    statusCounts["Pending"]
            //},
            //        Name = "Projects",
            //        DataLabelsPaint = new SolidColorPaint(SKColors.White),
            //        DataLabelsPosition = LiveChartsCore.Measure.DataLabelsPosition.Middle,
            //        DataLabelsFormatter = point => $"{point.Model}"
            //    };
            //};

            //if (projectStatusChart.XAxes == null || !projectStatusChart.XAxes.Any())
            //{
            //    projectStatusChart.XAxes = new Axis[]
            //    {
            //new Axis
            //{
            //    Labels = new[] { "Completed", "In Progress", "Pending" },
            //    LabelsRotation = 0,
            //    SeparatorsPaint = new SolidColorPaint(SKColors.LightGray)
            //}
            //    };
            //}

            //if (projectStatusChart.YAxes == null || !projectStatusChart.YAxes.Any())
            //{
            //    projectStatusChart.YAxes = new Axis[] { new Axis() };
            //}
        //}


        private Dictionary<string, int> GetProjectStatusCounts(DateTime? startDate = null, DateTime? endDate = null)
        {
            var counts = new Dictionary<string, int>();

            try
            {
                using var conn = new SqlConnection(connStr);
                conn.Open();

                string query = @"
            SELECT Status, COUNT(*) AS Count
            FROM Projects
            WHERE (@StartDate IS NULL OR StartDate >= @StartDate)
              AND (@EndDate IS NULL OR StartDate <= @EndDate)
            GROUP BY Status";

                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StartDate", (object?)startDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@EndDate", (object?)endDate ?? DBNull.Value);

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var status = reader["Status"].ToString();
                    var count = reader["Count"] is DBNull ? 0 : Convert.ToInt32(reader["Count"]);

                    if (!string.IsNullOrEmpty(status))
                    {
                        counts[status] = count;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
            }

            return counts;
        }

        private void SetupUpdateTimer()
        {
            updateTimer.Interval = 30000;
            //updateTimer.Tick += (sender, args) => SetupStatusChart();
            updateTimer.Start();
        }

        private void chkdarkMode_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.IsDarkMode = chkDarkMode.Checked;
            foreach (Form openForm in Application.OpenForms)
            {
                ThemeManager.ApplyTheme(openForm);
            }
        }

        private int GetProjectCount(DateTime? startDate = null, DateTime? endDate = null)
        {
            using var conn = new SqlConnection(connStr);
            conn.Open();

            string query = "SELECT COUNT(*) FROM Projects WHERE 1=1";
            if (startDate.HasValue && endDate.HasValue)
                query += " AND StartDate >= @StartDate AND StartDate <= @EndDate";

            using var cmd = new SqlCommand(query, conn);

            if (startDate.HasValue && endDate.HasValue)
            {
                cmd.Parameters.AddWithValue("@StartDate", startDate.Value);
                cmd.Parameters.AddWithValue("@EndDate", endDate.Value);
            }

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        private int GetStatusCount(string status, DateTime? startDate = null, DateTime? endDate = null)
        {
            using var conn = new SqlConnection(connStr);
            conn.Open();

            string query = "SELECT COUNT(*) FROM Projects WHERE Status = @Status";
            if (startDate.HasValue && endDate.HasValue)
                query += " AND StartDate >= @StartDate AND StartDate <= @EndDate";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Status", status);

            if (startDate.HasValue && endDate.HasValue)
            {
                cmd.Parameters.AddWithValue("@StartDate", startDate.Value);
                cmd.Parameters.AddWithValue("@EndDate", endDate.Value);
            }

            return Convert.ToInt32(cmd.ExecuteScalar());

        }

        private void UpdateProjectCounts(DateTime? startDate = null, DateTime? endDate = null)
        {

            lblTotalProjects.Text = GetProjectCount(startDate, endDate).ToString();
            lblCompleted.Text = GetStatusCount("Completed", startDate, endDate).ToString();
            lblInProgress.Text = GetStatusCount("In Progress", startDate, endDate).ToString();
            lblPending.Text = GetStatusCount("to do", startDate, endDate).ToString();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            chatBot chatForm = new chatBot();
            chatForm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void projectStatusChart_Load(object sender, EventArgs e)
        {

        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {

            DateTime start = dtpStartDate.Value.Date;
            DateTime end = dtpEndDate.Value.Date;

            if (start > end)
            {
                MessageBox.Show("Start date cannot be after end date.");
                return;
            }

            UpdateProjectCounts(start, end);
            //SetupStatusChart(start, end); // ← this refreshes the chart!
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            UpdateProjectCounts();     // Load all project counts
            //SetupStatusChart();        // Load full chart (no filters)
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Manually refresh both counts and chart with no filters
            UpdateProjectCounts();
            //SetupStatusChart();
        }

    }
}
