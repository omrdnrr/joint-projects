using dersProgrami.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dersProgrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bölümler episode = new Bölümler();
            episode.ShowDialog();
        }

        private void btn_ders_Click(object sender, EventArgs e)
        {
               lesson lesson = new lesson();
               lesson.ShowDialog();
        }

        private void btn_ogretmen_Click(object sender, EventArgs e)
        {
            teacher form = new teacher();
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_zaman_Click(object sender, EventArgs e)
        {
          timer form = new timer();
            form.ShowDialog();
        }

        private void btn_program_Click(object sender, EventArgs e)
        {
            program form = new program();
            form.ShowDialog();
        }
    }
}
