namespace nagyZH_gsqrbp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUserControl1 = new System.Windows.Forms.Button();
            this.btnUserControl2 = new System.Windows.Forms.Button();
            this.btnUserControl3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnUserControl1
            // 
            this.btnUserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserControl1.Location = new System.Drawing.Point(12, 12);
            this.btnUserControl1.Name = "btnUserControl1";
            this.btnUserControl1.Size = new System.Drawing.Size(109, 23);
            this.btnUserControl1.TabIndex = 0;
            this.btnUserControl1.Text = "User Control 1";
            this.btnUserControl1.UseVisualStyleBackColor = true;
            this.btnUserControl1.Click += new System.EventHandler(this.btnUserControl1_Click);
            // 
            // btnUserControl2
            // 
            this.btnUserControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserControl2.Location = new System.Drawing.Point(12, 41);
            this.btnUserControl2.Name = "btnUserControl2";
            this.btnUserControl2.Size = new System.Drawing.Size(109, 23);
            this.btnUserControl2.TabIndex = 1;
            this.btnUserControl2.Text = "User Control 2";
            this.btnUserControl2.UseVisualStyleBackColor = true;
            this.btnUserControl2.Click += new System.EventHandler(this.btnUserControl2_Click);
            // 
            // btnUserControl3
            // 
            this.btnUserControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserControl3.Location = new System.Drawing.Point(12, 70);
            this.btnUserControl3.Name = "btnUserControl3";
            this.btnUserControl3.Size = new System.Drawing.Size(109, 23);
            this.btnUserControl3.TabIndex = 2;
            this.btnUserControl3.Text = "User Control 3";
            this.btnUserControl3.UseVisualStyleBackColor = true;
            this.btnUserControl3.Click += new System.EventHandler(this.btnUserControl3_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(127, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 473);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUserControl3);
            this.Controls.Add(this.btnUserControl2);
            this.Controls.Add(this.btnUserControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnUserControl1;
        private Button btnUserControl2;
        private Button btnUserControl3;
        private Panel panel1;
    }
}