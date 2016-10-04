using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using Ionic.Zip;
using System.Diagnostics;
using System.Linq;

namespace Encode_Decode
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string path1,path2, p1,p;
        

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                path1 = Path.GetFullPath(openFileDialog1.FileName);
                textBox1.Text = path1;
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            
            f1.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            
            p1 = Path.GetFileName(path1);
            p2.p = Path.GetDirectoryName(path1);

            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.WorkingDirectory = p2.p;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C copy /d " + "\"" + p1 + "\"" + " decode.zip";
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
                startInfo.WorkingDirectory = "";
                startInfo.FileName = "7za.exe";
                startInfo.Arguments = "x " + "\"" + p2.p + "\\decode.zip" + "\"" + " -aoa -o" + "\"" + p2.p + "\"";
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
                startInfo.WorkingDirectory = p2.p;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C del " + "\"" + p2.p + "\\decode.zip" + "\"";
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
                startInfo.Arguments = "/C del " + "\"" + p2.p + "\\7z.exe" + "\"";
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();

            }
 

            File.Delete(p2.p + "\\new1.zip");

            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();

            ab.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f1 = new Form6();
            f1.Show();
        }
    }
}
