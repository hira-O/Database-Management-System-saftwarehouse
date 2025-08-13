using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;

namespace Softwarehouse_DBMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chkDarkMode.Checked = ThemeManager.IsDarkMode;
            ThemeManager.ApplyTheme(this);

            pbTogglePassword.Image = Properties.Resources.eye_closed; // start with hidden password
            textBox2.UseSystemPasswordChar = true;

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if (username == "CEOtest" && password == "CEOtest123")
            {
                CEOmainform CEOmainform = new CEOmainform();  // Assuming the CEO form is named 'CEO'
                CEOmainform.Show();
                this.Hide();
            }
            else if (username == "EMPtest" && password == "EMPtest123")
            {
                employeemainpage employeeForm = new employeemainpage();
                employeeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Enter Correct Username Or Password");
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(11, 47, 82);
            button1.ForeColor = Color.White;

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(227, 234, 242);
            button1.ForeColor = Color.FromArgb(104, 120, 143);

        }

        private void chkdarkMode_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.IsDarkMode = chkDarkMode.Checked;

            foreach (Form openForm in Application.OpenForms)
            {
                ThemeManager.ApplyTheme(openForm);
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void pbTogglePassword_Click_2(object sender, EventArgs e)
        {
            // Toggle the password character visibility
            if (textBox2.UseSystemPasswordChar)
            {
                // Show password
                textBox2.UseSystemPasswordChar = false;
                pbTogglePassword.Image = Properties.Resources.eye_open; // use your eye open icon
            }
            else
            {
                // Hide password
                textBox2.UseSystemPasswordChar = true;
                pbTogglePassword.Image = Properties.Resources.eye_closed; // use your eye closed icon
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
