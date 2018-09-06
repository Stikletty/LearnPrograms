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

            IPAddressTextBox.Enabled = false;

            if (this.NetCheck()) {
                if (netHandler.ValidateIPAdress(IPAddressTextBox.Text))
                {
                    //Van hálózat, IP cím van a textboxban.
                    if (netHandler.PingHost(IPAddressTextBox.Text))
                    {
                        IPLogTextBox.AppendText(DateTime.Now.ToLongTimeString() + " - IP address is pingable.");
                        //TODO: Itt folytasd
                        
                        /*if ()
                        {

                        }*/
                    }
                }
                else
                {
                    IPLogTextBox.AppendText(DateTime.Now.ToLongTimeString()+" - Not valid IP address.\n");
                    IPAddressTextBox.Enabled = true;
                    IPAddressTextBox.Focus();
                }
            }
            else
            {
                IPAddressTextBox.Enabled = true;
                IPLogTextBox.AppendText(DateTime.Now.ToLongTimeString() + " - Network disconnected!\n");
            }

            
        }
    }
}
