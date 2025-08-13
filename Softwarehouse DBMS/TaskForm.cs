using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Softwarehouse_DBMS
{
    public partial class Form2 : Form
    {
        private System.Windows.Forms.Timer timerClock = new System.Windows.Forms.Timer();

        public Form2()
        {
            InitializeComponent();
            DisplayTasks();
        }
        SqlConnection conn = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PMS.mdf;Integrated Security=True;");

        private void DisplayTasks()
        {
            try
            {
                dataGridView1.Columns.Clear(); // <-- Add this line to fix your issue
                conn.Open();
                string query = "select * from Tasks";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
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
        void DisplayProjectId()
        {
            string sql = "select * from Projects";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rdr;
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("ProId", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                comboBox3.ValueMember = "ProId";
                comboBox3.DataSource = dt;
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
        void DisplayEmployeeId()
        {
            string sql = "select * from Employees";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rdr;
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("EmpId", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                comboBox2.ValueMember = "EmpId";
                comboBox2.DataSource = dt;
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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
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
            Employees employee = new Employees();
            this.Hide();
            employee.Show();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            project project = new project();
            this.Hide();
            project.Show();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            this.Hide();
            report.Show();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            LoginForm.Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ChatPopup popup = new ChatPopup(this); // ✅ Always pass `this` as the parent
            this.Controls.Add(popup);
            {
                DisplayProjectId();
                DisplayEmployeeId();
            }
            timerClock.Interval = 1000;
            timerClock.Tick += TimerClock_Tick;
            timerClock.Start();
            chkDarkMode.Checked = ThemeManager.IsDarkMode;
            ThemeManager.ApplyTheme(this);
        }
        private void TimerClock_Tick(object? sender, EventArgs e)
        {
            label19.Text = DateTime.Now.ToString("dddd, dd-MM-yyyy hh:mm:ss tt");
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Projectbutton3_Click(object sender, EventArgs e)
        {
            project projectForm = new project(); // Use PascalCase class name
            this.Hide();
            projectForm.Show();
        }

        private void taskbutton4_Click(object sender, EventArgs e)
        {
            Form2 taskForm = new Form2();
            this.Hide();
            taskForm.Show();
        }

        private void employeebutton4_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            this.Hide();
            employees.Show();
        }

        private void Reportbutton4_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            this.Hide();
        }

        private void logout4_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void taskbutton4_MouseEnter(object sender, EventArgs e)
        {
            taskbutton4.BackColor = Color.FromArgb(11, 47, 82);
            taskbutton4.ForeColor = Color.White;

        }

        private void taskbutton4_MouseLeave(object sender, EventArgs e)
        {
            taskbutton4.BackColor = Color.FromArgb(227, 234, 242);
            taskbutton4.ForeColor = Color.FromArgb(104, 120, 143);

        }

        private void employeebutton4_MouseEnter(object sender, EventArgs e)
        {
            employeebutton4.BackColor = Color.FromArgb(11, 47, 82);
            employeebutton4.ForeColor = Color.White;

        }

        private void employeebutton4_MouseLeave(object sender, EventArgs e)
        {
            employeebutton4.BackColor = Color.FromArgb(227, 234, 242);
            employeebutton4.ForeColor = Color.FromArgb(104, 120, 143);

        }

        private void Projectbutton4_MouseEnter(object sender, EventArgs e)
        {
            Projectbutton4.BackColor = Color.FromArgb(11, 47, 82);
            Projectbutton4.ForeColor = Color.White;

        }

        private void Projectbutton4_MouseLeave(object sender, EventArgs e)
        {
            Projectbutton4.BackColor = Color.FromArgb(227, 234, 242);
            Projectbutton4.ForeColor = Color.FromArgb(104, 120, 143);

        }

        private void Reportbutton4_MouseEnter(object sender, EventArgs e)
        {
            Reportbutton4.BackColor = Color.FromArgb(11, 47, 82);
            Reportbutton4.ForeColor = Color.White;

        }

        private void Reportbutton4_MouseLeave(object sender, EventArgs e)
        {
            Reportbutton4.BackColor = Color.FromArgb(227, 234, 242);
            Reportbutton4.ForeColor = Color.FromArgb(104, 120, 143);

        }

        private void logout4_MouseEnter(object sender, EventArgs e)
        {
            logout4.BackColor = Color.FromArgb(11, 47, 82);
            logout4.ForeColor = Color.White;

        }

        private void logout4_MouseLeave(object sender, EventArgs e)
        {
            logout4.BackColor = Color.FromArgb(227, 234, 242);
            logout4.ForeColor = Color.FromArgb(104, 120, 143);

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            employeemainpage mainPage = new employeemainpage(); // must match exact class name
            mainPage.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "" || comboBox3.Text == "" || textBox3.Text == "" || comboBox2.Text == "" || dateTimePicker2.Text == "" || comboBox1.Text == "")
                {
                    MessageBox.Show("Missing Information");

                }
                else
                {
                    conn.Open();
                    string query = "Insert into Tasks values('" + textBox2.Text + "','" + comboBox3.SelectedValue + "','" + textBox3.Text + "','" + comboBox2.SelectedValue + "','" + dateTimePicker2.Value.Date + "','" + comboBox1.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record Added Successfully");
                    DisplayTasks();
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

        private void chkdarkMode_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.IsDarkMode = chkDarkMode.Checked;

            foreach (Form openForm in Application.OpenForms)
            {
                ThemeManager.ApplyTheme(openForm);
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            chatBot chatForm = new chatBot();
            chatForm.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            using (InfoTasks tskForm = new InfoTasks())
            {
                tskForm.ShowDialog();  // This will open the form and block the main form
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (TaskDashboard tskdashForm = new TaskDashboard())
            {
                tskdashForm.ShowDialog();
            }
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            UploadForm upfile = new UploadForm(this);
            this.Hide();
            upfile.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Enter the Tasks ID");

                }
                else
                {
                    conn.Open();
                    string query = "Delete from Tasks WHERE TaskId='" + textBox2.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record Deleted Successfully");
                    DisplayTasks();
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
            comboBox3.Text = "";
            textBox3.Text = "";
            comboBox2.Text = "";
            dateTimePicker2.Text = "";
            comboBox1.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                comboBox3.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

                textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

                comboBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

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

        private void Form2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                comboBox3.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                comboBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                dateTimePicker2.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
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
    }
}

