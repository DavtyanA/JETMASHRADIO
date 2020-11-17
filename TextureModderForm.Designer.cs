namespace JETMASHRADIO
{
    partial class TextureModderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextureModderForm));
            this.selectItemLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bmpRadioButton = new System.Windows.Forms.RadioButton();
            this.pvrRadioButton = new System.Windows.Forms.RadioButton();
            this.ImportSuccessLabel = new System.Windows.Forms.Label();
            this.ImportErrorLabel = new System.Windows.Forms.Label();
            this.convertToBinFileButton = new System.Windows.Forms.Button();
            this.binDirBrowseButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ExportedBinOutputDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.FilesToImportDirectory = new System.Windows.Forms.TextBox();
            this.pvrFileDirButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.convertToPNGButton = new System.Windows.Forms.Button();
            this.ExportSuccessLabel = new System.Windows.Forms.Label();
            this.convertPVRError = new System.Windows.Forms.Label();
            this.ExportErrorLabel = new System.Windows.Forms.Label();
            this.convertToPVRButton = new System.Windows.Forms.Button();
            this.binFileLocationLabel = new System.Windows.Forms.Label();
            this.outDirFileChooseBtn = new System.Windows.Forms.Button();
            this.BinToExportFilePathTextBox = new System.Windows.Forms.TextBox();
            this.ExportedTexturesDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.binFileChooser = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.characterRadioButton = new System.Windows.Forms.RadioButton();
            this.stageRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectItemLabel
            // 
            this.selectItemLabel.AutoSize = true;
            this.selectItemLabel.Location = new System.Drawing.Point(207, 36);
            this.selectItemLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectItemLabel.Name = "selectItemLabel";
            this.selectItemLabel.Size = new System.Drawing.Size(104, 15);
            this.selectItemLabel.TabIndex = 0;
            this.selectItemLabel.Text = "Select a Character:";
            this.selectItemLabel.Click += new System.EventHandler(this.selectItemLabel_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(319, 33);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.ImportSuccessLabel);
            this.tabPage2.Controls.Add(this.ImportErrorLabel);
            this.tabPage2.Controls.Add(this.convertToBinFileButton);
            this.tabPage2.Controls.Add(this.binDirBrowseButton);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.ExportedBinOutputDirectoryTextBox);
            this.tabPage2.Controls.Add(this.FilesToImportDirectory);
            this.tabPage2.Controls.Add(this.pvrFileDirButton);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(440, 306);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Import Textures";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bmpRadioButton);
            this.groupBox2.Controls.Add(this.pvrRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(13, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(195, 62);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filetype";
            // 
            // bmpRadioButton
            // 
            this.bmpRadioButton.AutoSize = true;
            this.bmpRadioButton.Checked = true;
            this.bmpRadioButton.Location = new System.Drawing.Point(7, 22);
            this.bmpRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bmpRadioButton.Name = "bmpRadioButton";
            this.bmpRadioButton.Size = new System.Drawing.Size(49, 19);
            this.bmpRadioButton.TabIndex = 21;
            this.bmpRadioButton.TabStop = true;
            this.bmpRadioButton.Text = ".png";
            this.bmpRadioButton.UseVisualStyleBackColor = true;
            // 
            // pvrRadioButton
            // 
            this.pvrRadioButton.AutoSize = true;
            this.pvrRadioButton.Location = new System.Drawing.Point(97, 22);
            this.pvrRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pvrRadioButton.Name = "pvrRadioButton";
            this.pvrRadioButton.Size = new System.Drawing.Size(45, 19);
            this.pvrRadioButton.TabIndex = 22;
            this.pvrRadioButton.Text = ".pvr";
            this.pvrRadioButton.UseVisualStyleBackColor = true;
            // 
            // ImportSuccessLabel
            // 
            this.ImportSuccessLabel.AutoSize = true;
            this.ImportSuccessLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.ImportSuccessLabel.Location = new System.Drawing.Point(208, 215);
            this.ImportSuccessLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ImportSuccessLabel.Name = "ImportSuccessLabel";
            this.ImportSuccessLabel.Size = new System.Drawing.Size(0, 15);
            this.ImportSuccessLabel.TabIndex = 17;
            // 
            // ImportErrorLabel
            // 
            this.ImportErrorLabel.AutoSize = true;
            this.ImportErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ImportErrorLabel.Location = new System.Drawing.Point(208, 185);
            this.ImportErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ImportErrorLabel.Name = "ImportErrorLabel";
            this.ImportErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.ImportErrorLabel.TabIndex = 16;
            // 
            // convertToBinFileButton
            // 
            this.convertToBinFileButton.Location = new System.Drawing.Point(13, 149);
            this.convertToBinFileButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.convertToBinFileButton.Name = "convertToBinFileButton";
            this.convertToBinFileButton.Size = new System.Drawing.Size(176, 110);
            this.convertToBinFileButton.TabIndex = 14;
            this.convertToBinFileButton.Text = "Convert to BIN file";
            this.convertToBinFileButton.UseVisualStyleBackColor = true;
            this.convertToBinFileButton.Click += new System.EventHandler(this.convertToBinFileButton_Click);
            // 
            // binDirBrowseButton
            // 
            this.binDirBrowseButton.Location = new System.Drawing.Point(406, 103);
            this.binDirBrowseButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.binDirBrowseButton.Name = "binDirBrowseButton";
            this.binDirBrowseButton.Size = new System.Drawing.Size(88, 27);
            this.binDirBrowseButton.TabIndex = 13;
            this.binDirBrowseButton.Text = "Browse...";
            this.binDirBrowseButton.UseVisualStyleBackColor = true;
            this.binDirBrowseButton.Click += new System.EventHandler(this.binDirBrowseButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Output Directory:";
            // 
            // ExportedBinOutputDirectoryTextBox
            // 
            this.ExportedBinOutputDirectoryTextBox.Location = new System.Drawing.Point(118, 105);
            this.ExportedBinOutputDirectoryTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExportedBinOutputDirectoryTextBox.Name = "ExportedBinOutputDirectoryTextBox";
            this.ExportedBinOutputDirectoryTextBox.Size = new System.Drawing.Size(268, 23);
            this.ExportedBinOutputDirectoryTextBox.TabIndex = 11;
            // 
            // FilesToImportDirectory
            // 
            this.FilesToImportDirectory.Location = new System.Drawing.Point(146, 75);
            this.FilesToImportDirectory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FilesToImportDirectory.Name = "FilesToImportDirectory";
            this.FilesToImportDirectory.Size = new System.Drawing.Size(268, 23);
            this.FilesToImportDirectory.TabIndex = 8;
            // 
            // pvrFileDirButton
            // 
            this.pvrFileDirButton.Location = new System.Drawing.Point(434, 73);
            this.pvrFileDirButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pvrFileDirButton.Name = "pvrFileDirButton";
            this.pvrFileDirButton.Size = new System.Drawing.Size(88, 27);
            this.pvrFileDirButton.TabIndex = 10;
            this.pvrFileDirButton.Text = "Browse...";
            this.pvrFileDirButton.UseVisualStyleBackColor = true;
            this.pvrFileDirButton.Click += new System.EventHandler(this.pvrFileDirButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Directory of PVR Files:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.convertToPNGButton);
            this.tabPage1.Controls.Add(this.ExportSuccessLabel);
            this.tabPage1.Controls.Add(this.convertPVRError);
            this.tabPage1.Controls.Add(this.ExportErrorLabel);
            this.tabPage1.Controls.Add(this.convertToPVRButton);
            this.tabPage1.Controls.Add(this.binFileLocationLabel);
            this.tabPage1.Controls.Add(this.outDirFileChooseBtn);
            this.tabPage1.Controls.Add(this.BinToExportFilePathTextBox);
            this.tabPage1.Controls.Add(this.ExportedTexturesDirectoryTextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.binFileChooser);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(440, 306);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Export Textures";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // convertToPNGButton
            // 
            this.convertToPNGButton.Location = new System.Drawing.Point(211, 158);
            this.convertToPNGButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.convertToPNGButton.Name = "convertToPNGButton";
            this.convertToPNGButton.Size = new System.Drawing.Size(176, 110);
            this.convertToPNGButton.TabIndex = 18;
            this.convertToPNGButton.Text = "Convert to PNG file(s)";
            this.convertToPNGButton.UseVisualStyleBackColor = true;
            this.convertToPNGButton.Click += new System.EventHandler(this.convertToPNGButton_Click);
            // 
            // ExportSuccessLabel
            // 
            this.ExportSuccessLabel.AutoSize = true;
            this.ExportSuccessLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.ExportSuccessLabel.Location = new System.Drawing.Point(19, 290);
            this.ExportSuccessLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExportSuccessLabel.Name = "ExportSuccessLabel";
            this.ExportSuccessLabel.Size = new System.Drawing.Size(0, 15);
            this.ExportSuccessLabel.TabIndex = 17;
            // 
            // convertPVRError
            // 
            this.convertPVRError.AutoSize = true;
            this.convertPVRError.ForeColor = System.Drawing.Color.Red;
            this.convertPVRError.Location = new System.Drawing.Point(19, 290);
            this.convertPVRError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.convertPVRError.Name = "convertPVRError";
            this.convertPVRError.Size = new System.Drawing.Size(0, 15);
            this.convertPVRError.TabIndex = 10;
            // 
            // ExportErrorLabel
            // 
            this.ExportErrorLabel.AutoSize = true;
            this.ExportErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ExportErrorLabel.Location = new System.Drawing.Point(19, 290);
            this.ExportErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExportErrorLabel.Name = "ExportErrorLabel";
            this.ExportErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.ExportErrorLabel.TabIndex = 9;
            // 
            // convertToPVRButton
            // 
            this.convertToPVRButton.Location = new System.Drawing.Point(9, 158);
            this.convertToPVRButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.convertToPVRButton.Name = "convertToPVRButton";
            this.convertToPVRButton.Size = new System.Drawing.Size(176, 110);
            this.convertToPVRButton.TabIndex = 8;
            this.convertToPVRButton.Text = "Convert to PVR file(s)";
            this.convertToPVRButton.UseVisualStyleBackColor = true;
            this.convertToPVRButton.Click += new System.EventHandler(this.convertToPVRButton_Click);
            // 
            // binFileLocationLabel
            // 
            this.binFileLocationLabel.AutoSize = true;
            this.binFileLocationLabel.Location = new System.Drawing.Point(7, 17);
            this.binFileLocationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.binFileLocationLabel.Name = "binFileLocationLabel";
            this.binFileLocationLabel.Size = new System.Drawing.Size(148, 15);
            this.binFileLocationLabel.TabIndex = 2;
            this.binFileLocationLabel.Text = "Link to location of .bin file:";
            // 
            // outDirFileChooseBtn
            // 
            this.outDirFileChooseBtn.Location = new System.Drawing.Point(299, 96);
            this.outDirFileChooseBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.outDirFileChooseBtn.Name = "outDirFileChooseBtn";
            this.outDirFileChooseBtn.Size = new System.Drawing.Size(88, 27);
            this.outDirFileChooseBtn.TabIndex = 7;
            this.outDirFileChooseBtn.Text = "Browse...";
            this.outDirFileChooseBtn.UseVisualStyleBackColor = true;
            this.outDirFileChooseBtn.Click += new System.EventHandler(this.outDirFileChooseBtn_Click);
            // 
            // BinToExportFilePathTextBox
            // 
            this.BinToExportFilePathTextBox.Location = new System.Drawing.Point(10, 38);
            this.BinToExportFilePathTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BinToExportFilePathTextBox.Name = "BinToExportFilePathTextBox";
            this.BinToExportFilePathTextBox.Size = new System.Drawing.Size(268, 23);
            this.BinToExportFilePathTextBox.TabIndex = 3;
            // 
            // ExportedTexturesDirectoryTextBox
            // 
            this.ExportedTexturesDirectoryTextBox.Location = new System.Drawing.Point(10, 98);
            this.ExportedTexturesDirectoryTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExportedTexturesDirectoryTextBox.Name = "ExportedTexturesDirectoryTextBox";
            this.ExportedTexturesDirectoryTextBox.Size = new System.Drawing.Size(268, 23);
            this.ExportedTexturesDirectoryTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output Directory:";
            // 
            // binFileChooser
            // 
            this.binFileChooser.Location = new System.Drawing.Point(299, 36);
            this.binFileChooser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.binFileChooser.Name = "binFileChooser";
            this.binFileChooser.Size = new System.Drawing.Size(88, 27);
            this.binFileChooser.TabIndex = 4;
            this.binFileChooser.Text = "Browse...";
            this.binFileChooser.UseVisualStyleBackColor = true;
            this.binFileChooser.Click += new System.EventHandler(this.binFileChooser_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(19, 80);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(448, 334);
            this.tabControl1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.characterRadioButton);
            this.groupBox1.Controls.Add(this.stageRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(170, 62);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // characterRadioButton
            // 
            this.characterRadioButton.AutoSize = true;
            this.characterRadioButton.Checked = true;
            this.characterRadioButton.Location = new System.Drawing.Point(7, 22);
            this.characterRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.characterRadioButton.Name = "characterRadioButton";
            this.characterRadioButton.Size = new System.Drawing.Size(76, 19);
            this.characterRadioButton.TabIndex = 21;
            this.characterRadioButton.TabStop = true;
            this.characterRadioButton.Text = "Character";
            this.characterRadioButton.UseVisualStyleBackColor = true;
            this.characterRadioButton.CheckedChanged += new System.EventHandler(this.characterRadioButton_CheckedChanged);
            // 
            // stageRadioButton
            // 
            this.stageRadioButton.AutoSize = true;
            this.stageRadioButton.Location = new System.Drawing.Point(97, 22);
            this.stageRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.stageRadioButton.Name = "stageRadioButton";
            this.stageRadioButton.Size = new System.Drawing.Size(54, 19);
            this.stageRadioButton.TabIndex = 22;
            this.stageRadioButton.Text = "Stage";
            this.stageRadioButton.UseVisualStyleBackColor = true;
            this.stageRadioButton.CheckedChanged += new System.EventHandler(this.stageRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Данный прикол сделан челиком по имени Alex Spedding @AlexDiru ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextureModderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.selectItemLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TextureModderForm";
            this.Text = "JET MASH RADIOOOOOO";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectItemLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label ImportSuccessLabel;
        private System.Windows.Forms.Label ImportErrorLabel;
        private System.Windows.Forms.Button convertToBinFileButton;
        private System.Windows.Forms.Button binDirBrowseButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ExportedBinOutputDirectoryTextBox;
        private System.Windows.Forms.TextBox FilesToImportDirectory;
        private System.Windows.Forms.Button pvrFileDirButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label ExportSuccessLabel;
        private System.Windows.Forms.Label convertPVRError;
        private System.Windows.Forms.Label ExportErrorLabel;
        private System.Windows.Forms.Button convertToPVRButton;
        private System.Windows.Forms.Label binFileLocationLabel;
        private System.Windows.Forms.Button outDirFileChooseBtn;
        private System.Windows.Forms.TextBox BinToExportFilePathTextBox;
        private System.Windows.Forms.TextBox ExportedTexturesDirectoryTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button binFileChooser;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button convertToPNGButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton bmpRadioButton;
        private System.Windows.Forms.RadioButton pvrRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton characterRadioButton;
        private System.Windows.Forms.RadioButton stageRadioButton;
        private System.Windows.Forms.Label label1;
    }
}