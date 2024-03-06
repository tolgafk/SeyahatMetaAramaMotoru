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
    public partial class Form9 : Form
    {
        public static Route.Seferler pzt = new Route.Seferler();
        public static Route.Seferler sal = new Route.Seferler();
        public static Route.Seferler car = new Route.Seferler();
        public static Route.Seferler per = new Route.Seferler();
        public static Route.Seferler cum = new Route.Seferler();
        public static Route.Seferler cmt = new Route.Seferler();
        public static Route.Seferler pzr = new Route.Seferler();
        string gunAdi;
        
        public Form9()
        {
            InitializeComponent();
            for (int i = 0; i < 6; i++)
            {
                comboBox1.Items.Add(Route.Sehir.sehir_adi_dondur(i));
            }
            for (int i = 0; i < 6; i++)
            {
                comboBox2.Items.Add(Route.Sehir.sehir_adi_dondur(i));
            }
            
        }

        public Form9(string gunAdi)
        {
            InitializeComponent();
            for (int i = 0; i < 6; i++)
            {
                comboBox1.Items.Add(Route.Sehir.sehir_adi_dondur(i));
            }
            for (int i = 0; i < 6; i++)
            {
                comboBox2.Items.Add(Route.Sehir.sehir_adi_dondur(i));
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Form10 sefer_sec = new Form10(comboBox1.SelectedIndex, comboBox2.SelectedIndex, numericUpDown1.Value, "pzt");
            if (numericUpDown1.Value == 11)
            {
                Route.AltSeferler.sefer_kur(comboBox1.SelectedIndex, comboBox2.SelectedIndex, "pzt");
                sefer_sec = new Form10(comboBox1.SelectedIndex, comboBox2.SelectedIndex, numericUpDown1.Value, "pzt");
            }
            else if (numericUpDown1.Value == 12)
            {
                Route.AltSeferler.sefer_kur(comboBox1.SelectedIndex, comboBox2.SelectedIndex, "sal");
                sefer_sec = new Form10(comboBox1.SelectedIndex, comboBox2.SelectedIndex, numericUpDown1.Value, "sal");
            }
            else if (numericUpDown1.Value == 13)
            {
                Route.AltSeferler.sefer_kur(comboBox1.SelectedIndex, comboBox2.SelectedIndex, "car");
                sefer_sec = new Form10(comboBox1.SelectedIndex, comboBox2.SelectedIndex, numericUpDown1.Value, "car");
            }
            else if (numericUpDown1.Value == 14)
            {
                Route.AltSeferler.sefer_kur(comboBox1.SelectedIndex, comboBox2.SelectedIndex, "per");
                sefer_sec = new Form10(comboBox1.SelectedIndex, comboBox2.SelectedIndex, numericUpDown1.Value, "per");
            }
            else if (numericUpDown1.Value == 15)
            {
                Route.AltSeferler.sefer_kur(comboBox1.SelectedIndex, comboBox2.SelectedIndex, "cum");
                sefer_sec = new Form10(comboBox1.SelectedIndex, comboBox2.SelectedIndex, numericUpDown1.Value, "cum");
            }
            else if (numericUpDown1.Value == 16)
            {
                Route.AltSeferler.sefer_kur(comboBox1.SelectedIndex, comboBox2.SelectedIndex, "cmt");
                sefer_sec = new Form10(comboBox1.SelectedIndex, comboBox2.SelectedIndex, numericUpDown1.Value, "cmt");
            }
            else if (numericUpDown1.Value == 17)
            {
                Route.AltSeferler.sefer_kur(comboBox1.SelectedIndex, comboBox2.SelectedIndex, "pzr");
                sefer_sec = new Form10(comboBox1.SelectedIndex, comboBox2.SelectedIndex, numericUpDown1.Value, "pzr");
            }
            
            

            
            sefer_sec.Show();
            //this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
