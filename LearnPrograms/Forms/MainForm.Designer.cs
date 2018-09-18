namespace LearnPrograms
{
    partial class MainForm
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
            this.NetworkButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SystemInfButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.UserInfoStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.RemoteSystemInfButton = new System.Windows.Forms.Button();
            this.ComputerNameStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NetworkButton
            // 
            this.NetworkButton.Location = new System.Drawing.Point(12, 12);
            this.NetworkButton.Name = "NetworkButton";
            this.NetworkButton.Size = new System.Drawing.Size(75, 23);
            this.NetworkButton.TabIndex = 0;
            this.NetworkButton.Text = "Network";
            this.NetworkButton.UseVisualStyleBackColor = true;
            this.NetworkButton.Click += new System.EventHandler(this.NetworkButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(713, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SystemInfButton
            // 
            this.SystemInfButton.Location = new System.Drawing.Point(93, 12);
            this.SystemInfButton.Name = "SystemInfButton";
            this.SystemInfButton.Size = new System.Drawing.Size(135, 23);
            this.SystemInfButton.TabIndex = 2;
            this.SystemInfButton.Text = "Local System Information";
            this.SystemInfButton.UseVisualStyleBackColor = true;
            this.SystemInfButton.Click += new System.EventHandler(this.SystemInfButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ComputerNameStatusLabel,
            this.UserInfoStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // UserInfoStatusLabel
            // 
            this.UserInfoStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.UserInfoStatusLabel.Name = "UserInfoStatusLabel";
            this.UserInfoStatusLabel.Size = new System.Drawing.Size(54, 17);
            this.UserInfoStatusLabel.Text = "UserData";
            // 
            // RemoteSystemInfButton
            // 
            this.RemoteSystemInfButton.Location = new System.Drawing.Point(234, 12);
            this.RemoteSystemInfButton.Name = "RemoteSystemInfButton";
            this.RemoteSystemInfButton.Size = new System.Drawing.Size(148, 23);
            this.RemoteSystemInfButton.TabIndex = 4;
            this.RemoteSystemInfButton.Text = "Remote System Information";
            this.RemoteSystemInfButton.UseVisualStyleBackColor = true;
            this.RemoteSystemInfButton.Click += new System.EventHandler(this.RemoteSystemInfButton_Click);
            // 
            // ComputerNameStatusLabel
            // 
            this.ComputerNameStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.ComputerNameStatusLabel.Name = "ComputerNameStatusLabel";
            this.ComputerNameStatusLabel.Size = new System.Drawing.Size(92, 17);
            this.ComputerNameStatusLabel.Text = "computer name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RemoteSystemInfButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.SystemInfButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.NetworkButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NetworkButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SystemInfButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel UserInfoStatusLabel;
        private System.Windows.Forms.Button RemoteSystemInfButton;
        private System.Windows.Forms.ToolStripStatusLabel ComputerNameStatusLabel;
    }
}

