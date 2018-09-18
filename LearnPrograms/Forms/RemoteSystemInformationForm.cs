﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace LearnPrograms
{
    public partial class RemoteSystemInformationForm : Form
    {

        Thread DeviceInformationThread;

        public RemoteSystemInformationForm()
        {
            InitializeComponent();
        }

        private void CheckNetwork()
        {
            NetClass nethandler = new NetClass();

            //Hálózat ellenőrzése
            if (nethandler.IsNetworkLikelyAvailable())
            {
                SystemInformationButton.Enabled = true;
                DeviceInformationButton.Enabled = true;
                NetworkStatusLabel.Text = "Connected";
            }
            else
            {
                SystemInformationButton.Enabled = false;
                DeviceInformationButton.Enabled = false;
                NetworkStatusLabel.Text = "Disconnected";
                MessageBox.Show("Network disconnected!", "Network error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SystemInformationForm_Load(object sender, EventArgs e)
        {
            //Win32Class textbox feltöltése XML-ből
            try {
                XMLHandler handler = new XMLHandler();
                List<string> stringWin32classes = new List<string>();

                stringWin32classes = handler.getXMLElement(@"XML\Win32Classes.xml", "class");

                Win32ClassesComboBox.Items.Clear();

                foreach (string stringWin32class in stringWin32classes)            
                {
                    //comboBox feltöltése
                    Win32ClassesComboBox.Items.Add(stringWin32class);                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Win32Class XML read error: "+ex.ToString(), "Win32Class XML read error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Hálózati kapcsolat ellenőrzése.
            this.CheckNetwork();

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

        private void ClearTextBoxesButton_Click(object sender, EventArgs e)
        {
            RemoteIPTextBox.Clear();
            UserNameTextBox.Clear();
            PasswordTextBox.Clear();
        }

        private void NetworkCheckButton_Click(object sender, EventArgs e)
        {
            this.CheckNetwork();
        }
    }
}
