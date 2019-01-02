using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.9.0", "File Explorer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void loadFileBtn_Click(object sender, EventArgs e)
        {
            myOpenFileDlg.Title = "Choose Text file";
            myOpenFileDlg.Filter = "Text files(*.txt)| *.txt";
            if (myOpenFileDlg.ShowDialog() == DialogResult.OK)
            {

                textFileLst.Items.Clear();

                var fileStream = new FileStream(myOpenFileDlg.FileName, FileMode.Open, FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        textFileLst.Items.Add(line);
                    }
                }
            }

        }

        private void loadImageBtn_Click(object sender, EventArgs e)
        {
            myOpenFileDlg.Title = "Choose Image file";
            myOpenFileDlg.Filter = "Image files(*.jpg)| *.jpg";
            if (myOpenFileDlg.ShowDialog() == DialogResult.OK)
            {

                textFileLst.Items.Clear();

                myPictureBox.Image = new Bitmap(myOpenFileDlg.FileName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit?", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void modifyForeBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textLbl.ForeColor = colorDialog1.Color;
            }
        }

        private void modifyBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textLbl.BackColor = colorDialog1.Color;
            }
        }
    }
}
