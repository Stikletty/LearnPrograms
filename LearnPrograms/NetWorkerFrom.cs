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

        private void NetCheck()
        {
            if (netHandler.IsNetworkLikelyAvailable())
            {
                NetConnectedStatusLabel.Text = "Connected";
            }
            else
            {
                NetConnectedStatusLabel.Text = "Disconnected";
                MessageBox.Show("Network disconnected!", "Network error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
