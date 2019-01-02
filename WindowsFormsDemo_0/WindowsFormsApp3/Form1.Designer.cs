namespace WindowsFormsApp3
{
    partial class Form1
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
            this.myTabs = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileBtn = new System.Windows.Forms.Button();
            this.textFileLst = new System.Windows.Forms.ListBox();
            this.myOpenFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.myPictureBox = new System.Windows.Forms.PictureBox();
            this.loadImageBtn = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.textLbl = new System.Windows.Forms.Label();
            this.modifyForeBtn = new System.Windows.Forms.Button();
            this.modifyBackColor = new System.Windows.Forms.Button();
            this.myTabs.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // myTabs
            // 
            this.myTabs.Controls.Add(this.tabPage3);
            this.myTabs.Controls.Add(this.tabPage4);
            this.myTabs.Controls.Add(this.tabPage1);
            this.myTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myTabs.Location = new System.Drawing.Point(0, 24);
            this.myTabs.Name = "myTabs";
            this.myTabs.SelectedIndex = 0;
            this.myTabs.Size = new System.Drawing.Size(486, 432);
            this.myTabs.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textFileLst);
            this.tabPage3.Controls.Add(this.loadFileBtn);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(478, 406);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Text";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.loadImageBtn);
            this.tabPage4.Controls.Add(this.myPictureBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(478, 406);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Images";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(486, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // loadFileBtn
            // 
            this.loadFileBtn.Location = new System.Drawing.Point(8, 352);
            this.loadFileBtn.Name = "loadFileBtn";
            this.loadFileBtn.Size = new System.Drawing.Size(94, 29);
            this.loadFileBtn.TabIndex = 0;
            this.loadFileBtn.Text = "Load Text File";
            this.loadFileBtn.UseVisualStyleBackColor = true;
            this.loadFileBtn.Click += new System.EventHandler(this.loadFileBtn_Click);
            // 
            // textFileLst
            // 
            this.textFileLst.FormattingEnabled = true;
            this.textFileLst.Location = new System.Drawing.Point(8, 25);
            this.textFileLst.Name = "textFileLst";
            this.textFileLst.Size = new System.Drawing.Size(441, 290);
            this.textFileLst.TabIndex = 1;
            // 
            // myOpenFileDlg
            // 
            this.myOpenFileDlg.FileName = "openFileDialog1";
            // 
            // myPictureBox
            // 
            this.myPictureBox.Location = new System.Drawing.Point(24, 27);
            this.myPictureBox.Name = "myPictureBox";
            this.myPictureBox.Size = new System.Drawing.Size(426, 279);
            this.myPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myPictureBox.TabIndex = 0;
            this.myPictureBox.TabStop = false;
            // 
            // loadImageBtn
            // 
            this.loadImageBtn.Location = new System.Drawing.Point(24, 348);
            this.loadImageBtn.Name = "loadImageBtn";
            this.loadImageBtn.Size = new System.Drawing.Size(94, 29);
            this.loadImageBtn.TabIndex = 1;
            this.loadImageBtn.Text = "Load Image File";
            this.loadImageBtn.UseVisualStyleBackColor = true;
            this.loadImageBtn.Click += new System.EventHandler(this.loadImageBtn_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.modifyBackColor);
            this.tabPage1.Controls.Add(this.modifyForeBtn);
            this.tabPage1.Controls.Add(this.textLbl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(478, 406);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Colors";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textLbl
            // 
            this.textLbl.AutoSize = true;
            this.textLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textLbl.Location = new System.Drawing.Point(100, 143);
            this.textLbl.Name = "textLbl";
            this.textLbl.Size = new System.Drawing.Size(283, 37);
            this.textLbl.TabIndex = 0;
            this.textLbl.Text = "Hello I am a Label!";
            // 
            // modifyForeBtn
            // 
            this.modifyForeBtn.Location = new System.Drawing.Point(90, 283);
            this.modifyForeBtn.Name = "modifyForeBtn";
            this.modifyForeBtn.Size = new System.Drawing.Size(122, 23);
            this.modifyForeBtn.TabIndex = 1;
            this.modifyForeBtn.Text = "Modify ForeColor";
            this.modifyForeBtn.UseVisualStyleBackColor = true;
            this.modifyForeBtn.Click += new System.EventHandler(this.modifyForeBtn_Click);
            // 
            // modifyBackColor
            // 
            this.modifyBackColor.Location = new System.Drawing.Point(246, 283);
            this.modifyBackColor.Name = "modifyBackColor";
            this.modifyBackColor.Size = new System.Drawing.Size(157, 23);
            this.modifyBackColor.TabIndex = 2;
            this.modifyBackColor.Text = "Modify Background Color";
            this.modifyBackColor.UseVisualStyleBackColor = true;
            this.modifyBackColor.Click += new System.EventHandler(this.modifyBackColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 456);
            this.Controls.Add(this.myTabs);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.myTabs.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl myTabs;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ListBox textFileLst;
        private System.Windows.Forms.Button loadFileBtn;
        private System.Windows.Forms.OpenFileDialog myOpenFileDlg;
        private System.Windows.Forms.Button loadImageBtn;
        private System.Windows.Forms.PictureBox myPictureBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button modifyBackColor;
        private System.Windows.Forms.Button modifyForeBtn;
        private System.Windows.Forms.Label textLbl;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

