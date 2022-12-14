namespace nagyZH_gsqrbp
{
    partial class FormUjTermek
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
            this.cmbKategoria = new System.Windows.Forms.ComboBox();
            this.cmbRaktarkod = new System.Windows.Forms.ComboBox();
            this.labelMegnevezes = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtMegnevezes = new System.Windows.Forms.TextBox();
            this.txtListaar = new System.Windows.Forms.TextBox();
            this.txtkeszlet = new System.Windows.Forms.TextBox();
            this.txtTermekkod = new System.Windows.Forms.TextBox();
            this.labelKategoria = new System.Windows.Forms.Label();
            this.labelRaktarkod = new System.Windows.Forms.Label();
            this.labelListaar = new System.Windows.Forms.Label();
            this.labelKeszlet = new System.Windows.Forms.Label();
            this.labelTermekkod = new System.Windows.Forms.Label();
            this.termekkategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raktarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termekkategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raktarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(12, 186);
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
            this.btnCancel.Location = new System.Drawing.Point(237, 186);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cmbKategoria
            // 
            this.cmbKategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbKategoria.DataSource = this.termekkategoriaBindingSource;
            this.cmbKategoria.DisplayMember = "KATNEV";
            this.cmbKategoria.FormattingEnabled = true;
            this.cmbKategoria.Location = new System.Drawing.Point(173, 41);
            this.cmbKategoria.Name = "cmbKategoria";
            this.cmbKategoria.Size = new System.Drawing.Size(139, 23);
            this.cmbKategoria.TabIndex = 2;
            this.cmbKategoria.ValueMember = "KATID";
            // 
            // cmbRaktarkod
            // 
            this.cmbRaktarkod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRaktarkod.DataSource = this.raktarBindingSource;
            this.cmbRaktarkod.DisplayMember = "RAKTARKOD";
            this.cmbRaktarkod.FormattingEnabled = true;
            this.cmbRaktarkod.Location = new System.Drawing.Point(173, 70);
            this.cmbRaktarkod.Name = "cmbRaktarkod";
            this.cmbRaktarkod.Size = new System.Drawing.Size(139, 23);
            this.cmbRaktarkod.TabIndex = 3;
            this.cmbRaktarkod.ValueMember = "RAKTARKOD";
            // 
            // labelMegnevezes
            // 
            this.labelMegnevezes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMegnevezes.AutoSize = true;
            this.labelMegnevezes.Location = new System.Drawing.Point(12, 15);
            this.labelMegnevezes.Name = "labelMegnevezes";
            this.labelMegnevezes.Size = new System.Drawing.Size(38, 15);
            this.labelMegnevezes.TabIndex = 4;
            this.labelMegnevezes.Text = "label1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtMegnevezes
            // 
            this.txtMegnevezes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMegnevezes.Location = new System.Drawing.Point(173, 12);
            this.txtMegnevezes.Name = "txtMegnevezes";
            this.txtMegnevezes.Size = new System.Drawing.Size(139, 23);
            this.txtMegnevezes.TabIndex = 5;
            this.txtMegnevezes.Validating += new System.ComponentModel.CancelEventHandler(this.txtMegnevezes_Validating);
            this.txtMegnevezes.Validated += new System.EventHandler(this.txtMegnevezes_Validated);
            // 
            // txtListaar
            // 
            this.txtListaar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtListaar.Location = new System.Drawing.Point(173, 99);
            this.txtListaar.Name = "txtListaar";
            this.txtListaar.Size = new System.Drawing.Size(139, 23);
            this.txtListaar.TabIndex = 6;
            this.txtListaar.Validating += new System.ComponentModel.CancelEventHandler(this.txtListaar_Validating);
            this.txtListaar.Validated += new System.EventHandler(this.txtListaar_Validated);
            // 
            // txtkeszlet
            // 
            this.txtkeszlet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtkeszlet.Location = new System.Drawing.Point(173, 128);
            this.txtkeszlet.Name = "txtkeszlet";
            this.txtkeszlet.Size = new System.Drawing.Size(139, 23);
            this.txtkeszlet.TabIndex = 7;
            // 
            // txtTermekkod
            // 
            this.txtTermekkod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTermekkod.Location = new System.Drawing.Point(173, 157);
            this.txtTermekkod.Name = "txtTermekkod";
            this.txtTermekkod.Size = new System.Drawing.Size(139, 23);
            this.txtTermekkod.TabIndex = 8;
            // 
            // labelKategoria
            // 
            this.labelKategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKategoria.AutoSize = true;
            this.labelKategoria.Location = new System.Drawing.Point(12, 44);
            this.labelKategoria.Name = "labelKategoria";
            this.labelKategoria.Size = new System.Drawing.Size(38, 15);
            this.labelKategoria.TabIndex = 9;
            this.labelKategoria.Text = "label2";
            // 
            // labelRaktarkod
            // 
            this.labelRaktarkod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRaktarkod.AutoSize = true;
            this.labelRaktarkod.Location = new System.Drawing.Point(12, 73);
            this.labelRaktarkod.Name = "labelRaktarkod";
            this.labelRaktarkod.Size = new System.Drawing.Size(38, 15);
            this.labelRaktarkod.TabIndex = 10;
            this.labelRaktarkod.Text = "label3";
            // 
            // labelListaar
            // 
            this.labelListaar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelListaar.AutoSize = true;
            this.labelListaar.Location = new System.Drawing.Point(12, 102);
            this.labelListaar.Name = "labelListaar";
            this.labelListaar.Size = new System.Drawing.Size(38, 15);
            this.labelListaar.TabIndex = 11;
            this.labelListaar.Text = "label4";
            // 
            // labelKeszlet
            // 
            this.labelKeszlet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKeszlet.AutoSize = true;
            this.labelKeszlet.Location = new System.Drawing.Point(12, 131);
            this.labelKeszlet.Name = "labelKeszlet";
            this.labelKeszlet.Size = new System.Drawing.Size(38, 15);
            this.labelKeszlet.TabIndex = 12;
            this.labelKeszlet.Text = "label5";
            // 
            // labelTermekkod
            // 
            this.labelTermekkod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTermekkod.AutoSize = true;
            this.labelTermekkod.Location = new System.Drawing.Point(12, 160);
            this.labelTermekkod.Name = "labelTermekkod";
            this.labelTermekkod.Size = new System.Drawing.Size(38, 15);
            this.labelTermekkod.TabIndex = 13;
            this.labelTermekkod.Text = "label6";
            // 
            // termekkategoriaBindingSource
            // 
            this.termekkategoriaBindingSource.DataSource = typeof(nagyZH_gsqrbp.ModelsWebshop.Termekkategoria);
            // 
            // raktarBindingSource
            // 
            this.raktarBindingSource.DataSource = typeof(nagyZH_gsqrbp.ModelsWebshop.Raktar);
            // 
            // FormUjTermek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 219);
            this.Controls.Add(this.labelTermekkod);
            this.Controls.Add(this.labelKeszlet);
            this.Controls.Add(this.labelListaar);
            this.Controls.Add(this.labelRaktarkod);
            this.Controls.Add(this.labelKategoria);
            this.Controls.Add(this.txtTermekkod);
            this.Controls.Add(this.txtkeszlet);
            this.Controls.Add(this.txtListaar);
            this.Controls.Add(this.txtMegnevezes);
            this.Controls.Add(this.labelMegnevezes);
            this.Controls.Add(this.cmbRaktarkod);
            this.Controls.Add(this.cmbKategoria);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "FormUjTermek";
            this.Text = "FormUjTermek";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termekkategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raktarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOK;
        private Button btnCancel;
        private Label labelMegnevezes;
        private ErrorProvider errorProvider1;
        private Label labelTermekkod;
        private Label labelKeszlet;
        private Label labelListaar;
        private Label labelRaktarkod;
        private Label labelKategoria;
        private BindingSource termekkategoriaBindingSource;
        private BindingSource raktarBindingSource;
        public TextBox txtTermekkod;
        public TextBox txtkeszlet;
        public TextBox txtListaar;
        public ComboBox cmbKategoria;
        public ComboBox cmbRaktarkod;
        public TextBox txtMegnevezes;
    }
}