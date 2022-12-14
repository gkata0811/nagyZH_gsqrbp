namespace nagyZH_gsqrbp
{
    partial class UserControl3
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnUjRendeles = new System.Windows.Forms.Button();
            this.btnUjTermek = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.rendelesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sorszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.megnevezesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raktarKodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keszletDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termekkodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendelesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUjRendeles
            // 
            this.btnUjRendeles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUjRendeles.Location = new System.Drawing.Point(311, 3);
            this.btnUjRendeles.Name = "btnUjRendeles";
            this.btnUjRendeles.Size = new System.Drawing.Size(75, 23);
            this.btnUjRendeles.TabIndex = 0;
            this.btnUjRendeles.Text = "+";
            this.btnUjRendeles.UseVisualStyleBackColor = true;
            this.btnUjRendeles.Click += new System.EventHandler(this.btnUjRendeles_Click);
            // 
            // btnUjTermek
            // 
            this.btnUjTermek.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUjTermek.Location = new System.Drawing.Point(720, 3);
            this.btnUjTermek.Name = "btnUjTermek";
            this.btnUjTermek.Size = new System.Drawing.Size(75, 23);
            this.btnUjTermek.TabIndex = 1;
            this.btnUjTermek.Text = "+";
            this.btnUjTermek.UseVisualStyleBackColor = true;
            this.btnUjTermek.Click += new System.EventHandler(this.btnUjTermek_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sorszamDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rendelesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(302, 442);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.megnevezesDataGridViewTextBoxColumn,
            this.katDataGridViewTextBoxColumn,
            this.raktarKodDataGridViewTextBoxColumn,
            this.listaarDataGridViewTextBoxColumn,
            this.keszletDataGridViewTextBoxColumn,
            this.termekkodDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.termekBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(392, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(322, 442);
            this.dataGridView2.TabIndex = 3;
            // 
            // rendelesBindingSource
            // 
            this.rendelesBindingSource.DataSource = typeof(nagyZH_gsqrbp.ModelsWebshop.Rendeles);
            // 
            // sorszamDataGridViewTextBoxColumn
            // 
            this.sorszamDataGridViewTextBoxColumn.DataPropertyName = "Sorszam";
            this.sorszamDataGridViewTextBoxColumn.HeaderText = "Sorszám";
            this.sorszamDataGridViewTextBoxColumn.Name = "sorszamDataGridViewTextBoxColumn";
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // termekBindingSource
            // 
            this.termekBindingSource.DataSource = typeof(nagyZH_gsqrbp.ModelsWebshop.Termek);
            // 
            // megnevezesDataGridViewTextBoxColumn
            // 
            this.megnevezesDataGridViewTextBoxColumn.DataPropertyName = "Megnevezes";
            this.megnevezesDataGridViewTextBoxColumn.HeaderText = "Megnevezés";
            this.megnevezesDataGridViewTextBoxColumn.Name = "megnevezesDataGridViewTextBoxColumn";
            // 
            // katDataGridViewTextBoxColumn
            // 
            this.katDataGridViewTextBoxColumn.DataPropertyName = "Kat";
            this.katDataGridViewTextBoxColumn.HeaderText = "Kategória";
            this.katDataGridViewTextBoxColumn.Name = "katDataGridViewTextBoxColumn";
            // 
            // raktarKodDataGridViewTextBoxColumn
            // 
            this.raktarKodDataGridViewTextBoxColumn.DataPropertyName = "RaktarKod";
            this.raktarKodDataGridViewTextBoxColumn.HeaderText = "Raktárkód";
            this.raktarKodDataGridViewTextBoxColumn.Name = "raktarKodDataGridViewTextBoxColumn";
            // 
            // listaarDataGridViewTextBoxColumn
            // 
            this.listaarDataGridViewTextBoxColumn.DataPropertyName = "Listaar";
            this.listaarDataGridViewTextBoxColumn.HeaderText = "Listaár";
            this.listaarDataGridViewTextBoxColumn.Name = "listaarDataGridViewTextBoxColumn";
            // 
            // keszletDataGridViewTextBoxColumn
            // 
            this.keszletDataGridViewTextBoxColumn.DataPropertyName = "Keszlet";
            this.keszletDataGridViewTextBoxColumn.HeaderText = "Készlet";
            this.keszletDataGridViewTextBoxColumn.Name = "keszletDataGridViewTextBoxColumn";
            // 
            // termekkodDataGridViewTextBoxColumn
            // 
            this.termekkodDataGridViewTextBoxColumn.DataPropertyName = "Termekkod";
            this.termekkodDataGridViewTextBoxColumn.HeaderText = "Termékkód";
            this.termekkodDataGridViewTextBoxColumn.Name = "termekkodDataGridViewTextBoxColumn";
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUjTermek);
            this.Controls.Add(this.btnUjRendeles);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(798, 448);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendelesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termekBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnUjRendeles;
        private Button btnUjTermek;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn sorszamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private BindingSource rendelesBindingSource;
        private DataGridViewTextBoxColumn megnevezesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn katDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn raktarKodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn listaarDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn keszletDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn termekkodDataGridViewTextBoxColumn;
        private BindingSource termekBindingSource;
    }
}
