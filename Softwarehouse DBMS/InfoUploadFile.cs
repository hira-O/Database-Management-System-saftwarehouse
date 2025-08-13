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
    public partial class InfoUploadFile : Form
    {
        private Form _previousForm;  // To hold reference to calling form
        public InfoUploadFile(Form callingForm)
        {
            InitializeComponent();
           
            _previousForm = callingForm;  // Save the reference
        }
       
        private void chkDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.IsDarkMode = chkDarkMode.Checked;

            foreach (Form openForm in Application.OpenForms)
            {
                ThemeManager.ApplyTheme(openForm);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InfoUploadFile_Load(object sender, EventArgs e)
        {
            chkDarkMode.Checked = ThemeManager.IsDarkMode;
            ThemeManager.ApplyTheme(this);

            rtbDescription.Text =
                "📂 Upload Files - Help Guide\n\n" +
                "This section guides you on how to upload and manage project files in the system.\n\n" +

                "🔑 Key Fields:\n" +
                "• 🆔 Upload ID:  Unique ID for the uploaded project.\n" +
                "• 👤 Employee Name:  Name of the uploader.\n" +
                "• 📘 Project Title:  Title or name of the project.\n" +
                "• 🗜️ Project Zip File:  Path of the .zip file to upload.\n\n" +

                "🧭 Buttons & Controls:\n" +
                "• 📁 Browse: Opens a dialog to select a .zip file.\n" +
                "• ⬆️ Upload File:  Uploads the project info and file.\n" +
                "• ⬇️ Download Selected:  Downloads the selected file from the list.\n" +
                "• 📝 File List:  Displays all uploaded project files.\n" +
                "• 🌐 Open GitHub:  Launches GitHub in your browser.\n" +
                "• 🌓 Dark Mode: Toggles light/dark themes.\n" +
                "• 📅 Date & Time: Displays current system date and time.\n";

            rtbDescription.Font = new Font("Segoe UI", 11);

            // Apply bold formatting to headings
            BoldLine("📂 Upload Files - Help Guide");
            BoldLine("🔑 Key Fields:");
            BoldLine("🧭 Buttons & Controls:");

        }

        // Only ONE BoldLine method is defined here
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
    }
}
