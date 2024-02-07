namespace dersProgrami
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_bolum = new System.Windows.Forms.Button();
            this.btn_zaman = new System.Windows.Forms.Button();
            this.btn_program = new System.Windows.Forms.Button();
            this.btn_ders = new System.Windows.Forms.Button();
            this.btn_ogretmen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_bolum
            // 
            this.btn_bolum.Location = new System.Drawing.Point(45, 26);
            this.btn_bolum.Name = "btn_bolum";
            this.btn_bolum.Size = new System.Drawing.Size(114, 23);
            this.btn_bolum.TabIndex = 0;
            this.btn_bolum.Text = "Bölüm İşlemleri";
            this.btn_bolum.UseVisualStyleBackColor = true;
            this.btn_bolum.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_zaman
            // 
            this.btn_zaman.Location = new System.Drawing.Point(45, 167);
            this.btn_zaman.Name = "btn_zaman";
            this.btn_zaman.Size = new System.Drawing.Size(114, 23);
            this.btn_zaman.TabIndex = 1;
            this.btn_zaman.Text = "Zaman İşlemleri";
            this.btn_zaman.UseVisualStyleBackColor = true;
            this.btn_zaman.Click += new System.EventHandler(this.btn_zaman_Click);
            // 
            // btn_program
            // 
            this.btn_program.Location = new System.Drawing.Point(45, 217);
            this.btn_program.Name = "btn_program";
            this.btn_program.Size = new System.Drawing.Size(114, 23);
            this.btn_program.TabIndex = 2;
            this.btn_program.Text = "Program";
            this.btn_program.UseVisualStyleBackColor = true;
            this.btn_program.Click += new System.EventHandler(this.btn_program_Click);
            // 
            // btn_ders
            // 
            this.btn_ders.Location = new System.Drawing.Point(45, 119);
            this.btn_ders.Name = "btn_ders";
            this.btn_ders.Size = new System.Drawing.Size(114, 23);
            this.btn_ders.TabIndex = 4;
            this.btn_ders.Text = "Ders İşlemleri";
            this.btn_ders.UseVisualStyleBackColor = true;
            this.btn_ders.Click += new System.EventHandler(this.btn_ders_Click);
            // 
            // btn_ogretmen
            // 
            this.btn_ogretmen.Location = new System.Drawing.Point(45, 71);
            this.btn_ogretmen.Name = "btn_ogretmen";
            this.btn_ogretmen.Size = new System.Drawing.Size(114, 23);
            this.btn_ogretmen.TabIndex = 5;
            this.btn_ogretmen.Text = "Öğretmen İşlemleri";
            this.btn_ogretmen.UseVisualStyleBackColor = true;
            this.btn_ogretmen.Click += new System.EventHandler(this.btn_ogretmen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 273);
            this.Controls.Add(this.btn_ogretmen);
            this.Controls.Add(this.btn_ders);
            this.Controls.Add(this.btn_program);
            this.Controls.Add(this.btn_zaman);
            this.Controls.Add(this.btn_bolum);
            this.Name = "Form1";
            this.Text = "Menü";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_bolum;
        private System.Windows.Forms.Button btn_zaman;
        private System.Windows.Forms.Button btn_program;
        private System.Windows.Forms.Button btn_ders;
        private System.Windows.Forms.Button btn_ogretmen;
    }
}

