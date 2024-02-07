using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace dersProgrami.Manager
{
    public class Otomasyon
    {
        DataSet1TableAdapters.bolumatamasıTableAdapter dtBolumAtamasi = new DataSet1TableAdapters.bolumatamasıTableAdapter();
        DataSet1TableAdapters.derslerTableAdapter dtDersler = new DataSet1TableAdapters.derslerTableAdapter();
        DataSet1TableAdapters.ogretmenatamasıTableAdapter dtogratama = new DataSet1TableAdapters.ogretmenatamasıTableAdapter();
        DataSet1TableAdapters.derslikTableAdapter dtDerslik = new DataSet1TableAdapters.derslikTableAdapter();
        DataSet1TableAdapters.OgretmenMusaitlikTableAdapter dtogrMusaitlik = new DataSet1TableAdapters.OgretmenMusaitlikTableAdapter();
        DataSet1TableAdapters.GunlerTableAdapter dtGunler = new DataSet1TableAdapters.GunlerTableAdapter();

        DataTable derslikler;

        public void Start()
        {
            // dtBolumler.GetDataBy3() metodu ile bölüm adlarını al
            DataTable bolumAdlari = dtBolumAtamasi.GetBolumAtama();

            // DataTable'dan bölüm adlarını listeye kopyala
            foreach (DataRow atama in bolumAdlari.Rows)
            {

                int bolumID = Convert.ToInt32(atama["bolum"]);
                int dersID = Convert.ToInt32(atama["ders"]);

                string dersSaati = "";
                int derslikID = 0;

                DataTable dersBilgileri = dtDersler.getDers(dersID);
                DataTable dersVerenHocalar = dtogratama.GetOgretmenID(dersID);

                foreach (DataRow veri in dersBilgileri.Rows)
                {
                    dersSaati = veri["saat"].ToString();
                    derslikID = Convert.ToInt32(veri["derslikId"]);
                }
                int dersSaat = Convert.ToInt32(dersSaati);

                foreach (DataRow veri in dersVerenHocalar.Rows)
                {
                    int ogretmen = Convert.ToInt32(veri["ogretmen"]);

                    musaitgünarama(ogretmen, bolumID, derslikID, dersSaat, dersID);
                }
            }
        }

        public void musaitgünarama(int OgretmenID, int BölümId, int derslikID, int dersSaat, int dersİD) {

            DataSet1TableAdapters.programTableAdapter dtProgram = new DataSet1TableAdapters.programTableAdapter();
            DataSet1TableAdapters.zamanTableAdapter dtZaman = new DataSet1TableAdapters.zamanTableAdapter();

            DataTable Program = dtProgram.GetProgram();


            DataTable ogretmenZamanları = dtProgram.GetOgretmenlereGöre(OgretmenID);
            DataTable Zaman = dtZaman.getZamanlar();
            DataTable bolumZamanları = dtProgram.getBolumeGöre(BölümId);

            // Silinecek satırları belirlemek için bir liste oluştur
            List<DataRow> silinecekler = new List<DataRow>();
            // Her bir bolumZamanları satırını kontrol et
            foreach (DataRow veri in bolumZamanları.Rows)
            {
                int gunID = Convert.ToInt32(veri["gun"]);

                // Zaman tablosunda gunID ile eşleşen satırları bul
                DataRow[] zamanSatirlari = Zaman.Select($"id = {gunID}");

                // Eşleşen satırları silinecekler listesine ekle
                silinecekler.AddRange(zamanSatirlari);
            }

            // Her bir ogretmenZamanları satırını kontrol et
            foreach (DataRow veri in ogretmenZamanları.Rows)
            {
                int gunID = Convert.ToInt32(veri["gun"]);

                // Zaman tablosunda gunID ile eşleşen satırları bul
                DataRow[] zamanSatirlari = Zaman.Select($"id = {gunID}");

                // Eşleşen satırları silinecekler listesine ekle
                silinecekler.AddRange(zamanSatirlari);
            }





            DataTable ogretmenMüsaitliği = dtogrMusaitlik.getMusaitlik(OgretmenID);

            foreach (DataRow veri in ogretmenMüsaitliği.Rows)
            {
                string gunID = veri["gun"].ToString();
                string gunler = dtGunler.FillByaaa(gunID) == null ? "0" : dtGunler.FillByaaa(gunID).ToString();

                foreach (DataRow veri3 in Zaman.Rows)
                {
                    DataRow[] zamanSatirlari = Zaman.Select($"Gun = {gunler}");
                    silinecekler.AddRange(zamanSatirlari);

                }
            }







            silinecekler = düzenle(silinecekler);




            // Silinecek satırları gerçekten sil
            foreach (DataRow silinecekSatir in silinecekler)
            {
                Zaman.Rows.Remove(silinecekSatir);
            }
            silinecekler.Clear();
            if (Zaman.Columns.Count >= dersSaat) {
                DataTable derslikZamanları = dtProgram.GetDerslikGöre(derslikID);
                // Her bir derslikZamanları satırını kontrol et
                foreach (DataRow veri in derslikZamanları.Rows)
                {
                    int gunID = Convert.ToInt32(veri["gun"]);

                    // Zaman tablosunda gunID ile eşleşen satırları bul
                    DataRow[] zamanSatirlari = Zaman.Select($"id = {gunID}");

                    // Eşleşen satırları silinecekler listesine ekle
                    silinecekler.AddRange(zamanSatirlari);
                }

                // Silinecek satırları gerçekten sil
                foreach (DataRow silinecekSatir in silinecekler)
                {
                    Zaman.Rows.Remove(silinecekSatir);
                }

                if (Zaman.Columns.Count >= dersSaat)
                {
                    int kontrol = 0;
                    foreach (DataRow veri in Zaman.Rows)
                    {

                        int zaman = Convert.ToInt32(veri["id"]);
                        dtProgram.InsertProgram(BölümId, OgretmenID, dersİD, derslikID, zaman);
                        kontrol = kontrol + 1;
                        if (kontrol == dersSaat) {
                            break;
                        }
                    }
                }
                else {
                    DataRow[] silinecekSatir = Zaman.Select($"id = {derslikID}");
                    foreach (DataRow veri in silinecekSatir)
                    {
                        derslikler.Rows.Remove(veri);
                    }

                    foreach (DataRow veri in derslikler.Rows)
                    {
                        int derslik = Convert.ToInt32(veri["id"]);
                        musaitgünarama(OgretmenID, BölümId, derslik, dersSaat, dersİD);
                    }
                }
            }
        }

        public List<DataRow> düzenle(List<DataRow> silinecekler)
        {
            // Temizlenmiş verileri saklamak için bir liste oluştur
            List<DataRow> temizVeriler = new List<DataRow>();

            // Aynı verilere sahip olan satırları bul ve birini sil
            var gruplanmışSatırlar = from DataRow satır in silinecekler
                                     group satır by new
                                     {
                                         // Aynı verilere sahip olup olmadığını belirlemek için sütunları seçin
                                         Column1 = satır["id"],
                                         // Diğer sütunlar için aynı şekilde devam edebilirsiniz
                                     }
                                     into grup
                                     where grup.Count() > 1 // Birden fazla aynı veri içeren grupları seç
                                     select grup;

            // Temizlenmiş verileri saklamak için listeye ekle
            foreach (var grup in gruplanmışSatırlar)
            {
                // İlk satırı koru, diğerlerini sil
                var ilkSatır = grup.First();
                temizVeriler.Add(ilkSatır);
            }

            // Temizlenmiş verileri döndür
            return temizVeriler;
        }

    }
}
