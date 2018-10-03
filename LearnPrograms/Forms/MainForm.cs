using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnPrograms
{
    public partial class MainForm : Form
    {
        UserClass userhandler = new UserClass();

        public MainForm()
        {
            InitializeComponent();
        }

        private void NetworkButton_Click(object sender, EventArgs e)
        {
            NetWorkerFrom networkerform = new NetWorkerFrom();

            networkerform.ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {            
            Application.Exit();
        }

        private void SystemInfButton_Click(object sender, EventArgs e)
        {
            SystemInformationForm systemInformationForm = new SystemInformationForm();

            systemInformationForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UserInfoStatusLabel.Text = "User: "+userhandler.GetUserName();
            if (userhandler.IsUserAdministrator())
            {
                UserInfoStatusLabel.Text += " - Administrator";
            }
            else
            {
                UserInfoStatusLabel.Text += " - User";
            }

            ComputerNameStatusLabel.Text = "Computer Name: " + Environment.MachineName;
        }

        private void RemoteSystemInfButton_Click(object sender, EventArgs e)
        {            
            RemoteSystemInformationForm remoteSystemInformationForm = new RemoteSystemInformationForm();

            remoteSystemInformationForm.ShowDialog();
        }

        private void ADHandlerButton_Click(object sender, EventArgs e)
        {
            ADHandlerForm aDHandlerForm = new ADHandlerForm();

            aDHandlerForm.ShowDialog();
        }
    }
}
