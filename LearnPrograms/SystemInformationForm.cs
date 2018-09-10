using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace LearnPrograms
{
    public partial class SystemInformationForm : Form
    {
        public SystemInformationForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
            //TODO: Szöveg tördelés nem megfelelő.
            SystemInformationsTextBox.Text = compinfo.SystemInformation();
            SystemInformationButton.Enabled = true;
        }
    }
}
