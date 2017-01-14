using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkıiliKart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Kart yolcu)
        {
            InitializeComponent();
        }

        OgrenciKart ogrenci = new OgrenciKart();
        Ogretmen ogretmen = new Ogretmen();
        Kart tam = new Kart();

        static List<Kart> kaliciListe = new List<Kart>();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int kartid = 1;

            if (radioBtnOgrenci.Checked)
            {
                ogrenci.bakiye = Convert.ToDouble(TxtBakiye.Text);
                ogrenci.KartID = kartid;
                kartid++;
                ogrenci.okulAdi = TxtOkulAdi.Text;
                ogrenci.kartTuru = YolcuTipi.Ögrenci;
                lstBoxYolcular.Items.Add(ogrenci);
                kaliciListe.Add(ogrenci);
            }

            else if (radioBtnOgretmen.Checked)
            {
                ogretmen.bakiye = Convert.ToDouble(TxtBakiye.Text);
                ogretmen.KartID = kartid;
                kartid++;
                ogretmen.kartTuru = YolcuTipi.Öğretmen;
                lstBoxYolcular.Items.Add(ogrenci);
                kaliciListe.Add(ogrenci);
            }
            else if (radioBtnTam.Checked)
            {
                tam.bakiye = Convert.ToDouble(TxtBakiye.Text);
                tam.KartID = kartid;
                kartid++;
                tam.kartTuru = YolcuTipi.Tam;
                lstBoxYolcular.Items.Add(tam);
                kaliciListe.Add(tam);
            }
            Temizle();
        }

        private void radioBtnOgrenci_CheckedChanged(object sender, EventArgs e)
        {
            //kısa if sorgusu! radiobuttonun checkedı işaretlenirse GBoxOkulAdinın Enabledı true olsun değilse false!
            GBoxOkuladi.Enabled = radioBtnOgrenci.Checked == true ? true : false;
        }

        public void Temizle()
        {
            TxtBakiye.Clear();
            TxtOkulAdi.Clear();
        }

        private void lstBoxYolcular_DoubleClick(object sender, EventArgs e)
        {
            //Sadece yakalamak için kullanalım.
            //var yolcu = lstBoxYolcular.SelectedItem;

            Kart yolcu = (Kart)lstBoxYolcular.SelectedItem;

            if (yolcu.kartTuru == YolcuTipi.Ögrenci && yolcu.bakiye - 1 >= 0)
            {
                lstBoxYolcular.Items.RemoveAt(lstBoxYolcular.SelectedIndex);
                ogrenci = (OgrenciKart)yolcu;
                ogrenci.Okut();
                lstBoxYolcular.Items.Add(ogrenci);
            }
            else if (yolcu.kartTuru == YolcuTipi.Öğretmen && yolcu.bakiye - 2 >= 0)
            {
                lstBoxYolcular.Items.RemoveAt(lstBoxYolcular.SelectedIndex);
                ogretmen = (Ogretmen)yolcu;
                ogretmen.Okut();
                lstBoxYolcular.Items.Add(ogretmen);
            }
            else if (yolcu.kartTuru == YolcuTipi.Tam && yolcu.bakiye - 3 >= 0)
            {
                lstBoxYolcular.Items.RemoveAt(lstBoxYolcular.SelectedIndex);
                tam = yolcu;
                tam.Okut();
                lstBoxYolcular.Items.Add(tam);
            }
            else
            {
                MessageBox.Show("Yetersiz Bakiye");

                DialogResult result = MessageBox.Show("Bakiye Yüklemek İstermisiniz?", "Bildirim Ekranı", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Yukleme frm = new Yukleme(yolcu);
                    frm.Show();
                    this.Hide();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in kaliciListe)
            {
                lstBoxYolcular.Items.Add(item);
            }
        }
    }
}

