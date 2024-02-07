namespace dersProgrami.Manager
{
    partial class timer
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
            this.Onayla = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.veri_derssüresi = new System.Windows.Forms.NumericUpDown();
            this.veri_derssayısısonra = new System.Windows.Forms.NumericUpDown();
            this.veri_derssayısıönce = new System.Windows.Forms.NumericUpDown();
            this.veri_tenefüssüresi = new System.Windows.Forms.NumericUpDown();
            this.veri_öğlenmolasüresi = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnGunKaydet = new System.Windows.Forms.Button();
            this.veri_ilkders = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbmx_gun = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new dersProgrami.Manager.DataSet1();
            this.zamanJoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zamanJoinTableAdapter = new dersProgrami.Manager.DataSet1TableAdapters.zamanJoinTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baslangicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.veri_derssüresi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veri_derssayısısonra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veri_derssayısıönce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veri_tenefüssüresi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veri_öğlenmolasüresi)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamanJoinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Onayla
            // 
            this.Onayla.Location = new System.Drawing.Point(176, 348);
            this.Onayla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Onayla.Name = "Onayla";
            this.Onayla.Size = new System.Drawing.Size(100, 28);
            this.Onayla.TabIndex = 74;
            this.Onayla.Text = "Güncelle";
            this.Onayla.UseVisualStyleBackColor = true;
            this.Onayla.Click += new System.EventHandler(this.Onayla_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(129, 59);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(207, 31);
            this.label17.TabIndex = 73;
            this.label17.Text = "Zaman Bilgileri";
            // 
            // veri_derssüresi
            // 
            this.veri_derssüresi.Location = new System.Drawing.Point(235, 172);
            this.veri_derssüresi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.veri_derssüresi.Name = "veri_derssüresi";
            this.veri_derssüresi.Size = new System.Drawing.Size(160, 22);
            this.veri_derssüresi.TabIndex = 72;
            // 
            // veri_derssayısısonra
            // 
            this.veri_derssayısısonra.Location = new System.Drawing.Point(235, 302);
            this.veri_derssayısısonra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.veri_derssayısısonra.Name = "veri_derssayısısonra";
            this.veri_derssayısısonra.Size = new System.Drawing.Size(160, 22);
            this.veri_derssayısısonra.TabIndex = 71;
            // 
            // veri_derssayısıönce
            // 
            this.veri_derssayısıönce.Location = new System.Drawing.Point(235, 238);
            this.veri_derssayısıönce.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.veri_derssayısıönce.Name = "veri_derssayısıönce";
            this.veri_derssayısıönce.Size = new System.Drawing.Size(160, 22);
            this.veri_derssayısıönce.TabIndex = 70;
            // 
            // veri_tenefüssüresi
            // 
            this.veri_tenefüssüresi.Location = new System.Drawing.Point(235, 206);
            this.veri_tenefüssüresi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.veri_tenefüssüresi.Name = "veri_tenefüssüresi";
            this.veri_tenefüssüresi.Size = new System.Drawing.Size(160, 22);
            this.veri_tenefüssüresi.TabIndex = 69;
            // 
            // veri_öğlenmolasüresi
            // 
            this.veri_öğlenmolasüresi.Location = new System.Drawing.Point(235, 270);
            this.veri_öğlenmolasüresi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.veri_öğlenmolasüresi.Name = "veri_öğlenmolasüresi";
            this.veri_öğlenmolasüresi.Size = new System.Drawing.Size(160, 22);
            this.veri_öğlenmolasüresi.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 278);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 16);
            this.label8.TabIndex = 65;
            this.label8.Text = "Öğlen Molası Süresi :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(115, 214);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 16);
            this.label10.TabIndex = 63;
            this.label10.Text = "Tenefüs Süresi :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(137, 180);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 16);
            this.label11.TabIndex = 62;
            this.label11.Text = "Ders Süresi :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(115, 148);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 16);
            this.label12.TabIndex = 61;
            this.label12.Text = "İlk Dersin Saati :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 246);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 16);
            this.label9.TabIndex = 64;
            this.label9.Text = "Ders Sayisi (Öğleden Önce) :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 310);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 16);
            this.label7.TabIndex = 66;
            this.label7.Text = "Ders Sayisi (Öğleden Sonra) :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Controls.Add(this.btnGunKaydet);
            this.panel1.Controls.Add(this.veri_ilkders);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbmx_gun);
            this.panel1.Controls.Add(this.Onayla);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.veri_derssüresi);
            this.panel1.Controls.Add(this.veri_derssayısısonra);
            this.panel1.Controls.Add(this.veri_derssayısıönce);
            this.panel1.Controls.Add(this.veri_tenefüssüresi);
            this.panel1.Controls.Add(this.veri_öğlenmolasüresi);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 598);
            this.panel1.TabIndex = 83;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Pazartesi",
            "Salı",
            "Çarşamba",
            "Perşembe",
            "Cuma",
            "Cumartesi",
            "Pazar"});
            this.checkedListBox1.Location = new System.Drawing.Point(84, 425);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(165, 123);
            this.checkedListBox1.TabIndex = 88;
            // 
            // btnGunKaydet
            // 
            this.btnGunKaydet.Location = new System.Drawing.Point(259, 448);
            this.btnGunKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGunKaydet.Name = "btnGunKaydet";
            this.btnGunKaydet.Size = new System.Drawing.Size(139, 37);
            this.btnGunKaydet.TabIndex = 87;
            this.btnGunKaydet.Text = "Günleri Güncelle";
            this.btnGunKaydet.UseVisualStyleBackColor = true;
            this.btnGunKaydet.Click += new System.EventHandler(this.btnGunKaydet_Click);
            // 
            // veri_ilkders
            // 
            this.veri_ilkders.Location = new System.Drawing.Point(259, 142);
            this.veri_ilkders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.veri_ilkders.Mask = "90:00";
            this.veri_ilkders.Name = "veri_ilkders";
            this.veri_ilkders.Size = new System.Drawing.Size(100, 22);
            this.veri_ilkders.TabIndex = 86;
            this.veri_ilkders.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 489);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 84;
            this.label1.Text = "Seçilen Günler";
            // 
            // cbmx_gun
            // 
            this.cbmx_gun.FormattingEnabled = true;
            this.cbmx_gun.Items.AddRange(new object[] {
            "Pazartesi",
            "Salı",
            "Çarşamba",
            "Perşembe",
            "Cuma"});
            this.cbmx_gun.Location = new System.Drawing.Point(259, 521);
            this.cbmx_gun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbmx_gun.Name = "cbmx_gun";
            this.cbmx_gun.Size = new System.Drawing.Size(160, 24);
            this.cbmx_gun.TabIndex = 83;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numaraDataGridViewTextBoxColumn,
            this.turDataGridViewTextBoxColumn,
            this.baslangicDataGridViewTextBoxColumn,
            this.bitisDataGridViewTextBoxColumn,
            this.dayDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zamanJoinBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(429, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(584, 527);
            this.dataGridView1.TabIndex = 89;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zamanJoinBindingSource
            // 
            this.zamanJoinBindingSource.DataMember = "zamanJoin";
            this.zamanJoinBindingSource.DataSource = this.dataSet1;
            // 
            // zamanJoinTableAdapter
            // 
            this.zamanJoinTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // numaraDataGridViewTextBoxColumn
            // 
            this.numaraDataGridViewTextBoxColumn.DataPropertyName = "numara";
            this.numaraDataGridViewTextBoxColumn.HeaderText = "numara";
            this.numaraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numaraDataGridViewTextBoxColumn.Name = "numaraDataGridViewTextBoxColumn";
            this.numaraDataGridViewTextBoxColumn.ReadOnly = true;
            this.numaraDataGridViewTextBoxColumn.Width = 125;
            // 
            // turDataGridViewTextBoxColumn
            // 
            this.turDataGridViewTextBoxColumn.DataPropertyName = "tur";
            this.turDataGridViewTextBoxColumn.HeaderText = "tur";
            this.turDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.turDataGridViewTextBoxColumn.Name = "turDataGridViewTextBoxColumn";
            this.turDataGridViewTextBoxColumn.ReadOnly = true;
            this.turDataGridViewTextBoxColumn.Width = 125;
            // 
            // baslangicDataGridViewTextBoxColumn
            // 
            this.baslangicDataGridViewTextBoxColumn.DataPropertyName = "baslangic";
            this.baslangicDataGridViewTextBoxColumn.HeaderText = "baslangic";
            this.baslangicDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.baslangicDataGridViewTextBoxColumn.Name = "baslangicDataGridViewTextBoxColumn";
            this.baslangicDataGridViewTextBoxColumn.ReadOnly = true;
            this.baslangicDataGridViewTextBoxColumn.Width = 125;
            // 
            // bitisDataGridViewTextBoxColumn
            // 
            this.bitisDataGridViewTextBoxColumn.DataPropertyName = "bitis";
            this.bitisDataGridViewTextBoxColumn.HeaderText = "bitis";
            this.bitisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bitisDataGridViewTextBoxColumn.Name = "bitisDataGridViewTextBoxColumn";
            this.bitisDataGridViewTextBoxColumn.ReadOnly = true;
            this.bitisDataGridViewTextBoxColumn.Width = 125;
            // 
            // dayDataGridViewTextBoxColumn
            // 
            this.dayDataGridViewTextBoxColumn.DataPropertyName = "day";
            this.dayDataGridViewTextBoxColumn.HeaderText = "day";
            this.dayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            this.dayDataGridViewTextBoxColumn.ReadOnly = true;
            this.dayDataGridViewTextBoxColumn.Width = 125;
            // 
            // timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 626);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "timer";
            this.Text = "timer";
            this.Load += new System.EventHandler(this.timer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.veri_derssüresi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veri_derssayısısonra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veri_derssayısıönce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veri_tenefüssüresi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veri_öğlenmolasüresi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamanJoinBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Onayla;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown veri_derssüresi;
        private System.Windows.Forms.NumericUpDown veri_derssayısısonra;
        private System.Windows.Forms.NumericUpDown veri_derssayısıönce;
        private System.Windows.Forms.NumericUpDown veri_tenefüssüresi;
        private System.Windows.Forms.NumericUpDown veri_öğlenmolasüresi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox veri_ilkders;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnGunKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbmx_gun;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource zamanJoinBindingSource;
        private DataSet1TableAdapters.zamanJoinTableAdapter zamanJoinTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslangicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
    }
}