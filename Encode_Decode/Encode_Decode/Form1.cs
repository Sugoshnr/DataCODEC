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
using System.Threading;

namespace Encode_Decode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        string p3=p2.p;

 
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
            
            
        }

        private void Decode_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1=new Form1();
            f1.Show();
            this.Hide();

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }
    }
}
