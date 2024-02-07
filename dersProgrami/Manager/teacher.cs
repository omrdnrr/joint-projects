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
    public partial class teacher : Form
    {
        public teacher()
        {
            InitializeComponent();
        }
        int SecilenOgrId;
        int SecilenDersId;
        DataSet1TableAdapters.ogretmenTableAdapter dtogr = new DataSet1TableAdapters.ogretmenTableAdapter();
        DataSet1TableAdapters.ogretmenatamasıTableAdapter dtogratama=new DataSet1TableAdapters.ogretmenatamasıTableAdapter();
        DataSet1TableAdapters.derslerTableAdapter dtdersler = new DataSet1TableAdapters.derslerTableAdapter();
        DataSet1TableAdapters.OgrAtamaJoinTableAdapter dtOgrAtamaJoin = new DataSet1TableAdapters.OgrAtamaJoinTableAdapter();
        DataSet1TableAdapters.OgretmenMusaitlikTableAdapter dtogrMusaitlik = new DataSet1TableAdapters.OgretmenMusaitlikTableAdapter();
        DataSet1TableAdapters.OgrMusaitlikJoinTableAdapter dtOgrMusaitlikJoin = new DataSet1TableAdapters.OgrMusaitlikJoinTableAdapter();
        private void OgretmenListele()
        {

            dataGridView2.DataSource=  dtogr.GetOgretmen();
            dataGridView3.DataSource = dtOgrAtamaJoin.GetOgrAtamaJoin();
            dataGridView1.DataSource = dtOgrMusaitlikJoin.GetOgretmenMusaitlikJoin();

            cmbx_ogrmusait.DataSource = dtogr.GetOgretmen();
            cmbx_ogrmusait.DisplayMember = "ad";
            cmbx_ogrmusait.ValueMember = "id";

            cmbx_ogrAtama.DataSource = dtogr.GetOgretmen();
            cmbx_ogrAtama.DisplayMember = "ad";
            cmbx_ogrAtama.ValueMember = "id";
        }
        private void teacher_Load(object sender, EventArgs e)
        {
            OgretmenListele();
            OgretmenAtamaListesi();
            OgretmenMusaitlikListesi();
            cmbx_ogrAtama.DataSource = dtogr.GetOgretmen();
            cmbx_ogrAtama.DisplayMember = "ad";
            cmbx_ogrAtama.ValueMember = "id";
            cmbx_OgrDersAtama.DataSource = dtdersler.GetDersler();
            cmbx_OgrDersAtama.DisplayMember = "ders";
            cmbx_OgrDersAtama.ValueMember = "id";
            cmbx_ogrmusait.DataSource = dtogr.GetOgretmen();
            cmbx_ogrmusait.DisplayMember = "ad";
            cmbx_ogrmusait.ValueMember = "id";

        }

        private void btn_ogr_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                dtogr.InsertOgretmen(cbmx_yetki.Text, cmbx_ünvan.Text, veri_tc.Text, veri_telefon.Text, veri_ad.Text + " " + veri_soyad.Text, veri_sifre.Text);
                MessageBox.Show("Ogretmen sisteme eklendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OgretmenListele();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                int errorCode = ex.Number; // SQL hatasının numarasını al

                if (errorCode == 547)
                {
                    MessageBox.Show("Hata: Lütfen tüm değerleri minimum 3 harf ile girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (errorCode == 2627)
                {
                    string errorMessage = ex.Message.ToLower();

                    if (errorMessage.Contains("telefon"))
                    {
                        MessageBox.Show("Hata: Telefon numarası benzersiz olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (errorMessage.Contains("tc"))
                    {
                        MessageBox.Show("Hata: TC kimlik numarası benzersiz olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Bilinmeyen bir hata oluştu. Hata kodu: " + errorCode.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Bilinmeyen bir hata oluştu. Hata kodu: " + errorCode.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btn_ogr_sil_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_ogr_id.Text, out int ogretmenId))
            {
                dtogr.DeleteOgretmen(ogretmenId);
                MessageBox.Show("Öğretmen " + ogretmenId + " silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                OgretmenListele();
            }
            else
            {
                MessageBox.Show("Geçersiz Öğretmen ID", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_ogr_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txt_ogr_id.Text, out int ogretmenId))
                {
                    dtogr.UpdateOgretmen(cbmx_yetki.Text, cmbx_ünvan.Text, veri_tc.Text, veri_telefon.Text, veri_ad.Text + " " + veri_soyad.Text , veri_sifre.Text, ogretmenId);
                    MessageBox.Show("Öğretmen " + ogretmenId + " güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OgretmenListele();
                }
                else
                {
                    MessageBox.Show("Geçersiz Öğretmen ID", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                int errorCode = ex.Number; // SQL hatasının numarasını al

                if (errorCode == 547)
                {
                    MessageBox.Show("Hata: Lütfen tüm değerleri minimum 3 harf ile girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (errorCode == 2627)
                {
                    MessageBox.Show("Hata: Telefon ve TC lütfen benzersiz yapın.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Bilinmeyen bir hata oluştu. Hata kodu: " + errorCode.ToString(), "Hata" + ex.Number, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btn_ogr_ogr_atama_Click(object sender, EventArgs e)
        {
            if (cmbx_ogrAtama.SelectedItem != null && cmbx_OgrDersAtama.SelectedItem != null)
            {
                SecilenDersId = Convert.ToInt32(cmbx_OgrDersAtama.SelectedValue);
                SecilenOgrId = Convert.ToInt32(cmbx_ogrAtama.SelectedValue);

            }
            dtogratama.UpdateOgrAtama(SecilenOgrId,SecilenDersId,int.Parse(txt_ogrAtma_id.Text));
            MessageBox.Show("Ogretmen ataması" + txt_ogr_id.Text + " güncellendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OgretmenAtamaListesi();
        }

        private void btn_kaydet_atama_Click(object sender, EventArgs e)
        {
            try
            {
                SecilenDersId = Convert.ToInt32(cmbx_OgrDersAtama.SelectedValue);
                SecilenOgrId = Convert.ToInt32(cmbx_ogrAtama.SelectedValue);

                dtogratama.InsertOgrAtama(SecilenOgrId, SecilenDersId);
                MessageBox.Show("Öğretmen ataması yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OgretmenAtamaListesi();
            }
            catch (System.Data.SqlClient.SqlException ex) {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Bu atama zaten yapıldı.", "Hata " + ex.Number, MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else if (ex.Number == 547)
                {
                    MessageBox.Show("Lütfen boş bırakmayın.", "Hata " + ex.Number, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Hata ", "Hata " + ex.Number, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void btn_sil_ogr_atama_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_ogrAtma_id.Text) && int.TryParse(txt_ogrAtma_id.Text, out int ogrAtamaId))
            {
                dtogratama.DeleteOgrAtama(ogrAtamaId);
                MessageBox.Show("Oğretmen ataması " + ogrAtamaId + " silindi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                OgretmenAtamaListesi();
            }
            else
            {
                MessageBox.Show("Geçersiz atama ID", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OgretmenAtamaListesi()
        {
            dataGridView3.DataSource = dtOgrAtamaJoin.GetOgrAtamaJoin();
        }
        private void OgretmenMusaitlikListesi()
        {
            dataGridView1.DataSource=dtOgrMusaitlikJoin.GetOgretmenMusaitlikJoin();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SecilenOgrId = Convert.ToInt32(cmbx_ogrmusait.SelectedValue);
                dtogrMusaitlik.Insert(SecilenOgrId, txt_gun.Text);
                MessageBox.Show("Ogretmen müsait işlemi yapıldı", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OgretmenMusaitlikListesi();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Bu atama zaten yapıldı.", "Hata " + ex.Number, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Number == 547)
                {
                    MessageBox.Show("Lütfen boş bırakmayın.", "Hata " + ex.Number, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Hata ", "Hata " + ex.Number, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_gunc_ogr_belirleme_Click(object sender, EventArgs e)
        {
            if (cmbx_ogrmusait.SelectedItem != null)
            {
               
                SecilenOgrId = Convert.ToInt32(cmbx_ogrmusait.SelectedValue);

            }
            dtogrMusaitlik.UpdateOgrMusaitlik(SecilenOgrId, txt_gun.Text, int.Parse(txt_ogrMusait_id.Text));
            MessageBox.Show("Ogretmen müsaitliği" + txt_ogrMusait_id.Text + " güncellendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OgretmenMusaitlikListesi();
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_ogrMusait_id.Text) && int.TryParse(txt_ogrMusait_id.Text, out int ogrMusaitId))
            {
                dtogrMusaitlik.DeleteOgrMusaitlik(ogrMusaitId);
                MessageBox.Show("Oğretmen müsaitliği " + ogrMusaitId + " silindi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                OgretmenMusaitlikListesi();
            }
            else
            {
                MessageBox.Show("Geçersiz müsaitlik ID", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
