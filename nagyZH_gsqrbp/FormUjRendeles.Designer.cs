namespace nagyZH_gsqrbp
{
    partial class FormUjRendeles
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
            this.components = new System.ComponentModel.Container();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbLogin = new System.Windows.Forms.ComboBox();
            this.labelSorszam = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.txtSorszam = new System.Windows.Forms.TextBox();
            this.ugyfelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ugyfelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(12, 70);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(213, 70);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cmbLogin
            // 
            this.cmbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLogin.DataSource = this.ugyfelBindingSource;
            this.cmbLogin.DisplayMember = "LOGIN";
            this.cmbLogin.FormattingEnabled = true;
            this.cmbLogin.Location = new System.Drawing.Point(149, 41);
            this.cmbLogin.Name = "cmbLogin";
            this.cmbLogin.Size = new System.Drawing.Size(139, 23);
            this.cmbLogin.TabIndex = 2;
            this.cmbLogin.ValueMember = "LOGIN";
            // 
            // labelSorszam
            // 
            this.labelSorszam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSorszam.AutoSize = true;
            this.labelSorszam.Location = new System.Drawing.Point(12, 15);
            this.labelSorszam.Name = "labelSorszam";
            this.labelSorszam.Size = new System.Drawing.Size(38, 15);
            this.labelSorszam.TabIndex = 3;
            this.labelSorszam.Text = "label1";
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(12, 44);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(38, 15);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "label2";
            // 
            // txtSorszam
            // 
            this.txtSorszam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSorszam.Location = new System.Drawing.Point(149, 12);
            this.txtSorszam.Name = "txtSorszam";
            this.txtSorszam.Size = new System.Drawing.Size(139, 23);
            this.txtSorszam.TabIndex = 5;
            // 
            // ugyfelBindingSource
            // 
            this.ugyfelBindingSource.DataSource = typeof(nagyZH_gsqrbp.ModelsWebshop.Ugyfel);
            // 
            // FormUjRendeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 106);
            this.Controls.Add(this.txtSorszam);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelSorszam);
            this.Controls.Add(this.cmbLogin);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "FormUjRendeles";
            this.Text = "FormUjRendeles";
            ((System.ComponentModel.ISupportInitialize)(this.ugyfelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOK;
        private Button btnCancel;
        private Label labelSorszam;
        private Label labelLogin;
        private BindingSource ugyfelBindingSource;
        public ComboBox cmbLogin;
        public TextBox txtSorszam;
    }
}