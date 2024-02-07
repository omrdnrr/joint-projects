namespace dersProgrami.Manager
{
    partial class lesson
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbx_dersId = new System.Windows.Forms.TextBox();
            this.btn_dersGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_dersSil = new System.Windows.Forms.Button();
            this.btn_dersKaydet = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Txtbx_dersAdi = new System.Windows.Forms.TextBox();
            this.Txtbx_dersKodu = new System.Windows.Forms.TextBox();
            this.txtbx_dersAlttan = new System.Windows.Forms.TextBox();
            this.Txtbx_dersSaat = new System.Windows.Forms.TextBox();
            this.Cmbx_dersDerslik = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.ver_Id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.veri_kap = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ver_tur = new System.Windows.Forms.TextBox();
            this.veri_kapasite = new System.Windows.Forms.Label();
            this.veri_tür = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kapasiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.derslikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new dersProgrami.Manager.DataSet1();
            this.derslikTableAdapter = new dersProgrami.Manager.DataSet1TableAdapters.derslikTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veri_kap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.derslikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtbx_dersId);
            this.panel1.Controls.Add(this.btn_dersGuncelle);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btn_dersSil);
            this.panel1.Controls.Add(this.btn_dersKaydet);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Txtbx_dersAdi);
            this.panel1.Controls.Add(this.Txtbx_dersKodu);
            this.panel1.Controls.Add(this.txtbx_dersAlttan);
            this.panel1.Controls.Add(this.Txtbx_dersSaat);
            this.panel1.Controls.Add(this.Cmbx_dersDerslik);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 289);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1256, 347);
            this.panel1.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(156, 87);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Id :";
            // 
            // txtbx_dersId
            // 
            this.txtbx_dersId.Location = new System.Drawing.Point(199, 84);
            this.txtbx_dersId.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_dersId.Name = "txtbx_dersId";
            this.txtbx_dersId.Size = new System.Drawing.Size(57, 22);
            this.txtbx_dersId.TabIndex = 19;
            // 
            // btn_dersGuncelle
            // 
            this.btn_dersGuncelle.Location = new System.Drawing.Point(4, 303);
            this.btn_dersGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dersGuncelle.Name = "btn_dersGuncelle";
            this.btn_dersGuncelle.Size = new System.Drawing.Size(100, 28);
            this.btn_dersGuncelle.TabIndex = 18;
            this.btn_dersGuncelle.Text = "Güncelle";
            this.btn_dersGuncelle.UseVisualStyleBackColor = true;
            this.btn_dersGuncelle.Click += new System.EventHandler(this.btn_dersGuncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(373, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(840, 308);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_dersSil
            // 
            this.btn_dersSil.Location = new System.Drawing.Point(219, 303);
            this.btn_dersSil.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dersSil.Name = "btn_dersSil";
            this.btn_dersSil.Size = new System.Drawing.Size(100, 28);
            this.btn_dersSil.TabIndex = 15;
            this.btn_dersSil.Text = "Veriyi Sil";
            this.btn_dersSil.UseVisualStyleBackColor = true;
            this.btn_dersSil.Click += new System.EventHandler(this.btn_dersSil_Click);
            // 
            // btn_dersKaydet
            // 
            this.btn_dersKaydet.Location = new System.Drawing.Point(111, 303);
            this.btn_dersKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dersKaydet.Name = "btn_dersKaydet";
            this.btn_dersKaydet.Size = new System.Drawing.Size(100, 28);
            this.btn_dersKaydet.TabIndex = 14;
            this.btn_dersKaydet.Text = "Kayıt Et";
            this.btn_dersKaydet.UseVisualStyleBackColor = true;
            this.btn_dersKaydet.Click += new System.EventHandler(this.btn_dersKaydet_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(95, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 48);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ders Ekle";
            // 
            // Txtbx_dersAdi
            // 
            this.Txtbx_dersAdi.Location = new System.Drawing.Point(144, 185);
            this.Txtbx_dersAdi.Margin = new System.Windows.Forms.Padding(4);
            this.Txtbx_dersAdi.Name = "Txtbx_dersAdi";
            this.Txtbx_dersAdi.Size = new System.Drawing.Size(160, 22);
            this.Txtbx_dersAdi.TabIndex = 11;
            // 
            // Txtbx_dersKodu
            // 
            this.Txtbx_dersKodu.Location = new System.Drawing.Point(144, 217);
            this.Txtbx_dersKodu.Margin = new System.Windows.Forms.Padding(4);
            this.Txtbx_dersKodu.Name = "Txtbx_dersKodu";
            this.Txtbx_dersKodu.Size = new System.Drawing.Size(160, 22);
            this.Txtbx_dersKodu.TabIndex = 10;
            // 
            // txtbx_dersAlttan
            // 
            this.txtbx_dersAlttan.Location = new System.Drawing.Point(144, 251);
            this.txtbx_dersAlttan.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_dersAlttan.Name = "txtbx_dersAlttan";
            this.txtbx_dersAlttan.Size = new System.Drawing.Size(160, 22);
            this.txtbx_dersAlttan.TabIndex = 9;
            // 
            // Txtbx_dersSaat
            // 
            this.Txtbx_dersSaat.Location = new System.Drawing.Point(144, 149);
            this.Txtbx_dersSaat.Margin = new System.Windows.Forms.Padding(4);
            this.Txtbx_dersSaat.Name = "Txtbx_dersSaat";
            this.Txtbx_dersSaat.Size = new System.Drawing.Size(160, 22);
            this.Txtbx_dersSaat.TabIndex = 7;
            // 
            // Cmbx_dersDerslik
            // 
            this.Cmbx_dersDerslik.DisplayMember = "tür";
            this.Cmbx_dersDerslik.FormattingEnabled = true;
            this.Cmbx_dersDerslik.Location = new System.Drawing.Point(144, 116);
            this.Cmbx_dersDerslik.Margin = new System.Windows.Forms.Padding(4);
            this.Cmbx_dersDerslik.Name = "Cmbx_dersDerslik";
            this.Cmbx_dersDerslik.Size = new System.Drawing.Size(160, 24);
            this.Cmbx_dersDerslik.TabIndex = 6;
            this.Cmbx_dersDerslik.ValueMember = "tür";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 193);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ders :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Saati :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kodu : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 260);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altan Alan :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Derslik :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.ver_Id);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.veri_kap);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.ver_tur);
            this.panel2.Controls.Add(this.veri_kapasite);
            this.panel2.Controls.Add(this.veri_tür);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(16, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1255, 267);
            this.panel2.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(117, 215);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 16;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ver_Id
            // 
            this.ver_Id.Location = new System.Drawing.Point(245, 91);
            this.ver_Id.Margin = new System.Windows.Forms.Padding(4);
            this.ver_Id.Name = "ver_Id";
            this.ver_Id.Size = new System.Drawing.Size(132, 22);
            this.ver_Id.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(224, 95);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Id : ";
            // 
            // veri_kap
            // 
            this.veri_kap.Location = new System.Drawing.Point(232, 155);
            this.veri_kap.Margin = new System.Windows.Forms.Padding(4);
            this.veri_kap.Name = "veri_kap";
            this.veri_kap.Size = new System.Drawing.Size(160, 22);
            this.veri_kap.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(273, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 31);
            this.label8.TabIndex = 11;
            this.label8.Text = "Derslik İşlemleri";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 215);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 215);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ver_tur
            // 
            this.ver_tur.Location = new System.Drawing.Point(245, 123);
            this.ver_tur.Margin = new System.Windows.Forms.Padding(4);
            this.ver_tur.Name = "ver_tur";
            this.ver_tur.Size = new System.Drawing.Size(132, 22);
            this.ver_tur.TabIndex = 6;
            // 
            // veri_kapasite
            // 
            this.veri_kapasite.AutoSize = true;
            this.veri_kapasite.Location = new System.Drawing.Point(164, 164);
            this.veri_kapasite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.veri_kapasite.Name = "veri_kapasite";
            this.veri_kapasite.Size = new System.Drawing.Size(66, 16);
            this.veri_kapasite.TabIndex = 3;
            this.veri_kapasite.Text = "Kapasite :";
            // 
            // veri_tür
            // 
            this.veri_tür.AutoSize = true;
            this.veri_tür.Location = new System.Drawing.Point(204, 126);
            this.veri_tür.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.veri_tür.Name = "veri_tür";
            this.veri_tür.Size = new System.Drawing.Size(33, 16);
            this.veri_tür.TabIndex = 1;
            this.veri_tür.Text = "Tür :";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.turDataGridViewTextBoxColumn,
            this.kapasiteDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.derslikBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(623, 26);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(473, 217);
            this.dataGridView2.TabIndex = 0;
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
            // turDataGridViewTextBoxColumn
            // 
            this.turDataGridViewTextBoxColumn.DataPropertyName = "tur";
            this.turDataGridViewTextBoxColumn.HeaderText = "Tür";
            this.turDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.turDataGridViewTextBoxColumn.Name = "turDataGridViewTextBoxColumn";
            this.turDataGridViewTextBoxColumn.ReadOnly = true;
            this.turDataGridViewTextBoxColumn.Width = 125;
            // 
            // kapasiteDataGridViewTextBoxColumn
            // 
            this.kapasiteDataGridViewTextBoxColumn.DataPropertyName = "kapasite";
            this.kapasiteDataGridViewTextBoxColumn.HeaderText = "Kapasite";
            this.kapasiteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kapasiteDataGridViewTextBoxColumn.Name = "kapasiteDataGridViewTextBoxColumn";
            this.kapasiteDataGridViewTextBoxColumn.ReadOnly = true;
            this.kapasiteDataGridViewTextBoxColumn.Width = 125;
            // 
            // derslikBindingSource
            // 
            this.derslikBindingSource.DataMember = "derslik";
            this.derslikBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // derslikTableAdapter
            // 
            this.derslikTableAdapter.ClearBeforeFill = true;
            // 
            // lesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 647);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "lesson";
            this.Text = "lesson";
            this.Load += new System.EventHandler(this.lesson_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veri_kap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.derslikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_dersSil;
        private System.Windows.Forms.Button btn_dersKaydet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txtbx_dersAdi;
        private System.Windows.Forms.TextBox Txtbx_dersKodu;
        private System.Windows.Forms.TextBox txtbx_dersAlttan;
        private System.Windows.Forms.TextBox Txtbx_dersSaat;
        private System.Windows.Forms.ComboBox Cmbx_dersDerslik;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown veri_kap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ver_tur;
        private System.Windows.Forms.Label veri_kapasite;
        private System.Windows.Forms.Label veri_tür;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox ver_Id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbx_dersId;
        private System.Windows.Forms.Button btn_dersGuncelle;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource derslikBindingSource;
        private DataSet1TableAdapters.derslikTableAdapter derslikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kapasiteDataGridViewTextBoxColumn;
    }
}