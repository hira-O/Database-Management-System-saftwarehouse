using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Softwarehouse_DBMS
{
    public partial class project : Form
    {
        private System.Windows.Forms.Timer timerClock = new System.Windows.Forms.Timer();

        public project()
        {
            InitializeComponent();
            DisplayProjects();
        }
        // readonly
        SqlConnection conn = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PMS.mdf;Integrated Security=True;");

        private void DisplayProjects()
        {
            try
            {
                conn.Open();
                string query = "select * from Projects";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                if (dataGridView1.Columns.Contains("ProNamd"))
                {
                    dataGridView1.Columns["ProName"].Width = 150;
                    dataGridView1.Columns["ProName"].DefaultCellStyle.Format = "f"; // full date/time
                }
                if (dataGridView1.Columns.Contains("ProDesc"))
                {
                    dataGridView1.Columns["ProDesc"].Width = 150;
                    dataGridView1.Columns["ProDesc"].DefaultCellStyle.Format = "f"; // full date/time
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }



        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

            TaskForm taskForm = new TaskForm();
            this.Hide();
            TaskForm.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            this.Hide();
            employees.Show();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            project p = new project();
            p.Show();
            this.Hide();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            this.Hide();
            report.Show();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            LoginForm Loginform = new LoginForm();
            LoginForm.Show();
            this.Close();

        }

        private void project_Load(object sender, EventArgs e)
        {
            ChatPopup popup = new ChatPopup(this); // ✅ Always pass `this` as the parent
            this.Controls.Add(popup); timerClock.Interval = 1000;
            timerClock.Tick += TimerClock_Tick;
            timerClock.Start();
            chkDarkMode.Checked = ThemeManager.IsDarkMode;
            ThemeManager.ApplyTheme(this);
        }
        private void TimerClock_Tick(object? sender, EventArgs e)
        {
            label17.Text = DateTime.Now.ToString("dddd, dd-MM-yyyy hh:mm:ss tt");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "" || textBox1.Text == "" || textBox3.Text == "" || dateTimePicker1.Text == "" || dateTimePicker2.Text == "" || comboBox1.Text == "")
                {
                    MessageBox.Show("Missing Information");

                }
                else
                {
                    conn.Open();
                    string query = "Insert into Projects values('" + textBox2.Text + "','" + textBox1.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Value.Date + "','" + dateTimePicker2.Value.Date + "','" + comboBox1.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record Added Successfully");
                    DisplayProjects();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Enter the Employee ID");

                }
                else
                {
                    conn.Open();
                    string query = "Delete from Projects WHERE ProId='" + textBox2.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record Deleted Successfully");
                    DisplayProjects();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "";
            textBox3.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            comboBox1.Text = "";


        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // First validate and clean your data
            CleanDataGridViewContent();

            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintGrid);

            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDocument;
            previewDialog.ShowDialog();
        }

        private void CleanDataGridViewContent()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                // Clean each cell value
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        // Remove any special characters or formatting issues
                        string cleanValue = Regex.Replace(cell.Value.ToString(), @"[^\w\s\-/.:@#]", "");
                        cell.Value = cleanValue;
                    }
                }
            }
        }

        private void PrintGrid(object sender, PrintPageEventArgs e)
        {
            int leftMargin = 50;
            int topMargin = 100;
            int currentX = leftMargin;
            int currentY = topMargin;
            int rowHeight = 40;
            int padding = 5;

            // Calculate column widths based on content
            int[] columnWidths = new int[dataGridView1.Columns.Count];
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font cellFont = new Font("Arial", 10);
            Brush textBrush = Brushes.Black;
            Pen borderPen = new Pen(Color.Black, 1);

            // Measure column widths
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                // Measure header width
                int headerWidth = (int)e.Graphics.MeasureString(dataGridView1.Columns[j].HeaderText, headerFont).Width + 20;

                // Measure content width for each row
                int contentWidth = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow && row.Cells[j].Value != null)
                    {
                        int cellWidth = (int)e.Graphics.MeasureString(row.Cells[j].Value.ToString(), cellFont).Width + 20;
                        contentWidth = Math.Max(contentWidth, cellWidth);
                    }
                }

                columnWidths[j] = Math.Max(100, Math.Max(headerWidth, contentWidth));
            }

            // Print title
            string title = "PROJECT REPORT";
            SizeF titleSize = e.Graphics.MeasureString(title, new Font("Arial", 16, FontStyle.Bold));
            float titleX = (e.PageBounds.Width - titleSize.Width) / 2;
            e.Graphics.DrawString(title, new Font("Arial", 16, FontStyle.Bold), textBrush, titleX, 40);

            // Print generation date
            string generationOn = "Generated On: " + DateTime.Now.ToString("MM/dd/yyyy");
            e.Graphics.DrawString(generationOn, new Font("Arial", 10, FontStyle.Italic), textBrush, leftMargin, topMargin - 30);

            // Print headers
            currentX = leftMargin;
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, currentX, currentY, columnWidths[j], rowHeight);
                e.Graphics.DrawRectangle(borderPen, currentX, currentY, columnWidths[j], rowHeight);

                // Center the header text
                SizeF headerSize = e.Graphics.MeasureString(dataGridView1.Columns[j].HeaderText, headerFont);
                float headerX = currentX + (columnWidths[j] - headerSize.Width) / 2;
                float headerY = currentY + (rowHeight - headerSize.Height) / 2;

                e.Graphics.DrawString(dataGridView1.Columns[j].HeaderText, headerFont, textBrush, headerX, headerY);
                currentX += columnWidths[j];
            }

            currentY += rowHeight;

            // Print rows
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                currentX = leftMargin;

                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    string cellValue = row.Cells[j].Value?.ToString() ?? "";

                    // Handle text that's too long for the cell
                    if (e.Graphics.MeasureString(cellValue, cellFont).Width > columnWidths[j] - 10)
                    {
                        cellValue = TruncateString(e.Graphics, cellValue, cellFont, columnWidths[j] - 10);
                    }

                    e.Graphics.DrawRectangle(borderPen, currentX, currentY, columnWidths[j], rowHeight);

                    // Adjust text position with padding
                    e.Graphics.DrawString(cellValue, cellFont, textBrush,
                        new RectangleF(currentX + padding, currentY + padding, columnWidths[j] - 2 * padding, rowHeight - 2 * padding));

                    currentX += columnWidths[j];
                }

                currentY += rowHeight;

                // Check for page overflow
                if (currentY + rowHeight > e.PageBounds.Height - 100)
                {
                    e.HasMorePages = true;
                    return;
                }
            }
        }

        private string TruncateString(Graphics g, string value, Font font, float maxWidth)
        {
            if (string.IsNullOrEmpty(value)) return value;

            string truncated = value;
            while (g.MeasureString(truncated + "...", font).Width > maxWidth && truncated.Length > 3)
            {
                truncated = truncated.Substring(0, truncated.Length - 1);
            }

            return truncated + (truncated.Length < value.Length ? "..." : "");
        }


        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            TaskForm taskForm = new TaskForm();
            this.Hide();
            TaskForm.Show();
        }

        private void taskbutton_Click(object sender, EventArgs e)
        {
            Form2 taskForm = new Form2();
            this.Hide();
            taskForm.Show();
        }

        private void employeebutton_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            this.Hide();
            employees.Show();
        }

        private void Projectbutton2_Click(object sender, EventArgs e)
        {
            project projectForm = new project(); // Use PascalCase class name
            this.Hide();
            projectForm.Show();
        }

        private void Reportbutton2_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            this.Hide();
        }

        private void logout2_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void taskbutton2_MouseLeave(object sender, EventArgs e)
        {
            taskbutton2.BackColor = Color.FromArgb(227, 234, 242);
            taskbutton2.ForeColor = Color.FromArgb(104, 120, 143);

        }

        private void taskbutton2_MouseEnter(object sender, EventArgs e)
        {
            taskbutton2.BackColor = Color.FromArgb(11, 47, 82);
            taskbutton2.ForeColor = Color.White;

        }

        private void employeebutton2_MouseEnter(object sender, EventArgs e)
        {
            employeebutton2.BackColor = Color.FromArgb(11, 47, 82);
            employeebutton2.ForeColor = Color.White;

        }

        private void employeebutton2_MouseLeave(object sender, EventArgs e)
        {
            employeebutton2.BackColor = Color.FromArgb(227, 234, 242);
            employeebutton2.ForeColor = Color.FromArgb(104, 120, 143);

        }

        private void Projectbutton2_MouseEnter(object sender, EventArgs e)
        {
            Projectbutton2.BackColor = Color.FromArgb(11, 47, 82);
            Projectbutton2.ForeColor = Color.White;

        }

        private void Projectbutton2_MouseLeave(object sender, EventArgs e)
        {
            Projectbutton2.BackColor = Color.FromArgb(227, 234, 242);
            Projectbutton2.ForeColor = Color.FromArgb(104, 120, 143);

        }

        private void Reportbutton2_MouseEnter(object sender, EventArgs e)
        {
            Reportbutton2.BackColor = Color.FromArgb(11, 47, 82);
            Reportbutton2.ForeColor = Color.White;

        }

        private void Reportbutton2_MouseLeave(object sender, EventArgs e)
        {
            Reportbutton2.BackColor = Color.FromArgb(227, 234, 242);
            Reportbutton2.ForeColor = Color.FromArgb(104, 120, 143);

        }

        private void logout2_MouseEnter(object sender, EventArgs e)
        {
            logout2.BackColor = Color.FromArgb(11, 47, 82);
            logout2.ForeColor = Color.White;

        }

        private void logout2_MouseLeave(object sender, EventArgs e)
        {
            logout2.BackColor = Color.FromArgb(227, 234, 242);
            logout2.ForeColor = Color.FromArgb(104, 120, 143);

        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {

            //button4.BackColor = Color.FromArgb(11, 47, 82);
            //button4.ForeColor = Color.White;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            //button4.BackColor = Color.FromArgb(227, 234, 242);
            //button4.ForeColor = Color.FromArgb(104, 120, 143);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {

            //button3.BackColor = Color.FromArgb(11, 47, 82);
            //button3.ForeColor = Color.White;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            //button3.BackColor = Color.FromArgb(227, 234, 242);
            //button3.ForeColor = Color.FromArgb(104, 120, 143);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {


            //button2.BackColor = Color.FromArgb(11, 47, 82);
            //button2.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            //button2.BackColor = Color.FromArgb(227, 234, 242);
            //button2.ForeColor = Color.FromArgb(104, 120, 143);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            //button1.BackColor = Color.FromArgb(11, 47, 82);
            //button1.ForeColor = Color.White;

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            //button1.BackColor = Color.FromArgb(227, 234, 242);
            //button1.ForeColor = Color.FromArgb(104, 120, 143);

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            employeemainpage mainPage = new employeemainpage(); // must match exact class name
            mainPage.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            chatBot chatForm = new chatBot();
            chatForm.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (InfoProject empForm = new InfoProject())
            {
                empForm.ShowDialog();
            }
            this.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            using (ProjectsDashboard projdashForm = new ProjectsDashboard())
            {
                projdashForm.ShowDialog();
            }
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            UploadForm upfile = new UploadForm(this);
            this.Hide();
            upfile.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string status = e.Value.ToString().ToLower();

                if (status == "to do")
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                }
                else if (status == "in progress")
                {
                    e.CellStyle.BackColor = Color.Gray;
                    e.CellStyle.ForeColor = Color.Black;
                }
                else if (status == "completed")
                {
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.White;
                }
            }

        }
    }
}



