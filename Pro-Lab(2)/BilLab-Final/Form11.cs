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
    public partial class Form11 : Form
    {
        public static List<Passenger> list = new List<Passenger>();
        private int sayac = 1;
        private string kalkis;
        private string varis;
        public Form11(int i, string k, string v)
        {
            InitializeComponent();
            kalkis = k;
            varis = v;
            label1.Text = sayac.ToString();
            if (i == 1)
            {
                button1.Visible = false;
                button2.Visible = true;
            }
            
        }        
        public Form11(string k, string v)
        {
            InitializeComponent();
            sayac++;
            kalkis = k;
            varis = v;
            label1.Text = sayac.ToString();
            button1.Visible = false;
            button2.Visible = true;
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Passenger ekle = new Passenger(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            list.Add(ekle);
            Form11 tekrar = new Form11(kalkis, varis);
            tekrar.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Passenger ekle = new Passenger(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            list.Add(ekle);
            Form12 son_ekran = new Form12(sayac, kalkis, varis);
            son_ekran.Show();
            this.Close();
        }
    }
}
