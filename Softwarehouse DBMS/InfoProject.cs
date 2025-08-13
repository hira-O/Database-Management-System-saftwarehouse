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
    public partial class InfoProject : Form
    {
        public InfoProject()
        {
            InitializeComponent();
        }

        private void InfoProject_Load(object sender, EventArgs e)
        {
            rtbDescription.Text =
       "📘 Button Guide - Project Page\n\n" +
       "➕ Add Button:\n" +
       "   - Adds a new project with the provided details like Project ID, Name, Description, Start/End Date, and Status.\n" +
       "\n" +
       "🧹 Clear Button:\n" +
       "   - Clears all the input fields so you can enter new data without manual deletion.\n" +
       "\n" +
       "🗑️ Delete Button:\n" +
       "   - Deletes the project with the entered Project ID.\n" +
       "\n" +
       "🖨️ Print Button:\n" +
       "   - Opens the printer dialog to print the selected project’s details.\n" +
       "\n" +
       "🔙 Back Button:\n" +
       "   - Takes you back to the main page or previous window.\n" +
       "\n" +
       "📅 Start Date / End Date Pickers:\n" +
       "   - Used to select when a project starts and ends.\n" +
       "\n" +
       "📊 Status ComboBox:\n" +
       "   - Select project status (e.g., Pending, In Progress, Completed).\n" +
       "\n" +
       "📋 Project Table (Grid):\n" +
       "   - Displays all added projects in a table format.";

            rtbDescription.Font = new Font("Segoe UI", 11);
            // Bold headers

            BoldLine("📘 Button Guide - Project Page");
            BoldLine("➕ Add Button:");
            BoldLine("🧹 Clear Button:");
            BoldLine("🗑️ Delete Button:");
            BoldLine("🖨️ Print Button:");
            BoldLine("🔙 Back Button:");
            BoldLine("📅 Start Date / End Date Pickers:");
            BoldLine("📊 Status ComboBox:");
            BoldLine("📋 Project Table (Grid):");

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
            this.Close(); // or navigate to main menu
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rtbDescription_TextChanged(object sender, EventArgs e)
        {
            ThemeManager.IsDarkMode = chkDarkMode.Checked;

            foreach (Form openForm in Application.OpenForms)
            {
                ThemeManager.ApplyTheme(openForm);
            }

        }
    }
}
