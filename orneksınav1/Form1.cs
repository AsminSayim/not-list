using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orneksınav1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> notlar = new List<int>();
        private void Form1_Load(object sender, EventArgs e)
        {
          

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            notlar.Clear();
            Random rnd = new Random();
            for (int i = 1; i <= 38; i++)
            {
                notlar.Add(rnd.Next(0, 101));
            }
            listBox1.DataSource = notlar.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            notlar.Sort();
            listBox1.DataSource = notlar.ToList();
        }

        private void btnBuyuktenkucuge_Click(object sender, EventArgs e)
        {
            notlar.Sort();
            notlar.Reverse();

            listBox1.DataSource = notlar.ToList();
        }

        private void btnAra100_Click(object sender, EventArgs e)
        {
            if (notlar.Contains(100) == true)
            {
                MessageBox.Show("100 alan öğrenci var.");
            }
            else
            {
                MessageBox.Show("100 alan öğrenci yok.");
            }
        }

        private void btnGecensayisi_Click(object sender, EventArgs e)
        {

            int gecenSayisi = 0;
            for (int i = 0; i < notlar.Count; i++)
            {
                if (notlar[i] >= 50)
                {
                    gecenSayisi++;
                }
            }
            MessageBox.Show("Geçen Sayısı: " + gecenSayisi);
        }

        private void btnBelge_Click(object sender, EventArgs e)
        {
            int belgeSayisi = 0;
            for (int i = 0; i < notlar.Count; i++)
            {
                if (notlar[i] >= 70)
                {
                    belgeSayisi++;
                }
            }
            MessageBox.Show("Belge alan  Sayısı: " + belgeSayisi);
        }

        private void btnKalansayisi_Click(object sender, EventArgs e)
        {
            int kalanSayisi = 0;
            for (int i = 0; i < notlar.Count; i++)
            {
                if (notlar[i] < 50)
                {
                    kalanSayisi++;
                }
            }
            MessageBox.Show("kalan Sayısı: " + kalanSayisi);
        }

        private void btnEndusuknot_Click(object sender, EventArgs e)
        {
            notlar.Sort();
            MessageBox.Show("En düşük Not: " + notlar[0]);
        }

        private void btnEnbuyuknot_Click(object sender, EventArgs e)
        {
            notlar.Sort();
            notlar.Reverse();
            MessageBox.Show("En Yüksek Not :" + notlar[0]);
        }
    }
}
