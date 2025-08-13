using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Softwarehouse_DBMS
{
    public partial class chatBot : Form
    {
        private bool isFirstMessageSent = false;
        private Timer startupTimer;

        private Color lightBackColor = Color.WhiteSmoke;
        private Color darkBackColor = Color.FromArgb(30, 30, 30);
        private Color lightTextColor = Color.Black;
        private Color darkTextColor = Color.White;

        private readonly Dictionary<string, string> faq = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "Who is the CEO of the company?", "The CEO of Codes Logistics is Faizan Muzaffar, a backend developer with over 6 years of experience in full-stack development." },
            { "How can I view employee details?", "Employee details are available in the HR section of the system. You can search by role, department, or name." },
            { "Who is responsible for HR and marketing?", "Ifraz Shoaib handles HR and marketing activities." },
            { "Can I see the tasks assigned to a specific employee?", "Yes, each employee's assigned tasks are visible in their profile or the project detail view." },
            { "How do I view ongoing projects?", "You can view ongoing projects in the Owner’s Dashboard or the Project Overview section." },
            { "How are projects assigned?", "Projects are assigned by the business developer or owner based on team members’ expertise and availability." },
            { "What is the status of a project?", "Project status can be “Pending”, “In Progress”, or “Done”. You can check it in the project status panel." },
            { "Can I filter projects by category?", "Yes, you can filter projects by type such as Web Development, App Development, or Graphic Design." },
            { "How do I track project progress?", "Use the project timeline and milestone tracker to monitor progress and deadlines." },
            { "How are tasks created and assigned?", "Tasks are created during project planning and are assigned based on team roles and project requirements." },
            { "Can I update task status?", "Yes, team members can update their task status to “Pending”, “In Progress”, or “Done”." },
            { "What kind of reports can I generate?", "You can generate reports on project completion, employee performance, revenue, and delays." },
            { "How can I see delayed projects?", "The Owner’s Dashboard highlights delayed projects along with expected vs. actual timelines." },
            { "Can I export reports?", "Yes, reports can be exported as PDFs or Excel files from the Reports section." },
            { "How do I log a new project?", "In the Projects section, click “New Project”, select the client, enter details, and assign team members." },
            { "How is payment tracked?", "Payment details like budget, terms, and status are logged in the Project and Client records." },
            { "Are there reminders for deadlines?", "Yes, automated reminders are sent when project deadlines approach or tasks are marked as done." },
            { "Can the CEO approve final deliveries?", "Yes, once a project is marked as done, an alert notifies the CEO for review and final approval." }
        };

        private readonly Dictionary<string, List<string>> suggestionsByKeyword = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase)
        {
            { "employee", new List<string> {
                "Who is the CEO of the company?",
                "How can I view employee details?",
                "Who is responsible for HR and marketing?",
                "Can I see the tasks assigned to a specific employee?"
            }},
            { "project", new List<string> {
                "How do I view ongoing projects?",
                "How are projects assigned?",
                "What is the status of a project?",
                "Can I filter projects by category?",
                "How do I log a new project?",
                "How do I track project progress?",
                "How is payment tracked?",
                "Are there reminders for deadlines?",
                "Can the CEO approve final deliveries?"
            }},
            { "task", new List<string> {
                "How are tasks created and assigned?",
                "Can I update task status?",
                "Can I see the tasks assigned to a specific employee?"
            }},
            { "report", new List<string> {
                "What kind of reports can I generate?",
                "How can I see delayed projects?",
                "Can I export reports?"
            }}
        };

        public chatBot()
        {
            InitializeComponent();
            this.AcceptButton = buttonSend;
            InitializeStartupTimer();
        }

        private void InitializeStartupTimer()
        {
            flowLayoutPanelChat.Visible = false;
            textBoxMessage.Visible = false;
            buttonSend.Visible = false;

            startupTimer = new Timer();
            startupTimer.Interval = 5000;
            startupTimer.Tick += (s, e) =>
            {
                startupTimer.Stop();
                pictureBoxBot.Visible = false;
                lblBot.Visible = false;

                flowLayoutPanelChat.Visible = true;
                flowLayoutPanelChat.Height = 400;
                textBoxMessage.Visible = true;
                buttonSend.Visible = true;
            };
            startupTimer.Start();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string userMessage = textBoxMessage.Text.Trim();
            if (string.IsNullOrWhiteSpace(userMessage)) return;

            if (!isFirstMessageSent)
                isFirstMessageSent = true;

            AddChatBubble(userMessage, isUser: true);
            textBoxMessage.Clear();

            string input = userMessage.Trim().ToLower();

            if (input == "hi" || input == "hello")
            {
                AddChatBubble("Hi, how can I assist you today?", isUser: false);
                return;
            }

            string matchedQuestion = faq.Keys.FirstOrDefault(q => q.Trim().ToLower().Equals(input, StringComparison.OrdinalIgnoreCase));

            if (matchedQuestion != null)
            {
                AddChatBubble(faq[matchedQuestion], isUser: false);
                return;
            }

            foreach (var keyword in suggestionsByKeyword.Keys)
            {
                if (input.Contains(keyword))
                {
                    AddChatBubble("Are you asking about:", isUser: false);
                    foreach (string suggestion in suggestionsByKeyword[keyword])
                        AddSuggestionButton(suggestion);
                    return;
                }
            }

            AddChatBubble("I'm not sure how to respond to that. Please rephrase or ask a specific question.", isUser: false);
        }

        private void AddChatBubble(string message, bool isUser)
        {
            Label bubble = new Label
            {
                Text = message,
                AutoSize = true,
                MaximumSize = new Size(250, 0),
                Font = new Font("Segoe UI", 10),
                Padding = new Padding(10),
                BackColor = isUser ? Color.LightBlue : Color.LightGray,
                ForeColor = Color.Black,
                Margin = new Padding(5),
                TextAlign = ContentAlignment.MiddleLeft
            };

            Panel container = new Panel
            {
                AutoSize = true,
                Width = flowLayoutPanelChat.ClientSize.Width - 25,
                BackColor = Color.Transparent,
                Padding = isUser ? new Padding(80, 5, 5, 5) : new Padding(5, 5, 80, 5),
                Anchor = isUser ? AnchorStyles.Right : AnchorStyles.Left
            };

            container.Controls.Add(bubble);
            flowLayoutPanelChat.Controls.Add(container);
            flowLayoutPanelChat.ScrollControlIntoView(container);
        }

        private void AddSuggestionButton(string suggestion)
        {
            Button btn = new Button
            {
                Text = suggestion,
                AutoSize = true,
                BackColor = Color.White,
                ForeColor = Color.Black,
                Font = new Font("Segoe UI", 9F),
                FlatStyle = FlatStyle.Flat,
                Margin = new Padding(5),
                Padding = new Padding(5)
            };

            btn.Click += (sender, e) =>
            {
                AddChatBubble(btn.Text, isUser: true);
                if (faq.TryGetValue(btn.Text, out string answer))
                    AddChatBubble(answer, isUser: false);
                else
                    AddChatBubble("I'm not sure how to respond to that.", isUser: false);
            };

            Panel container = new Panel
            {
                AutoSize = true,
                Padding = new Padding(5, 2, 80, 2),
                Width = flowLayoutPanelChat.ClientSize.Width - 25,
                BackColor = Color.Transparent,
                Anchor = AnchorStyles.Left
            };

            container.Controls.Add(btn);
            flowLayoutPanelChat.Controls.Add(container);
            flowLayoutPanelChat.ScrollControlIntoView(container);
        }

        private void checkBoxDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBoxDarkMode.Checked)
            //    ApplyDarkTheme();
            //else
            //    ApplyLightTheme();
        }

        private void ApplyDarkTheme()
        {
            
        }

        private void ApplyLightTheme()
        {
          
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chatBot_Load(object sender, EventArgs e)
        {
                chkDarkMode.Checked = ThemeManager.IsDarkMode;
            ThemeManager.ApplyTheme(this);
        }
    }
}
