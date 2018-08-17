namespace OeCheckDevices
{
    public partial class Main
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
            this.lblIniFilePath = new System.Windows.Forms.Label();
            this.tbIniFilePath = new System.Windows.Forms.TextBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.tbSection = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.btnReadValue = new System.Windows.Forms.Button();
            this.btnReadSection = new System.Windows.Forms.Button();
            this.btnReadKeys = new System.Windows.Forms.Button();
            this.btnReadKeyValuePairs = new System.Windows.Forms.Button();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnWriteValue = new System.Windows.Forms.Button();
            this.btnDeleteSection = new System.Windows.Forms.Button();
            this.btnDeleteKey = new System.Windows.Forms.Button();
            this.tbIniFile = new System.Windows.Forms.TextBox();
            this.btncheckini = new System.Windows.Forms.Button();
            this.lblfileexists = new System.Windows.Forms.Label();
            this.btnCurrentDir = new System.Windows.Forms.Button();
            this.lblCurrentdir = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIniFilePath
            // 
            this.lblIniFilePath.AutoSize = true;
            this.lblIniFilePath.Location = new System.Drawing.Point(27, 36);
            this.lblIniFilePath.Name = "lblIniFilePath";
            this.lblIniFilePath.Size = new System.Drawing.Size(65, 13);
            this.lblIniFilePath.TabIndex = 0;
            this.lblIniFilePath.Text = "INI File Path";
            // 
            // tbIniFilePath
            // 
            this.tbIniFilePath.Location = new System.Drawing.Point(192, 29);
            this.tbIniFilePath.Name = "tbIniFilePath";
            this.tbIniFilePath.Size = new System.Drawing.Size(229, 20);
            this.tbIniFilePath.TabIndex = 1;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Location = new System.Drawing.Point(27, 72);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(43, 13);
            this.lblSection.TabIndex = 2;
            this.lblSection.Text = "Section";
            // 
            // tbSection
            // 
            this.tbSection.Location = new System.Drawing.Point(192, 65);
            this.tbSection.Name = "tbSection";
            this.tbSection.Size = new System.Drawing.Size(229, 20);
            this.tbSection.TabIndex = 3;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(27, 112);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(25, 13);
            this.lblKey.TabIndex = 4;
            this.lblKey.Text = "Key";
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(192, 105);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(229, 20);
            this.tbKey.TabIndex = 5;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(27, 158);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(34, 13);
            this.lblValue.TabIndex = 6;
            this.lblValue.Text = "Value";
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(192, 151);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(229, 20);
            this.tbValue.TabIndex = 7;
            // 
            // btnReadValue
            // 
            this.btnReadValue.Location = new System.Drawing.Point(27, 210);
            this.btnReadValue.Name = "btnReadValue";
            this.btnReadValue.Size = new System.Drawing.Size(146, 23);
            this.btnReadValue.TabIndex = 8;
            this.btnReadValue.Text = "Read Value";
            this.btnReadValue.UseVisualStyleBackColor = true;
            this.btnReadValue.Click += new System.EventHandler(this.btnReadValue_Click);
            // 
            // btnReadSection
            // 
            this.btnReadSection.Location = new System.Drawing.Point(27, 240);
            this.btnReadSection.Name = "btnReadSection";
            this.btnReadSection.Size = new System.Drawing.Size(146, 23);
            this.btnReadSection.TabIndex = 9;
            this.btnReadSection.Text = "Read Section";
            this.btnReadSection.UseVisualStyleBackColor = true;
            this.btnReadSection.Click += new System.EventHandler(this.btnReadSection_Click);
            // 
            // btnReadKeys
            // 
            this.btnReadKeys.Location = new System.Drawing.Point(27, 270);
            this.btnReadKeys.Name = "btnReadKeys";
            this.btnReadKeys.Size = new System.Drawing.Size(146, 23);
            this.btnReadKeys.TabIndex = 10;
            this.btnReadKeys.Text = "Read Keys";
            this.btnReadKeys.UseVisualStyleBackColor = true;
            this.btnReadKeys.Click += new System.EventHandler(this.btnReadKeys_Click);
            // 
            // btnReadKeyValuePairs
            // 
            this.btnReadKeyValuePairs.Location = new System.Drawing.Point(27, 300);
            this.btnReadKeyValuePairs.Name = "btnReadKeyValuePairs";
            this.btnReadKeyValuePairs.Size = new System.Drawing.Size(146, 23);
            this.btnReadKeyValuePairs.TabIndex = 11;
            this.btnReadKeyValuePairs.Text = "Read Key Value Pairs";
            this.btnReadKeyValuePairs.UseVisualStyleBackColor = true;
            this.btnReadKeyValuePairs.Click += new System.EventHandler(this.btnReadKeyValuePairs_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(27, 330);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(146, 23);
            this.btnReadFile.TabIndex = 12;
            this.btnReadFile.Text = "Read File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // btnWriteValue
            // 
            this.btnWriteValue.Location = new System.Drawing.Point(192, 211);
            this.btnWriteValue.Name = "btnWriteValue";
            this.btnWriteValue.Size = new System.Drawing.Size(135, 23);
            this.btnWriteValue.TabIndex = 13;
            this.btnWriteValue.Text = "Write Value";
            this.btnWriteValue.UseVisualStyleBackColor = true;
            this.btnWriteValue.Click += new System.EventHandler(this.btnWriteValue_Click);
            // 
            // btnDeleteSection
            // 
            this.btnDeleteSection.Location = new System.Drawing.Point(192, 240);
            this.btnDeleteSection.Name = "btnDeleteSection";
            this.btnDeleteSection.Size = new System.Drawing.Size(135, 23);
            this.btnDeleteSection.TabIndex = 14;
            this.btnDeleteSection.Text = "Delete Section";
            this.btnDeleteSection.UseVisualStyleBackColor = true;
            this.btnDeleteSection.Click += new System.EventHandler(this.btnDeleteSection_Click);
            // 
            // btnDeleteKey
            // 
            this.btnDeleteKey.Location = new System.Drawing.Point(192, 270);
            this.btnDeleteKey.Name = "btnDeleteKey";
            this.btnDeleteKey.Size = new System.Drawing.Size(135, 23);
            this.btnDeleteKey.TabIndex = 15;
            this.btnDeleteKey.Text = "Delete Key";
            this.btnDeleteKey.UseVisualStyleBackColor = true;
            this.btnDeleteKey.Click += new System.EventHandler(this.btnDeleteKey_Click);
            // 
            // tbIniFile
            // 
            this.tbIniFile.Location = new System.Drawing.Point(27, 184);
            this.tbIniFile.Name = "tbIniFile";
            this.tbIniFile.Size = new System.Drawing.Size(394, 20);
            this.tbIniFile.TabIndex = 16;
            // 
            // btncheckini
            // 
            this.btncheckini.Location = new System.Drawing.Point(27, 397);
            this.btncheckini.Name = "btncheckini";
            this.btncheckini.Size = new System.Drawing.Size(202, 23);
            this.btncheckini.TabIndex = 17;
            this.btncheckini.Text = "Check if INI is available";
            this.btncheckini.UseVisualStyleBackColor = true;
            this.btncheckini.Click += new System.EventHandler(this.btncheckini_Click);
            // 
            // lblfileexists
            // 
            this.lblfileexists.AutoSize = true;
            this.lblfileexists.Location = new System.Drawing.Point(24, 436);
            this.lblfileexists.Name = "lblfileexists";
            this.lblfileexists.Size = new System.Drawing.Size(51, 13);
            this.lblfileexists.TabIndex = 18;
            this.lblfileexists.Text = "unknown";
            // 
            // btnCurrentDir
            // 
            this.btnCurrentDir.Location = new System.Drawing.Point(259, 397);
            this.btnCurrentDir.Name = "btnCurrentDir";
            this.btnCurrentDir.Size = new System.Drawing.Size(162, 23);
            this.btnCurrentDir.TabIndex = 19;
            this.btnCurrentDir.Text = "Get Current Directory";
            this.btnCurrentDir.UseVisualStyleBackColor = true;
            this.btnCurrentDir.Click += new System.EventHandler(this.btnCurrentDir_Click);
            // 
            // lblCurrentdir
            // 
            this.lblCurrentdir.AutoSize = true;
            this.lblCurrentdir.Location = new System.Drawing.Point(259, 436);
            this.lblCurrentdir.Name = "lblCurrentdir";
            this.lblCurrentdir.Size = new System.Drawing.Size(23, 13);
            this.lblCurrentdir.TabIndex = 20;
            this.lblCurrentdir.Text = "null";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tsAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(787, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsAbout
            // 
            this.tsAbout.Name = "tsAbout";
            this.tsAbout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsAbout.Size = new System.Drawing.Size(52, 20);
            this.tsAbout.Text = "&About";
            this.tsAbout.Click += new System.EventHandler(this.tsAbout_Click);
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(787, 491);
            this.Controls.Add(this.lblCurrentdir);
            this.Controls.Add(this.btnCurrentDir);
            this.Controls.Add(this.lblfileexists);
            this.Controls.Add(this.btncheckini);
            this.Controls.Add(this.tbIniFile);
            this.Controls.Add(this.btnDeleteKey);
            this.Controls.Add(this.btnDeleteSection);
            this.Controls.Add(this.btnWriteValue);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.btnReadKeyValuePairs);
            this.Controls.Add(this.btnReadKeys);
            this.Controls.Add(this.btnReadSection);
            this.Controls.Add(this.btnReadValue);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.tbSection);
            this.Controls.Add(this.lblSection);
            this.Controls.Add(this.tbIniFilePath);
            this.Controls.Add(this.lblIniFilePath);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxFilePath;
        private System.Windows.Forms.TextBox txtBoxSection;
        private System.Windows.Forms.TextBox txtBoxKey;
        private System.Windows.Forms.TextBox txtBoxValue;
        private System.Windows.Forms.Button btnReadValues;
        private System.Windows.Forms.Label lblIniFilePath;
        private System.Windows.Forms.TextBox tbIniFilePath;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.TextBox tbSection;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Button btnReadValue;
        private System.Windows.Forms.Button btnReadSection;
        private System.Windows.Forms.Button btnReadKeys;
        private System.Windows.Forms.Button btnReadKeyValuePairs;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button btnWriteValue;
        private System.Windows.Forms.Button btnDeleteSection;
        private System.Windows.Forms.Button btnDeleteKey;
        private System.Windows.Forms.TextBox tbIniFile;
        private System.Windows.Forms.Button btncheckini;
        private System.Windows.Forms.Label lblfileexists;
        private System.Windows.Forms.Button btnCurrentDir;
        private System.Windows.Forms.Label lblCurrentdir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsAbout;
    }
}

