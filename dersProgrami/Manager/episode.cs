using dersProgrami.Manager.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dersProgrami.Manager
{
    public partial class Bölümler : Form
    {
        public Bölümler()
        {
            InitializeComponent();
        }

        int SecilenBolumId;
        int SecilenDersId;
        DataSet1TableAdapters.bolumlerTableAdapter dtBolumler = new DataSet1TableAdapters.bolumlerTableAdapter();
        DataSet1TableAdapters.bolumatamasıTableAdapter dtBolumAtamasi = new DataSet1TableAdapters.bolumatamasıTableAdapter();
        DataSet1TableAdapters.derslerTableAdapter dtDersler = new DataSet1TableAdapters.derslerTableAdapter();
        DataSet1TableAdapters.BolumAtamasiByDersandBolumTableAdapter dtBolumatamasiByDersandBolum = new DataSet1TableAdapters.BolumAtamasiByDersandBolumTableAdapter();


        // cmbx_bolum'deki veriler güncelllemek için
        private void cmbx_bolumReload()
        {
            cmbx_bolum.DataSource = dtBolumler.GetBolumler();
            cmbx_bolum.DisplayMember = "ad";
            cmbx_bolum.ValueMember = "id";
        }
        private void btn_blm_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                dtBolumler.InsertBolumler(veri_bölümadı.Text);
                MessageBox.Show("Bölüm sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BolumlerListele();
                cmbx_bolumReload();  
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                if (ex.Number == 2627) // Hata numarası, benzersiz anahtar hatasını temsil ediyor olabilir
                {
                    MessageBox.Show("Bu bölüm zaten mevcut", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ex.Number == 547) { 
                    MessageBox.Show("Bu veri boş olmamalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata " + ex.Number, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void episode_Load(object sender, EventArgs e)
        {
            BolumlerListele();
            cmbx_bolum.DataSource = dtBolumler.GetBolumler();
            cmbx_bolum.DisplayMember = "ad";
            cmbx_bolum.ValueMember = "id";
            cmbx_Ders.DataSource = dtDersler.GetDersler(); ;
            cmbx_Ders.DisplayMember = "ders";
            cmbx_Ders.ValueMember = "id";
            BolumAtamasiListele();
        }
        private void BolumlerListele()
        {
          dataGridView3.DataSource =  dtBolumler.GetBolumler();
        }
        private void BolumAtamasiListele()
        {
            dataGridView2.DataSource = dtBolumatamasiByDersandBolum.GetBolumAtamasiByDersandBolum();
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_blm_sil_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_BolumId.Text))
            {
                dtBolumler.DeleteBolumler(int.Parse(txt_BolumId.Text));
                MessageBox.Show("Bolum id'si " + txt_BolumId.Text + " silindi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BolumlerListele();
            }
            else
            {
                MessageBox.Show("Geçersiz Bolum Atama ID", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_bolumGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txt_BolumId.Text, out int bolumId)) // Check if txt_BolumId.Text is a valid integer
                {
                    if (string.IsNullOrEmpty(txt_id.Text))
                    {
                        dtBolumler.UpdateBolumler(veri_bölümadı.Text, bolumId);
                        MessageBox.Show("Bolumler " + bolumId + " güncellendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BolumlerListele();
                        cmbx_bolumReload();
                        BolumAtamasiListele();
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz Bolum Atama ID", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Geçersiz Bolum ID", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Bu bölüm zaten mevcut", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btn_kaydetB_Click(object sender, EventArgs e)
        {
           if(cmbx_Ders.SelectedItem != null && cmbx_bolum.SelectedItem !=null)
            {
                SecilenDersId = Convert.ToInt32(cmbx_Ders.SelectedValue);
                SecilenBolumId = Convert.ToInt32(cmbx_bolum.SelectedValue);
                
            }
            dtBolumAtamasi.Insert(SecilenBolumId, SecilenDersId);
            MessageBox.Show("Bolüm ders ataması yapıldı", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BolumAtamasiListele();
        }

        private void btn_silB_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_id.Text, out int bolumAtamaId))
            {
                dtBolumAtamasi.DeleteBolumAtama(bolumAtamaId);
                MessageBox.Show("Bolum atama  id'si " + txt_id.Text + " silindi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BolumAtamasiListele();
            }
            else
            {
                MessageBox.Show("Geçersiz Bolum Atama ID", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_gncatama_Click(object sender, EventArgs e)
        {
            if (cmbx_Ders.SelectedItem != null && cmbx_bolum.SelectedItem != null)
            {
                SecilenDersId = Convert.ToInt32(cmbx_Ders.SelectedValue);
                SecilenBolumId = Convert.ToInt32(cmbx_bolum.SelectedValue);
            }

            if (int.TryParse(txt_id.Text, out int bolumAtamaId))
            {
                dtBolumAtamasi.UpdateBolumAtama(SecilenBolumId, SecilenDersId, bolumAtamaId);
                MessageBox.Show("Bolum ataması " + txt_id.Text + " güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BolumAtamasiListele();
            }
            else
            {
                MessageBox.Show("Geçersiz Bolum Atama ID", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
