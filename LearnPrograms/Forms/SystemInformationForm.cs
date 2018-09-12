using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace LearnPrograms
{
    public partial class SystemInformationForm : Form
    {

        Thread DeviceInformationThread;

        public SystemInformationForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //TODO: WIN32CLASSES -> áttenni XML-be a listát és megszüntetni a properties classt.
        private void SystemInformationForm_Load(object sender, EventArgs e)
        {
            PropertiesClass propertiesClass = new PropertiesClass();

            string[] stringWin32classes = propertiesClass.stringWin32classes;

            Win32ClassesComboBox.Items.Clear();

            foreach (string stringWin32class in stringWin32classes)
            {
                //comboBox in more tab
                Win32ClassesComboBox.Items.Add(stringWin32class);
            }
        }

        private void SystemInformationButton_Click(object sender, EventArgs e)
        {
            CompInfo compinfo = new CompInfo();

            SystemInformationButton.Enabled = false;
            SystemInformationsTextBox.Clear();
            SystemInformationsTextBox.Text = compinfo.SystemInformation();
            SystemInformationButton.Enabled = true;
        }

        private void getDeviceInformation(string win32ClassName)
        {
            try
            {
                CompInfo compinfo = new CompInfo();
                string devinfotmp = compinfo.DeviceInformation(win32ClassName);

                this.Invoke((MethodInvoker)delegate ()
                {
                    DeviceInformationsTextBox.Clear();
                    if (devinfotmp.Length > 0)
                    {
                        DeviceInformationsTextBox.Text = devinfotmp;
                    }
                    else
                    {
                        DeviceInformationsTextBox.Text = "Class empty.";
                    }
                    DeviceInformationButton.Enabled = true;
                    Win32ClassesComboBox.Enabled = true;
                });
            }
            catch (ThreadAbortException abortException)
            {
                Console.WriteLine((string)abortException.ExceptionState);
            }
        }

        private void DeviceInformationButton_Click(object sender, EventArgs e)
        {

            DeviceInformationButton.Enabled = false;
            Win32ClassesComboBox.Enabled = false;

            if (Win32ClassesComboBox.Text.Length > 0)
            {
                DeviceInformationsTextBox.Clear();
                CompInfo compinfo = new CompInfo();
                string Win32Class = Win32ClassesComboBox.Text;
              
                //getDeviceInformation(Win32Class);
                DeviceInformationThread = new Thread(
                    new ThreadStart(() => getDeviceInformation(Win32Class))
                )
                {
                    Name = "DeviceInformation",
                    IsBackground = true
                };

                DeviceInformationThread.Start();
                DeviceInformationsTextBox.Text = "Getting informations. Please Wait...";
            }
            else
            {
                MessageBox.Show("Win32Class Combobox empty", "Win32Class empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DeviceInformationButton.Enabled = true;
                Win32ClassesComboBox.Enabled = true;
                Win32ClassesComboBox.Focus();
            }

        }
    }
}
