using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilLab_Final
{
    public partial class Form7 : Form
    {
        Route.Seferler gun_here = new Route.Seferler();
        int güzergah;
        int fiyat;
        string gunAdi;
        string kalkis;
        string varis;
        public Form7(int b, int a, string gunAdi, string kalkis, string varis)
        {
            InitializeComponent();
            this.güzergah = b;
            this.kalkis = kalkis;
            this.varis = varis;
            string str = "box";
            string sayi = "1";
            this.fiyat = a;
            for (int i = 0; i < gun_here.doluluk[b].Length; i++)
            {
                str = "box";
                sayi = (i + 1).ToString();
                str = str + sayi;
                if (gunAdi == "pzt")
                {
                    if (Form9.pzt.doluluk[b][i] == 1)
                    {
                        CheckBox box = flowLayoutPanel1.Controls.Find(str, true).FirstOrDefault() as CheckBox;
                        box.Enabled = false;
                        box.Text = "X";
                    }
                }
                if (gunAdi == "sal")
                {
                    if (Form9.sal.doluluk[b][i] == 1)
                    {
                        CheckBox box = flowLayoutPanel1.Controls.Find(str, true).FirstOrDefault() as CheckBox;
                        box.Enabled = false;
                        box.Text = "X";
                    }
                }
                if (gunAdi == "car")
                {
                    if (Form9.car.doluluk[b][i] == 1)
                    {
                        CheckBox box = flowLayoutPanel1.Controls.Find(str, true).FirstOrDefault() as CheckBox;
                        box.Enabled = false;
                        box.Text = "X";
                    }
                }
                if (gunAdi == "per")
                {
                    if (Form9.per.doluluk[b][i] == 1)
                    {
                        CheckBox box = flowLayoutPanel1.Controls.Find(str, true).FirstOrDefault() as CheckBox;
                        box.Enabled = false;
                        box.Text = "X";
                    }
                }
                if (gunAdi == "cum")
                {
                    if (Form9.cum.doluluk[b][i] == 1)
                    {
                        CheckBox box = flowLayoutPanel1.Controls.Find(str, true).FirstOrDefault() as CheckBox;
                        box.Enabled = false;
                        box.Text = "X";
                    }
                }
                if (gunAdi == "cmt")
                {
                    if (Form9.cmt.doluluk[b][i] == 1)
                    {
                        CheckBox box = flowLayoutPanel1.Controls.Find(str, true).FirstOrDefault() as CheckBox;
                        box.Enabled = false;
                        box.Text = "X";
                    }
                }
                if (gunAdi == "pzr")
                {
                    if (Form9.pzr.doluluk[b][i] == 1)
                    {
                        CheckBox box = flowLayoutPanel1.Controls.Find(str, true).FirstOrDefault() as CheckBox;
                        box.Enabled = false;
                        box.Text = "X";
                    }
                }
            }

            this.gunAdi = gunAdi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;
            string sayi;
            int sayac = 0;
            for (int i = 0; i < 25; i++)
            {
                str = "box";
                sayi = (i + 1).ToString();
                str = str + sayi;
                CheckBox box = flowLayoutPanel1.Controls.Find(str, true).FirstOrDefault() as CheckBox;
                if (box.Checked)
                {
                    sayac++;
                    if (sayac > 2)
                    {
                        label4.Visible = true;
                        break;
                    }
                    if (gunAdi == "pzt")
                    {
                        Form9.pzt.doluluk[güzergah][i] = 1;
                    }
                    if (gunAdi == "sal")
                    {
                        Form9.sal.doluluk[güzergah][i] = 1;
                    }
                    if (gunAdi == "car")
                    {
                        Form9.car.doluluk[güzergah][i] = 1;
                    }
                    if (gunAdi == "per")
                    {
                        Form9.per.doluluk[güzergah][i] = 1;
                    }
                    if (gunAdi == "cum")
                    {
                        Form9.cum.doluluk[güzergah][i] = 1;
                    }
                    if (gunAdi == "cmt")
                    {
                        Form9.cmt.doluluk[güzergah][i] = 1;
                    }
                    if (gunAdi == "pzr")
                    {
                        Form9.pzr.doluluk[güzergah][i] = 1;
                    }
                }
            }
            if (sayac <= 2)
            {
                this.Hide();
                Form11 form11 = new Form11(sayac, kalkis, varis);
                form11.Show();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str;
            string sayi;
            int sayac = 0;
            for (int i = 0; i < 25; i++)
            {
                str = "box";
                sayi = (i + 1).ToString();
                str = str + sayi;
                CheckBox box = flowLayoutPanel1.Controls.Find(str, true).FirstOrDefault() as CheckBox;
                if (box.Checked)
                {
                    sayac++;
                }
                label3.Text = (fiyat * sayac).ToString() + " TL";
            }
        }
    }
}
