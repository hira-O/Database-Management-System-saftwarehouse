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
    public partial class Report : Form
    {
        private System.Windows.Forms.Timer timerClock = new System.Windows.Forms.Timer();

        public Report()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PMS.mdf;Integrated Security=True;");
        private void DisplayReports()
        {
            try
            {
                conn.Open();
                string query = "select * from Reports";
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
                comboBox2.ValueMember = "ProId";
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
        void DisplayTaskStatus()
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PMS.mdf;Integrated Security=True;"))
                {
                    conn.Open();
                    string query = "SELECT SUM(CASE WHEN Status = 'completed' THEN 1 ELSE 0 END) AS CompletedTasks, SUM(CASE WHEN Status= 'in progress' THEN 1 ELSE 0 END) AS PendingTasks,SUM(CASE WHEN Status= 'to do' THEN 1 ELSE 0 END) AS ToDoTasks FROM Tasks Where ProjectId= @ProjectId; ";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!int.TryParse(comboBox2.SelectedValue?.ToString(), out int projectId))
                        {
                            MessageBox.Show("Invalid Project Id");
                            return;
                        }

                        cmd.Parameters.AddWithValue("@ProjectId", projectId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int completed = reader["CompletedTasks"] != DBNull.Value ? Convert.ToInt32(reader["CompletedTasks"]) : 0;
                                int Pending = reader["PendingTasks"] != DBNull.Value ? Convert.ToInt32(reader["PendingTasks"]) : 0;
                                int todo = reader["ToDoTasks"] != DBNull.Value ? Convert.ToInt32(reader["ToDoTasks"]) : 0;
                                int total = completed + Pending + todo;

                                textBox1.Text = total.ToString();
                                textBox7.Text = completed.ToString();
                                textBox5.Text = Pending.ToString();
                                textBox3.Text = todo.ToString();
                            }
                            else
                            {
                                textBox1.Text = "0";
                                textBox7.Text = "0";
                                textBox5.Text = "0";
                                textBox3.Text = "0";
                            }
                        }

                    }
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


        private void Report_Load(object sender, EventArgs e)
        {
            ChatPopup popup = new ChatPopup(this); // ✅ Always pass `this` as the parent
            this.Controls.Add(popup); DisplayReports();
            DisplayProjectId();
            timerClock.Interval = 1000;
            timerClock.Tick += TimerClock_Tick;
            timerClock.Start();
            chkDarkMode.Checked = ThemeManager.IsDarkMode;
            ThemeManager.ApplyTheme(this);
        }
        private void TimerClock_Tick(object? sender, EventArgs e)
        {
            label18.Text = DateTime.Now.ToString("dddd, dd-MM-yyyy hh:mm:ss tt");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                comboBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox7.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();



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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            //LoginForm loginForm = new LoginForm();
            //loginForm.Show();
            //this.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            this.Hide();
            report.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            project project = new project();
            this.Hide();
            project.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            this.Hide();
            employees.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            TaskForm tasksForm = new TaskForm();
            TaskForm.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void taskbutton3_Click(object sender, EventArgs e)
        {
            Form2 taskForm = new Form2();
            this.Hide();
            taskForm.Show();
        }

        private void employeebutton3_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            this.Hide();
            employees.Show();
        }

        private void Projectbutton3_Click(object sender, EventArgs e)
        {
            project projectForm = new project(); // Use PascalCase class name
            this.Hide();
            projectForm.Show();
        }

        private void Reportbutton3_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logout3_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void taskbutton3_MouseEnter(object sender, EventArgs e)
        {
            taskbutton3.BackColor = Color.FromArgb(11, 47, 82);
            taskbutton3.ForeColor = Color.White;

        }

        private void taskbutton3_MouseLeave(object sender, EventArgs e)
        {
            taskbutton3.BackColor = Color.FromArgb(227, 234, 242);
            taskbutton3.ForeColor = Color.FromArgb(104, 120, 143);
        }

        private void employeebutton3_MouseEnter(object sender, EventArgs e)
        {
            employeebutton3.BackColor = Color.FromArgb(11, 47, 82);
            employeebutton3.ForeColor = Color.White;

        }

        private void employeebutton3_MouseLeave(object sender, EventArgs e)
        {
            employeebutton3.BackColor = Color.FromArgb(227, 234, 242);
            employeebutton3.ForeColor = Color.FromArgb(104, 120, 143);
        }

        private void Projectbutton3_MouseEnter(object sender, EventArgs e)
        {
            Projectbutton3.BackColor = Color.FromArgb(11, 47, 82);
            Projectbutton3.ForeColor = Color.White;

        }

        private void Projectbutton3_MouseHover(object sender, EventArgs e)
        {


        }

        private void Projectbutton3_MouseLeave(object sender, EventArgs e)
        {
            Projectbutton3.BackColor = Color.FromArgb(227, 234, 242);
            Projectbutton3.ForeColor = Color.FromArgb(104, 120, 143);

        }

        private void Reportbutton3_MouseEnter(object sender, EventArgs e)
        {
            Reportbutton3.BackColor = Color.FromArgb(11, 47, 82);
            Reportbutton3.ForeColor = Color.White;

        }

        private void Reportbutton3_MouseLeave(object sender, EventArgs e)
        {
            Reportbutton3.BackColor = Color.FromArgb(227, 234, 242);
            Reportbutton3.ForeColor = Color.FromArgb(104, 120, 143);
        }

        private void logout3_MouseEnter(object sender, EventArgs e)
        {
            logout3.BackColor = Color.FromArgb(11, 47, 82);
            logout3.ForeColor = Color.White;

        }

        private void logout3_MouseLeave(object sender, EventArgs e)
        {
            logout3.BackColor = Color.FromArgb(227, 234, 242);
            logout3.ForeColor = Color.FromArgb(104, 120, 143);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "" || comboBox2.Text == "" || textBox1.Text == "" || textBox7.Text == "" || textBox5.Text == "" || textBox3.Text == "" || dateTimePicker1.Text == "")
                {
                    MessageBox.Show("Missing Information");

                }
                else
                {
                    conn.Open();
                    string query = "Insert into Reports values('" + textBox2.Text + "','" + comboBox2.SelectedValue + "','" + textBox1.Text + "','" + textBox7.Text + "','" + textBox5.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Value.Date + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record Added Successfully");
                    DisplayReports();
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

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            //button4.BackColor = Color.FromArgb(11, 47, 82);
            //button4.ForeColor = Color.White;

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

        private void button2_Leave(object sender, EventArgs e)
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

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            //button4.BackColor = Color.FromArgb(227, 234, 242);
            //button4.ForeColor = Color.FromArgb(104, 120, 143);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            employeemainpage mainPage = new employeemainpage(); // must match exact class name
            mainPage.Show();
            this.Hide();
        }

        private void chkdarkMode_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.IsDarkMode = chkDarkMode.Checked;

            foreach (Form openForm in Application.OpenForms)
            {
                ThemeManager.ApplyTheme(openForm);
            }

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            chatBot chatForm = new chatBot();
            chatForm.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            using (InfoReports rptForm = new InfoReports())
            {
                rptForm.ShowDialog();  // This will open the form and block the main form
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //using (ReportDashboard rptdashForm = new ReportDashboard())
            //{
            //    rptdashForm.ShowDialog();
            //}
            //this.Show();
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
                    MessageBox.Show("Enter the Reports ID");

                }
                else
                {
                    conn.Open();
                    string query = "Delete from Reports WHERE RId='" + textBox2.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record Deleted Successfully");
                    DisplayReports();
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
            comboBox2.Text = "";
            textBox1.Text = "";
            textBox7.Text = "";
            textBox5.Text = "";
            textBox3.Text = "";
            dateTimePicker1.Text = "";
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

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DisplayTaskStatus();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
