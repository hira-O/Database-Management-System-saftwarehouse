using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace Softwarehouse_DBMS
    
{
    public partial class Employees : Form
    {
        private System.Windows.Forms.Timer timerClock = new System.Windows.Forms.Timer();

        public Employees()
        {
            InitializeComponent();
            DisplayEmp();
        }
        readonly SqlConnection conn = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PMS.mdf;Integrated Security=True;");

        private void DisplayEmp()
        {
            try
            {
                conn.Open();
                string query = "select * from Employees";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                if (dataGridView1.Columns.Contains("EmpName"))
                {
                    dataGridView1.Columns["EmpName"].Width = 150;
                    dataGridView1.Columns["EmpName"].DefaultCellStyle.Format = "f"; // full date/time
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
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Employees_Load(object sender, EventArgs e)
        {
            ChatPopup popup = new ChatPopup(this); // ✅ Always pass `this` as the parent
            this.Controls.Add(popup); timerClock.Interval = 1000;
            timerClock.Tick += TimerClock_Tick;
            timerClock.Start();
            chkDarkMode.Checked = ThemeManager.IsDarkMode;
            ThemeManager.ApplyTheme(this);
            //LoadData();
            //LoadUploads();

         

        }
        private void TimerClock_Tick(object? sender, EventArgs e)
        {
            label16.Text = DateTime.Now.ToString("dddd, dd-MM-yyyy hh:mm:ss tt");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            TaskForm taskForm = new TaskForm();
            this.Hide();
            TaskForm.Show();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            this.Hide();

        }

        private void btnproject_Click(object sender, EventArgs e)
        {
            project projectForm = new project(); // Use PascalCase class name
            this.Hide();
            projectForm.Show();
        }

        /*private void btnproject_Click(object sender, EventArgs e)
        {
            project project = new project();
            this.Hide();
            project.Show();

        }*/

        private void btnemployee_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            this.Hide();
            employees.Show();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            LoginForm Loginform = new LoginForm();
            LoginForm.Show();
            this.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "" || textBox1.Text == "" || comboBox2.Text == "" || textBox7.Text == "")
                {
                    MessageBox.Show("Missing Information");

                }
                else
                {
                    conn.Open();
                    string query = "Insert into Employees values('" + textBox2.Text + "','" + textBox1.Text + "','" + comboBox2.SelectedItem.ToString() + "','" + textBox7.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record Added Successfully");
                    DisplayEmp();
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
                    string query = "Delete from employees where EmpId='" + textBox2.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record Deleted Successfully");
                    DisplayEmp();
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
            comboBox2.Text = "";
            textBox7.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintGrid);
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            {
                //Document = printDocument
                previewDialog.Document = printDocument;
            }
            ;
            previewDialog.ShowDialog();
        }
        private void PrintGrid(object sender, PrintPageEventArgs e)
        {
            int x = 50, y = 100;
            int cellHeight = 40;
            int[] columnWidths = new int[dataGridView1.Columns.Count];

            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font tableFont = new Font("Arial", 10);
            Brush brush = Brushes.Black;
            Pen pen = new Pen(Color.Black, 1);
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                columnWidths[j] = Math.Max(100, (int)e.Graphics.MeasureString(dataGridView1.Columns[j].HeaderText, headerFont).Width + 20);

            }
            string title = "PROJECT REPORT";
            SizeF titleSize = e.Graphics.MeasureString(title, new Font("Arial", 16, FontStyle.Bold));
            float titleX = (e.PageBounds.Width - titleSize.Width) / 2;
            e.Graphics.DrawString(title, new Font("Arial", 16, FontStyle.Bold), brush, titleX, 40);

            string generationOn = "Generated On: " + DateTime.Now.ToString("MM/dd/yyyy");
            e.Graphics.DrawString(generationOn, new Font("Arial", 10, FontStyle.Italic), brush, x, y - 30);

            // int tempX = x;
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, x, y, columnWidths[j], cellHeight);
                e.Graphics.DrawRectangle(pen, x, y, columnWidths[j], cellHeight);
                e.Graphics.DrawString(dataGridView1.Columns[j].HeaderText, headerFont, brush, x + 5, y + 10);
                x += columnWidths[j];

            }
            y += cellHeight;
            x = 50;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].IsNewRow) continue;

                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    string value = dataGridView1.Rows[i].Cells[j].Value?.ToString() ?? "";
                    e.Graphics.DrawRectangle(pen, x, y, columnWidths[j], cellHeight);
                    e.Graphics.DrawString(value, tableFont, brush, x + 5, y + 10);
                    x += columnWidths[j];
                }

                y += cellHeight;
                x = 50;
            }
        }


        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                comboBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox7.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void taskbutton1_Click(object sender, EventArgs e)
        {

            Form2 taskForm = new Form2();
            this.Hide();
            taskForm.Show();
        }

        private void employeebutton1_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            this.Hide();
            employees.Show();
        }

        private void Projectbutton1_Click(object sender, EventArgs e)
        {
            project projectForm = new project(); // Use PascalCase class name
            this.Hide();
            projectForm.Show();
        }

        private void Reportbutton_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logout1_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void taskbutton1_MouseEnter(object sender, EventArgs e)
        {
            taskbutton1.BackColor = Color.FromArgb(11, 47, 82);
            taskbutton1.ForeColor = Color.White;

        }

        private void taskbutton1_MouseLeave(object sender, EventArgs e)
        {
            taskbutton1.BackColor = Color.FromArgb(227, 234, 242);
            taskbutton1.ForeColor = Color.FromArgb(104, 120, 143);

        }

        private void employeebutton1_MouseEnter(object sender, EventArgs e)
        {
            employeebutton1.BackColor = Color.FromArgb(11, 47, 82);
            employeebutton1.ForeColor = Color.White;

        }

        private void employeebutton1_MouseLeave(object sender, EventArgs e)
        {
            employeebutton1.BackColor = Color.FromArgb(227, 234, 242);
            employeebutton1.ForeColor = Color.FromArgb(104, 120, 143);

        }

        private void Projectbutton1_MouseEnter(object sender, EventArgs e)
        {
            Projectbutton1.BackColor = Color.FromArgb(11, 47, 82);
            Projectbutton1.ForeColor = Color.White;

        }

        private void Projectbutton1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void Reportbutton_MouseEnter(object sender, EventArgs e)
        {
            Reportbutton.BackColor = Color.FromArgb(11, 47, 82);
            Reportbutton.ForeColor = Color.White;

        }

        private void Reportbutton_MouseLeave(object sender, EventArgs e)
        {
            Reportbutton.BackColor = Color.FromArgb(227, 234, 242);
            Reportbutton.ForeColor = Color.FromArgb(104, 120, 143);

        }

        private void logout1_MouseEnter(object sender, EventArgs e)
        {
            logout1.BackColor = Color.FromArgb(11, 47, 82);
            logout1.ForeColor = Color.White;

        }

        private void logout1_MouseLeave(object sender, EventArgs e)
        {
            logout1.BackColor = Color.FromArgb(227, 234, 242);
            logout1.ForeColor = Color.FromArgb(104, 120, 143);

        }

        private void Projectbutton1_MouseLeave(object sender, EventArgs e)
        {
            Projectbutton1.BackColor = Color.FromArgb(227, 234, 242);
            Projectbutton1.ForeColor = Color.FromArgb(104, 120, 143);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            employeemainpage mainPage = new employeemainpage(); // must match exact class name
            mainPage.Show();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            chatBot chatForm = new chatBot();
            chatForm.Show(); // or .ShowDialog() if you want it to block the main form
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            using (InfoEmployees empForm = new InfoEmployees())
            {
                empForm.ShowDialog();  // This will open the form and block the main form
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UploadForm upfile = new UploadForm(this); // pass current form
            this.Hide();
            upfile.Show();
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
