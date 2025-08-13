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
    public partial class InfoCEOEmp : Form
    {
        public InfoCEOEmp()
        {
            InitializeComponent();
        }

        private void InfoCEOEmp_Load(object sender, EventArgs e)
        {
            rtbDescription.Text =
              "📁 Button Guide - Employee Page\n\n" +
                "🔍 Search by Employee ID:\n" +
                "   - Enter the Employee ID and click Search to retrieve employee details.\n\n" +
                "🔍 Search by Employee Name:\n" +
                "   - Enter the name of the employee and click Search to view the matching employee records.\n\n" +
                "📋 Employee Table (Grid):\n" +
                "   - Displays employee information like ID, Name, Role, Department, and Join Date.\n\n" +
                //"🏠 Home Icon:\n" +
                //"   - Click to return to the dashboard or home screen.\n\n"+
                // "🌗 Dark Mode:\n" +
                //"   - Toggle to switch between light and dark themes.\n\n" +
                "📌 Sidebar Navigation:\n" +
                "   - Click 'Task', 'Project', or 'Report' to navigate to other modules.\n\n" +
                "🌘 Dark Mode:\n" +
                "   - Toggle this to switch the interface to dark theme for better night-time visibility.\n\n" +
                "🏠 Home Button:\n" +
                   "   - Click to return to the dashboard or main panel view.\n" +
                "🕒 Date & Time:\n" +
                "   - Displayed at the bottom as 'lblDateTime' to show current time.";
            // Apply base font size
            rtbDescription.Font = new Font("Segoe UI", 11);

            chkDarkMode.Checked = ThemeManager.IsDarkMode;
            ThemeManager.ApplyTheme(this);


            // Bold key headers
            BoldLine("📁 Button Guide - Employee Page");
            BoldLine("🔍 Search by Employee ID:");
            BoldLine("🔍 Search by Employee Name:");
            BoldLine("📋 Employee Table (Grid):");
            //BoldLine("🏠 Home Icon:");
            //BoldLine("🌗 Dark Mode:");
            BoldLine("📌 Sidebar Navigation:");
            BoldLine("🌗 Dark Mode:");
            BoldLine("🕒 Date & Time:");
            ;
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
            this.Close(); // Or navigate to main dashboard
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