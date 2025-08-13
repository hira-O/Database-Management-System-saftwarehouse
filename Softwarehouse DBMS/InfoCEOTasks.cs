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
    public partial class InfoCEOTasks : Form
    {
        public InfoCEOTasks()
        {
            InitializeComponent();
        }

        private void InfoCEOTasks_Load(object sender, EventArgs e)
        {
            rtbDescription.Text =
             "🗂️ Button Guide - Task Page\n\n" +
             "🔍 Search by Task ID:\n" +
             "   - Input a valid Task ID (e.g., T001, T145).\n" +
             "   - Click the left Search button to fetch that specific task.\n\n" +
             "📝 Search by Task Name:\n" +
             "   - Choose a task name from the dropdown list.\n" +
             "   - Click the right Search button to view relevant task details.\n\n" +
             "📋 Task Display Area:\n" +
             "   - Results such as task name, status, assigned employee, and deadline will appear here.\n\n" +
             "🌘 Dark Mode:\n" +
             "   - Toggle this to switch the interface to dark theme for better night-time visibility.\n\n" +
             "📌 Left Sidebar:\n" +
             "   - Navigate between modules: Task, Employee, Project, Report, Upload File.\n\n" +
             "🏠 Home Icons:\n" +
             "   - Top bar includes home and help/info buttons for guidance and quick return.\n\n" +
             "🕒 Date & Time:\n" +
             "   - Displayed at the bottom as 'lblDateTime' to show current time.";

            rtbDescription.Font = new Font("Segoe UI", 11);

            BoldLine("🗂 Button Guide - Task Page");
            BoldLine("🔍 Search by Task ID:");
            BoldLine("📝 Search by Task Name:");
            BoldLine("📋 Task Display Area:");
            BoldLine("🌘 Dark Mode:");
            BoldLine("📌 Left Sidebar:");
            BoldLine("🏠 Home Icons:"); 
            BoldLine("🕒 Date & Time:");

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

        private void rtbDescription_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
