namespace JETMASHRADIO
{
    partial class InitialForm
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
            this.ModDownloadButton = new System.Windows.Forms.Button();
            this.ModifyFilesButton = new System.Windows.Forms.Button();
            this.MashupLink = new System.Windows.Forms.LinkLabel();
            this.ShonLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ModDownloadButton
            // 
            this.ModDownloadButton.Location = new System.Drawing.Point(178, 63);
            this.ModDownloadButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ModDownloadButton.Name = "ModDownloadButton";
            this.ModDownloadButton.Size = new System.Drawing.Size(177, 85);
            this.ModDownloadButton.TabIndex = 24;
            this.ModDownloadButton.Text = "Просто установить мод";
            this.ModDownloadButton.UseVisualStyleBackColor = true;
            this.ModDownloadButton.Click += new System.EventHandler(this.characterModderButton_Click);
            // 
            // ModifyFilesButton
            // 
            this.ModifyFilesButton.Location = new System.Drawing.Point(178, 165);
            this.ModifyFilesButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ModifyFilesButton.Name = "ModifyFilesButton";
            this.ModifyFilesButton.Size = new System.Drawing.Size(177, 89);
            this.ModifyFilesButton.TabIndex = 25;
            this.ModifyFilesButton.Text = "Модифицировать файлы";
            this.ModifyFilesButton.UseVisualStyleBackColor = true;
            this.ModifyFilesButton.Click += new System.EventHandler(this.preferencesButton_Click);
            // 
            // MashupLink
            // 
            this.MashupLink.AutoSize = true;
            this.MashupLink.BackColor = System.Drawing.Color.Transparent;
            this.MashupLink.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MashupLink.LinkColor = System.Drawing.Color.White;
            this.MashupLink.Location = new System.Drawing.Point(12, 311);
            this.MashupLink.Name = "MashupLink";
            this.MashupLink.Size = new System.Drawing.Size(123, 20);
            this.MashupLink.TabIndex = 26;
            this.MashupLink.TabStop = true;
            this.MashupLink.Text = "vk.com/mashup";
            this.MashupLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MashupLink_LinkClicked);
            // 
            // ShonLink
            // 
            this.ShonLink.AutoSize = true;
            this.ShonLink.BackColor = System.Drawing.Color.Transparent;
            this.ShonLink.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShonLink.LinkColor = System.Drawing.Color.White;
            this.ShonLink.Location = new System.Drawing.Point(377, 311);
            this.ShonLink.Name = "ShonLink";
            this.ShonLink.Size = new System.Drawing.Size(157, 20);
            this.ShonLink.TabIndex = 26;
            this.ShonLink.TabStop = true;
            this.ShonLink.Text = "vk.com/shonyourbro";
            this.ShonLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShonLink_LinkClicked);
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 340);
            this.Controls.Add(this.ShonLink);
            this.Controls.Add(this.MashupLink);
            this.Controls.Add(this.ModifyFilesButton);
            this.Controls.Add(this.ModDownloadButton);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "InitialForm";
            this.Text = "JET MASH RADIO";
            this.Load += new System.EventHandler(this.InitialForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ModDownloadButton;
        private System.Windows.Forms.Button ModifyFilesButton;
        private System.Windows.Forms.LinkLabel MashupLink;
        private System.Windows.Forms.LinkLabel ShonLink;
    }
}