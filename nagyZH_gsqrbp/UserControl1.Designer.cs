namespace nagyZH_gsqrbp
{
    partial class UserControl1
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
            this.btnMentes = new System.Windows.Forms.Button();
            this.listBoxKurzusok = new System.Windows.Forms.ListBox();
            this.kurzusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvOktatok = new System.Windows.Forms.DataGridView();
            this.instructorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instructorSkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salutationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.employementFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kurzusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOktatok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMentes
            // 
            this.btnMentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMentes.Location = new System.Drawing.Point(3, 3);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(75, 23);
            this.btnMentes.TabIndex = 0;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // listBoxKurzusok
            // 
            this.listBoxKurzusok.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxKurzusok.DataSource = this.kurzusBindingSource;
            this.listBoxKurzusok.DisplayMember = "Name";
            this.listBoxKurzusok.FormattingEnabled = true;
            this.listBoxKurzusok.ItemHeight = 15;
            this.listBoxKurzusok.Location = new System.Drawing.Point(569, 32);
            this.listBoxKurzusok.Name = "listBoxKurzusok";
            this.listBoxKurzusok.Size = new System.Drawing.Size(228, 409);
            this.listBoxKurzusok.TabIndex = 2;
            this.listBoxKurzusok.ValueMember = "CourseSK";
            // 
            // kurzusBindingSource
            // 
            this.kurzusBindingSource.DataSource = typeof(nagyZH_gsqrbp.Kurzus);
            // 
            // dgvOktatok
            // 
            this.dgvOktatok.AllowUserToAddRows = false;
            this.dgvOktatok.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOktatok.AutoGenerateColumns = false;
            this.dgvOktatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOktatok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.instructorSkDataGridViewTextBoxColumn,
            this.salutationDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.statusFkDataGridViewTextBoxColumn,
            this.employementFkDataGridViewTextBoxColumn});
            this.dgvOktatok.DataSource = this.instructorBindingSource;
            this.dgvOktatok.Location = new System.Drawing.Point(3, 32);
            this.dgvOktatok.Name = "dgvOktatok";
            this.dgvOktatok.RowTemplate.Height = 25;
            this.dgvOktatok.Size = new System.Drawing.Size(560, 409);
            this.dgvOktatok.TabIndex = 3;
            // 
            // instructorBindingSource
            // 
            this.instructorBindingSource.DataSource = typeof(nagyZH_gsqrbp.ModelsStudies.Instructor);
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataSource = typeof(nagyZH_gsqrbp.ModelsStudies.Status);
            // 
            // employementBindingSource
            // 
            this.employementBindingSource.DataSource = typeof(nagyZH_gsqrbp.ModelsStudies.Employement);
            // 
            // instructorSkDataGridViewTextBoxColumn
            // 
            this.instructorSkDataGridViewTextBoxColumn.DataPropertyName = "InstructorSk";
            this.instructorSkDataGridViewTextBoxColumn.HeaderText = "InstructorSk";
            this.instructorSkDataGridViewTextBoxColumn.Name = "instructorSkDataGridViewTextBoxColumn";
            // 
            // salutationDataGridViewTextBoxColumn
            // 
            this.salutationDataGridViewTextBoxColumn.DataPropertyName = "Salutation";
            this.salutationDataGridViewTextBoxColumn.HeaderText = "Salutation";
            this.salutationDataGridViewTextBoxColumn.Name = "salutationDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // statusFkDataGridViewTextBoxColumn
            // 
            this.statusFkDataGridViewTextBoxColumn.DataPropertyName = "StatusFk";
            this.statusFkDataGridViewTextBoxColumn.DataSource = this.statusBindingSource;
            this.statusFkDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.statusFkDataGridViewTextBoxColumn.HeaderText = "StatusFk";
            this.statusFkDataGridViewTextBoxColumn.Name = "statusFkDataGridViewTextBoxColumn";
            this.statusFkDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusFkDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.statusFkDataGridViewTextBoxColumn.ValueMember = "StatusId";
            // 
            // employementFkDataGridViewTextBoxColumn
            // 
            this.employementFkDataGridViewTextBoxColumn.DataPropertyName = "EmployementFk";
            this.employementFkDataGridViewTextBoxColumn.DataSource = this.employementBindingSource;
            this.employementFkDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.employementFkDataGridViewTextBoxColumn.HeaderText = "EmployementFk";
            this.employementFkDataGridViewTextBoxColumn.Name = "employementFkDataGridViewTextBoxColumn";
            this.employementFkDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.employementFkDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.employementFkDataGridViewTextBoxColumn.ValueMember = "EmployementId";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.dgvOktatok);
            this.Controls.Add(this.listBoxKurzusok);
            this.Controls.Add(this.btnMentes);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.kurzusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOktatok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employementBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnMentes;
        private ListBox listBoxKurzusok;
        private BindingSource kurzusBindingSource;
        private DataGridView dgvOktatok;
        private DataGridViewTextBoxColumn instructorSkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salutationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn statusFkDataGridViewTextBoxColumn;
        private BindingSource statusBindingSource;
        private DataGridViewComboBoxColumn employementFkDataGridViewTextBoxColumn;
        private BindingSource employementBindingSource;
        private BindingSource instructorBindingSource;
    }
}
