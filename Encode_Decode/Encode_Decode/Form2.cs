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



namespace Encode_Decode
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Panel panel1 = new Panel();
        int i = 140, j = 2, k = 50, l = 0;
        string[] path = new string[30];

        private void DynamicButton_Click(object sender, EventArgs e)
        {

        }
       
       
        private void txtRun_TextChanged(object sender, EventArgs e)
        {
            

        }
        
      
        private void CreateDynamicText()
        {
           
                
                TextBox txtRun = new TextBox();
                txtRun.Name = "txtDynamic";
                txtRun.Location = new System.Drawing.Point(k, 70 + i);
                txtRun.Size = new System.Drawing.Size(376, 20);
                txtRun.TextChanged += new EventHandler(txtRun_TextChanged);
                Controls.Add(txtRun);
                
                path[j] = Path.GetFullPath(openFileDialog1.FileName);
                txtRun.Text = path[j];
                j++;
                if (j == 8)
                {
                    k = 690;
                    i = -70;
                }
                    
            
           
            
        }
        
       
      

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                path[0] = Path.GetFullPath(openFileDialog1.FileName);
                textBox1.Text = path[0];
                
                
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                path[1] = Path.GetFullPath(openFileDialog1.FileName);
                textBox2.Text = path[1];
                
            }
         }
        private void button4_Click(object sender, EventArgs e)
        {

           
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
            
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                CreateDynamicText();
                i = i + 70;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string p1;
         string desk = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
         p1 = Path.GetFileName(path[0]);
         p2.p = Path.GetDirectoryName(path[0]);
         File.Delete(p2.p + "\\new1.zip");
         ZipFile zf = new ZipFile(p2.p+"\\new1.zip");
         for (i = 0; i < j; i++)
         {
             zf.AddFile(path[i],"");
         }
        zf.Save();
        System.Diagnostics.Process process = new System.Diagnostics.Process();
        System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
        startInfo.FileName = "CMD.exe";
        startInfo.WorkingDirectory=p2.p;
        string a = Path.GetExtension(p1);
        startInfo.Arguments = "/C copy /b " + "\"" + p1 + "\"" + " + new1.zip encode" + a;
        process.StartInfo = startInfo;
        process.Start();
        process.WaitForExit();
        startInfo.Arguments = "/C del " + "\"" +p2.p+ "\\new1.zip" + "\"";
        process.StartInfo = startInfo;
        process.Start();
        process.WaitForExit();

        Form1 f1=new Form1();
            f1.Show();
            this.Hide();

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
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

        private void Form2_Load(object sender, EventArgs e)
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

      



    }
}
