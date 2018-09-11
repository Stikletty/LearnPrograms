﻿namespace LearnPrograms
{
    partial class NetWorkerFrom
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
            this.CheckNetworkButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.NetConnectedStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.IPToolPanel = new System.Windows.Forms.Panel();
            this.ResolveHostName = new System.Windows.Forms.Button();
            this.PingButton = new System.Windows.Forms.Button();
            this.ClearLogBoxButton = new System.Windows.Forms.Button();
            this.IPLogTextBox = new System.Windows.Forms.TextBox();
            this.HostNameTextBox = new System.Windows.Forms.TextBox();
            this.HostNameLabel = new System.Windows.Forms.Label();
            this.IPAddressTextBox = new System.Windows.Forms.TextBox();
            this.IPAddressLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ResetPanelButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.IPToolPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckNetworkButton
            // 
            this.CheckNetworkButton.Location = new System.Drawing.Point(12, 12);
            this.CheckNetworkButton.Name = "CheckNetworkButton";
            this.CheckNetworkButton.Size = new System.Drawing.Size(90, 23);
            this.CheckNetworkButton.TabIndex = 0;
            this.CheckNetworkButton.Text = "Check Network";
            this.CheckNetworkButton.UseVisualStyleBackColor = true;
            this.CheckNetworkButton.Click += new System.EventHandler(this.CheckNetworkButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NetConnectedStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 413);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // NetConnectedStatusLabel
            // 
            this.NetConnectedStatusLabel.Name = "NetConnectedStatusLabel";
            this.NetConnectedStatusLabel.Size = new System.Drawing.Size(116, 17);
            this.NetConnectedStatusLabel.Text = "NetConnectedStatus";
            // 
            // IPToolPanel
            // 
            this.IPToolPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IPToolPanel.Controls.Add(this.ResetPanelButton);
            this.IPToolPanel.Controls.Add(this.ResolveHostName);
            this.IPToolPanel.Controls.Add(this.PingButton);
            this.IPToolPanel.Controls.Add(this.ClearLogBoxButton);
            this.IPToolPanel.Controls.Add(this.IPLogTextBox);
            this.IPToolPanel.Controls.Add(this.HostNameTextBox);
            this.IPToolPanel.Controls.Add(this.HostNameLabel);
            this.IPToolPanel.Controls.Add(this.IPAddressTextBox);
            this.IPToolPanel.Controls.Add(this.IPAddressLabel);
            this.IPToolPanel.Location = new System.Drawing.Point(12, 41);
            this.IPToolPanel.Name = "IPToolPanel";
            this.IPToolPanel.Size = new System.Drawing.Size(349, 364);
            this.IPToolPanel.TabIndex = 2;
            // 
            // ResolveHostName
            // 
            this.ResolveHostName.Location = new System.Drawing.Point(273, 28);
            this.ResolveHostName.Name = "ResolveHostName";
            this.ResolveHostName.Size = new System.Drawing.Size(71, 23);
            this.ResolveHostName.TabIndex = 6;
            this.ResolveHostName.Text = "Resolve";
            this.ResolveHostName.UseVisualStyleBackColor = true;
            this.ResolveHostName.Click += new System.EventHandler(this.ResolveHostName_Click);
            // 
            // PingButton
            // 
            this.PingButton.Location = new System.Drawing.Point(273, 3);
            this.PingButton.Name = "PingButton";
            this.PingButton.Size = new System.Drawing.Size(71, 23);
            this.PingButton.TabIndex = 5;
            this.PingButton.Text = "Ping";
            this.PingButton.UseVisualStyleBackColor = true;
            this.PingButton.Click += new System.EventHandler(this.PingButton_Click);
            // 
            // ClearLogBoxButton
            // 
            this.ClearLogBoxButton.Location = new System.Drawing.Point(269, 334);
            this.ClearLogBoxButton.Name = "ClearLogBoxButton";
            this.ClearLogBoxButton.Size = new System.Drawing.Size(75, 23);
            this.ClearLogBoxButton.TabIndex = 3;
            this.ClearLogBoxButton.Text = "Clear Log";
            this.ClearLogBoxButton.UseVisualStyleBackColor = true;
            this.ClearLogBoxButton.Click += new System.EventHandler(this.ClearLogBoxButton_Click);
            // 
            // IPLogTextBox
            // 
            this.IPLogTextBox.Location = new System.Drawing.Point(4, 57);
            this.IPLogTextBox.Multiline = true;
            this.IPLogTextBox.Name = "IPLogTextBox";
            this.IPLogTextBox.ReadOnly = true;
            this.IPLogTextBox.Size = new System.Drawing.Size(340, 271);
            this.IPLogTextBox.TabIndex = 4;
            // 
            // HostNameTextBox
            // 
            this.HostNameTextBox.Location = new System.Drawing.Point(76, 30);
            this.HostNameTextBox.Name = "HostNameTextBox";
            this.HostNameTextBox.Size = new System.Drawing.Size(169, 20);
            this.HostNameTextBox.TabIndex = 3;
            // 
            // HostNameLabel
            // 
            this.HostNameLabel.AutoSize = true;
            this.HostNameLabel.Location = new System.Drawing.Point(7, 33);
            this.HostNameLabel.Name = "HostNameLabel";
            this.HostNameLabel.Size = new System.Drawing.Size(63, 13);
            this.HostNameLabel.TabIndex = 3;
            this.HostNameLabel.Text = "Host Name:";
            // 
            // IPAddressTextBox
            // 
            this.IPAddressTextBox.Location = new System.Drawing.Point(76, 3);
            this.IPAddressTextBox.Name = "IPAddressTextBox";
            this.IPAddressTextBox.Size = new System.Drawing.Size(169, 20);
            this.IPAddressTextBox.TabIndex = 1;
            // 
            // IPAddressLabel
            // 
            this.IPAddressLabel.AutoSize = true;
            this.IPAddressLabel.Location = new System.Drawing.Point(9, 6);
            this.IPAddressLabel.Name = "IPAddressLabel";
            this.IPAddressLabel.Size = new System.Drawing.Size(61, 13);
            this.IPAddressLabel.TabIndex = 0;
            this.IPAddressLabel.Text = "IP Address:";
            this.IPAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(713, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ResetPanelButton
            // 
            this.ResetPanelButton.Location = new System.Drawing.Point(188, 334);
            this.ResetPanelButton.Name = "ResetPanelButton";
            this.ResetPanelButton.Size = new System.Drawing.Size(75, 23);
            this.ResetPanelButton.TabIndex = 7;
            this.ResetPanelButton.Text = "Reset";
            this.ResetPanelButton.UseVisualStyleBackColor = true;
            this.ResetPanelButton.Click += new System.EventHandler(this.ResetPanelButton_Click);
            // 
            // NetWorkerFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 435);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.IPToolPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.CheckNetworkButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NetWorkerFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Network";
            this.Load += new System.EventHandler(this.NetWorkerFrom_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.IPToolPanel.ResumeLayout(false);
            this.IPToolPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CheckNetworkButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel NetConnectedStatusLabel;
        private System.Windows.Forms.Panel IPToolPanel;
        private System.Windows.Forms.TextBox HostNameTextBox;
        private System.Windows.Forms.Label HostNameLabel;
        private System.Windows.Forms.TextBox IPAddressTextBox;
        private System.Windows.Forms.Label IPAddressLabel;
        private System.Windows.Forms.Button ClearLogBoxButton;
        private System.Windows.Forms.TextBox IPLogTextBox;
        private System.Windows.Forms.Button ResolveHostName;
        private System.Windows.Forms.Button PingButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ResetPanelButton;
    }
}