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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.ogretmenTableAdapter dtogr = new DataSet1TableAdapters.ogretmenTableAdapter();

        private void btn_grsYap_Click(object sender, EventArgs e)
        {

            DataSet1 dataSet = new DataSet1(); // DataSet nesnesi oluşturunuz, isim DataSet1 olarak varsayılmıştır
            DataSet1TableAdapters.OgretmenMusaitlikTableAdapter dtogrMusaitlik = new DataSet1TableAdapters.OgretmenMusaitlikTableAdapter();

            string yetki = dtogr.permission(veri_tc.Text, veri_sifre.Text);

            if (yetki == null )
            {
                MessageBox.Show("Geçersiz giriş işlemi");
                return;
            }
            if (yetki.Equals("Yönetici"))
            {
                Form1 form = new Form1();
                form.ShowDialog();
                this.Close();
            }
            else if (yetki.Equals("Ögretmen"))
            {

                userForm form = new userForm(veri_tc.Text);
                form.ShowDialog();
                this.Close();
            }
            else {
                MessageBox.Show("Geçersiz giriş işlemi");
            }
        }
    }
}
