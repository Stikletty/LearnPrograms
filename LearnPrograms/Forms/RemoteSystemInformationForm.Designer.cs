namespace LearnPrograms
{
    partial class RemoteSystemInformationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CloseButton = new System.Windows.Forms.Button();
            this.DeviceInformationButton = new System.Windows.Forms.Button();
            this.SystemInformationButton = new System.Windows.Forms.Button();
            this.DeviceInformationsTextBox = new System.Windows.Forms.TextBox();
            this.SystemInformationsTextBox = new System.Windows.Forms.TextBox();
            this.DeviceInformationsLabel = new System.Windows.Forms.Label();
            this.SystemInformationsLabel = new System.Windows.Forms.Label();
            this.Win32ClassesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RemoteIPTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NetworkCheckButton = new System.Windows.Forms.Button();
            this.ClearTextBoxesButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.NetworkStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(640, 27);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DeviceInformationButton
            // 
            this.DeviceInformationButton.Location = new System.Drawing.Point(546, 76);
            this.DeviceInformationButton.Name = "DeviceInformationButton";
            this.DeviceInformationButton.Size = new System.Drawing.Size(110, 23);
            this.DeviceInformationButton.TabIndex = 1;
            this.DeviceInformationButton.Text = "Device Informations";
            this.DeviceInformationButton.UseVisualStyleBackColor = true;
            this.DeviceInformationButton.Click += new System.EventHandler(this.DeviceInformationButton_Click);
            // 
            // SystemInformationButton
            // 
            this.SystemInformationButton.Location = new System.Drawing.Point(12, 76);
            this.SystemInformationButton.Name = "SystemInformationButton";
            this.SystemInformationButton.Size = new System.Drawing.Size(110, 23);
            this.SystemInformationButton.TabIndex = 2;
            this.SystemInformationButton.Text = "System Information";
            this.SystemInformationButton.UseVisualStyleBackColor = true;
            this.SystemInformationButton.Click += new System.EventHandler(this.SystemInformationButton_Click);
            // 
            // DeviceInformationsTextBox
            // 
            this.DeviceInformationsTextBox.Location = new System.Drawing.Point(382, 124);
            this.DeviceInformationsTextBox.Multiline = true;
            this.DeviceInformationsTextBox.Name = "DeviceInformationsTextBox";
            this.DeviceInformationsTextBox.ReadOnly = true;
            this.DeviceInformationsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DeviceInformationsTextBox.Size = new System.Drawing.Size(350, 380);
            this.DeviceInformationsTextBox.TabIndex = 3;
            // 
            // SystemInformationsTextBox
            // 
            this.SystemInformationsTextBox.Location = new System.Drawing.Point(12, 124);
            this.SystemInformationsTextBox.Multiline = true;
            this.SystemInformationsTextBox.Name = "SystemInformationsTextBox";
            this.SystemInformationsTextBox.ReadOnly = true;
            this.SystemInformationsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SystemInformationsTextBox.Size = new System.Drawing.Size(350, 380);
            this.SystemInformationsTextBox.TabIndex = 4;
            // 
            // DeviceInformationsLabel
            // 
            this.DeviceInformationsLabel.AutoSize = true;
            this.DeviceInformationsLabel.Location = new System.Drawing.Point(379, 108);
            this.DeviceInformationsLabel.Name = "DeviceInformationsLabel";
            this.DeviceInformationsLabel.Size = new System.Drawing.Size(104, 13);
            this.DeviceInformationsLabel.TabIndex = 5;
            this.DeviceInformationsLabel.Text = "Device Informations:";
            // 
            // SystemInformationsLabel
            // 
            this.SystemInformationsLabel.AutoSize = true;
            this.SystemInformationsLabel.Location = new System.Drawing.Point(9, 108);
            this.SystemInformationsLabel.Name = "SystemInformationsLabel";
            this.SystemInformationsLabel.Size = new System.Drawing.Size(104, 13);
            this.SystemInformationsLabel.TabIndex = 6;
            this.SystemInformationsLabel.Text = "System Informations:";
            // 
            // Win32ClassesComboBox
            // 
            this.Win32ClassesComboBox.FormattingEnabled = true;
            this.Win32ClassesComboBox.Location = new System.Drawing.Point(382, 76);
            this.Win32ClassesComboBox.Name = "Win32ClassesComboBox";
            this.Win32ClassesComboBox.Size = new System.Drawing.Size(158, 21);
            this.Win32ClassesComboBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Remote Computer IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "User Name: ";
            // 
            // RemoteIPTextBox
            // 
            this.RemoteIPTextBox.Location = new System.Drawing.Point(117, 3);
            this.RemoteIPTextBox.Name = "RemoteIPTextBox";
            this.RemoteIPTextBox.Size = new System.Drawing.Size(100, 20);
            this.RemoteIPTextBox.TabIndex = 10;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(75, 30);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.UserNameTextBox.TabIndex = 11;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(243, 30);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordTextBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.NetworkCheckButton);
            this.panel1.Controls.Add(this.ClearTextBoxesButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PasswordTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.RemoteIPTextBox);
            this.panel1.Controls.Add(this.UserNameTextBox);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 54);
            this.panel1.TabIndex = 14;
            // 
            // NetworkCheckButton
            // 
            this.NetworkCheckButton.Location = new System.Drawing.Point(369, 3);
            this.NetworkCheckButton.Name = "NetworkCheckButton";
            this.NetworkCheckButton.Size = new System.Drawing.Size(89, 23);
            this.NetworkCheckButton.TabIndex = 15;
            this.NetworkCheckButton.Text = "Netwok Check";
            this.NetworkCheckButton.UseVisualStyleBackColor = true;
            this.NetworkCheckButton.Click += new System.EventHandler(this.NetworkCheckButton_Click);
            // 
            // ClearTextBoxesButton
            // 
            this.ClearTextBoxesButton.Location = new System.Drawing.Point(369, 28);
            this.ClearTextBoxesButton.Name = "ClearTextBoxesButton";
            this.ClearTextBoxesButton.Size = new System.Drawing.Size(89, 23);
            this.ClearTextBoxesButton.TabIndex = 14;
            this.ClearTextBoxesButton.Text = "Clear";
            this.ClearTextBoxesButton.UseVisualStyleBackColor = true;
            this.ClearTextBoxesButton.Click += new System.EventHandler(this.ClearTextBoxesButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NetworkStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 517);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(743, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // NetworkStatusLabel
            // 
            this.NetworkStatusLabel.Name = "NetworkStatusLabel";
            this.NetworkStatusLabel.Size = new System.Drawing.Size(50, 17);
            this.NetworkStatusLabel.Text = "network";
            // 
            // RemoteSystemInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 539);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Win32ClassesComboBox);
            this.Controls.Add(this.SystemInformationsLabel);
            this.Controls.Add(this.DeviceInformationsLabel);
            this.Controls.Add(this.SystemInformationsTextBox);
            this.Controls.Add(this.DeviceInformationsTextBox);
            this.Controls.Add(this.SystemInformationButton);
            this.Controls.Add(this.DeviceInformationButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RemoteSystemInformationForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote System Information";
            this.Load += new System.EventHandler(this.SystemInformationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button DeviceInformationButton;
        private System.Windows.Forms.Button SystemInformationButton;
        private System.Windows.Forms.TextBox DeviceInformationsTextBox;
        private System.Windows.Forms.TextBox SystemInformationsTextBox;
        private System.Windows.Forms.Label DeviceInformationsLabel;
        private System.Windows.Forms.Label SystemInformationsLabel;
        private System.Windows.Forms.ComboBox Win32ClassesComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RemoteIPTextBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ClearTextBoxesButton;
        private System.Windows.Forms.Button NetworkCheckButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel NetworkStatusLabel;
    }
}