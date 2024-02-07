namespace dersProgrami.Manager
{
    partial class Bölümler
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_BolumId = new System.Windows.Forms.TextBox();
            this.btn_bolumGuncelle = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.veri_bölümadı = new System.Windows.Forms.TextBox();
            this.btn_blm_sil = new System.Windows.Forms.Button();
            this.btn_blm_kaydet = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cmbx_Ders = new System.Windows.Forms.ComboBox();
            this.cmbx_bolum = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_silB = new System.Windows.Forms.Button();
            this.btn_kaydetB = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txt_BolumId);
            this.panel3.Controls.Add(this.btn_bolumGuncelle);
            this.panel3.Controls.Add(this.dataGridView3);
            this.panel3.Controls.Add(this.veri_bölümadı);
            this.panel3.Controls.Add(this.btn_blm_sil);
            this.panel3.Controls.Add(this.btn_blm_kaydet);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(566, 226);
            this.panel3.TabIndex = 34;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Id :";
            // 
            // txt_BolumId
            // 
            this.txt_BolumId.Location = new System.Drawing.Point(100, 88);
            this.txt_BolumId.Name = "txt_BolumId";
            this.txt_BolumId.Size = new System.Drawing.Size(121, 20);
            this.txt_BolumId.TabIndex = 35;
            // 
            // btn_bolumGuncelle
            // 
            this.btn_bolumGuncelle.Location = new System.Drawing.Point(91, 188);
            this.btn_bolumGuncelle.Name = "btn_bolumGuncelle";
            this.btn_bolumGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_bolumGuncelle.TabIndex = 34;
            this.btn_bolumGuncelle.Text = "Güncelle";
            this.btn_bolumGuncelle.UseVisualStyleBackColor = true;
            this.btn_bolumGuncelle.Click += new System.EventHandler(this.btn_bolumGuncelle_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(281, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(243, 216);
            this.dataGridView3.TabIndex = 33;
            // 
            // veri_bölümadı
            // 
            this.veri_bölümadı.Location = new System.Drawing.Point(100, 111);
            this.veri_bölümadı.Name = "veri_bölümadı";
            this.veri_bölümadı.Size = new System.Drawing.Size(121, 20);
            this.veri_bölümadı.TabIndex = 32;
            // 
            // btn_blm_sil
            // 
            this.btn_blm_sil.Location = new System.Drawing.Point(145, 151);
            this.btn_blm_sil.Name = "btn_blm_sil";
            this.btn_blm_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_blm_sil.TabIndex = 31;
            this.btn_blm_sil.Text = "Veriyi Sil";
            this.btn_blm_sil.UseVisualStyleBackColor = true;
            this.btn_blm_sil.Click += new System.EventHandler(this.btn_blm_sil_Click);
            // 
            // btn_blm_kaydet
            // 
            this.btn_blm_kaydet.Location = new System.Drawing.Point(45, 151);
            this.btn_blm_kaydet.Name = "btn_blm_kaydet";
            this.btn_blm_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_blm_kaydet.TabIndex = 26;
            this.btn_blm_kaydet.Text = "Kayıt Et";
            this.btn_blm_kaydet.UseVisualStyleBackColor = true;
            this.btn_blm_kaydet.Click += new System.EventHandler(this.btn_blm_kaydet_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(58, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 26);
            this.label16.TabIndex = 18;
            this.label16.Text = "Bölüm Ekle";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(28, 116);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "Bölüm Adı :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.txt_id);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.cmbx_Ders);
            this.panel2.Controls.Add(this.cmbx_bolum);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btn_silB);
            this.panel2.Controls.Add(this.btn_kaydetB);
            this.panel2.Location = new System.Drawing.Point(12, 244);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 187);
            this.panel2.TabIndex = 35;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(67, 36);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(121, 20);
            this.txt_id.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Id : ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(242, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(312, 173);
            this.dataGridView2.TabIndex = 17;
            // 
            // cmbx_Ders
            // 
            this.cmbx_Ders.DisplayMember = "ders";
            this.cmbx_Ders.FormattingEnabled = true;
            this.cmbx_Ders.Location = new System.Drawing.Point(66, 94);
            this.cmbx_Ders.Name = "cmbx_Ders";
            this.cmbx_Ders.Size = new System.Drawing.Size(121, 21);
            this.cmbx_Ders.TabIndex = 16;
            this.cmbx_Ders.ValueMember = "id";
            // 
            // cmbx_bolum
            // 
            this.cmbx_bolum.DisplayMember = "ad";
            this.cmbx_bolum.FormattingEnabled = true;
            this.cmbx_bolum.Location = new System.Drawing.Point(67, 65);
            this.cmbx_bolum.Name = "cmbx_bolum";
            this.cmbx_bolum.Size = new System.Drawing.Size(121, 21);
            this.cmbx_bolum.TabIndex = 15;
            this.cmbx_bolum.ValueMember = "id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ders :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(26, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Bölüme Ders Atama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Bölüm :";
            // 
            // btn_silB
            // 
            this.btn_silB.Location = new System.Drawing.Point(111, 126);
            this.btn_silB.Name = "btn_silB";
            this.btn_silB.Size = new System.Drawing.Size(75, 23);
            this.btn_silB.TabIndex = 11;
            this.btn_silB.Text = "Sil";
            this.btn_silB.UseVisualStyleBackColor = true;
            this.btn_silB.Click += new System.EventHandler(this.btn_silB_Click);
            // 
            // btn_kaydetB
            // 
            this.btn_kaydetB.Location = new System.Drawing.Point(17, 126);
            this.btn_kaydetB.Name = "btn_kaydetB";
            this.btn_kaydetB.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydetB.TabIndex = 10;
            this.btn_kaydetB.Text = "Kaydet";
            this.btn_kaydetB.UseVisualStyleBackColor = true;
            this.btn_kaydetB.Click += new System.EventHandler(this.btn_kaydetB_Click);
            // 
            // Bölümler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 440);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "Bölümler";
            this.Text = "episode";
            this.Load += new System.EventHandler(this.episode_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox veri_bölümadı;
        private System.Windows.Forms.Button btn_blm_sil;
        private System.Windows.Forms.Button btn_blm_kaydet;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cmbx_Ders;
        private System.Windows.Forms.ComboBox cmbx_bolum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_silB;
        private System.Windows.Forms.Button btn_kaydetB;
        private System.Windows.Forms.Button btn_bolumGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_BolumId;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
    }
}