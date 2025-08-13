using System.Drawing;
using System.Windows.Forms;
using System;

namespace Softwarehouse_DBMS
{
    partial class chatBot
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBoxBot;
        private System.Windows.Forms.Label lblBot;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelChat;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.CheckBox chkDarkMode;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pictureBoxBot = new PictureBox();
            lblBot = new Label();
            flowLayoutPanelChat = new FlowLayoutPanel();
            textBoxMessage = new TextBox();
            buttonSend = new Button();
            buttonBack = new Button();
            chkDarkMode = new CheckBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBot).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxBot
            // 
            pictureBoxBot.BackColor = Color.FromArgb(227, 234, 242);
            pictureBoxBot.Image = Properties.Resources.chatbot_icon;
            pictureBoxBot.Location = new Point(100, 70);
            pictureBoxBot.Name = "pictureBoxBot";
            pictureBoxBot.Size = new Size(200, 160);
            pictureBoxBot.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxBot.TabIndex = 0;
            pictureBoxBot.TabStop = false;
            // 
            // lblBot
            // 
            lblBot.AutoSize = true;
            lblBot.BackColor = Color.FromArgb(227, 234, 242);
            lblBot.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBot.Location = new Point(70, 240);
            lblBot.Name = "lblBot";
            lblBot.Size = new Size(229, 30);
            lblBot.TabIndex = 1;
            lblBot.Text = "How may I help you?";
            // 
            // flowLayoutPanelChat
            // 
            flowLayoutPanelChat.AutoScroll = true;
            flowLayoutPanelChat.BackColor = Color.FromArgb(227, 234, 242);
            flowLayoutPanelChat.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelChat.Location = new Point(20, 60);
            flowLayoutPanelChat.Name = "flowLayoutPanelChat";
            flowLayoutPanelChat.Size = new Size(360, 400);
            flowLayoutPanelChat.TabIndex = 2;
            flowLayoutPanelChat.WrapContents = false;
            // 
            // textBoxMessage
            // 
            textBoxMessage.BackColor = Color.FromArgb(227, 234, 242);
            textBoxMessage.Font = new Font("Segoe UI", 10F);
            textBoxMessage.Location = new Point(20, 480);
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.Size = new Size(260, 25);
            textBoxMessage.TabIndex = 3;
            // 
            // buttonSend
            // 
            buttonSend.BackColor = Color.FromArgb(227, 234, 242);
            buttonSend.Font = new Font("Segoe UI", 9F);
            buttonSend.Location = new Point(290, 480);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(90, 30);
            buttonSend.TabIndex = 4;
            buttonSend.Text = "Send";
            buttonSend.UseVisualStyleBackColor = false;
            buttonSend.Click += buttonSend_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(10, 10);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(60, 30);
            buttonBack.TabIndex = 5;
            buttonBack.Text = "Back";
            buttonBack.Click += BtnBack_Click;
            // 
            // chkDarkMode
            // 
            chkDarkMode.AutoSize = true;
            chkDarkMode.Location = new Point(308, 11);
            chkDarkMode.Name = "chkDarkMode";
            chkDarkMode.Size = new Size(84, 19);
            chkDarkMode.TabIndex = 6;
            chkDarkMode.Text = "Dark Mode";
            chkDarkMode.CheckedChanged += checkBoxDarkMode_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 47, 82);
            panel1.Controls.Add(chkDarkMode);
            panel1.Controls.Add(buttonBack);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 50);
            panel1.TabIndex = 151;
            // 
            // chatBot
            // 
            BackColor = Color.White;
            ClientSize = new Size(400, 530);
            Controls.Add(panel1);
            Controls.Add(pictureBoxBot);
            Controls.Add(lblBot);
            Controls.Add(flowLayoutPanelChat);
            Controls.Add(textBoxMessage);
            Controls.Add(buttonSend);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "chatBot";
            Text = "ChatBot";
            Load += chatBot_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxBot).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        private Panel panel1;
    }
}