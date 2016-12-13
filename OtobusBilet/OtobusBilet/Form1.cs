using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusBilet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string sendData;

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = Form2.sendData1;//koltuk numarasını 2. forma gönderen kod.
        }
        private void btn_Click(object sender, EventArgs e)
        {
            
            Button secbtn = sender as Button;
            sendData = secbtn.Text;
            Form2 yeni = new Form2();
            yeni.Show();
            secbtn.BackColor = Color.Green;
            
            //2. formda secılen kadın erkek tercıhıne gore secılı koltugun rengını atayan kod. (Hata var)
            if (Form2.sendData1=="Kadın")
            {
                secbtn.BackColor = Color.Red;
                MessageBox.Show("Seçilen Koltuk Doludur!\nBaşka Koltuk Seçiniz!");
            }
            else if (Form2.sendData1=="Erkek")
            {
                secbtn.BackColor = Color.Blue;
                MessageBox.Show("Seçilen Koltuk Doludur!\nBaşka Koltuk Seçiniz!"); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex.ToString() == "0")
            {
                int sayac = 0;
                for (int i = 0; i < 12; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if ((j != 2 || i == 11) && (i != 5 || j <= 2))
                        {
                            sayac++;
                            Button btn = new Button();
                            btn.Width = 40;
                            btn.Height = 40;

                            btn.Top = (btn.Width * i);
                            btn.Left = (btn.Width * j);
                            this.Controls.Add(btn);
                            btn.Text = sayac.ToString();
                            this.Controls.Add(btn);
                            btn.Click += new EventHandler(btn_Click);
                        }
                    }
                }
            }
            else if (comboBox1.SelectedIndex.ToString() == "1")
            {
                int sayac = 0;
                for (int i = 0; i < 14; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if ((j != 2 || i == 13) && (i != 7 || j <= 2))
                        {
                            sayac++;
                            Button btn = new Button();
                            btn.Width = 40;
                            btn.Height = 40;

                            btn.Top = (btn.Width * i);
                            btn.Left = (btn.Width * j);
                            this.Controls.Add(btn);
                            btn.Text = sayac.ToString();
                            this.Controls.Add(btn);
                            btn.Click += new EventHandler(btn_Click);
                        }
                    }
                }
            }
        }
    }
}

