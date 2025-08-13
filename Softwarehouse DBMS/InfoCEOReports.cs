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
    public partial class InfoCEOReports : Form
    {
        public InfoCEOReports()
        {
            InitializeComponent();
        }

        private void InfoCEOReports_Load(object sender, EventArgs e)
        {
            rtbDescription.Text =
              "📄 Button Guide - Report Page\n\n" +
              "🔍 Search by Report ID:\n" +
              "   - Enter a numeric report ID (e.g., 101, 203).\n" +
              "   - Click the left Search button to view that report’s details.\n\n" +
              "📝 Search by Report Name:\n" +
              "   - Choose a report name from the dropdown menu.\n" +
              "   - Click the right Search button to view matching report(s).\n\n" +
              "📋 Report Display:\n" +
              "   - The large box displays results fetched from your report database.\n" +
              "   - It may show report titles, submission dates, authors, or summaries.\n\n" +
              "🌘 Dark Mode:\n" +
              "   - Enable this checkbox to switch to dark theme instantly.\n\n" +
              "📌 Left Panel Navigation:\n" +
              "   - Task, Employee, Project, Report, and Upload File open their respective modules.\n\n" +
              "🏠 Home & Help Buttons:\n" +
              "   - Top-right icons help with navigation and system info.\n\n" +
              "🕒 Date & Time:\n" +
              "   - Displayed at the bottom as 'lblDateTime' to show current time.";


            chkDarkMode.Checked = ThemeManager.IsDarkMode;
            ThemeManager.ApplyTheme(this);

            // Set default larger font
            rtbDescription.Font = new Font("Segoe UI", 11);

            // Bold headers
            BoldLine("📄 Button Guide - Report Page");
            BoldLine("🔍 Search by Report ID:");
            BoldLine("📝 Search by Report Name:");
            BoldLine("📋 Report Display:");
            BoldLine("🌘 Dark Mode:");
            BoldLine("📌 Left Panel Navigation:");
            BoldLine("🏠 Home & Help Buttons:");
            BoldLine("🕒 Date & Time:");

            // Apply theme
            chkDarkMode.Checked = ThemeManager.IsDarkMode;
            ThemeManager.ApplyTheme(this);
        }

        private void BoldLine(string lineToBold)
        {
            int index = rtbDescription.Text.IndexOf(lineToBold);
            if (index >= 0)
            {
                rtbDescription.Select(index, lineToBold.Length);
                rtbDescription.SelectionFont = new Font(rtbDescription.Font, FontStyle.Bold);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rtbDescription_TextChanged(object sender, EventArgs e)
        {
            ThemeManager.IsDarkMode = chkDarkMode.Checked;

            foreach (Form form in Application.OpenForms)
            {
                ThemeManager.ApplyTheme(form);
            }
        }

        private void chkDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.IsDarkMode = chkDarkMode.Checked;

            foreach (Form openForm in Application.OpenForms)
            {

            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}