using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaasHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            int sayi;
            int mesai;
            int maas;
            string ad, soyad;
            ad = txt_ad.Text;
            soyad = txt_soyad.Text;
            maas = int.Parse(txt_maas.Text);
            mesai = int.Parse(txt_mesaisaati.Text);
            if (rdb_gece.Checked==true)
            {
                sayi = maas + ( 15 * mesai) ;
                MessageBox.Show(ad +" " +soyad + "Adlı Kişinin Maaşı =" + sayi);
            }
            else
            {
                sayi = maas + (10 * mesai);
                MessageBox.Show(ad + " " + soyad + "Adlı Kişinin Maaşı = " + sayi);
            }
        }
    }
}
