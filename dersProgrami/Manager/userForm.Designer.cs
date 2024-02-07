namespace dersProgrami.Manager
{
    partial class userForm
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
            this.teacherTablo = new System.Windows.Forms.DataGridView();
            this.joinProgramBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new dersProgrami.Manager.DataSet1();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programTableAdapter = new dersProgrami.Manager.DataSet1TableAdapters.programTableAdapter();
            this.btn_yazdr = new System.Windows.Forms.Button();
            this.btn_prgram = new System.Windows.Forms.Button();
            this.joinProgramBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.joinProgramTableAdapter = new dersProgrami.Manager.DataSet1TableAdapters.joinProgramTableAdapter();
            this.programJoin2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programJoin2TableAdapter = new dersProgrami.Manager.DataSet1TableAdapters.ProgramJoin2TableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bölümDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.öğretmenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.derslikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zamanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.teacherTablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinProgramBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinProgramBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programJoin2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // teacherTablo
            // 
            this.teacherTablo.AllowUserToAddRows = false;
            this.teacherTablo.AllowUserToDeleteRows = false;
            this.teacherTablo.AutoGenerateColumns = false;
            this.teacherTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherTablo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.bölümDataGridViewTextBoxColumn,
            this.öğretmenDataGridViewTextBoxColumn,
            this.dersDataGridViewTextBoxColumn,
            this.derslikDataGridViewTextBoxColumn,
            this.zamanDataGridViewTextBoxColumn});
            this.teacherTablo.DataSource = this.joinProgramBindingSource1;
            this.teacherTablo.Location = new System.Drawing.Point(59, 55);
            this.teacherTablo.Name = "teacherTablo";
            this.teacherTablo.ReadOnly = true;
            this.teacherTablo.Size = new System.Drawing.Size(643, 383);
            this.teacherTablo.TabIndex = 0;
            // 
            // joinProgramBindingSource1
            // 
            this.joinProgramBindingSource1.DataMember = "joinProgram";
            this.joinProgramBindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataMember = "program";
            this.programBindingSource.DataSource = this.dataSet1;
            // 
            // programTableAdapter
            // 
            this.programTableAdapter.ClearBeforeFill = true;
            // 
            // btn_yazdr
            // 
            this.btn_yazdr.Location = new System.Drawing.Point(442, 26);
            this.btn_yazdr.Name = "btn_yazdr";
            this.btn_yazdr.Size = new System.Drawing.Size(133, 23);
            this.btn_yazdr.TabIndex = 2;
            this.btn_yazdr.Text = "Programımı Yazdır";
            this.btn_yazdr.UseVisualStyleBackColor = true;
            this.btn_yazdr.Click += new System.EventHandler(this.btn_yazdr_Click);
            // 
            // btn_prgram
            // 
            this.btn_prgram.Location = new System.Drawing.Point(209, 26);
            this.btn_prgram.Name = "btn_prgram";
            this.btn_prgram.Size = new System.Drawing.Size(145, 23);
            this.btn_prgram.TabIndex = 3;
            this.btn_prgram.Text = "Sadece Benim Programım";
            this.btn_prgram.UseVisualStyleBackColor = true;
            this.btn_prgram.Click += new System.EventHandler(this.btn_prgram_Click);
            // 
            // joinProgramBindingSource
            // 
            this.joinProgramBindingSource.DataMember = "joinProgram";
            this.joinProgramBindingSource.DataSource = this.dataSet1;
            // 
            // joinProgramTableAdapter
            // 
            this.joinProgramTableAdapter.ClearBeforeFill = true;
            // 
            // programJoin2BindingSource
            // 
            this.programJoin2BindingSource.DataMember = "ProgramJoin2";
            this.programJoin2BindingSource.DataSource = this.dataSet1;
            // 
            // programJoin2TableAdapter
            // 
            this.programJoin2TableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bölümDataGridViewTextBoxColumn
            // 
            this.bölümDataGridViewTextBoxColumn.DataPropertyName = "Bölüm";
            this.bölümDataGridViewTextBoxColumn.HeaderText = "Bölüm";
            this.bölümDataGridViewTextBoxColumn.Name = "bölümDataGridViewTextBoxColumn";
            this.bölümDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // öğretmenDataGridViewTextBoxColumn
            // 
            this.öğretmenDataGridViewTextBoxColumn.DataPropertyName = "Öğretmen";
            this.öğretmenDataGridViewTextBoxColumn.HeaderText = "Öğretmen";
            this.öğretmenDataGridViewTextBoxColumn.Name = "öğretmenDataGridViewTextBoxColumn";
            this.öğretmenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dersDataGridViewTextBoxColumn
            // 
            this.dersDataGridViewTextBoxColumn.DataPropertyName = "Ders";
            this.dersDataGridViewTextBoxColumn.HeaderText = "Ders";
            this.dersDataGridViewTextBoxColumn.Name = "dersDataGridViewTextBoxColumn";
            this.dersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // derslikDataGridViewTextBoxColumn
            // 
            this.derslikDataGridViewTextBoxColumn.DataPropertyName = "Derslik";
            this.derslikDataGridViewTextBoxColumn.HeaderText = "Derslik";
            this.derslikDataGridViewTextBoxColumn.Name = "derslikDataGridViewTextBoxColumn";
            this.derslikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zamanDataGridViewTextBoxColumn
            // 
            this.zamanDataGridViewTextBoxColumn.DataPropertyName = "Zaman";
            this.zamanDataGridViewTextBoxColumn.HeaderText = "Zaman";
            this.zamanDataGridViewTextBoxColumn.Name = "zamanDataGridViewTextBoxColumn";
            this.zamanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 450);
            this.Controls.Add(this.btn_prgram);
            this.Controls.Add(this.btn_yazdr);
            this.Controls.Add(this.teacherTablo);
            this.Name = "userForm";
            this.Text = "Kullanıcı Menüsü";
            this.Load += new System.EventHandler(this.userForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teacherTablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinProgramBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinProgramBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programJoin2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView teacherTablo;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource programBindingSource;
        private DataSet1TableAdapters.programTableAdapter programTableAdapter;
        private System.Windows.Forms.Button btn_yazdr;
        private System.Windows.Forms.Button btn_prgram;
        private System.Windows.Forms.BindingSource joinProgramBindingSource;
        private DataSet1TableAdapters.joinProgramTableAdapter joinProgramTableAdapter;
        private System.Windows.Forms.BindingSource programJoin2BindingSource;
        private DataSet1TableAdapters.ProgramJoin2TableAdapter programJoin2TableAdapter;
        private System.Windows.Forms.BindingSource joinProgramBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bölümDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn öğretmenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn derslikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zamanDataGridViewTextBoxColumn;
    }
}