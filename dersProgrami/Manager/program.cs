using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dersProgrami.Manager
{
    public partial class program : Form
    {
        private DataTable _dataTable;
        public program()
        {
            InitializeComponent();
            _dataTable = new DataTable();
        }


        DataSet1TableAdapters.programTableAdapter dtProgram = new DataSet1TableAdapters.programTableAdapter();
        DataSet1TableAdapters.ProgramListelemeJoinTableAdapter dtProgramJoin = new DataSet1TableAdapters.ProgramListelemeJoinTableAdapter();
        DataSet1TableAdapters.derslikTableAdapter dtderslik = new DataSet1TableAdapters.derslikTableAdapter();
        DataSet1TableAdapters.ProgramJoin2TableAdapter dtProgramJoin2 = new DataSet1TableAdapters.ProgramJoin2TableAdapter();
        DataSet1TableAdapters.joinProgramTableAdapter dtPto = new DataSet1TableAdapters.joinProgramTableAdapter();

        private void program_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dataSet1.joinProgram' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.joinProgramTableAdapter.Fill(this.dataSet1.joinProgram);
            // TODO: Bu kod satırı 'dataSet1.blm_aktar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.blm_aktarTableAdapter.Fill(this.dataSet1.blm_aktar);
            veri_derslik.DataSource = dtderslik.GetDerslik();
            veri_derslik.ValueMember = "id";
            veri_derslik.DisplayMember = "tur";
            // TODO: Bu kod satırı 'dataSet1.program' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
             this.programTableAdapter.FillProgram(this.dataSet1.program);
            // TODO: Bu kod satırı 'dataSet1.dersvekodu' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.dersvekoduTableAdapter.Fill(this.dataSet1.dersvekodu);
            // TODO: Bu kod satırı 'dataSet1.dersler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.derslerTableAdapter.FillDersler(this.dataSet1.dersler);
            // TODO: Bu kod satırı 'dataSet1.ogretmen' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogretmenTableAdapter.FillOgretmen(this.dataSet1.ogretmen);
            // TODO: Bu kod satırı 'dataSet1.zaman1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.zaman1TableAdapter.Fill(this.dataSet1.zaman1);
            // TODO: Bu kod satırı 'dataSet1.bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter.FillBolumler(this.dataSet1.bolumler);



        }

        int secilenDerslikId;
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                ShowAllProgramData();
                // Verileri al
                int bölüm = Convert.ToInt32(veri_blm.SelectedValue);
                int ogretmen = Convert.ToInt32(veri_öğretmen.SelectedValue);
                int ders = Convert.ToInt32(veri_ders.SelectedValue);
                int vakit = Convert.ToInt32(veri_vakit.SelectedValue);
                int derslik = Convert.ToInt32(veri_derslik.SelectedValue);

                kontrol kontroller = new kontrol();

                // Gerekli kontroller
                if (kontroller.ogretmenKontrol(dataGridView1, veri_öğretmen.Text, veri_vakit.Text))
                {
                    DialogResult result = MessageBox.Show("Öğretmen o gün müsait değil, yine de eklemek istiyor musunuz?",
                        "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }
                if (kontroller.bolumKontrol(dataGridView1, veri_blm.Text, veri_vakit.Text))
                {
                    DialogResult result = MessageBox.Show("Bölüm o gün müsait değil, yine de eklemek istiyor musunuz?",
                        "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }
                if (kontroller.derslikKontrol(dataGridView1, veri_derslik.Text, veri_vakit.Text))
                {
                    DialogResult result = MessageBox.Show("Derslik o gün müsait değil, yine de eklemek istiyor musunuz?",
                        "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }

                string[] heceler = veri_vakit.Text.Split(' ');
                DataSet1 dataSets = new DataSet1();
                if (kontroller.ogretmenmusaitlik(ogretmen, (string)heceler[0]))
                {
                    DialogResult result = MessageBox.Show("Öğretmen o gün çalışmıyor.., yine de eklemek istiyor musunuz?",
                        "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }
                if(veri_derslik.SelectedItem != null)
                {
                    secilenDerslikId= Convert.ToInt32(veri_derslik.SelectedValue);
                }
                
                dtProgram.InsertProgram(bölüm, ogretmen, ders, secilenDerslikId, vakit);
                ShowAllProgramData();
                MessageBox.Show("Program sisteme eklendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                ShowAllProgramData();
                int id = Convert.ToInt32(veri_id.Text);
                int bolum = Convert.ToInt32(veri_blm.SelectedValue);
                int ogretmen = Convert.ToInt32(veri_öğretmen.SelectedValue);
                int ders = Convert.ToInt32(veri_ders.SelectedValue);
                int vakit = Convert.ToInt32(veri_vakit.SelectedValue);
                string derslik = veri_derslik.Text;

                kontrol kontroller = new kontrol();

                if (kontroller.ogretmenKontrol(dataGridView1, veri_öğretmen.Text, veri_vakit.Text, id))
                {
                    DialogResult result = MessageBox.Show("Öğretmen o gün müsait değil, yine de eklemek istiyor musunuz?",
                        "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }
                if (kontroller.bolumKontrol(dataGridView1, veri_blm.Text, veri_vakit.Text, id))
                {
                    DialogResult result = MessageBox.Show("Bölüm o gün müsait değil, yine de eklemek istiyor musunuz?",
                        "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }
                if (kontroller.derslikKontrol(dataGridView1, veri_derslik.Text, veri_vakit.Text, id))
                {
                    DialogResult result = MessageBox.Show("Derslik o gün müsait değil, yine de eklemek istiyor musunuz?",
                        "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }

                string[] heceler = veri_vakit.Text.Split(' ');
                DataSet1 dataSets = new DataSet1();
                if (kontroller.ogretmenmusaitlik(ogretmen, (string)heceler[0]))
                {
                    DialogResult result = MessageBox.Show("Derslik o gün çalışmıyor.., yine de eklemek istiyor musunuz?",
                        "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }

                if(veri_derslik.SelectedItem != null)
                {
                    secilenDerslikId = Convert.ToInt32(veri_derslik.SelectedValue);
                }
                dtProgram.UpdateProgram(bolum, ogretmen, ders, secilenDerslikId, vakit, id);
                ShowAllProgramData();
                MessageBox.Show("Program sistemde güncellendi.", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (FormatException)
            {
                MessageBox.Show("Hatalı giriş! Lütfen sayısal değerleri doğru formatta girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                ShowAllProgramData();
                if (int.TryParse(veri_id.Text, out int id))
                {
                    //derslik verileri silme 
                    dtProgram.DeleteQuery(id);
                    MessageBox.Show("Programda " + veri_id.Text + " silindi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Bir hata oluştu: Lütfen bilgileri kontrol edin.. ", "Hata " + ex.Number, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata " + ex.Number, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }







        private void btn_programHazırla_Click(object sender, EventArgs e)
        {

            dtProgram.RemoveAll();
            Otomasyon otomasyon = new Otomasyon();
            otomasyon.Start();
            ShowAllProgramData();
            MessageBox.Show("Program hazırlandı");

        }

        // Hepsini sil
        private void btn_programSıfırla_Click(object sender, EventArgs e)
        {
            dtProgram.RemoveAll();
            ShowAllProgramData();
            MessageBox.Show("Program Temizlenmiştir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Listem.Clear();
            _dataTable = ToDataTable(Listem);
            dataGridView1.DataSource = _dataTable;

        }
        List<string> Listem = new List<string>();
        // Bölüm ve Öğretmene Göre Listeleme
        private void btn_BolumListele_Click(object sender, EventArgs e)
        {
            Listem.Clear();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    // "id" değerini al
                    string id = row.Cells[1].Value.ToString();

                    // Belirli bir koşulu sağlayan satırları listele (örneğin, id değeri 1 olanları)
                    if (cmbx_bolum.Text.Equals(id))
                    {
                        // Satır verilerini almak için örnek bir işlem
                        string rowData =
                            $" id: {row.Cells[0].Value}, " +
                            $" bolum: {row.Cells[1].Value}," +
                            $" ogretmen: {row.Cells[2].Value}," +
                            $" ders: {row.Cells[3].Value}," +
                            $" derslik: {row.Cells[4].Value}," +
                            $" gun: {row.Cells[5].Value}";


                        // Liste içine satır verilerini ekleyin
                        Listem.Add(rowData);
                    }
                }
            }
            _dataTable = ToDataTable(Listem);
            dataGridView1.DataSource = _dataTable;
        }
        private void btn_ogrlistele_Click(object sender, EventArgs e)
        {
            Listem.Clear();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    // "id" değerini al
                    string id = row.Cells[2].Value.ToString();
                    // Belirli bir koşulu sağlayan satırları listele (örneğin, id değeri 1 olanları)
                    if (cmbx_ogretmen.Text.Equals(id))
                    {
                        // Satır verilerini almak için örnek bir işlem
                        string rowData =
                            $" id: {row.Cells[0].Value}, " +
                            $" bolum: {row.Cells[1].Value}," +
                            $" ogretmen: {row.Cells[2].Value}," +
                            $" ders: {row.Cells[3].Value}," +
                            $" derslik: {row.Cells[4].Value}," +
                            $" gun: {row.Cells[5].Value}";


                        // Liste içine satır verilerini ekleyin
                        Listem.Add(rowData);
                    }
                }
            }
            _dataTable = ToDataTable(Listem);
            dataGridView1.DataSource = _dataTable;
        }
        // Hepsini listeleme
        private void btnHepsiListele_Click(object sender, EventArgs e)
        {
            ShowAllProgramData();
        }
        private void ShowAllProgramData()
        {
            try
            {
                // Veritabanından tüm program verilerini çekin
                DataTable allProgramData = dtPto.GetData();

                // DataGridView'e verileri atayın
                dataGridView1.DataSource = allProgramData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Tabloda veri listelenir.
        private DataTable ToDataTable(List<string> dataList)
        {
            DataTable dataTable = new DataTable("Ders Programı");
            
            // Kolon isimlerini belirle (örneğin, "id", "Bölüm", "Öğretmen", "Ders", "Derslik", "Ders2")
            string[] columnNames = { "id", "Bölüm", "Öğretmen", "Ders", "Derslik", "Zaman" };

            // Kolonları DataTable'a ekle
            foreach (string columnName in columnNames)
            {
                dataTable.Columns.Add(columnName);
            }
            // Her satır verisini ayır ve DataTable'a ekle
            foreach (string rowData in dataList)
            {
                // Satır verisini parçala
                string[] values = rowData.Split(',');

                // Yeni bir DataRow oluştur
                DataRow row = dataTable.NewRow();

                // Her bir değeri uygun kolona ekle
                for (int i = 0; i < values.Length; i++)
                {
                    // Boşlukları temizle ve değeri ekleyerek DataTable'a ekle
                    row[columnNames[i]] = values[i].Split(':')[1].Trim(); // Sadece değeri ekleyerek düzenle

                    // Örnek: " id: 1" -> "1"
                }

                // DataRow'ı DataTable'a ekle
                dataTable.Rows.Add(row);
            }
            return dataTable;
        }



        // Yazırma işlemi
        private void btn_yazdır_Click(object sender, EventArgs e)
        {
            try
            {
                // Dosya iletişim kutusunu oluşturun
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                // Başlangıçta görünecek dosya adını ve türünü belirtin
                saveFileDialog.FileName = "Program.csv";
                saveFileDialog.Filter = "CSV Dosyaları (*.csv)|*.csv|Tüm Dosyalar (*.*)|*.*";

                // Eğer kullanıcı bir dosya seçerse
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Seçilen dosyanın yolunu alın
                    string filePath = saveFileDialog.FileName;

                    // DataGridView'deki verileri CSV dosyasına kaydedin
                    ExportDataTableToCSV(ConvertDataGridViewToDataTable(dataGridView1), filePath);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private DataTable ConvertDataGridViewToDataTable(DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();

            // DataGridView'deki sütunları DataTable'a ekle
            foreach (DataGridViewColumn dataGridViewColumn in dataGridView.Columns)
            {
                dataTable.Columns.Add(dataGridViewColumn.HeaderText);
            }

            // DataGridView'deki satırları DataTable'a ekle
            foreach (DataGridViewRow dataGridViewRow in dataGridView.Rows)
            {
                DataRow dataRow = dataTable.NewRow();
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    dataRow[i] = dataGridViewRow.Cells[i].Value;
                }
                dataTable.Rows.Add(dataRow);
            }

            return dataTable;
        }
        private void ExportDataTableToCSV(DataTable dataTable, string filePath)
        {
            StringBuilder sb = new StringBuilder();

            // Başlık satırı
            foreach (DataColumn column in dataTable.Columns)
            {
                sb.Append($"\"{column.ColumnName}\";"); // Sütunları noktalı virgül ile ayırarak ekle
            }
            sb.AppendLine();

            // Veri satırları
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    sb.Append($"\"{row[column].ToString().Replace("\"", "\"\"")}\";"); // Hücreleri noktalı virgül ile ayırarak ekle
                }
                sb.AppendLine();
            }

            try
            {
                // CultureInfo ile sayı formatını Türkçe'ye uygun şekilde belirledik
                CultureInfo.CurrentCulture = new CultureInfo("tr-TR");

                // Dosyayı UTF-8 ile oku, varsa üzerine yazma
                using (StreamWriter streamWriter = new StreamWriter(filePath, true, Encoding.UTF8))
                {
                    streamWriter.Write(sb.ToString());
                }

                MessageBox.Show("DataTable verileri başarıyla CSV dosyasına kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"İzin hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
