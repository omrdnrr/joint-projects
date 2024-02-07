namespace dersProgrami.Manager
{
    partial class Login
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
            this.veri_tc = new System.Windows.Forms.TextBox();
            this.veri_sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_grsYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // veri_tc
            // 
            this.veri_tc.Location = new System.Drawing.Point(64, 32);
            this.veri_tc.Name = "veri_tc";
            this.veri_tc.Size = new System.Drawing.Size(100, 20);
            this.veri_tc.TabIndex = 0;
            // 
            // veri_sifre
            // 
            this.veri_sifre.Location = new System.Drawing.Point(64, 82);
            this.veri_sifre.Name = "veri_sifre";
            this.veri_sifre.Size = new System.Drawing.Size(100, 20);
            this.veri_sifre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ŞİFRE";
            // 
            // btn_grsYap
            // 
            this.btn_grsYap.Location = new System.Drawing.Point(75, 131);
            this.btn_grsYap.Name = "btn_grsYap";
            this.btn_grsYap.Size = new System.Drawing.Size(75, 23);
            this.btn_grsYap.TabIndex = 4;
            this.btn_grsYap.Text = "Giriş Yap";
            this.btn_grsYap.UseVisualStyleBackColor = true;
            this.btn_grsYap.Click += new System.EventHandler(this.btn_grsYap_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 201);
            this.Controls.Add(this.btn_grsYap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.veri_sifre);
            this.Controls.Add(this.veri_tc);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox veri_tc;
        private System.Windows.Forms.TextBox veri_sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_grsYap;
    }
}