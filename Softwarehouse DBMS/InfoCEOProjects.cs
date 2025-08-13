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
    public partial class InfoCEOProjects : Form
    {
        public InfoCEOProjects()
        {
            InitializeComponent();
        }

        private void InfoCEOProjects_Load(object sender, EventArgs e)
        {
            rtbDescription.Text =
   "📁 Button Guide - Project Page\n" +
   "🔍 Search by Project Name:\n" +
   "   - Enter the exact or partial project name.\n" +
   "   - Click the left Search button to display matching records.\n" +
   "📈 Search by Progress:\n" +
   "   - Choose a progress status from the dropdown (e.g., Ongoing, Completed).\n" +
   "   - Click the right Search button to filter projects by status.\n" +
   "📊 Project Table:\n" +
   "   - Shows project details including ID, Name, Status, Start & End Dates.\n" +
   "🌗 Dark Mode:\n" +
   "   - Toggle to switch between dark and light themes instantly.\n" +
   "🏠 Home Button:\n" +
   "   - Click to return to the dashboard or main panel view.\n" +
   "🕒 Date & Time:\n" +
   "   - Displayed at the bottom as 'lblDateTime' to show current time.";


            rtbDescription.Font = new Font("Segoe UI", 11);

            // Bold headers
            BoldLine("📁 Button Guide - Project Page");
            BoldLine("🔍 Search by Project Name:");
            BoldLine("📈 Search by Progress:");
            BoldLine("📊 Project Table:");
            BoldLine("🌗 Dark Mode:");
            BoldLine("🏠 Home Button:");
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
                rtbDescription.SelectionCharOffset = 0; // <- prevents line shift
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Optional: Navigate to home screen if required
        }

        private void rtbDescription_TextChanged(object sender, EventArgs e)
        {
            ThemeManager.IsDarkMode = chkDarkMode.Checked;

            foreach (Form openForm in Application.OpenForms)
            {
                ThemeManager.ApplyTheme(openForm);
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