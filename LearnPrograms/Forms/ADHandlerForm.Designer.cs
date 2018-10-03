namespace LearnPrograms
{
    partial class ADHandlerForm
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
            this.ADComputersListBox = new System.Windows.Forms.ListBox();
            this.ADComputersListButton = new System.Windows.Forms.Button();
            this.directoryEntryTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ADComputersListBox
            // 
            this.ADComputersListBox.FormattingEnabled = true;
            this.ADComputersListBox.Location = new System.Drawing.Point(12, 39);
            this.ADComputersListBox.Name = "ADComputersListBox";
            this.ADComputersListBox.Size = new System.Drawing.Size(214, 329);
            this.ADComputersListBox.TabIndex = 0;
            // 
            // ADComputersListButton
            // 
            this.ADComputersListButton.Location = new System.Drawing.Point(12, 12);
            this.ADComputersListButton.Name = "ADComputersListButton";
            this.ADComputersListButton.Size = new System.Drawing.Size(119, 23);
            this.ADComputersListButton.TabIndex = 1;
            this.ADComputersListButton.Text = "AD Computers list";
            this.ADComputersListButton.UseVisualStyleBackColor = true;
            this.ADComputersListButton.Click += new System.EventHandler(this.ADComputersListButton_Click);
            // 
            // directoryEntryTextBox
            // 
            this.directoryEntryTextBox.Location = new System.Drawing.Point(137, 15);
            this.directoryEntryTextBox.Name = "directoryEntryTextBox";
            this.directoryEntryTextBox.Size = new System.Drawing.Size(165, 20);
            this.directoryEntryTextBox.TabIndex = 2;
            // 
            // ADHandlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.directoryEntryTextBox);
            this.Controls.Add(this.ADComputersListButton);
            this.Controls.Add(this.ADComputersListBox);
            this.Name = "ADHandlerForm";
            this.Text = "AD Learning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ADComputersListBox;
        private System.Windows.Forms.Button ADComputersListButton;
        private System.Windows.Forms.TextBox directoryEntryTextBox;
    }
}