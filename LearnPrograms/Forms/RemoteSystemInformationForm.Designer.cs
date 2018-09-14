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
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(665, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DeviceInformationButton
            // 
            this.DeviceInformationButton.Location = new System.Drawing.Point(549, 12);
            this.DeviceInformationButton.Name = "DeviceInformationButton";
            this.DeviceInformationButton.Size = new System.Drawing.Size(110, 23);
            this.DeviceInformationButton.TabIndex = 1;
            this.DeviceInformationButton.Text = "Device Informations";
            this.DeviceInformationButton.UseVisualStyleBackColor = true;
            this.DeviceInformationButton.Click += new System.EventHandler(this.DeviceInformationButton_Click);
            // 
            // SystemInformationButton
            // 
            this.SystemInformationButton.Location = new System.Drawing.Point(15, 12);
            this.SystemInformationButton.Name = "SystemInformationButton";
            this.SystemInformationButton.Size = new System.Drawing.Size(110, 23);
            this.SystemInformationButton.TabIndex = 2;
            this.SystemInformationButton.Text = "System Information";
            this.SystemInformationButton.UseVisualStyleBackColor = true;
            this.SystemInformationButton.Click += new System.EventHandler(this.SystemInformationButton_Click);
            // 
            // DeviceInformationsTextBox
            // 
            this.DeviceInformationsTextBox.Location = new System.Drawing.Point(385, 60);
            this.DeviceInformationsTextBox.Multiline = true;
            this.DeviceInformationsTextBox.Name = "DeviceInformationsTextBox";
            this.DeviceInformationsTextBox.ReadOnly = true;
            this.DeviceInformationsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DeviceInformationsTextBox.Size = new System.Drawing.Size(350, 380);
            this.DeviceInformationsTextBox.TabIndex = 3;
            // 
            // SystemInformationsTextBox
            // 
            this.SystemInformationsTextBox.Location = new System.Drawing.Point(15, 60);
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
            this.DeviceInformationsLabel.Location = new System.Drawing.Point(382, 44);
            this.DeviceInformationsLabel.Name = "DeviceInformationsLabel";
            this.DeviceInformationsLabel.Size = new System.Drawing.Size(104, 13);
            this.DeviceInformationsLabel.TabIndex = 5;
            this.DeviceInformationsLabel.Text = "Device Informations:";
            // 
            // SystemInformationsLabel
            // 
            this.SystemInformationsLabel.AutoSize = true;
            this.SystemInformationsLabel.Location = new System.Drawing.Point(12, 44);
            this.SystemInformationsLabel.Name = "SystemInformationsLabel";
            this.SystemInformationsLabel.Size = new System.Drawing.Size(104, 13);
            this.SystemInformationsLabel.TabIndex = 6;
            this.SystemInformationsLabel.Text = "System Informations:";
            // 
            // Win32ClassesComboBox
            // 
            this.Win32ClassesComboBox.FormattingEnabled = true;
            this.Win32ClassesComboBox.Location = new System.Drawing.Point(385, 12);
            this.Win32ClassesComboBox.Name = "Win32ClassesComboBox";
            this.Win32ClassesComboBox.Size = new System.Drawing.Size(158, 21);
            this.Win32ClassesComboBox.TabIndex = 7;
            // 
            // RemoteSystemInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 457);
            this.Controls.Add(this.Win32ClassesComboBox);
            this.Controls.Add(this.SystemInformationsLabel);
            this.Controls.Add(this.DeviceInformationsLabel);
            this.Controls.Add(this.SystemInformationsTextBox);
            this.Controls.Add(this.DeviceInformationsTextBox);
            this.Controls.Add(this.SystemInformationButton);
            this.Controls.Add(this.DeviceInformationButton);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RemoteSystemInformationForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote System Information";
            this.Load += new System.EventHandler(this.SystemInformationForm_Load);
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
    }
}