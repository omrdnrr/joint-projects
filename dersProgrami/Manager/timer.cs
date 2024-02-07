using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dersProgrami.Manager
{
    public partial class timer : Form
    {
        public timer()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.zamanTableAdapter dtZaman = new DataSet1TableAdapters.zamanTableAdapter();
        DataSet1TableAdapters.zamanJoinTableAdapter dtJoin = new DataSet1TableAdapters.zamanJoinTableAdapter();
        DataSet1TableAdapters.GunlerTableAdapter dtGun = new DataSet1TableAdapters.GunlerTableAdapter();
        private void zamanListele()
        {
            dataGridView1.DataSource= dtJoin.GetData();
        }
        private void timer_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dataSet1.zamanJoin' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.zamanJoinTableAdapter.Fill(this.dataSet1.zamanJoin);
            cbmx_gun.DataSource= dtGun.GetGunler();
            cbmx_gun.DisplayMember = "day";
            cbmx_gun.ValueMember = "id";
            zamanListele();          
        }


        private void Onayla_Click(object sender, EventArgs e)
        {
            try
            {
                // Tüm gerekli alanların doldurulup doldurulmadığını kontrol eder
                if (string.IsNullOrWhiteSpace(veri_ilkders.Text)
                    || veri_derssüresi.Value == 0
                    || veri_tenefüssüresi.Value == 0
                    || veri_derssayısıönce.Value == 0
                    || veri_öğlenmolasüresi.Value == 0
                    || veri_derssayısısonra.Value == 0
                    )
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dtZaman.DeleteZaman();
                // Saat ve dakika bilgilerini ayır


                foreach (DataRowView rowView in cbmx_gun.Items) {
                    string[] saatiAyir = veri_ilkders.Text.Split(':');
                    int dersbaslangıc = (int.Parse(saatiAyir[0]) * 60) + int.Parse(saatiAyir[1]);
                    DataRow row = rowView.Row;
                    int i;
                    for (i = 1; i <= veri_derssayısıönce.Value; i++)
                    {
                        dtZaman.InsertZaman("Ders", i.ToString(), Gndr(dersbaslangıc.ToString()), Gndr((dersbaslangıc + (int)veri_derssüresi.Value).ToString()), int.Parse(row["id"].ToString()));
                        dersbaslangıc = dersbaslangıc + (int)veri_derssüresi.Value;

                        if ((int)veri_derssayısıönce.Value != i)
                        {
                            dtZaman.InsertZaman("Tenefüs", i.ToString(), Gndr(dersbaslangıc.ToString()), Gndr((dersbaslangıc + (int)veri_tenefüssüresi.Value).ToString()), int.Parse(row["id"].ToString()));
                            dersbaslangıc = dersbaslangıc + (int)veri_tenefüssüresi.Value;
                        }

                    }
                    dtZaman.InsertZaman("Öğlen Molası", 0.ToString(), Gndr(dersbaslangıc.ToString()), Gndr((dersbaslangıc + (int)veri_öğlenmolasüresi.Value).ToString()), int.Parse(row["id"].ToString()));
                    dersbaslangıc = dersbaslangıc + (int)veri_derssüresi.Value;

                    int a = (int) veri_derssayısısonra.Value;
                    int sonlanan = a + i;
                    for (; i < sonlanan; i++)
                    {
                        dtZaman.InsertZaman("Ders", i.ToString(), Gndr(dersbaslangıc.ToString()), Gndr((dersbaslangıc + (int)veri_derssüresi.Value).ToString()), int.Parse(row["id"].ToString()));
                        dersbaslangıc = dersbaslangıc + (int)veri_derssüresi.Value;

                    }
                }
                // Başarı mesajı göster
                MessageBox.Show("Başarıyla zaman eklendi", "Başarılı", MessageBoxButtons.OK);
                zamanListele();
                
            }
        catch (Exception ex)
         {
                if(cbmx_gun.SelectedItem != null)
                {
                    MessageBox.Show("Gün seçmediniz Günler yoksa Aşağıdan günleri belirlemeniz yeterli");
                }
                    MessageBox.Show("Genel hata: " + ex.Message);
           }
        }

        private String Gndr(string veri)
        {
            int saat = Convert.ToInt32(veri)/60;
            int dakika = Convert.ToInt32(veri)%60;
            return saat + ":" + dakika;
        }


        private void btnGunKaydet_Click(object sender, EventArgs e)
        {
            dtGun.DeleteGunler();

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                // CheckBox seçili ise metni listeye ekleyin
                if (checkedListBox1.GetItemChecked(i))
                {
                    dtGun.InsertGunler(checkedListBox1.Items[i].ToString());
                }
            }
            cbmx_gun.DataSource = dtGun.GetGunler();
            cbmx_gun.DisplayMember = "day";
            cbmx_gun.ValueMember = "id";
        }
    }
}
