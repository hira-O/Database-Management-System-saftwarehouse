using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Softwarehouse_DBMS
{
    public partial class ChatPopup : UserControl
    {
        // ✅ 1. Declare hideTimer at the top
        private System.Windows.Forms.Timer hideTimer;

        // ✅ 2. Store a reference to the parent control
        private Control parent;

        // ✅ 3. Modified constructor to accept parent control
        private void ApplyRoundedCorners(int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(this.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(this.Width - radius, this.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, this.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();
            this.Region = new Region(path);
        }
        public ChatPopup(Control parent)
        {

            InitializeComponent();
            ApplyRoundedCorners(20); // 🎯 You can change 20 to adjust roundness
            this.Size = new Size(250, 50);
            ApplyRoundedCorners(20); // 👈 Apply rounded corners here


            this.parent = parent;

            this.BackColor = Color.FromArgb(11, 47, 82);
            this.ForeColor = Color.White;
            this.Font = new Font("Segoe UI", 10);
            this.Size = new Size(250, 50);// Slightly bigger, optional
                                          //this.BorderStyle = BorderStyle.FixedSingle;
            ApplyRoundedCorners(20); // ⭕ Rounded corners

            Label lbl = new Label()
            {
                Text = "Hi, how can I help you?",
                AutoSize = true,
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Location = new Point(15, 20) // vertical centering
            };
            this.Controls.Add(lbl);

            hideTimer = new System.Windows.Forms.Timer();
            hideTimer.Interval = 4000;//seconds
            hideTimer.Tick += (s, e) =>
            {
                this.Hide();
                hideTimer.Stop();
            };

            this.Load += ChatPopup_Load;
        }

        private void ChatPopup_Load(object sender, EventArgs e)
        {
            if (parent != null)
            {
                this.Location = new Point(parent.ClientSize.Width - this.Width - 40, 40);
                this.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                parent.Controls.Add(this);
                this.BringToFront();
                this.Show();
                hideTimer.Start();
            }
            else
            {
                MessageBox.Show("Parent not set. Cannot position ChatPopup.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }// ✅ 6. Now parent is defined, this works
            this.Location = new Point(parent.ClientSize.Width - this.Width - 40, 40);
            this.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            parent.Controls.Add(this);
            this.BringToFront();
            this.Show();
            hideTimer.Start();
        }
    }
}
