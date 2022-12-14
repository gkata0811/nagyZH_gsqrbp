namespace nagyZH_gsqrbp
{
    partial class UserControl2
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
            this.btnAddHozzavalo = new System.Windows.Forms.Button();
            this.btnRemoveHozzavalo = new System.Windows.Forms.Button();
            this.dgvHozzavalok = new System.Windows.Forms.DataGridView();
            this.hozzavaloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNyersanyagSzures = new System.Windows.Forms.TextBox();
            this.txtFogasSzures = new System.Windows.Forms.TextBox();
            this.txtMennyiseg = new System.Windows.Forms.TextBox();
            this.listBoxFogasok = new System.Windows.Forms.ListBox();
            this.listBoxNyersanyagok = new System.Windows.Forms.ListBox();
            this.nyersanyagNevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mennyiseg_4fo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egysegNevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.árDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceptID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHozzavalok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hozzavaloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddHozzavalo
            // 
            this.btnAddHozzavalo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddHozzavalo.Location = new System.Drawing.Point(577, 199);
            this.btnAddHozzavalo.Name = "btnAddHozzavalo";
            this.btnAddHozzavalo.Size = new System.Drawing.Size(75, 23);
            this.btnAddHozzavalo.TabIndex = 0;
            this.btnAddHozzavalo.Text = "+";
            this.btnAddHozzavalo.UseVisualStyleBackColor = true;
            this.btnAddHozzavalo.Click += new System.EventHandler(this.btnAddHozzavalo_Click);
            // 
            // btnRemoveHozzavalo
            // 
            this.btnRemoveHozzavalo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveHozzavalo.Location = new System.Drawing.Point(577, 228);
            this.btnRemoveHozzavalo.Name = "btnRemoveHozzavalo";
            this.btnRemoveHozzavalo.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveHozzavalo.TabIndex = 1;
            this.btnRemoveHozzavalo.Text = "-";
            this.btnRemoveHozzavalo.UseVisualStyleBackColor = true;
            this.btnRemoveHozzavalo.Click += new System.EventHandler(this.btnRemoveHozzavalo_Click);
            // 
            // dgvHozzavalok
            // 
            this.dgvHozzavalok.AllowUserToAddRows = false;
            this.dgvHozzavalok.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHozzavalok.AutoGenerateColumns = false;
            this.dgvHozzavalok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHozzavalok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nyersanyagNevDataGridViewTextBoxColumn,
            this.Mennyiseg_4fo,
            this.egysegNevDataGridViewTextBoxColumn,
            this.árDataGridViewTextBoxColumn,
            this.ReceptID});
            this.dgvHozzavalok.DataSource = this.hozzavaloBindingSource;
            this.dgvHozzavalok.Location = new System.Drawing.Point(148, 32);
            this.dgvHozzavalok.Name = "dgvHozzavalok";
            this.dgvHozzavalok.RowTemplate.Height = 25;
            this.dgvHozzavalok.Size = new System.Drawing.Size(423, 349);
            this.dgvHozzavalok.TabIndex = 3;
            // 
            // hozzavaloBindingSource
            // 
            this.hozzavaloBindingSource.DataSource = typeof(nagyZH_gsqrbp.Hozzavalo);
            // 
            // txtNyersanyagSzures
            // 
            this.txtNyersanyagSzures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNyersanyagSzures.Location = new System.Drawing.Point(658, 3);
            this.txtNyersanyagSzures.Name = "txtNyersanyagSzures";
            this.txtNyersanyagSzures.Size = new System.Drawing.Size(139, 23);
            this.txtNyersanyagSzures.TabIndex = 6;
            this.txtNyersanyagSzures.TextChanged += new System.EventHandler(this.txtNyersanyagSzures_TextChanged);
            // 
            // txtFogasSzures
            // 
            this.txtFogasSzures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFogasSzures.Location = new System.Drawing.Point(3, 3);
            this.txtFogasSzures.Name = "txtFogasSzures";
            this.txtFogasSzures.Size = new System.Drawing.Size(139, 23);
            this.txtFogasSzures.TabIndex = 7;
            this.txtFogasSzures.TextChanged += new System.EventHandler(this.txtFogasSzures_TextChanged);
            // 
            // txtMennyiseg
            // 
            this.txtMennyiseg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMennyiseg.Location = new System.Drawing.Point(658, 395);
            this.txtMennyiseg.Name = "txtMennyiseg";
            this.txtMennyiseg.Size = new System.Drawing.Size(75, 23);
            this.txtMennyiseg.TabIndex = 8;
            // 
            // listBoxFogasok
            // 
            this.listBoxFogasok.FormattingEnabled = true;
            this.listBoxFogasok.ItemHeight = 15;
            this.listBoxFogasok.Location = new System.Drawing.Point(3, 32);
            this.listBoxFogasok.Name = "listBoxFogasok";
            this.listBoxFogasok.Size = new System.Drawing.Size(139, 349);
            this.listBoxFogasok.TabIndex = 9;
            this.listBoxFogasok.SelectedIndexChanged += new System.EventHandler(this.listBoxFogasok_SelectedIndexChanged);
            // 
            // listBoxNyersanyagok
            // 
            this.listBoxNyersanyagok.FormattingEnabled = true;
            this.listBoxNyersanyagok.ItemHeight = 15;
            this.listBoxNyersanyagok.Location = new System.Drawing.Point(658, 32);
            this.listBoxNyersanyagok.Name = "listBoxNyersanyagok";
            this.listBoxNyersanyagok.Size = new System.Drawing.Size(139, 349);
            this.listBoxNyersanyagok.TabIndex = 10;
            // 
            // nyersanyagNevDataGridViewTextBoxColumn
            // 
            this.nyersanyagNevDataGridViewTextBoxColumn.DataPropertyName = "NyersanyagNev";
            this.nyersanyagNevDataGridViewTextBoxColumn.HeaderText = "Nyersanyag";
            this.nyersanyagNevDataGridViewTextBoxColumn.Name = "nyersanyagNevDataGridViewTextBoxColumn";
            // 
            // Mennyiseg_4fo
            // 
            this.Mennyiseg_4fo.DataPropertyName = "Mennyiseg_4fo";
            this.Mennyiseg_4fo.HeaderText = "Mennyiség 4 főre";
            this.Mennyiseg_4fo.Name = "Mennyiseg_4fo";
            // 
            // egysegNevDataGridViewTextBoxColumn
            // 
            this.egysegNevDataGridViewTextBoxColumn.DataPropertyName = "EgysegNev";
            this.egysegNevDataGridViewTextBoxColumn.HeaderText = "Egység";
            this.egysegNevDataGridViewTextBoxColumn.Name = "egysegNevDataGridViewTextBoxColumn";
            // 
            // árDataGridViewTextBoxColumn
            // 
            this.árDataGridViewTextBoxColumn.DataPropertyName = "Ár";
            this.árDataGridViewTextBoxColumn.HeaderText = "Ár";
            this.árDataGridViewTextBoxColumn.Name = "árDataGridViewTextBoxColumn";
            // 
            // ReceptID
            // 
            this.ReceptID.DataPropertyName = "ReceptID";
            this.ReceptID.HeaderText = "ReceptID";
            this.ReceptID.Name = "ReceptID";
            this.ReceptID.Visible = false;
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.listBoxNyersanyagok);
            this.Controls.Add(this.listBoxFogasok);
            this.Controls.Add(this.txtMennyiseg);
            this.Controls.Add(this.txtFogasSzures);
            this.Controls.Add(this.txtNyersanyagSzures);
            this.Controls.Add(this.dgvHozzavalok);
            this.Controls.Add(this.btnRemoveHozzavalo);
            this.Controls.Add(this.btnAddHozzavalo);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHozzavalok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hozzavaloBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAddHozzavalo;
        private Button btnRemoveHozzavalo;
        private DataGridView dgvHozzavalok;
        private DataGridViewTextBoxColumn egysegarDataGridViewTextBoxColumn;
        private BindingSource hozzavaloBindingSource;
        private TextBox txtNyersanyagSzures;
        private TextBox txtFogasSzures;
        private TextBox txtMennyiseg;
        private ListBox listBoxFogasok;
        private ListBox listBoxNyersanyagok;
        private DataGridViewTextBoxColumn nyersanyagNevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Mennyiseg_4fo;
        private DataGridViewTextBoxColumn egysegNevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn árDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ReceptID;
    }
}
