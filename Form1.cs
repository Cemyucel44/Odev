using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BtnOrnek1_Click(object sender, EventArgs e)
        {
            string s1 = txtSayi1.Text;
            string s2 = txtSayi2.Text;

            int sayi1 = Convert.ToInt32(txtSayi1);
            int sayi2 = Convert.ToInt32(txtSayi2);

            int toplam = sayi1 + sayi2;
            int fark = sayi1 - sayi2;
            int bolumdenkalan = toplam % fark;
            MessageBox.Show("İşlem Sonucu : " + bolumdenkalan);

        }

        private void BtnOrnek2_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(txtSayi1.Text);
            sayi = sayi - 10;
            sayi = sayi + 20;
            int mod = sayi % 2;
            sayi = mod * mod;
            MessageBox.Show("Islem Sonucu  :" + sayi);

            sayi = int.Parse(txtSayi1.Text);
            Double sonuc = (sayi - 10 + 20) % 2;
            MessageBox.Show("İşlem Sonucu  :" + (sonuc + sonuc));

        }

        private void BtnOrnek3_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(txtSayi1.Text);
            int s2 = int.Parse(txtSayi2.Text);

            int birincikare = s1 * s1;
            int ikincikare = s2 * s2;

            int toplam = birincikare + ikincikare;
            int fark = birincikare - ikincikare;
            int sonuc = toplam + fark;

            MessageBox.Show("işlem sonucu : " + sonuc);


        }

        private void BtnOrnek4_Click(object sender, EventArgs e)
        {
            Double vize = double.Parse(txtSayi1.Text);
            Double Final = double.Parse(txtSayi2.Text);

            Double Sonuc = (vize * 0.30) + (Final * 0.70);
            MessageBox.Show("Not Ortalaması" + Sonuc);


        }

        private void BtnOrnek5_Click(object sender, EventArgs e)
        {
            String isim = txtSayi1.Text;
            string soyisim = txtSayi2.Text;

            string mail = isim + "." + soyisim + "@hotmail.com";
            MessageBox.Show(mail);




        }

    }

}


