using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeckinTruzim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(240, 244, 248);

            panelTravego.Visible = false;
            panelNeoplan.Visible = false;

            GBoxMusteriBilgileri.Enabled = false;

            #region TravegoKoltukları
            byte counter = 1;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((j != 2 || i == 11) && (i != 5 || j < 2))
                    {
                        Button btn = new Button();
                        btn.Click += ButtonClick;
                        btn.Width = 40;
                        btn.Height = 40;
                        btn.Text = counter + ""; // counter.ToString();
                        btn.BackColor = RenkOlustur(counter, "Travego");
                        btn.ForeColor = Color.White;
                        btn.Left = btn.Width * j;
                        btn.Top = btn.Height * i;
                        panelTravego.Controls.Add(btn);
                        counter++;
                    }
                }
            }
            #endregion

            #region NeoplanKoltuklari
            counter = 1;
            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((j != 2 || i == 13) && (i != 6 || j < 2))
                    {
                        Button btn = new Button();
                        btn.Click += ButtonClick;
                        btn.Width = 40;
                        btn.Height = 40;
                        btn.Text = counter + ""; // counter.ToString();
                        btn.BackColor = RenkOlustur(counter, "Neoplan");
                        btn.ForeColor = Color.White;
                        btn.Left = btn.Width * j;
                        btn.Top = btn.Height * i;
                        panelNeoplan.Controls.Add(btn);
                        counter++;
                    }
                }
            }

            #endregion

        }

        private void CBoxOtobusTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnKaydet.BackColor = Color.FromArgb(0, 76, 142);
            BtnKaydet.ForeColor = Color.White;
            TxtMusteriAdSoyad.Clear();
            CBoxKadin.Checked = false;
            CBoxErkek.Checked = false;

            if (CBoxOtobusTuru.SelectedItem.ToString() == "Neoplan")
            {
                panelNeoplan.Visible = true;
                panelTravego.Visible = false;
            }
            else if (CBoxOtobusTuru.SelectedItem.ToString() == "Travego")
            {
                panelTravego.Visible = true;
                panelNeoplan.Visible = false;
            }
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            Button secilenKoltuk = sender as Button;
            labelKoltukNo.Text = secilenKoltuk.Text;
            labelOtobusTuru.Text = CBoxOtobusTuru.SelectedItem.ToString();

            GBoxMusteriBilgileri.Enabled = true;

            if (CBoxOtobusTuru.SelectedItem.ToString() == "Travego")
            {
                string yolcu = travegoYolcularIsim[int.Parse(secilenKoltuk.Text) - 1];

                if (yolcu != "")
                {
                    TxtMusteriAdSoyad.Text = yolcu;

                    string cinsiyet = travegoYolcularCinsiyet[int.Parse(secilenKoltuk.Text) - 1];

                    if (cinsiyet == "Erkek")
                    {
                        CBoxErkek.Checked = true;
                        secilenKoltuk.BackColor = Color.Blue;
                    }

                    else if (cinsiyet == "Kadın")
                    {
                        CBoxKadin.Checked = true;
                        secilenKoltuk.BackColor = Color.Red;
                    }
                }
            }
            else
            {
                string yolcu = neoplanYolcularIsim[int.Parse(secilenKoltuk.Text) - 1];

                if (yolcu != "")
                {
                    TxtMusteriAdSoyad.Text = yolcu;

                    string cinsiyet = neoplanYolcularCinsiyet[int.Parse(secilenKoltuk.Text) - 1];

                    if (cinsiyet == "Erkek")
                    {
                        CBoxErkek.Checked = true;
                        secilenKoltuk.BackColor = Color.Blue;
                    }

                    else if (cinsiyet == "Kadın")
                    {
                        CBoxKadin.Checked = true;
                        secilenKoltuk.BackColor = Color.Red;
                    }
                }
            }
        }
        string[] travegoYolcularIsim = new string[47];
        string[] travegoYolcularCinsiyet = new string[47];
        string[] neoplanYolcularIsim = new string[55];
        string[] neoplanYolcularCinsiyet = new string[55];

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            #region Kaydet

            if (labelOtobusTuru.Text == "Neoplan")
            {
                neoplanYolcularIsim[int.Parse(labelKoltukNo.Text) - 1] = TxtMusteriAdSoyad.Text;

                string cinsiyet;

                if (CBoxKadin.Checked)
                {
                    cinsiyet = "Kadın";
                }

                else
                {
                    cinsiyet = "Erkek";
                }

                neoplanYolcularCinsiyet[int.Parse(labelKoltukNo.Text) - 1] = cinsiyet;   
            }
            else
            {
                travegoYolcularIsim[int.Parse(labelKoltukNo.Text) - 1] = TxtMusteriAdSoyad.Text;

                string cinsiyet;

                if (CBoxKadin.Checked)
                {
                    cinsiyet = "Kadın";
                }

                else
                {
                    cinsiyet = "Erkek";
                }

                travegoYolcularCinsiyet[int.Parse(labelKoltukNo.Text) - 1] = cinsiyet;
            }
            #endregion

            panelNeoplan.Controls.Clear();
            panelTravego.Controls.Clear();

            Form1_Load(sender, e);

            CBoxOtobusTuru.SelectedItem = labelOtobusTuru.Text;
            CBoxOtobusTuru_SelectedIndexChanged(sender, e);

            TxtMusteriAdSoyad.Clear();
            labelKoltukNo.Text = "";
            labelOtobusTuru.Text = "";
        }

        private Color RenkOlustur(int count, string otobusTuru)
        {
            Color color;

            if (otobusTuru == "Travego")
            {
                string cinsiyet = travegoYolcularCinsiyet[count - 1];

                if (cinsiyet == "Erkek")
                {
                    color = Color.Blue;
                }
                else if (cinsiyet =="Kadın")
                {
                    color = Color.Red;
                }
                else
                {
                    color = Color.FromArgb(12, 178, 240);
                }
            }
            else
            {
                string cinsiyet = neoplanYolcularCinsiyet[count - 1];

                if (cinsiyet == "Erkek")
                {
                    color = Color.Blue;
                }
                else if (cinsiyet == "Kadın")
                {
                    color = Color.Red;
                }
                else
                {
                    color = Color.FromArgb(12, 178, 240);
                }
            }
            return color;
        }
    }
}
