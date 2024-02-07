using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dersProgrami.Manager
{
    internal class kontrol
    {

        // Program eklemede gerekli kontroller
        public bool ogretmenKontrol(DataGridView dataGridView, string ogretmen, string gun)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {

                string ogretmenValue = row.Cells["ÖğretmenDataGridViewTextBoxColumn"].Value.ToString();
                string gunValue = row.Cells["ZamanDataGridViewTextBoxColumn"].Value.ToString();
                if (ogretmenValue.Equals(ogretmen) && gunValue.Equals(gun))
                {
                    return true;
                }
            }

            return false;
        }
        public bool bolumKontrol(DataGridView dataGridView, string bolum, string gun)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                string bolumValue = row.Cells["BölümDataGridViewTextBoxColumn"].Value.ToString();
                string gunValue = row.Cells["ZamanDataGridViewTextBoxColumn"].Value.ToString();

                if (bolumValue.Equals(bolum) && gunValue.Equals(gun))
                {
                    return true;
                }
            }

            return false;
        }
        public bool derslikKontrol(DataGridView dataGridView, string derslik, string gun)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                string derslikValue = row.Cells["DerslikDataGridViewTextBoxColumn"].Value.ToString();
                string gunValue = row.Cells["ZamanDataGridViewTextBoxColumn"].Value.ToString();

                if (derslikValue.Equals(derslik) && gunValue.Equals(gun))
                {
                    return true;
                }
            }
            return false;
        }




        // Program güncellerken gerekliler
        public bool ogretmenKontrol(DataGridView dataGridView, string ogretmen, string gun, int id)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                int currentId = Convert.ToInt32(row.Cells["idDataGridViewTextBoxColumn"].Value);
                string ogretmenValue = row.Cells["ÖğretmenDataGridViewTextBoxColumn"].Value.ToString();
                string gunValue = row.Cells["ZamanDataGridViewTextBoxColumn"].Value.ToString();

                if (currentId != id && ogretmenValue.Equals(ogretmen) && gunValue.Equals(gun))
                {
                    return true;
                }
            }

            return false;
        }
        public bool bolumKontrol(DataGridView dataGridView, string bolum, string gun, int id)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                int currentId = Convert.ToInt32(row.Cells["idDataGridViewTextBoxColumn"].Value);
                string bolumValue = row.Cells["BölümDataGridViewTextBoxColumn"].Value.ToString();
                string gunValue = row.Cells["ZamanDataGridViewTextBoxColumn"].Value.ToString();

                if (currentId != id && bolumValue.Equals(bolum) && gunValue.Equals(gun))
                {
                    return true;
                }
            }

            return false;
        }
        public bool derslikKontrol(DataGridView dataGridView, string derslik, string gun, int id)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                int currentId = Convert.ToInt32(row.Cells["idDataGridViewTextBoxColumn"].Value);
                string derslikValue = row.Cells["DerslikDataGridViewTextBoxColumn"].Value.ToString();
                string gunValue = row.Cells["ZamanDataGridViewTextBoxColumn"].Value.ToString();

                if (currentId != id && derslikValue.Equals(derslik) && gunValue.Equals(gun))
                {
                    return true;
                }
            }
            return false;
        }




        DataSet1TableAdapters.OgretmenMusaitlikTableAdapter dtogrMusaitlik = new DataSet1TableAdapters.OgretmenMusaitlikTableAdapter();

        public bool ogretmenmusaitlik(int ogretmen, string gun)
        {
            DataSet1 dataSet = new DataSet1(); // DataSet nesnesi oluşturunuz, isim DataSet1 olarak varsayılmıştır
            DataSet1TableAdapters.OgretmenMusaitlikTableAdapter dtogrMusaitlik = new DataSet1TableAdapters.OgretmenMusaitlikTableAdapter();

            int i = (int) dtogrMusaitlik.musaitArama(ogretmen,gun);
            return i != 0;
        }






    }
}
