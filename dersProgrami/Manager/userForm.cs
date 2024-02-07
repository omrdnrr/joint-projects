using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    public partial class userForm : Form
    {
        DataSet1TableAdapters.ogretmenTableAdapter dtogr = new DataSet1TableAdapters.ogretmenTableAdapter();
        private DataTable _dataTable;
        String userTC;
        string userID;

        public userForm(String userTC)
        {
            InitializeComponent();
            _dataTable = new DataTable();
            this.programTableAdapter.FillProgram(this.dataSet1.program);
            this.userTC = userTC;
        }

        DataSet1TableAdapters.programTableAdapter dtProgram = new DataSet1TableAdapters.programTableAdapter();


        List<string> Listem = new List<string>();


        private void userForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dataSet1.ProgramJoin2' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.programJoin2TableAdapter.FillProgramJoin2(this.dataSet1.ProgramJoin2);
            // TODO: Bu kod satırı 'dataSet1.joinProgram' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.joinProgramTableAdapter.Fill(this.dataSet1.joinProgram);
            // TODO: Bu kod satırı 'dataSet1.program' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.programTableAdapter.FillProgram(this.dataSet1.program);

        }

        private void btn_prgram_Click(object sender, EventArgs e)
        {
            userID = dtogr.getİD(userTC).ToString();
            Listem.Clear();
            foreach (DataGridViewRow row in teacherTablo.Rows)
            {
                if (!row.IsNewRow)
                {
                    // "id" değerini al
                    string id = row.Cells[2].Value.ToString();
                    // Belirli bir koşulu sağlayan satırları listele (örneğin, id değeri 1 olanları)
                    if (userID.Equals(id))
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
            teacherTablo.DataSource = _dataTable;
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
        private void btn_yazdr_Click(object sender, EventArgs e)
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
                    ExportDataTableToCSV(ConvertDataGridViewToDataTable(teacherTablo), filePath);

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
