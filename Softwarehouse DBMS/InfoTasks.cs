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
    public partial class InfoTasks : Form
    {
        public InfoTasks()
        {
            InitializeComponent();
        }

        private void InfoTasks_Load(object sender, EventArgs e)
        {
            rtbDescription.Text =
            "📝 Task Management Module Overview\n\n" +
            "This section allows administrators to manage project-related tasks effectively.\n\n" +
            "🔧 Core Functionalities:\n" +
            "• 🆔 Assign tasks to employees with unique Task ID & Project ID\n" +
            "• 📌 Set Task Name and due dates\n" +
            "• 👤 Allocate responsibility (Assigned To)\n" +
            "• 📅 Monitor Task Status (e.g., Pending, In Progress, Completed)\n\n" +
            "🛠 Buttons & Actions:\n" +
            "• ➕ Add: Saves a new task into the system with the entered details\n" +
            "• 🔄 Clear: Resets all input fields to blank/default state\n" +
            "• ❌ Delete: Removes the selected task from the record\n" +
            "• 🖨 Print: Generates a printable version of the task list for reporting or documentation\n\n" +
            "💡 Use this module to ensure each team member knows their responsibilities and deadlines!";

            rtbDescription.Font = new Font("Segoe UI", 11);

            // Bold headings
            BoldLine("📝 Task Management Module Overview");
            BoldLine("🔧 Core Functionalities:");
            BoldLine("🛠 Buttons & Actions:");

            chkDarkMode.Checked = ThemeManager.IsDarkMode;
            ThemeManager.ApplyTheme(this);
        }

        private void BoldLine(string text)
        {
            int idx = rtbDescription.Text.IndexOf(text);
            if (idx >= 0)
            {
                rtbDescription.Select(idx, text.Length);
                rtbDescription.SelectionFont = new Font(rtbDescription.Font, FontStyle.Bold);
                rtbDescription.SelectionColor = Color.DarkBlue;
                rtbDescription.DeselectAll();
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
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

        private void rtbDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
