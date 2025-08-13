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
    public partial class InfoReports : Form
    {
        public InfoReports()
        {
            InitializeComponent();
        }

        private void InfoReports_Load(object sender, EventArgs e)
        {
            rtbDescription.Text =
                 "📄 Report Management Module Overview\n\n" +
                 "This section provides detailed insights into how reports are managed within the software.\n\n" +
                 "🔧 Core Functionalities:\n" +
                 "• 🆕 Add a new project report\n" +
                 "• 📊 Track Total Tasks assigned to the project\n" +
                 "• ✅ Record Completed Tasks\n" +
                 "• ⏳ View Pending Tasks\n" +
                 "• 🗓 Store the exact date the report was generated\n\n" +
                 "🛠 Buttons & Actions:\n" +
                 "• ➕ Add: Save a new report entry\n" +
                 "• 🔄 Clear: Reset the input fields\n" +
                 "• ❌ Delete: Remove a report\n" +
                 "• 🖨 Print: Generate a physical or PDF report\n\n" +
                 "💡 Use this page to get a summarized view of project performance and ensure deadlines are being met effectively!";

            rtbDescription.Font = new Font("Segoe UI", 11);

            // Apply bold formatting to headings
            BoldLine("📄 Report Management Module Overview");
            BoldLine("🔧 Core Functionalities:");
            BoldLine("🛠 Buttons & Actions:");

            // Set Dark Mode checkbox state and apply theme
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
