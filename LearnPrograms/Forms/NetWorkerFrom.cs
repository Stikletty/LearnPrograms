using System;
using System.Windows.Forms;

namespace LearnPrograms
{
    public partial class NetWorkerFrom : Form
    {

        NetClass netHandler = new NetClass();

        public NetWorkerFrom()
        {
            InitializeComponent();
        }

        private bool NetCheck()
        {
            if (netHandler.IsNetworkLikelyAvailable())
            {
                NetConnectedStatusLabel.Text = "Connected";
                return true;
            }
            else
            {
                NetConnectedStatusLabel.Text = "Disconnected";
                MessageBox.Show("Network disconnected!", "Network error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void NetWorkerFrom_Load(object sender, EventArgs e)
        {
            this.NetCheck();
            IPLogTextBox.Clear();
        }

        private void CheckNetworkButton_Click(object sender, EventArgs e)
        {
            this.NetCheck();
        }


        private void ClearLogBoxButton_Click(object sender, EventArgs e)
        {
            IPLogTextBox.Clear();
        }

        private void PingButton_Click(object sender, EventArgs e)
        {

            long pingtime = 0;

            IPAddressTextBox.Enabled = false;

            if (this.NetCheck())
            {
                if (netHandler.ValidateIPAdress(IPAddressTextBox.Text))
                {
                    //Van hálózat, IP cím van a textboxban.
                    if (netHandler.PingHost(IPAddressTextBox.Text))
                    {
                        IPLogTextBox.AppendText(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + " - IP address is pingable.\n");

                        //TODO: Néha problemet ad vissza, néha rendben van.
                        for (int i = 1; i <= 3; i++)
                        {                            
                            pingtime = netHandler.PingRoundTime(IPAddressTextBox.Text);

                            if (pingtime > 0.0)
                            {
                                IPLogTextBox.AppendText(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + " - " + i.ToString() + ". ping roundtime: " + pingtime.ToString() + " ms \n");
                            }
                            else
                            {
                                IPLogTextBox.AppendText(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + " - " + i.ToString() + ". ping problem.\n");
                            }

                            pingtime = 0;
                        }

                        IPAddressTextBox.Enabled = true;
                    }
                }
                else
                {
                    IPLogTextBox.AppendText(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + " - Not valid IP address.\n");
                    IPAddressTextBox.Enabled = true;
                    IPAddressTextBox.Focus();
                }
            }
            else
            {
                IPLogTextBox.AppendText(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + " - Network disconnected!\n");
                IPAddressTextBox.Enabled = true;
            }


        }

        private void ResolveHostName_Click(object sender, EventArgs e)
        {

            HostNameTextBox.Enabled = false;

            if (this.NetCheck())
            {
                if (HostNameTextBox.Text.Length > 0)
                {
                    string ipaddress;

                    ipaddress = netHandler.GetHostNameIP(HostNameTextBox.Text);
                    IPLogTextBox.AppendText(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + " - Host ip address: " + ipaddress + "\n");

                    HostNameTextBox.Enabled = true;
                }
                else
                {
                    IPLogTextBox.AppendText(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + " - Empty Host Name TextBox.\n");
                    HostNameTextBox.Enabled = true;
                    HostNameTextBox.Focus();
                }
            }
            else
            {
                IPLogTextBox.AppendText(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + " - Network disconnected!\n");
                HostNameTextBox.Enabled = true;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetPanelButton_Click(object sender, EventArgs e)
        {
            IPAddressTextBox.Clear();
            HostNameTextBox.Clear();
            IPLogTextBox.Clear();
        }
    }
}
