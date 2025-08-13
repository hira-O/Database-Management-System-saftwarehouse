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
    public partial class InfoEmployees : Form
    {
        public InfoEmployees()
        {
            InitializeComponent();
        }

        private void InfoEmployee_Load(object sender, EventArgs e)
        {

            //rtbDescription.Text =
            //        "📋 EMPLOYEE MANAGEMENT PAGE OVERVIEW\n\n" +
            //        "🔘 Add Button:\n" +
            //        "Inserts a new employee into the system using the entered ID, name, gender, and phone.\n\n" +
            //        "🧹 Clear Button:\n" +
            //        "Clears all text fields (Employee ID, Name, Phone) and resets Gender dropdown.\n\n" +
            //        "🗑 Delete Button:\n" +
            //        "Removes an employee based on the entered Employee ID.\n\n" +
            //        "🖨 Print Button:\n" +
            //        "Prints or exports the list of employees displayed in the grid.\n\n" +
            //        "📥 Input Fields:\n" +
            //        "- Employee ID\n" +
            //        "- Employee Name\n" +
            //        "- Gender (Dropdown)\n" +
            //        "- Phone Number\n\n" +
            //        "💡 Use this form to keep employee records up to date.";

            //rtbDescription.Font = new Font("Segoe UI", 11);

            //BoldLine("📋 EMPLOYEE MANAGEMENT PAGE OVERVIEW");
            //BoldLine("🔘 Add Button:");
            //BoldLine("🧹 Clear Button:");
            //BoldLine("🗑 Delete Button:");
            //BoldLine("🖨 Print Button:");
            //BoldLine("📥 Input Fields:");
            //BoldLine("💡 Use this form to keep employee records up to date.");

            //chkDarkMode.Checked = ThemeManager.IsDarkMode;
            //ThemeManager.ApplyTheme(this);
        }

        //private void BoldLine(string lineToBold)
        //{
        //    int index = rtbDescription.Text.IndexOf(lineToBold);
        //    if (index >= 0)
        //    {
        //        rtbDescription.Select(index, lineToBold.Length);
        //        rtbDescription.SelectionFont = new Font(rtbDescription.Font, FontStyle.Bold);
        //    }
        //}


        
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rtbDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkdarkMode_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.IsDarkMode = chkDarkMode.Checked;

            foreach (Form openForm in Application.OpenForms)
            {
                ThemeManager.ApplyTheme(openForm);
            }

        }

        private void InfoEmployees_Load(object sender, EventArgs e)
        {
            rtbDescription.Text =
     "📋 EMPLOYEE MANAGEMENT PAGE OVERVIEW\n" +
     "🔘 Add Button:\n" +
     "Inserts a new employee into the system using the entered ID, name, gender, and phone.\n" +
     "🧹 Clear Button:\n" +
     "Clears all text fields (Employee ID, Name, Phone) and resets Gender dropdown.\n" +
     "🗑 Delete Button:\n" +
     "Removes an employee based on the entered Employee ID.\n" +
     "🖨 Print Button:\n" +
     "Prints or exports the list of employees displayed in the grid.\n" +
     "📥 Input Fields:\n" +
     "- Employee ID\n" +
     "- Employee Name\n" +
     "- Gender (Dropdown)\n" +
     "- Phone Number\n" +
     "💡 Use this form to keep employee records up to date.";

            rtbDescription.Font = new Font("Segoe UI", 11);

            BoldLine("📋 EMPLOYEE MANAGEMENT PAGE OVERVIEW");
            BoldLine("🔘 Add Button:");
            BoldLine("🧹 Clear Button:");
            BoldLine("🗑 Delete Button:");
            BoldLine("🖨 Print Button:");
            BoldLine("📥 Input Fields:");
            BoldLine("💡 Use this form to keep employee records up to date.");

            chkDarkMode.Checked = ThemeManager.IsDarkMode;
            ThemeManager.ApplyTheme(this);
            //chkDarkMode.Checked = ThemeManager.IsDarkMode;
            //ThemeManager.ApplyTheme(this);

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


        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
