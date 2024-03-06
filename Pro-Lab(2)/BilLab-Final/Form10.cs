using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BilLab_Final.Route;

namespace BilLab_Final
{
    public partial class Form10 : Form
    {
        string gunAdi;
        public Form10(int a, int b, decimal n, string gunAdi)
        {
            InitializeComponent();
            numericUpDown1.Value = n;
            for (int i = 0; i < 6; i++)
            {
                comboBox1.Items.Add(Route.Sehir.sehir_adi_dondur(i));
            }
            for (int i = 0; i < 6; i++)
            {
                comboBox2.Items.Add(Route.Sehir.sehir_adi_dondur(i));
            }
            comboBox1.SelectedIndex = a;
            comboBox2.SelectedIndex = b;
            int k = 0;
            int fiyat = 0;
            double doluluk = 0;
            int maks = 0;
            int dolu = 0;
            foreach (Route sefer in AltSeferler.seferlerListesi)
            {
                if (gunAdi == sefer.gunAdi)
                {
                    if (sefer.hangiYol == "Havayolu")
                    {
                        fiyat = sefer.mesafe * 4;
                    }
                    else if (sefer.hangiYol == "Karayolu")
                    {
                        fiyat = sefer.mesafe + (sefer.mesafe / 2);
                    }
                    else if (sefer.hangiYol == "Demiryolu")
                    {
                        fiyat = sefer.mesafe;
                    }

                    if (gunAdi == "pzt")
                    {
                        maks = Form9.pzt.doluluk[sefer.guzergah].Length;
                        dolu = 0;
                        for (int i = 0; i < maks; i++)
                        {
                            if (Form9.pzt.doluluk[sefer.guzergah][i] == 1)
                            {
                                dolu++;
                            }
                        }
                    }
                    if (gunAdi == "sal")
                    {
                        maks = Form9.sal.doluluk[sefer.guzergah].Length;
                        dolu = 0;
                        for (int i = 0; i < maks; i++)
                        {
                            if (Form9.sal.doluluk[sefer.guzergah][i] == 1)
                            {
                                dolu++;
                            }
                        }
                    }
                    if (gunAdi == "car")
                    {
                        maks = Form9.car.doluluk[sefer.guzergah].Length;
                        dolu = 0;
                        for (int i = 0; i < maks; i++)
                        {
                            if (Form9.car.doluluk[sefer.guzergah][i] == 1)
                            {
                                dolu++;
                            }
                        }
                    }
                    if (gunAdi == "per")
                    {
                        maks = Form9.per.doluluk[sefer.guzergah].Length;
                        dolu = 0;
                        for (int i = 0; i < maks; i++)
                        {
                            if (Form9.per.doluluk[sefer.guzergah][i] == 1)
                            {
                                dolu++;
                            }
                        }
                    }
                    if (gunAdi == "cum")
                    {
                        maks = Form9.cum.doluluk[sefer.guzergah].Length;
                        dolu = 0;
                        for (int i = 0; i < maks; i++)
                        {
                            if (Form9.cum.doluluk[sefer.guzergah][i] == 1)
                            {
                                dolu++;
                            }
                        }
                    }
                    if (gunAdi == "cmt")
                    {
                        maks = Form9.cmt.doluluk[sefer.guzergah].Length;
                        dolu = 0;
                        for (int i = 0; i < maks; i++)
                        {
                            if (Form9.cmt.doluluk[sefer.guzergah][i] == 1)
                            {
                                dolu++;
                            }
                        }
                    }
                    if (gunAdi == "pzr")
                    {
                        maks = Form9.pzr.doluluk[sefer.guzergah].Length;
                        dolu = 0;
                        for (int i = 0; i < maks; i++)
                        {
                            if (Form9.pzr.doluluk[sefer.guzergah][i] == 1)
                            {
                                dolu++;
                            }
                        }
                    }


                    doluluk = (double)dolu / maks;
                    if (k == 0)
                    {
                        flowLayoutPanel1.Visible = true;
                        flowLayoutPanel1.Enabled = true;
                        label4.Text = sefer.kalkisNoktasi;
                        label6.Text = sefer.varisNoktasi;
                        label7.Text = sefer.hangiYol;
                        label9.Text = fiyat.ToString();
                        label32.Text = sefer.aracID.ToString();
                        progressBar1.Value = (int)(doluluk * 100);
                    }
                    if (k == 1)
                    {
                        flowLayoutPanel2.Visible = true;
                        flowLayoutPanel2.Enabled = true;
                        label11.Text = sefer.kalkisNoktasi;
                        label13.Text = sefer.varisNoktasi;
                        label14.Text = sefer.hangiYol;
                        label16.Text = fiyat.ToString();
                        label34.Text = sefer.aracID.ToString();
                        progressBar2.Value = (int)(doluluk * 100);
                    }
                    if (k == 2)
                    {
                        flowLayoutPanel3.Visible = true;
                        flowLayoutPanel3.Enabled = true;
                        label18.Text = sefer.kalkisNoktasi;
                        label20.Text = sefer.varisNoktasi;
                        label21.Text = sefer.hangiYol;
                        label23.Text = fiyat.ToString();
                        label36.Text = sefer.aracID.ToString();
                        progressBar3.Value = (int)(doluluk * 100);
                    }
                    if (k == 3)
                    {
                        flowLayoutPanel4.Visible = true;
                        flowLayoutPanel4.Enabled = true;
                        label25.Text = sefer.kalkisNoktasi;
                        label27.Text = sefer.varisNoktasi;
                        label28.Text = sefer.hangiYol;
                        label30.Text = fiyat.ToString();
                        label38.Text = sefer.aracID.ToString();
                        progressBar4.Value = (int)(doluluk * 100);
                    }
                    if (k == 4)
                    {
                        flowLayoutPanel5.Visible = true;
                        flowLayoutPanel5.Enabled = true;
                        label40.Text = sefer.kalkisNoktasi;
                        label42.Text = sefer.varisNoktasi;
                        label43.Text = sefer.hangiYol;
                        label45.Text = fiyat.ToString();
                        label47.Text = sefer.aracID.ToString();
                        progressBar5.Value = (int)(doluluk * 100);
                    }
                    if (k == 5)
                    {
                        flowLayoutPanel6.Visible = true;
                        flowLayoutPanel6.Enabled = true;
                        label49.Text = sefer.kalkisNoktasi;
                        label51.Text = sefer.varisNoktasi;
                        label52.Text = sefer.hangiYol;
                        label54.Text = fiyat.ToString();
                        label56.Text = sefer.aracID.ToString();
                        progressBar6.Value = (int)(doluluk * 100);
                    }
                    k++;
                }
                else
                    continue;

            }
            k = 0;
            this.gunAdi = gunAdi;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            AltSeferler.seferlerListesi.Clear();
            AltSeferler.sefer_kur(comboBox1.SelectedIndex, comboBox2.SelectedIndex, gunAdi);
            Form10 sefer_sec = new Form10(comboBox1.SelectedIndex, comboBox2.SelectedIndex, numericUpDown1.Value, gunAdi);
            this.Close();
            sefer_sec.Show();
        }


        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Enabled = !checkBox1.Checked;
            checkBox3.Enabled = !checkBox1.Checked;
            checkBox4.Enabled = !checkBox1.Checked;
            checkBox6.Enabled = !checkBox1.Checked;
            checkBox5.Enabled = !checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = !checkBox2.Checked;
            checkBox3.Enabled = !checkBox2.Checked;
            checkBox4.Enabled = !checkBox2.Checked;
            checkBox6.Enabled = !checkBox2.Checked;
            checkBox5.Enabled = !checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Enabled = !checkBox3.Checked;
            checkBox1.Enabled = !checkBox3.Checked;
            checkBox4.Enabled = !checkBox3.Checked;
            checkBox6.Enabled = !checkBox3.Checked;
            checkBox5.Enabled = !checkBox3.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Enabled = !checkBox4.Checked;
            checkBox3.Enabled = !checkBox4.Checked;
            checkBox1.Enabled = !checkBox4.Checked;
            checkBox6.Enabled = !checkBox4.Checked;
            checkBox5.Enabled = !checkBox4.Checked;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Enabled = !checkBox5.Checked;
            checkBox3.Enabled = !checkBox5.Checked;
            checkBox4.Enabled = !checkBox5.Checked;
            checkBox6.Enabled = !checkBox5.Checked;
            checkBox1.Enabled = !checkBox5.Checked;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Enabled = !checkBox6.Checked;
            checkBox3.Enabled = !checkBox6.Checked;
            checkBox4.Enabled = !checkBox6.Checked;
            checkBox1.Enabled = !checkBox6.Checked;
            checkBox5.Enabled = !checkBox6.Checked;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                decide_form(AltSeferler.seferlerListesi[0]);
            }
            else if (checkBox2.Checked)
            {
                decide_form(AltSeferler.seferlerListesi[1]);
            }
            else if (checkBox3.Checked)
            {
                decide_form(AltSeferler.seferlerListesi[2]);
            }
            else if (checkBox4.Checked)
            {
                decide_form(AltSeferler.seferlerListesi[3]);
            }
            else if (checkBox5.Checked)
            {
                decide_form(AltSeferler.seferlerListesi[4]);
            }
            else if (checkBox6.Checked)
            {
                decide_form(AltSeferler.seferlerListesi[5]);
            }
        }
        Route.Seferler seferler = new Seferler();
        private void decide_form(Route sefer)
        {
            int kapasite = seferler.doluluk[sefer.guzergah].Length;
            int fiyat = 0;
            if (kapasite == 20)
            {
                fiyat = sefer.mesafe + (sefer.mesafe / 2);
                Form5 otobusA = new Form5(sefer.guzergah, fiyat, gunAdi, comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString());
                this.Close();
                otobusA.Show();
            }
            else if (kapasite == 15)
            {
                fiyat = sefer.mesafe + (sefer.mesafe / 2);
                Form6 otobusB = new Form6(sefer.guzergah, fiyat, gunAdi, comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString());
                this.Close();
                otobusB.Show();

            }
            else if(kapasite == 25)
            {
                fiyat = sefer.mesafe;
                Form7 tren = new Form7(sefer.guzergah, fiyat, gunAdi, comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString());
                this.Close();
                tren.Show();
            }
            else if(kapasite == 30)
            {
                fiyat = sefer.mesafe * 4;
                Form8 ucak = new Form8(sefer.guzergah, fiyat, gunAdi, comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString());
                this.Close();
                ucak.Show();
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 11)
            {
                gunAdi = "pzt";
            }
            else if (numericUpDown1.Value == 12)
            {
                gunAdi = "sal";
            }
            else if (numericUpDown1.Value == 13)
            {
                gunAdi = "car";
            }
            else if (numericUpDown1.Value == 14)
            {
                gunAdi = "per";
            }
            else if (numericUpDown1.Value == 15)
            {
                gunAdi = "cum";
            }
            else if (numericUpDown1.Value == 16)
            {
                gunAdi = "cmt";
            }
            else if (numericUpDown1.Value == 17)
            {
                gunAdi = "pzr";
            }
        }
    }
}
