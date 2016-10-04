namespace Encode_Decode
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.Programming = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Programming
            // 
            this.Programming.Location = new System.Drawing.Point(101, 9);
            this.Programming.Name = "Programming";
            this.Programming.Size = new System.Drawing.Size(172, 105);
            this.Programming.TabIndex = 0;
            this.Programming.Text = "Programming \r\n--------------\r\nSugosh . N . R\r\nSuraj. K\r\nVarun Nagaraj\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 142);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Programming);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authors";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Programming;
        private System.Windows.Forms.Button button1;
    }
}