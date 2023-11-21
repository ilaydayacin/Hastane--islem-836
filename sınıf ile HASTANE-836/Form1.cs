using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınıf_ile_HASTANE_836
{
    public partial class Form1 : Form
    {
        Hasta hasta = new Hasta();
        int sayac =0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            btnTemizle.Enabled = true;

            sayac++;

            hasta.ad = txtAd.Text;
            hasta.soyad = txtSoyad.Text;
            hasta.dtarih = dtpDogum.Value;
            hasta.tcno = txtTc.Text;
            hasta.tel = txtTel.Text;
            hasta.kanGrup = cmbKan.Text;

            if (rbVar.Checked)
            {
                hasta.kronikHastalik = true;
            }
            else
            {
                hasta.kronikHastalik = false;
            }

            lbHastaBilgi.Items.Add(sayac + " Hasta");
            lbHastaBilgi.Items.Add("Ad: " + hasta.ad);
            lbHastaBilgi.Items.Add("Soyad: " + hasta.soyad);
            lbHastaBilgi.Items.Add("Doğum tarihi: " + hasta.dtarih);
            lbHastaBilgi.Items.Add("Tc no: " + hasta.tcno);
            lbHastaBilgi.Items.Add("Telefon no: " + hasta.tel);
            lbHastaBilgi.Items.Add("Kronik rahatsızlık: " + hasta.kronikHastalik);
            lbHastaBilgi.Items.Add("Kan grubu: " + hasta.kanGrup);
            lbHastaBilgi.Items.Add("");

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTc.Clear();
            txtTel.Clear();

            btnTemizle.Enabled=false;

            lbHastaBilgi.Items.Clear();
        }

        private void btnGuncelleme_Click(object sender, EventArgs e)
        {
            lbHastaBilgi.Items.Clear();
            hasta.ad = txtAd.Text;
            hasta.soyad = txtSoyad.Text;
            hasta.dtarih = dtpDogum.Value;
            hasta.tcno = txtTc.Text;
            hasta.tel = txtTel.Text;
            hasta.kanGrup = cmbKan.Text;

            if (rbVar.Checked)
            {
                hasta.kronikHastalik = true;
            }
            else
            {
                hasta.kronikHastalik = false;
            }

            lbHastaBilgi.Items.Add(sayac + " Hasta");
            lbHastaBilgi.Items.Add("Ad: " + hasta.ad);
            lbHastaBilgi.Items.Add("Soyad: " + hasta.soyad);
            lbHastaBilgi.Items.Add("Doğum tarihi: " + hasta.dtarih);
            lbHastaBilgi.Items.Add("Tc no: " + hasta.tcno);
            lbHastaBilgi.Items.Add("Telefon no: " + hasta.tel);
            lbHastaBilgi.Items.Add("Kronik rahatsızlık: " + hasta.kronikHastalik);
            lbHastaBilgi.Items.Add("Kan grubu: " + hasta.kanGrup);
            lbHastaBilgi.Items.Add("");
        }
    }
}
