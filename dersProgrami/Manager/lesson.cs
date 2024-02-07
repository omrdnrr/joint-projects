using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dersProgrami.Manager
{
    public partial class lesson : Form
    {
        public lesson()
        {
            InitializeComponent();
        }
        //data getirme 
        int secilenDersId;
        DataSet1TableAdapters.derslikTableAdapter dtDerslik = new DataSet1TableAdapters.derslikTableAdapter();
        DataSet1TableAdapters.derslerTableAdapter dtDersler = new DataSet1TableAdapters.derslerTableAdapter();
        DataSet1TableAdapters.DerslerByDerslikTableAdapter dtDerslerByDerslik = new DataSet1TableAdapters.DerslerByDerslikTableAdapter();


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //derslik verisi kaydetme 
                dtDerslik.InsertDerslik(ver_tur.Text, veri_kap.Value.ToString(), "1");
                MessageBox.Show("Derslik sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dersliklistele();
                DerslerByDerslikListesi();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                if (ex.Number == 547) 
                {
                    MessageBox.Show("Hata: Lütfen boş veri bırakmayın", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Hata: Lütfen tür ismini benzersiz yapın", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void lesson_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dataSet1.derslik' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.derslikTableAdapter.FillDerslik(this.dataSet1.derslik);
            //verileri listeleme 
            Dersliklistele();
            DerslerByDerslikListesi();
            //derslik comboboxına derslikleri getirme
            Cmbx_dersDerslik.DataSource = dtDerslik.GetDerslik();
            Cmbx_dersDerslik.DisplayMember = "tur";
            Cmbx_dersDerslik.ValueMember = "id";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(ver_Id.Text, out int id))
                {
                    //derslik verileri silme 
                    dtDerslik.DeleteDerslik(id);
                    MessageBox.Show("Derslik " + ver_Id.Text + " silindi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Dersliklistele();
                }
                else
                {
                    MessageBox.Show("Hata: Geçersiz ID formatı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                if (ex.Number == 547) {
                    MessageBox.Show("Bir hata oluştu: Lütfen dersliğin ilgili olduğu dersleri değiştirin. ", "Hata " + ex.Number, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata " + ex.Number, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dersliklistele()
        {
            //derslikleri listeleme işlemi yapan kod
            DataSet1TableAdapters.derslikTableAdapter dtDerslik = new DataSet1TableAdapters.derslikTableAdapter();
            DataSet1TableAdapters.derslerTableAdapter dtDersler = new DataSet1TableAdapters.derslerTableAdapter();
            DataSet1TableAdapters.DerslerByDerslikTableAdapter dtDerslerByDerslik = new DataSet1TableAdapters.DerslerByDerslikTableAdapter();
            this.derslikTableAdapter.FillDerslik(this.dataSet1.derslik);

            // Derslik combobox güncelleme
            Cmbx_dersDerslik.DataSource = dtDerslik.GetDerslik();
            Cmbx_dersDerslik.DisplayMember = "tur";
            Cmbx_dersDerslik.ValueMember = "id";

        }
        private void DerslerByDerslikListesi()
        {
            dataGridView1.DataSource= dtDerslerByDerslik.GetDerslerByDersik();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try {

                if (int.TryParse(ver_Id.Text, out int id)) { 
                //Derslik Güncelle
                dtDerslik.UpdateDerslik(ver_tur.Text, veri_kap.Value.ToString(), "1", int.Parse(ver_Id.Text));
                MessageBox.Show("Derslik " + ver_Id.Text + " güncellendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dersliklistele();
                DerslerByDerslikListesi();
                }
                else
                {
                    MessageBox.Show("Hata: Geçersiz ID formatı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("Hata: Lütfen boş veri bırakmayın", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Number == 2627)
                {
                    MessageBox.Show("Hata: Lütfen tür ismini benzersiz yapın", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // Ders butonları
        private void btn_dersKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cmbx_dersDerslik.SelectedItem != null)
                {
                    secilenDersId = Convert.ToInt32(Cmbx_dersDerslik.SelectedValue);
                    // secilenDersID'yi başka bir yerde kullanabilirsiniz
                }

                dtDersler.InsertDersler(secilenDersId, Txtbx_dersAdi.Text, Txtbx_dersKodu.Text, Txtbx_dersSaat.Text, txtbx_dersAlttan.Text, "Belirsiz");
                MessageBox.Show("Dersler sisteme eklendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DerslerByDerslikListesi();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("Hata: Lütfen boş veri bırakmayın", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Number == 2627)
                {
                    MessageBox.Show("Hata: Ders adını ve Ders Kodunu benzersiz yapın", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else { 
                MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata " + ex.Number , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btn_dersGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cmbx_dersDerslik.SelectedItem != null)
                {
                    secilenDersId = Convert.ToInt32(Cmbx_dersDerslik.SelectedValue);
                    // secilenDersID'yi başka bir yerde kullanabilirsiniz
                }

                if (int.TryParse(txtbx_dersId.Text, out int dersId))
                {
                    dtDersler.UpdateDersler(secilenDersId, Txtbx_dersAdi.Text, Txtbx_dersKodu.Text, Txtbx_dersSaat.Text, txtbx_dersAlttan.Text, "Belirsiz" , dersId);
                    MessageBox.Show("Ders id 'si " + dersId + " güncellendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DerslerByDerslikListesi();
                }
                else
                {
                    MessageBox.Show("Hata: Ders ID'si geçerli bir sayı değil", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("Hata: Lütfen boş veri bırakmayın", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Number == 2627)
                {
                    MessageBox.Show("Hata: Ders adını ve Ders Kodunu benzersiz yapın", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata " + ex.Number, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btn_dersSil_Click(object sender, EventArgs e)
        {
            try
            {
                int dersId;
                if (int.TryParse(txtbx_dersId.Text, out dersId))
                {
                    dtDersler.DeleteDersler(dersId);
                    MessageBox.Show("Ders id'si " + txtbx_dersId.Text + " silindi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DerslerByDerslikListesi();
                }
                else
                {
                    MessageBox.Show("Hata: Geçersiz Ders ID formatı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
